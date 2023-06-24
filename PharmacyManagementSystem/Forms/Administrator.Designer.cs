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
            this.lbl_Adm_username = new System.Windows.Forms.Label();
            this.btn_Adm_back = new System.Windows.Forms.Button();
            this.btn_Adm_adduser = new System.Windows.Forms.Button();
            this.lbl_Adm_logo = new System.Windows.Forms.Label();
            this.pctBox_Adm_logo = new System.Windows.Forms.PictureBox();
            this.pnl_Adm_right = new System.Windows.Forms.Panel();
            this.btn_Adm_edit = new System.Windows.Forms.Button();
            this.btn_Adm_delete = new System.Windows.Forms.Button();
            this.btn_Adm_search = new System.Windows.Forms.Button();
            this.txt_Adm_search = new System.Windows.Forms.TextBox();
            this.dataGV_Uv = new System.Windows.Forms.DataGridView();
            this.btn_Adm_reset = new System.Windows.Forms.Button();
            this.btn_Adm_spplier = new System.Windows.Forms.Button();
            this.pnl_Adm_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Adm_logo)).BeginInit();
            this.pnl_Adm_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Uv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Adm_left
            // 
            this.pnl_Adm_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Adm_left.Controls.Add(this.btn_Adm_spplier);
            this.pnl_Adm_left.Controls.Add(this.lbl_Adm_username);
            this.pnl_Adm_left.Controls.Add(this.btn_Adm_back);
            this.pnl_Adm_left.Controls.Add(this.btn_Adm_adduser);
            this.pnl_Adm_left.Controls.Add(this.lbl_Adm_logo);
            this.pnl_Adm_left.Controls.Add(this.pctBox_Adm_logo);
            this.pnl_Adm_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_Adm_left.Name = "pnl_Adm_left";
            this.pnl_Adm_left.Size = new System.Drawing.Size(280, 730);
            this.pnl_Adm_left.TabIndex = 0;
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
            this.btn_Adm_back.Location = new System.Drawing.Point(65, 479);
            this.btn_Adm_back.Name = "btn_Adm_back";
            this.btn_Adm_back.Size = new System.Drawing.Size(150, 35);
            this.btn_Adm_back.TabIndex = 7;
            this.btn_Adm_back.Text = "Back";
            this.btn_Adm_back.UseVisualStyleBackColor = false;
            this.btn_Adm_back.Click += new System.EventHandler(this.btn_Adm_back_Click);
            // 
            // btn_Adm_adduser
            // 
            this.btn_Adm_adduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Adm_adduser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adm_adduser.ForeColor = System.Drawing.Color.White;
            this.btn_Adm_adduser.Location = new System.Drawing.Point(65, 350);
            this.btn_Adm_adduser.Name = "btn_Adm_adduser";
            this.btn_Adm_adduser.Size = new System.Drawing.Size(150, 35);
            this.btn_Adm_adduser.TabIndex = 4;
            this.btn_Adm_adduser.Text = "Add New User";
            this.btn_Adm_adduser.UseVisualStyleBackColor = false;
            this.btn_Adm_adduser.Click += new System.EventHandler(this.btn_Adm_adduser_Click);
            // 
            // lbl_Adm_logo
            // 
            this.lbl_Adm_logo.AutoSize = true;
            this.lbl_Adm_logo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Adm_logo.ForeColor = System.Drawing.Color.White;
            this.lbl_Adm_logo.Location = new System.Drawing.Point(38, 203);
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
            this.pnl_Adm_right.Controls.Add(this.btn_Adm_edit);
            this.pnl_Adm_right.Controls.Add(this.btn_Adm_delete);
            this.pnl_Adm_right.Controls.Add(this.btn_Adm_search);
            this.pnl_Adm_right.Controls.Add(this.txt_Adm_search);
            this.pnl_Adm_right.Controls.Add(this.dataGV_Uv);
            this.pnl_Adm_right.Controls.Add(this.btn_Adm_reset);
            this.pnl_Adm_right.Location = new System.Drawing.Point(275, 0);
            this.pnl_Adm_right.Name = "pnl_Adm_right";
            this.pnl_Adm_right.Size = new System.Drawing.Size(1086, 730);
            this.pnl_Adm_right.TabIndex = 1;
            // 
            // btn_Adm_edit
            // 
            this.btn_Adm_edit.BackColor = System.Drawing.Color.White;
            this.btn_Adm_edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Adm_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_Adm_edit.Location = new System.Drawing.Point(388, 632);
            this.btn_Adm_edit.Name = "btn_Adm_edit";
            this.btn_Adm_edit.Size = new System.Drawing.Size(108, 38);
            this.btn_Adm_edit.TabIndex = 20;
            this.btn_Adm_edit.Text = "Edit";
            this.btn_Adm_edit.UseVisualStyleBackColor = false;
            this.btn_Adm_edit.Click += new System.EventHandler(this.btn_Adm_edit_Click);
            // 
            // btn_Adm_delete
            // 
            this.btn_Adm_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Adm_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Adm_delete.ForeColor = System.Drawing.Color.White;
            this.btn_Adm_delete.Location = new System.Drawing.Point(592, 632);
            this.btn_Adm_delete.Name = "btn_Adm_delete";
            this.btn_Adm_delete.Size = new System.Drawing.Size(108, 38);
            this.btn_Adm_delete.TabIndex = 19;
            this.btn_Adm_delete.Text = "Delete";
            this.btn_Adm_delete.UseVisualStyleBackColor = false;
            this.btn_Adm_delete.Click += new System.EventHandler(this.btn_Adm_delete_Click);
            // 
            // btn_Adm_search
            // 
            this.btn_Adm_search.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Adm_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adm_search.ForeColor = System.Drawing.Color.White;
            this.btn_Adm_search.Location = new System.Drawing.Point(452, 67);
            this.btn_Adm_search.Name = "btn_Adm_search";
            this.btn_Adm_search.Size = new System.Drawing.Size(102, 37);
            this.btn_Adm_search.TabIndex = 6;
            this.btn_Adm_search.Text = "Search";
            this.btn_Adm_search.UseVisualStyleBackColor = false;
            this.btn_Adm_search.Click += new System.EventHandler(this.btn_Adm_search_Click);
            // 
            // txt_Adm_search
            // 
            this.txt_Adm_search.Location = new System.Drawing.Point(94, 77);
            this.txt_Adm_search.Name = "txt_Adm_search";
            this.txt_Adm_search.PlaceholderText = "Enter a name...";
            this.txt_Adm_search.Size = new System.Drawing.Size(340, 23);
            this.txt_Adm_search.TabIndex = 5;
            // 
            // dataGV_Uv
            // 
            this.dataGV_Uv.AllowUserToAddRows = false;
            this.dataGV_Uv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Uv.Location = new System.Drawing.Point(82, 137);
            this.dataGV_Uv.Name = "dataGV_Uv";
            this.dataGV_Uv.ReadOnly = true;
            this.dataGV_Uv.RowTemplate.Height = 25;
            this.dataGV_Uv.Size = new System.Drawing.Size(929, 443);
            this.dataGV_Uv.TabIndex = 0;
            this.dataGV_Uv.CellClick += DataGv_Uv_CellClick;
            this.dataGV_Uv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            // 
            // btn_Adm_reset
            // 
            this.btn_Adm_reset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Adm_reset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adm_reset.ForeColor = System.Drawing.Color.White;
            this.btn_Adm_reset.Location = new System.Drawing.Point(571, 67);
            this.btn_Adm_reset.Name = "btn_Adm_reset";
            this.btn_Adm_reset.Size = new System.Drawing.Size(102, 37);
            this.btn_Adm_reset.TabIndex = 1;
            this.btn_Adm_reset.Text = "Reset";
            this.btn_Adm_reset.UseVisualStyleBackColor = false;
            this.btn_Adm_reset.Click += new System.EventHandler(this.btn_Adm_reset_Click);
            // 
            // btn_Adm_spplier
            // 
            this.btn_Adm_spplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Adm_spplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adm_spplier.ForeColor = System.Drawing.Color.White;
            this.btn_Adm_spplier.Location = new System.Drawing.Point(65, 417);
            this.btn_Adm_spplier.Name = "btn_Adm_spplier";
            this.btn_Adm_spplier.Size = new System.Drawing.Size(150, 35);
            this.btn_Adm_spplier.TabIndex = 21;
            this.btn_Adm_spplier.Text = "Suppliers";
            this.btn_Adm_spplier.UseVisualStyleBackColor = false;
            this.btn_Adm_spplier.Click += new System.EventHandler(this.btn_Adm_spplier_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.pnl_Adm_left);
            this.Controls.Add(this.pnl_Adm_right);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.pnl_Adm_left.ResumeLayout(false);
            this.pnl_Adm_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Adm_logo)).EndInit();
            this.pnl_Adm_right.ResumeLayout(false);
            this.pnl_Adm_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Uv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Adm_left;
        private PictureBox pctBox_Adm_logo;
        private Panel pnl_Adm_right;
        private Label lbl_Adm_logo;
        private Button btn_Adm_back;
        private Button btn_Adm_adduser;
        private Label lbl_Adm_username;
        private DataGridView dataGV_Uv;
        private Button btn_Adm_reset;
        private TextBox txt_Adm_search;
        private Button btn_Adm_search;
        private Button btn_Adm_edit;
        private Button btn_Adm_delete;
        private Button btn_Adm_spplier;
    }
}