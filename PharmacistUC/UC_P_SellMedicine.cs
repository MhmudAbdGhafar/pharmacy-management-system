using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_P_SellMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();

            query = "select mname from medic where eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();

            query = "select mname from medic where mname like '"+txtSearch.Text+"%' and eDate > getdate() and quantity > '0'";
            ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnit.Clear();

            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);

            txtMedicineName.Text = name;
            query = "select mid, eDate, perUnit from medic where mname = '"+name+"'";
            ds = fn.getData(query);

            txtMedicineID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNoOfUnit_TextChanged(object sender, EventArgs e)
        {
            if(txtNoOfUnit.Text != "")
            {
                Int64 unitPrice;
                Int64 noOfUnit;
                try
                {
                    unitPrice = Int64.Parse(txtPricePerUnit.Text);
                    noOfUnit = Int64.Parse(txtNoOfUnit.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Select specific Medicine\nAnd Enter correct No of Units.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Int64 totalAmount = unitPrice * noOfUnit;
                txtTotalPrice.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(txtMedicineID.Text != "")
            {
                query = "select quantity from medic where mid = '"+txtMedicineID.Text+"'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                try
                {
                    newQuantity = quantity - Int64.Parse(txtNoOfUnit.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter correct No of Units.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMedicineID.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMedicineName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExpireDate.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtNoOfUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    totalLabel.Text = "Rs. " + totalAmount.ToString();

                    query = "update medic set quantity = '"+newQuantity+"' where mid = '"+txtMedicineID.Text+"'";
                    fn.setData(query, "Medicine Added.");
                }
                else
                {
                    MessageBox.Show("Medicine is out of Stock.\nOnly " + quantity + " Left", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                clearAll();
                UC_P_SellMedicine_Load(this, null);
            } 
            else
            {
                MessageBox.Show("Select Medicine First.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }


        int valueAmount;
        String valueID;
        protected Int64 noOfUnit;

        

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueID = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

            }
            catch(Exception) { }
        }

        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(valueID != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medic where mid = '"+valueID+"'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfUnit;

                    query = "update medic set quantity = '"+newQuantity+"' where mid = '"+valueID+"'";
                    fn.setData(query, "Medicine Removed from Cart.");
                    totalAmount = totalAmount - valueAmount;
                    totalLabel.Text = "Rs. " + totalAmount.ToString();
                }
                UC_P_SellMedicine_Load(this, null);
            }
        }

        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:-  {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount : " + totalLabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            totalLabel.Text = "Rs. 00";
            guna2DataGridView1.DataSource = 0;
        }

        private void clearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtNoOfUnit.Clear();
        }
    }
}
