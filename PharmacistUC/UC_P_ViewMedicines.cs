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
    public partial class UC_P_ViewMedicines : UserControl
    {
        function fn = new function();
        String query;

        public UC_P_ViewMedicines()
        {
            InitializeComponent();
        }

         

        private void UC_P_ViewMedicines_Load(object sender, EventArgs e)
        {
            query = "select *from medic";
            setDataGridView(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select *from medic where mname like '"+txtSearch.Text+"%'";
            setDataGridView(query);
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        String medicineid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineid = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Delete Conformation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { 
                if (medicineid == null || medicineid == "")
                {
                    MessageBox.Show("Select Row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                query = "delete from medic where mid = '"+medicineid+"'";
                fn.setData(query, "Medicine Record deleted."); 
                medicineid = null;

                UC_P_ViewMedicines_Load(this, null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            medicineid = "";
            UC_P_ViewMedicines_Load(this, null);
        }
    }
}
