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
            this.btn_Uv_refresh = new System.Windows.Forms.Button();
            this.lbl_Vu_username = new System.Windows.Forms.Label();
            this.txt_Vu_username = new System.Windows.Forms.TextBox();
            this.btn_Vu_delete = new System.Windows.Forms.Button();
            this.btn_Vu_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Uv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_Uv
            // 
            this.dataGV_Uv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Uv.Location = new System.Drawing.Point(12, 137);
            this.dataGV_Uv.Name = "dataGV_Uv";
            this.dataGV_Uv.RowTemplate.Height = 25;
            this.dataGV_Uv.Size = new System.Drawing.Size(1048, 443);
            this.dataGV_Uv.TabIndex = 0;
            this.dataGV_Uv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Uv_CellClick);
            // 
            // btn_Uv_refresh
            // 
            this.btn_Uv_refresh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Uv_refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Uv_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Uv_refresh.Location = new System.Drawing.Point(12, 12);
            this.btn_Uv_refresh.Name = "btn_Uv_refresh";
            this.btn_Uv_refresh.Size = new System.Drawing.Size(102, 37);
            this.btn_Uv_refresh.TabIndex = 1;
            this.btn_Uv_refresh.Text = "Refresh";
            this.btn_Uv_refresh.UseVisualStyleBackColor = false;
            this.btn_Uv_refresh.Click += new System.EventHandler(this.btn_Uv_refresh_Click);
            // 
            // lbl_Vu_username
            // 
            this.lbl_Vu_username.AutoSize = true;
            this.lbl_Vu_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Vu_username.Location = new System.Drawing.Point(157, 59);
            this.lbl_Vu_username.Name = "lbl_Vu_username";
            this.lbl_Vu_username.Size = new System.Drawing.Size(119, 21);
            this.lbl_Vu_username.TabIndex = 2;
            this.lbl_Vu_username.Text = "Enter username";
            // 
            // txt_Vu_username
            // 
            this.txt_Vu_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Vu_username.ForeColor = System.Drawing.Color.Black;
            this.txt_Vu_username.Location = new System.Drawing.Point(157, 83);
            this.txt_Vu_username.Name = "txt_Vu_username";
            this.txt_Vu_username.Size = new System.Drawing.Size(180, 27);
            this.txt_Vu_username.TabIndex = 3;
            this.txt_Vu_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Vu_username.TextChanged += new System.EventHandler(this.txt_Vu_username_TextChanged);
            // 
            // btn_Vu_delete
            // 
            this.btn_Vu_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Vu_delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Vu_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Vu_delete.Location = new System.Drawing.Point(968, 629);
            this.btn_Vu_delete.Name = "btn_Vu_delete";
            this.btn_Vu_delete.Size = new System.Drawing.Size(92, 29);
            this.btn_Vu_delete.TabIndex = 4;
            this.btn_Vu_delete.Text = "Delete";
            this.btn_Vu_delete.UseVisualStyleBackColor = false;
            this.btn_Vu_delete.Click += new System.EventHandler(this.btn_Vu_delete_Click);
            // 
            // btn_Vu_close
            // 
            this.btn_Vu_close.BackColor = System.Drawing.Color.Red;
            this.btn_Vu_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Vu_close.ForeColor = System.Drawing.Color.Black;
            this.btn_Vu_close.Location = new System.Drawing.Point(1030, 12);
            this.btn_Vu_close.Name = "btn_Vu_close";
            this.btn_Vu_close.Size = new System.Drawing.Size(30, 30);
            this.btn_Vu_close.TabIndex = 5;
            this.btn_Vu_close.Text = "X";
            this.btn_Vu_close.UseVisualStyleBackColor = false;
            // 
            // Viewuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 688);
            this.Controls.Add(this.btn_Vu_close);
            this.Controls.Add(this.btn_Vu_delete);
            this.Controls.Add(this.txt_Vu_username);
            this.Controls.Add(this.lbl_Vu_username);
            this.Controls.Add(this.btn_Uv_refresh);
            this.Controls.Add(this.dataGV_Uv);
            this.Name = "Viewuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewuser";
            this.Load += new System.EventHandler(this.Viewuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Uv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGV_Uv;
        private Button btn_Uv_refresh;
        private Label lbl_Vu_username;
        private TextBox txt_Vu_username;
        private Button btn_Vu_delete;
        private Button btn_Vu_close;
    }
}