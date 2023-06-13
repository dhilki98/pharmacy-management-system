namespace PharmacyManagementSystem
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.pnl_Adm_left = new System.Windows.Forms.Panel();
            this.btn_Adm_remove = new System.Windows.Forms.Button();
            this.lbl_Adm_username = new System.Windows.Forms.Label();
            this.btn_Adm_back = new System.Windows.Forms.Button();
            this.btn_Adm_update = new System.Windows.Forms.Button();
            this.btn_Adm_viewusers = new System.Windows.Forms.Button();
            this.btn_Adm_adduser = new System.Windows.Forms.Button();
            this.lbl_Adm_logo = new System.Windows.Forms.Label();
            this.pctBox_Adm_logo = new System.Windows.Forms.PictureBox();
            this.pnl_Adm_right = new System.Windows.Forms.Panel();
            this.pnl_Adm_right1 = new System.Windows.Forms.Panel();
            this.dataGV_Adm = new System.Windows.Forms.DataGridView();
            this.clm_Adm_userrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Adm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Adm_nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Adm_mnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Adm_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Adm_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Adm_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Adm_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Adm_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Adm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Adm_left
            // 
            this.pnl_Adm_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Adm_left.Controls.Add(this.btn_Adm_remove);
            this.pnl_Adm_left.Controls.Add(this.lbl_Adm_username);
            this.pnl_Adm_left.Controls.Add(this.btn_Adm_back);
            this.pnl_Adm_left.Controls.Add(this.btn_Adm_update);
            this.pnl_Adm_left.Controls.Add(this.btn_Adm_viewusers);
            this.pnl_Adm_left.Controls.Add(this.btn_Adm_adduser);
            this.pnl_Adm_left.Controls.Add(this.lbl_Adm_logo);
            this.pnl_Adm_left.Controls.Add(this.pctBox_Adm_logo);
            this.pnl_Adm_left.Controls.Add(this.pnl_Adm_right);
            this.pnl_Adm_left.Controls.Add(this.pnl_Adm_right1);
            this.pnl_Adm_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_Adm_left.Name = "pnl_Adm_left";
            this.pnl_Adm_left.Size = new System.Drawing.Size(275, 730);
            this.pnl_Adm_left.TabIndex = 0;
            // 
            // btn_Adm_remove
            // 
            this.btn_Adm_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Adm_remove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adm_remove.ForeColor = System.Drawing.Color.White;
            this.btn_Adm_remove.Location = new System.Drawing.Point(78, 455);
            this.btn_Adm_remove.Name = "btn_Adm_remove";
            this.btn_Adm_remove.Size = new System.Drawing.Size(125, 31);
            this.btn_Adm_remove.TabIndex = 7;
            this.btn_Adm_remove.Text = "Remove User";
            this.btn_Adm_remove.UseVisualStyleBackColor = false;
            // 
            // lbl_Adm_username
            // 
            this.lbl_Adm_username.AutoSize = true;
            this.lbl_Adm_username.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Adm_username.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Adm_username.Location = new System.Drawing.Point(78, 563);
            this.lbl_Adm_username.Name = "lbl_Adm_username";
            this.lbl_Adm_username.Size = new System.Drawing.Size(111, 29);
            this.lbl_Adm_username.TabIndex = 1;
            this.lbl_Adm_username.Text = "username";
            // 
            // btn_Adm_back
            // 
            this.btn_Adm_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Adm_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adm_back.ForeColor = System.Drawing.Color.White;
            this.btn_Adm_back.Location = new System.Drawing.Point(78, 511);
            this.btn_Adm_back.Name = "btn_Adm_back";
            this.btn_Adm_back.Size = new System.Drawing.Size(125, 31);
            this.btn_Adm_back.TabIndex = 7;
            this.btn_Adm_back.Text = "Back";
            this.btn_Adm_back.UseVisualStyleBackColor = false;
            this.btn_Adm_back.Click += new System.EventHandler(this.btn_Adm_back_Click);
            // 
            // btn_Adm_update
            // 
            this.btn_Adm_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Adm_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adm_update.ForeColor = System.Drawing.Color.White;
            this.btn_Adm_update.Location = new System.Drawing.Point(78, 403);
            this.btn_Adm_update.Name = "btn_Adm_update";
            this.btn_Adm_update.Size = new System.Drawing.Size(125, 31);
            this.btn_Adm_update.TabIndex = 6;
            this.btn_Adm_update.Text = "Update User";
            this.btn_Adm_update.UseVisualStyleBackColor = false;
            // 
            // btn_Adm_viewusers
            // 
            this.btn_Adm_viewusers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Adm_viewusers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adm_viewusers.ForeColor = System.Drawing.Color.White;
            this.btn_Adm_viewusers.Location = new System.Drawing.Point(78, 277);
            this.btn_Adm_viewusers.Name = "btn_Adm_viewusers";
            this.btn_Adm_viewusers.Size = new System.Drawing.Size(125, 31);
            this.btn_Adm_viewusers.TabIndex = 5;
            this.btn_Adm_viewusers.Text = "View Users";
            this.btn_Adm_viewusers.UseVisualStyleBackColor = false;
            this.btn_Adm_viewusers.Click += new System.EventHandler(this.btn_Adm_viewusers_Click);
            // 
            // btn_Adm_adduser
            // 
            this.btn_Adm_adduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Adm_adduser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adm_adduser.ForeColor = System.Drawing.Color.White;
            this.btn_Adm_adduser.Location = new System.Drawing.Point(78, 343);
            this.btn_Adm_adduser.Name = "btn_Adm_adduser";
            this.btn_Adm_adduser.Size = new System.Drawing.Size(125, 31);
            this.btn_Adm_adduser.TabIndex = 4;
            this.btn_Adm_adduser.Text = "Add User";
            this.btn_Adm_adduser.UseVisualStyleBackColor = false;
            this.btn_Adm_adduser.Click += new System.EventHandler(this.btn_Adm_adduser_Click);
            // 
            // lbl_Adm_logo
            // 
            this.lbl_Adm_logo.AutoSize = true;
            this.lbl_Adm_logo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Adm_logo.ForeColor = System.Drawing.Color.White;
            this.lbl_Adm_logo.Location = new System.Drawing.Point(39, 194);
            this.lbl_Adm_logo.Name = "lbl_Adm_logo";
            this.lbl_Adm_logo.Size = new System.Drawing.Size(215, 39);
            this.lbl_Adm_logo.TabIndex = 2;
            this.lbl_Adm_logo.Text = "Administration";
            // 
            // pctBox_Adm_logo
            // 
            this.pctBox_Adm_logo.Image = ((System.Drawing.Image)(resources.GetObject("pctBox_Adm_logo.Image")));
            this.pctBox_Adm_logo.Location = new System.Drawing.Point(48, 18);
            this.pctBox_Adm_logo.Name = "pctBox_Adm_logo";
            this.pctBox_Adm_logo.Size = new System.Drawing.Size(183, 173);
            this.pctBox_Adm_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBox_Adm_logo.TabIndex = 1;
            this.pctBox_Adm_logo.TabStop = false;
            // 
            // pnl_Adm_right
            // 
            this.pnl_Adm_right.Location = new System.Drawing.Point(281, 3);
            this.pnl_Adm_right.Name = "pnl_Adm_right";
            this.pnl_Adm_right.Size = new System.Drawing.Size(1086, 726);
            this.pnl_Adm_right.TabIndex = 1;
            // 
            // pnl_Adm_right1
            // 
            this.pnl_Adm_right1.Location = new System.Drawing.Point(281, 3);
            this.pnl_Adm_right1.Name = "pnl_Adm_right1";
            this.pnl_Adm_right1.Size = new System.Drawing.Size(1089, 729);
            this.pnl_Adm_right1.TabIndex = 1;
            // 
            // dataGV_Adm
            // 
            this.dataGV_Adm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Adm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Adm_userrole,
            this.clm_Adm_name,
            this.clm_Adm_nic,
            this.clm_Adm_mnum,
            this.clm_Adm_address,
            this.clm_Adm_username,
            this.clm_Adm_password});
            this.dataGV_Adm.Location = new System.Drawing.Point(281, 41);
            this.dataGV_Adm.Name = "dataGV_Adm";
            this.dataGV_Adm.RowTemplate.Height = 25;
            this.dataGV_Adm.Size = new System.Drawing.Size(1080, 150);
            this.dataGV_Adm.TabIndex = 1;
            // 
            // clm_Adm_userrole
            // 
            this.clm_Adm_userrole.HeaderText = "User Role";
            this.clm_Adm_userrole.Name = "clm_Adm_userrole";
            // 
            // clm_Adm_name
            // 
            this.clm_Adm_name.HeaderText = "Name";
            this.clm_Adm_name.Name = "clm_Adm_name";
            this.clm_Adm_name.Width = 200;
            // 
            // clm_Adm_nic
            // 
            this.clm_Adm_nic.HeaderText = "NIC No";
            this.clm_Adm_nic.Name = "clm_Adm_nic";
            this.clm_Adm_nic.Width = 150;
            // 
            // clm_Adm_mnum
            // 
            this.clm_Adm_mnum.HeaderText = "Mobile No";
            this.clm_Adm_mnum.Name = "clm_Adm_mnum";
            this.clm_Adm_mnum.Width = 150;
            // 
            // clm_Adm_address
            // 
            this.clm_Adm_address.HeaderText = "Email Address";
            this.clm_Adm_address.Name = "clm_Adm_address";
            this.clm_Adm_address.Width = 200;
            // 
            // clm_Adm_username
            // 
            this.clm_Adm_username.HeaderText = "Username";
            this.clm_Adm_username.Name = "clm_Adm_username";
            // 
            // clm_Adm_password
            // 
            this.clm_Adm_password.HeaderText = "Password";
            this.clm_Adm_password.Name = "clm_Adm_password";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 729);
            this.Controls.Add(this.dataGV_Adm);
            this.Controls.Add(this.pnl_Adm_left);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.pnl_Adm_left.ResumeLayout(false);
            this.pnl_Adm_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Adm_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Adm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Adm_left;
        private PictureBox pctBox_Adm_logo;
        private Panel pnl_Adm_right;
        private Panel pnl_Adm_right1;
        private Label lbl_Adm_logo;
        private Button btn_Adm_back;
        private Button btn_Adm_update;
        private Button btn_Adm_viewusers;
        private Button btn_Adm_adduser;
        private Label lbl_Adm_username;
        private DataGridView dataGV_Adm;
        private DataGridViewTextBoxColumn clm_Adm_userrole;
        private DataGridViewTextBoxColumn clm_Adm_name;
        private DataGridViewTextBoxColumn clm_Adm_nic;
        private DataGridViewTextBoxColumn clm_Adm_mnum;
        private DataGridViewTextBoxColumn clm_Adm_address;
        private DataGridViewTextBoxColumn clm_Adm_username;
        private DataGridViewTextBoxColumn clm_Adm_password;
        private Button btn_Adm_remove;
    }
}