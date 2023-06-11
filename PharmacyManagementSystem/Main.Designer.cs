namespace PharmacyManagementSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnl_Main_left = new System.Windows.Forms.Panel();
            this.lbl_Main_username = new System.Windows.Forms.Label();
            this.btn_Main_logout = new System.Windows.Forms.Button();
            this.btn_Main_billing = new System.Windows.Forms.Button();
            this.btn_Main_im = new System.Windows.Forms.Button();
            this.btn_Main_administration = new System.Windows.Forms.Button();
            this.lbl_Main_logo = new System.Windows.Forms.Label();
            this.pctBox_Main_logo = new System.Windows.Forms.PictureBox();
            this.pnl_Main_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Main_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main_left
            // 
            this.pnl_Main_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Main_left.Controls.Add(this.lbl_Main_username);
            this.pnl_Main_left.Controls.Add(this.btn_Main_logout);
            this.pnl_Main_left.Controls.Add(this.btn_Main_billing);
            this.pnl_Main_left.Controls.Add(this.btn_Main_im);
            this.pnl_Main_left.Controls.Add(this.btn_Main_administration);
            this.pnl_Main_left.Controls.Add(this.lbl_Main_logo);
            this.pnl_Main_left.Controls.Add(this.pctBox_Main_logo);
            this.pnl_Main_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main_left.Name = "pnl_Main_left";
            this.pnl_Main_left.Size = new System.Drawing.Size(275, 730);
            this.pnl_Main_left.TabIndex = 0;
            // 
            // lbl_Main_username
            // 
            this.lbl_Main_username.AutoSize = true;
            this.lbl_Main_username.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Main_username.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Main_username.Location = new System.Drawing.Point(93, 542);
            this.lbl_Main_username.Name = "lbl_Main_username";
            this.lbl_Main_username.Size = new System.Drawing.Size(119, 32);
            this.lbl_Main_username.TabIndex = 6;
            this.lbl_Main_username.Text = "username";
            // 
            // btn_Main_logout
            // 
            this.btn_Main_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Main_logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Main_logout.ForeColor = System.Drawing.Color.White;
            this.btn_Main_logout.Location = new System.Drawing.Point(75, 453);
            this.btn_Main_logout.Name = "btn_Main_logout";
            this.btn_Main_logout.Size = new System.Drawing.Size(137, 36);
            this.btn_Main_logout.TabIndex = 5;
            this.btn_Main_logout.Text = "Log Out";
            this.btn_Main_logout.UseVisualStyleBackColor = false;
            // 
            // btn_Main_billing
            // 
            this.btn_Main_billing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Main_billing.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Main_billing.ForeColor = System.Drawing.Color.White;
            this.btn_Main_billing.Location = new System.Drawing.Point(75, 411);
            this.btn_Main_billing.Name = "btn_Main_billing";
            this.btn_Main_billing.Size = new System.Drawing.Size(137, 36);
            this.btn_Main_billing.TabIndex = 4;
            this.btn_Main_billing.Text = "Billing";
            this.btn_Main_billing.UseVisualStyleBackColor = false;
            this.btn_Main_billing.Click += new System.EventHandler(this.btn_Main_billing_Click);
            // 
            // btn_Main_im
            // 
            this.btn_Main_im.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Main_im.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Main_im.ForeColor = System.Drawing.Color.White;
            this.btn_Main_im.Location = new System.Drawing.Point(75, 341);
            this.btn_Main_im.Name = "btn_Main_im";
            this.btn_Main_im.Size = new System.Drawing.Size(137, 64);
            this.btn_Main_im.TabIndex = 3;
            this.btn_Main_im.Text = "Item\r\nManagement";
            this.btn_Main_im.UseVisualStyleBackColor = false;
            this.btn_Main_im.Click += new System.EventHandler(this.btn_Main_im_Click);
            // 
            // btn_Main_administration
            // 
            this.btn_Main_administration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Main_administration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Main_administration.ForeColor = System.Drawing.Color.White;
            this.btn_Main_administration.Location = new System.Drawing.Point(75, 299);
            this.btn_Main_administration.Name = "btn_Main_administration";
            this.btn_Main_administration.Size = new System.Drawing.Size(137, 36);
            this.btn_Main_administration.TabIndex = 2;
            this.btn_Main_administration.Text = "Administration";
            this.btn_Main_administration.UseVisualStyleBackColor = false;
            this.btn_Main_administration.Click += new System.EventHandler(this.btn_Main_administration_Click);
            // 
            // lbl_Main_logo
            // 
            this.lbl_Main_logo.AutoSize = true;
            this.lbl_Main_logo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Main_logo.ForeColor = System.Drawing.Color.White;
            this.lbl_Main_logo.Location = new System.Drawing.Point(54, 215);
            this.lbl_Main_logo.Name = "lbl_Main_logo";
            this.lbl_Main_logo.Size = new System.Drawing.Size(165, 38);
            this.lbl_Main_logo.TabIndex = 1;
            this.lbl_Main_logo.Text = "Dashbord";
            // 
            // pctBox_Main_logo
            // 
            this.pctBox_Main_logo.Image = ((System.Drawing.Image)(resources.GetObject("pctBox_Main_logo.Image")));
            this.pctBox_Main_logo.Location = new System.Drawing.Point(45, 39);
            this.pctBox_Main_logo.Name = "pctBox_Main_logo";
            this.pctBox_Main_logo.Size = new System.Drawing.Size(183, 173);
            this.pctBox_Main_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBox_Main_logo.TabIndex = 0;
            this.pctBox_Main_logo.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 729);
            this.Controls.Add(this.pnl_Main_left);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.pnl_Main_left.ResumeLayout(false);
            this.pnl_Main_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Main_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Main_left;
        private Button btn_Main_administration;
        private Label lbl_Main_logo;
        private PictureBox pctBox_Main_logo;
        private Button btn_Main_logout;
        private Button btn_Main_billing;
        private Button btn_Main_im;
        private Label lbl_Main_username;
    }
}