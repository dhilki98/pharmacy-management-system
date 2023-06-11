namespace PharmacyManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnl_Login_left = new System.Windows.Forms.Panel();
            this.pctBox_Login_logo = new System.Windows.Forms.PictureBox();
            this.lbl_Login_title = new System.Windows.Forms.Label();
            this.pnl_Login_line = new System.Windows.Forms.Panel();
            this.pctBox_Login_up = new System.Windows.Forms.PictureBox();
            this.lbl_Login_signin = new System.Windows.Forms.Label();
            this.lbl_Login_username = new System.Windows.Forms.Label();
            this.lbl_Login_password = new System.Windows.Forms.Label();
            this.txt_Login_username = new System.Windows.Forms.TextBox();
            this.txt_Login_password = new System.Windows.Forms.TextBox();
            this.btn_Login_signin = new System.Windows.Forms.Button();
            this.btn_Login_clear = new System.Windows.Forms.Button();
            this.pnl_Login_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Login_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Login_up)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Login_left
            // 
            this.pnl_Login_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Login_left.Controls.Add(this.pctBox_Login_logo);
            this.pnl_Login_left.Controls.Add(this.lbl_Login_title);
            this.pnl_Login_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_Login_left.Name = "pnl_Login_left";
            this.pnl_Login_left.Size = new System.Drawing.Size(438, 770);
            this.pnl_Login_left.TabIndex = 0;
            // 
            // pctBox_Login_logo
            // 
            this.pctBox_Login_logo.Image = ((System.Drawing.Image)(resources.GetObject("pctBox_Login_logo.Image")));
            this.pctBox_Login_logo.Location = new System.Drawing.Point(110, 362);
            this.pctBox_Login_logo.Name = "pctBox_Login_logo";
            this.pctBox_Login_logo.Size = new System.Drawing.Size(205, 189);
            this.pctBox_Login_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBox_Login_logo.TabIndex = 1;
            this.pctBox_Login_logo.TabStop = false;
            // 
            // lbl_Login_title
            // 
            this.lbl_Login_title.AutoSize = true;
            this.lbl_Login_title.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login_title.ForeColor = System.Drawing.Color.White;
            this.lbl_Login_title.Location = new System.Drawing.Point(55, 128);
            this.lbl_Login_title.Name = "lbl_Login_title";
            this.lbl_Login_title.Size = new System.Drawing.Size(335, 177);
            this.lbl_Login_title.TabIndex = 0;
            this.lbl_Login_title.Text = "Management\r\nSystem -\r\nUnity Pharmacy\r\n";
            // 
            // pnl_Login_line
            // 
            this.pnl_Login_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.pnl_Login_line.Location = new System.Drawing.Point(613, 170);
            this.pnl_Login_line.Name = "pnl_Login_line";
            this.pnl_Login_line.Size = new System.Drawing.Size(4, 500);
            this.pnl_Login_line.TabIndex = 1;
            // 
            // pctBox_Login_up
            // 
            this.pctBox_Login_up.Image = ((System.Drawing.Image)(resources.GetObject("pctBox_Login_up.Image")));
            this.pctBox_Login_up.Location = new System.Drawing.Point(938, 99);
            this.pctBox_Login_up.Name = "pctBox_Login_up";
            this.pctBox_Login_up.Size = new System.Drawing.Size(100, 100);
            this.pctBox_Login_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBox_Login_up.TabIndex = 2;
            this.pctBox_Login_up.TabStop = false;
            // 
            // lbl_Login_signin
            // 
            this.lbl_Login_signin.AutoSize = true;
            this.lbl_Login_signin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login_signin.Location = new System.Drawing.Point(944, 202);
            this.lbl_Login_signin.Name = "lbl_Login_signin";
            this.lbl_Login_signin.Size = new System.Drawing.Size(94, 32);
            this.lbl_Login_signin.TabIndex = 3;
            this.lbl_Login_signin.Text = "Sign In";
            // 
            // lbl_Login_username
            // 
            this.lbl_Login_username.AutoSize = true;
            this.lbl_Login_username.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login_username.Location = new System.Drawing.Point(738, 300);
            this.lbl_Login_username.Name = "lbl_Login_username";
            this.lbl_Login_username.Size = new System.Drawing.Size(107, 26);
            this.lbl_Login_username.TabIndex = 4;
            this.lbl_Login_username.Text = "User Name";
            // 
            // lbl_Login_password
            // 
            this.lbl_Login_password.AutoSize = true;
            this.lbl_Login_password.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login_password.Location = new System.Drawing.Point(738, 388);
            this.lbl_Login_password.Name = "lbl_Login_password";
            this.lbl_Login_password.Size = new System.Drawing.Size(94, 26);
            this.lbl_Login_password.TabIndex = 5;
            this.lbl_Login_password.Text = "Password";
            // 
            // txt_Login_username
            // 
            this.txt_Login_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Login_username.Location = new System.Drawing.Point(738, 329);
            this.txt_Login_username.Name = "txt_Login_username";
            this.txt_Login_username.Size = new System.Drawing.Size(344, 29);
            this.txt_Login_username.TabIndex = 6;
            // 
            // txt_Login_password
            // 
            this.txt_Login_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Login_password.Location = new System.Drawing.Point(738, 417);
            this.txt_Login_password.Name = "txt_Login_password";
            this.txt_Login_password.PasswordChar = '*';
            this.txt_Login_password.Size = new System.Drawing.Size(344, 29);
            this.txt_Login_password.TabIndex = 7;
            // 
            // btn_Login_signin
            // 
            this.btn_Login_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Login_signin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login_signin.ForeColor = System.Drawing.Color.White;
            this.btn_Login_signin.Location = new System.Drawing.Point(738, 503);
            this.btn_Login_signin.Name = "btn_Login_signin";
            this.btn_Login_signin.Size = new System.Drawing.Size(146, 36);
            this.btn_Login_signin.TabIndex = 8;
            this.btn_Login_signin.Text = "Sign In";
            this.btn_Login_signin.UseVisualStyleBackColor = false;
            this.btn_Login_signin.Click += new System.EventHandler(this.btn_Login_signin_Click);
            // 
            // btn_Login_clear
            // 
            this.btn_Login_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Login_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login_clear.ForeColor = System.Drawing.Color.White;
            this.btn_Login_clear.Location = new System.Drawing.Point(996, 503);
            this.btn_Login_clear.Name = "btn_Login_clear";
            this.btn_Login_clear.Size = new System.Drawing.Size(146, 36);
            this.btn_Login_clear.TabIndex = 9;
            this.btn_Login_clear.Text = "Clear";
            this.btn_Login_clear.UseVisualStyleBackColor = false;
            this.btn_Login_clear.Click += this.btn_Login_clear_Click;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_Login_clear);
            this.Controls.Add(this.btn_Login_signin);
            this.Controls.Add(this.txt_Login_password);
            this.Controls.Add(this.txt_Login_username);
            this.Controls.Add(this.lbl_Login_password);
            this.Controls.Add(this.lbl_Login_username);
            this.Controls.Add(this.lbl_Login_signin);
            this.Controls.Add(this.pctBox_Login_up);
            this.Controls.Add(this.pnl_Login_line);
            this.Controls.Add(this.pnl_Login_left);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnl_Login_left.ResumeLayout(false);
            this.pnl_Login_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Login_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_Login_up)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_Login_left;
        private Label lbl_Login_title;
        private PictureBox pctBox_Login_logo;
        private Panel pnl_Login_line;
        private PictureBox pctBox_Login_up;
        private Label lbl_Login_signin;
        private Label lbl_Login_username;
        private Label lbl_Login_password;
        private TextBox txt_Login_username;
        private TextBox txt_Login_password;
        private Button btn_Login_signin;
        
       private Button btn_Login_clear;
    }
}