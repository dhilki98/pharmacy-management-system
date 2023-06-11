namespace PharmacyManagementSystem
{
    partial class Viewuser
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
            this.dataGV_Uv = new System.Windows.Forms.DataGridView();
            this.clm_Uv_userrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Uv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Uv_nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Uv_mNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Uv_eaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Uv_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Uv_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Uv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_Uv
            // 
            this.dataGV_Uv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Uv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Uv_userrole,
            this.clm_Uv_name,
            this.clm_Uv_nic,
            this.clm_Uv_mNo,
            this.clm_Uv_eaddress,
            this.clm_Uv_username,
            this.clm_Uv_password});
            this.dataGV_Uv.Location = new System.Drawing.Point(12, 35);
            this.dataGV_Uv.Name = "dataGV_Uv";
            this.dataGV_Uv.RowTemplate.Height = 25;
            this.dataGV_Uv.Size = new System.Drawing.Size(1048, 150);
            this.dataGV_Uv.TabIndex = 0;
            // 
            // clm_Uv_userrole
            // 
            this.clm_Uv_userrole.HeaderText = "User Role";
            this.clm_Uv_userrole.Name = "clm_Uv_userrole";
            // 
            // clm_Uv_name
            // 
            this.clm_Uv_name.HeaderText = "Name";
            this.clm_Uv_name.Name = "clm_Uv_name";
            this.clm_Uv_name.Width = 200;
            // 
            // clm_Uv_nic
            // 
            this.clm_Uv_nic.HeaderText = "NIC No";
            this.clm_Uv_nic.Name = "clm_Uv_nic";
            this.clm_Uv_nic.Width = 150;
            // 
            // clm_Uv_mNo
            // 
            this.clm_Uv_mNo.HeaderText = "Mobile No";
            this.clm_Uv_mNo.Name = "clm_Uv_mNo";
            this.clm_Uv_mNo.Width = 150;
            // 
            // clm_Uv_eaddress
            // 
            this.clm_Uv_eaddress.HeaderText = "Email Address";
            this.clm_Uv_eaddress.Name = "clm_Uv_eaddress";
            this.clm_Uv_eaddress.Width = 200;
            // 
            // clm_Uv_username
            // 
            this.clm_Uv_username.HeaderText = "Username";
            this.clm_Uv_username.Name = "clm_Uv_username";
            // 
            // clm_Uv_password
            // 
            this.clm_Uv_password.HeaderText = "Password";
            this.clm_Uv_password.Name = "clm_Uv_password";
            // 
            // Viewuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 688);
            this.Controls.Add(this.dataGV_Uv);
            this.Name = "Viewuser";
            this.Text = "Viewuser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Uv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGV_Uv;
        private DataGridViewTextBoxColumn clm_Uv_userrole;
        private DataGridViewTextBoxColumn clm_Uv_name;
        private DataGridViewTextBoxColumn clm_Uv_nic;
        private DataGridViewTextBoxColumn clm_Uv_mNo;
        private DataGridViewTextBoxColumn clm_Uv_eaddress;
        private DataGridViewTextBoxColumn clm_Uv_username;
        private DataGridViewTextBoxColumn clm_Uv_password;
    }
}