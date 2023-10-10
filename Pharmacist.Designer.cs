namespace Pharmacy_Management_System
{
    partial class Pharmacist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicineValidityCheck = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_P_MedicineValidityCheck1 = new Pharmacy_Management_System.PharmacistUC.UC_P_MedicineValidityCheck();
            this.uC_P_UpdateMedicine1 = new Pharmacy_Management_System.PharmacistUC.UC_P_UpdateMedicine();
            this.uC_P_ViewMedicines1 = new Pharmacy_Management_System.PharmacistUC.UC_P_ViewMedicines();
            this.uC_P_AddMedicine1 = new Pharmacy_Management_System.PharmacistUC.UC_P_AddMedicine();
            this.uC_P_Dashboard1 = new Pharmacy_Management_System.PharmacistUC.UC_P_Dashboard();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_P_SellMedicine1 = new Pharmacy_Management_System.PharmacistUC.UC_P_SellMedicine();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSellMedicine);
            this.panel1.Controls.Add(this.btnMedicineValidityCheck);
            this.panel1.Controls.Add(this.btnModifyMedicine);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 780);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(278, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 780);
            this.panel2.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnLogOut.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(11, 651);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(263, 45);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSellMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSellMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSellMedicine.CheckedState.Parent = this.btnSellMedicine;
            this.btnSellMedicine.CustomImages.Parent = this.btnSellMedicine;
            this.btnSellMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSellMedicine.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSellMedicine.HoverState.Parent = this.btnSellMedicine;
            this.btnSellMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnSellMedicine.Image")));
            this.btnSellMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSellMedicine.Location = new System.Drawing.Point(12, 589);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.ShadowDecoration.Parent = this.btnSellMedicine;
            this.btnSellMedicine.Size = new System.Drawing.Size(263, 45);
            this.btnSellMedicine.TabIndex = 7;
            this.btnSellMedicine.Text = " Sell Medicine";
            this.btnSellMedicine.Click += new System.EventHandler(this.btnSellMedicine_Click);
            // 
            // btnMedicineValidityCheck
            // 
            this.btnMedicineValidityCheck.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMedicineValidityCheck.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMedicineValidityCheck.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnMedicineValidityCheck.CheckedState.Parent = this.btnMedicineValidityCheck;
            this.btnMedicineValidityCheck.CustomImages.Parent = this.btnMedicineValidityCheck;
            this.btnMedicineValidityCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnMedicineValidityCheck.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineValidityCheck.ForeColor = System.Drawing.Color.White;
            this.btnMedicineValidityCheck.HoverState.Parent = this.btnMedicineValidityCheck;
            this.btnMedicineValidityCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicineValidityCheck.Image")));
            this.btnMedicineValidityCheck.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMedicineValidityCheck.Location = new System.Drawing.Point(12, 522);
            this.btnMedicineValidityCheck.Name = "btnMedicineValidityCheck";
            this.btnMedicineValidityCheck.ShadowDecoration.Parent = this.btnMedicineValidityCheck;
            this.btnMedicineValidityCheck.Size = new System.Drawing.Size(263, 45);
            this.btnMedicineValidityCheck.TabIndex = 6;
            this.btnMedicineValidityCheck.Text = "Medicine Validity Check";
            this.btnMedicineValidityCheck.Click += new System.EventHandler(this.btnMedicineValidityCheck_Click);
            // 
            // btnModifyMedicine
            // 
            this.btnModifyMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnModifyMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnModifyMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnModifyMedicine.CheckedState.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.CustomImages.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnModifyMedicine.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMedicine.ForeColor = System.Drawing.Color.White;
            this.btnModifyMedicine.HoverState.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMedicine.Image")));
            this.btnModifyMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnModifyMedicine.Location = new System.Drawing.Point(12, 459);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.ShadowDecoration.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.Size = new System.Drawing.Size(263, 45);
            this.btnModifyMedicine.TabIndex = 5;
            this.btnModifyMedicine.Text = "Modify Medicine";
            this.btnModifyMedicine.Click += new System.EventHandler(this.btnModifyMedicine_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewMedicine.CheckedState.Parent = this.btnViewMedicine;
            this.btnViewMedicine.CustomImages.Parent = this.btnViewMedicine;
            this.btnViewMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnViewMedicine.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.HoverState.Parent = this.btnViewMedicine;
            this.btnViewMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicine.Image")));
            this.btnViewMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewMedicine.Location = new System.Drawing.Point(12, 394);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.ShadowDecoration.Parent = this.btnViewMedicine;
            this.btnViewMedicine.Size = new System.Drawing.Size(263, 45);
            this.btnViewMedicine.TabIndex = 4;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddMedicine.CheckedState.Parent = this.btnAddMedicine;
            this.btnAddMedicine.CustomImages.Parent = this.btnAddMedicine;
            this.btnAddMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddMedicine.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.HoverState.Parent = this.btnAddMedicine;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddMedicine.Location = new System.Drawing.Point(12, 330);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.ShadowDecoration.Parent = this.btnAddMedicine;
            this.btnAddMedicine.Size = new System.Drawing.Size(263, 45);
            this.btnAddMedicine.TabIndex = 3;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDashboard.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(12, 266);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(263, 45);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // uC_P_MedicineValidityCheck1
            // 
            this.uC_P_MedicineValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uC_P_MedicineValidityCheck1.Location = new System.Drawing.Point(276, 0);
            this.uC_P_MedicineValidityCheck1.Name = "uC_P_MedicineValidityCheck1";
            this.uC_P_MedicineValidityCheck1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_MedicineValidityCheck1.TabIndex = 5;
            // 
            // uC_P_UpdateMedicine1
            // 
            this.uC_P_UpdateMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_UpdateMedicine1.Location = new System.Drawing.Point(277, 0);
            this.uC_P_UpdateMedicine1.Name = "uC_P_UpdateMedicine1";
            this.uC_P_UpdateMedicine1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_UpdateMedicine1.TabIndex = 4;
            // 
            // uC_P_ViewMedicines1
            // 
            this.uC_P_ViewMedicines1.BackColor = System.Drawing.Color.White;
            this.uC_P_ViewMedicines1.Location = new System.Drawing.Point(276, 0);
            this.uC_P_ViewMedicines1.Name = "uC_P_ViewMedicines1";
            this.uC_P_ViewMedicines1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_ViewMedicines1.TabIndex = 3;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(276, 0);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_AddMedicine1.TabIndex = 2;
            // 
            // uC_P_Dashboard1
            // 
            this.uC_P_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_P_Dashboard1.Location = new System.Drawing.Point(276, 0);
            this.uC_P_Dashboard1.Name = "uC_P_Dashboard1";
            this.uC_P_Dashboard1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_Dashboard1.TabIndex = 1;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // uC_P_SellMedicine1
            // 
            this.uC_P_SellMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_SellMedicine1.Location = new System.Drawing.Point(276, 0);
            this.uC_P_SellMedicine1.Name = "uC_P_SellMedicine1";
            this.uC_P_SellMedicine1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_SellMedicine1.TabIndex = 6;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 780);
            this.Controls.Add(this.uC_P_SellMedicine1);
            this.Controls.Add(this.uC_P_MedicineValidityCheck1);
            this.Controls.Add(this.uC_P_UpdateMedicine1);
            this.Controls.Add(this.uC_P_ViewMedicines1);
            this.Controls.Add(this.uC_P_AddMedicine1);
            this.Controls.Add(this.uC_P_Dashboard1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnSellMedicine;
        private Guna.UI2.WinForms.Guna2Button btnMedicineValidityCheck;
        private Guna.UI2.WinForms.Guna2Button btnModifyMedicine;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicine;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PharmacistUC.UC_P_Dashboard uC_P_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_P_ViewMedicines uC_P_ViewMedicines1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PharmacistUC.UC_P_UpdateMedicine uC_P_UpdateMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUC.UC_P_MedicineValidityCheck uC_P_MedicineValidityCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PharmacistUC.UC_P_SellMedicine uC_P_SellMedicine1;
    }
}