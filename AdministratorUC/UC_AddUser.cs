using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }
 
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role;
            String name;
            String dob;

            Int64 mobile;

            String email;
            String username;
            String password;

            try
            {
                role = txtUserRole.Text;
                name = txtName.Text;
                dob = txtDob.Text;

                mobile = Convert.ToInt64(txtMobileNo.Text);

                email = txtEmailAddress.Text;
                username = txtUserName.Text;
                password = txtPassword.Text;

                if (role == "" || name == "" || email == "" || username == "" || password == "")
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter correct Data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                query = "insert into users (userRole,name,dob,mobile,email,username,pass) values ('"+role+"','"+name+"','"+dob+"','"+mobile+"','"+email+"','"+username+"','"+password+"')";
                fn.setData(query, "Signed Up Successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtUserRole.SelectedIndex = -1;
            txtName.Clear();
            txtDob.ResetText(); 
            txtMobileNo.Clear();   
            txtEmailAddress.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + txtUserName.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"D:\pharmacy project\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"D:\pharmacy project\Pharmacy Management System in C#\no.png";

            }
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
