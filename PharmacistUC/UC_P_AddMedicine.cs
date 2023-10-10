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
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMedicineID.Text != "" && txtMedicineName.Text != "" && txtMedicineNumber.Text != "" && txtQuantity.Text != "" && txtPricePerUnit.Text != "")
            {
                String mid;
                String mname;
                String mnumber;
                String mdate;
                String edate;
                Int64 quantity;
                Int64 perunit;

                try
                {
                      mid = txtMedicineID.Text;
                      mname = txtMedicineName.Text;
                      mnumber = txtMedicineNumber.Text;
                      mdate = txtManufacturingDate.Text;
                      edate = txtExpireDate.Text;
                      quantity = Int64.Parse(txtQuantity.Text);
                      perunit = Int64.Parse(txtPricePerUnit.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter correct Date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    query = "insert into medic(mid, mname, mnumber, mDate, eDate, quantity, perUnit) values('" + mid + "', '" + mname + "', '" + mnumber + "', '" + mdate + "', '" + edate + "', " + quantity + ", " + perunit + ")";
                    fn.setData(query, "Medicine Added to Database.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Medicine already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all Date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtManufacturingDate.ResetText();
            txtExpireDate.ResetText();
        }

        private void txtMedicineID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
