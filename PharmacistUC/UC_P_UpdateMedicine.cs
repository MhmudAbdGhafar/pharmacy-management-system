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
    public partial class UC_P_UpdateMedicine : UserControl
    {
        function fn = new function();
        String query;

        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMedicineID.Text != "")
            {
                query = "select *from medic where mid = '"+txtMedicineID.Text+"'";
                DataSet ds = fn.getData(query);

                if(ds.Tables[0].Rows.Count > 0)
                {
                    txtMedicineName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedicineNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAvailableQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine with ID : " + txtMedicineID.Text + " Exists. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
            }
            else
            {
                clearAll();
            }
        }

        private void clearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtMDate.ResetText();
            txtEDate.ResetText();
            txtAvailableQuantity.Clear();
            txtAddQuantity.Clear();
            txtPricePerUnit.Clear();

            txtAddQuantity.Text = "0";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname;
            String mnumber;
            String mdate;
            String edate;
            Int64 quantity;
            Int64 addQuantity;
            Int64 unitprice;

            try
            {
                mname = txtMedicineName.Text;
                mnumber = txtMedicineNumber.Text;
                mdate = txtMDate.Text;
                edate = txtEDate.Text;
                quantity = Int64.Parse(txtAvailableQuantity.Text);
                addQuantity = Int64.Parse(txtAddQuantity.Text);
                unitprice = Int64.Parse(txtPricePerUnit.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter correct Date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            totalQuantity = quantity + addQuantity;

            //mid, mname, mnumber, mDate, eDate, quantity, perUnit
            query = "update medic set mname = '"+mname+ "', mnumber = '"+mnumber+ "', mDate = '" + mdate + "', eDate = '"+edate+ "', quantity = " + totalQuantity + ", perUnit = "+unitprice+" where mid = '"+txtMedicineID.Text+"'";
            fn.setData(query, "Medicine Details Updated.");
        }
    }
}
