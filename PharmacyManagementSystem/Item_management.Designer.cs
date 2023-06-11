namespace PharmacyManagementSystem
{
    partial class Item_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_management));
            this.pnl_Im_left = new System.Windows.Forms.Panel();
            this.btn_Im_update = new System.Windows.Forms.Button();
            this.lbl_Im_username = new System.Windows.Forms.Label();
            this.btn_Im_back = new System.Windows.Forms.Button();
            this.btn_Im_remove = new System.Windows.Forms.Button();
            this.btn_Im_view = new System.Windows.Forms.Button();
            this.btn_Im_add = new System.Windows.Forms.Button();
            this.lbl_Im_logo = new System.Windows.Forms.Label();
            this.pctBoc_Im_logo = new System.Windows.Forms.PictureBox();
            this.pnl_Im_right = new System.Windows.Forms.Panel();
            this.pnl_Im_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoc_Im_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Im_left
            // 
            this.pnl_Im_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Im_left.Controls.Add(this.btn_Im_update);
            this.pnl_Im_left.Controls.Add(this.lbl_Im_username);
            this.pnl_Im_left.Controls.Add(this.btn_Im_back);
            this.pnl_Im_left.Controls.Add(this.btn_Im_remove);
            this.pnl_Im_left.Controls.Add(this.btn_Im_view);
            this.pnl_Im_left.Controls.Add(this.btn_Im_add);
            this.pnl_Im_left.Controls.Add(this.lbl_Im_logo);
            this.pnl_Im_left.Controls.Add(this.pctBoc_Im_logo);
            this.pnl_Im_left.Controls.Add(this.pnl_Im_right);
            this.pnl_Im_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_Im_left.Name = "pnl_Im_left";
            this.pnl_Im_left.Size = new System.Drawing.Size(275, 730);
            this.pnl_Im_left.TabIndex = 0;
            // 
            // btn_Im_update
            // 
            this.btn_Im_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Im_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Im_update.ForeColor = System.Drawing.Color.White;
            this.btn_Im_update.Location = new System.Drawing.Point(60, 390);
            this.btn_Im_update.Name = "btn_Im_update";
            this.btn_Im_update.Size = new System.Drawing.Size(125, 31);
            this.btn_Im_update.TabIndex = 9;
            this.btn_Im_update.Text = "Update Item";
            this.btn_Im_update.UseVisualStyleBackColor = false;
            // 
            // lbl_Im_username
            // 
            this.lbl_Im_username.AutoSize = true;
            this.lbl_Im_username.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Im_username.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Im_username.Location = new System.Drawing.Point(74, 544);
            this.lbl_Im_username.Name = "lbl_Im_username";
            this.lbl_Im_username.Size = new System.Drawing.Size(111, 29);
            this.lbl_Im_username.TabIndex = 8;
            this.lbl_Im_username.Text = "username";
            // 
            // btn_Im_back
            // 
            this.btn_Im_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Im_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Im_back.ForeColor = System.Drawing.Color.White;
            this.btn_Im_back.Location = new System.Drawing.Point(60, 493);
            this.btn_Im_back.Name = "btn_Im_back";
            this.btn_Im_back.Size = new System.Drawing.Size(125, 31);
            this.btn_Im_back.TabIndex = 7;
            this.btn_Im_back.Text = "Back";
            this.btn_Im_back.UseVisualStyleBackColor = false;
            this.btn_Im_back.Click += new System.EventHandler(this.btn_Im_back_Click);
            // 
            // btn_Im_remove
            // 
            this.btn_Im_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Im_remove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Im_remove.ForeColor = System.Drawing.Color.White;
            this.btn_Im_remove.Location = new System.Drawing.Point(60, 442);
            this.btn_Im_remove.Name = "btn_Im_remove";
            this.btn_Im_remove.Size = new System.Drawing.Size(125, 31);
            this.btn_Im_remove.TabIndex = 6;
            this.btn_Im_remove.Text = "Remove Item";
            this.btn_Im_remove.UseVisualStyleBackColor = false;
            // 
            // btn_Im_view
            // 
            this.btn_Im_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Im_view.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Im_view.ForeColor = System.Drawing.Color.White;
            this.btn_Im_view.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Im_view.Location = new System.Drawing.Point(60, 293);
            this.btn_Im_view.Name = "btn_Im_view";
            this.btn_Im_view.Size = new System.Drawing.Size(125, 31);
            this.btn_Im_view.TabIndex = 5;
            this.btn_Im_view.Text = "View Items";
            this.btn_Im_view.UseVisualStyleBackColor = false;
            // 
            // btn_Im_add
            // 
            this.btn_Im_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Im_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Im_add.ForeColor = System.Drawing.Color.White;
            this.btn_Im_add.Location = new System.Drawing.Point(60, 342);
            this.btn_Im_add.Name = "btn_Im_add";
            this.btn_Im_add.Size = new System.Drawing.Size(125, 31);
            this.btn_Im_add.TabIndex = 4;
            this.btn_Im_add.Text = "Add Item";
            this.btn_Im_add.UseVisualStyleBackColor = false;
            // 
            // lbl_Im_logo
            // 
            this.lbl_Im_logo.AutoSize = true;
            this.lbl_Im_logo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Im_logo.ForeColor = System.Drawing.Color.White;
            this.lbl_Im_logo.Location = new System.Drawing.Point(44, 188);
            this.lbl_Im_logo.Name = "lbl_Im_logo";
            this.lbl_Im_logo.Size = new System.Drawing.Size(195, 78);
            this.lbl_Im_logo.TabIndex = 3;
            this.lbl_Im_logo.Text = "Item\r\nManagement\r\n";
            // 
            // pctBoc_Im_logo
            // 
            this.pctBoc_Im_logo.Image = ((System.Drawing.Image)(resources.GetObject("pctBoc_Im_logo.Image")));
            this.pctBoc_Im_logo.Location = new System.Drawing.Point(44, 12);
            this.pctBoc_Im_logo.Name = "pctBoc_Im_logo";
            this.pctBoc_Im_logo.Size = new System.Drawing.Size(183, 173);
            this.pctBoc_Im_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoc_Im_logo.TabIndex = 2;
            this.pctBoc_Im_logo.TabStop = false;
            // 
            // pnl_Im_right
            // 
            this.pnl_Im_right.Location = new System.Drawing.Point(275, 0);
            this.pnl_Im_right.Name = "pnl_Im_right";
            this.pnl_Im_right.Size = new System.Drawing.Size(1088, 727);
            this.pnl_Im_right.TabIndex = 1;
            // 
            // Item_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 729);
            this.Controls.Add(this.pnl_Im_left);
            this.Name = "Item_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item_management";
            this.pnl_Im_left.ResumeLayout(false);
            this.pnl_Im_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoc_Im_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Im_left;
        private Panel pnl_Im_right;
        private PictureBox pctBoc_Im_logo;
        private Label lbl_Im_logo;
        private Button btn_Im_add;
        private Button btn_Im_back;
        private Button btn_Im_remove;
        private Button btn_Im_view;
        private Label lbl_Im_username;
        private Button btn_Im_update;
    }
}