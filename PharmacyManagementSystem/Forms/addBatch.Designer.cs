namespace PharmacyManagementSystem
{
    partial class addBatch
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
            this.lbl_aB_iid = new System.Windows.Forms.Label();
            this.txt_aB_iid = new System.Windows.Forms.TextBox();
            this.lbl_aB_sid = new System.Windows.Forms.Label();
            this.txt_aB_sid = new System.Windows.Forms.TextBox();
            this.txt_aB_unitprice = new System.Windows.Forms.TextBox();
            this.txt_aB_quantity = new System.Windows.Forms.TextBox();
            this.lbl_aB_edate = new System.Windows.Forms.Label();
            this.lbl_aB_batchdetails = new System.Windows.Forms.Label();
            this.lbl_aB_quantity = new System.Windows.Forms.Label();
            this.lbl_aB_unitprice = new System.Windows.Forms.Label();
            this.pnl_aB_middle = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTP_aB_expiredate = new System.Windows.Forms.DateTimePicker();
            this.btn_aB_reset = new System.Windows.Forms.Button();
            this.btn_aB_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_aB_iid
            // 
            this.lbl_aB_iid.AutoSize = true;
            this.lbl_aB_iid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_aB_iid.Location = new System.Drawing.Point(56, 128);
            this.lbl_aB_iid.Name = "lbl_aB_iid";
            this.lbl_aB_iid.Size = new System.Drawing.Size(60, 21);
            this.lbl_aB_iid.TabIndex = 0;
            this.lbl_aB_iid.Text = "Item ID";
            // 
            // txt_aB_iid
            // 
            this.txt_aB_iid.Location = new System.Drawing.Point(56, 174);
            this.txt_aB_iid.Name = "txt_aB_iid";
            this.txt_aB_iid.Size = new System.Drawing.Size(340, 23);
            this.txt_aB_iid.TabIndex = 1;
            // 
            // lbl_aB_sid
            // 
            this.lbl_aB_sid.AutoSize = true;
            this.lbl_aB_sid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_aB_sid.Location = new System.Drawing.Point(56, 294);
            this.lbl_aB_sid.Name = "lbl_aB_sid";
            this.lbl_aB_sid.Size = new System.Drawing.Size(78, 21);
            this.lbl_aB_sid.TabIndex = 2;
            this.lbl_aB_sid.Text = "Spplier ID";
            this.lbl_aB_sid.Click += new System.EventHandler(this.lbl_aB_sid_Click);
            // 
            // txt_aB_sid
            // 
            this.txt_aB_sid.Location = new System.Drawing.Point(56, 346);
            this.txt_aB_sid.Name = "txt_aB_sid";
            this.txt_aB_sid.Size = new System.Drawing.Size(340, 23);
            this.txt_aB_sid.TabIndex = 3;
            // 
            // txt_aB_unitprice
            // 
            this.txt_aB_unitprice.Location = new System.Drawing.Point(526, 174);
            this.txt_aB_unitprice.Name = "txt_aB_unitprice";
            this.txt_aB_unitprice.Size = new System.Drawing.Size(340, 23);
            this.txt_aB_unitprice.TabIndex = 4;
            // 
            // txt_aB_quantity
            // 
            this.txt_aB_quantity.Location = new System.Drawing.Point(526, 346);
            this.txt_aB_quantity.Name = "txt_aB_quantity";
            this.txt_aB_quantity.Size = new System.Drawing.Size(340, 23);
            this.txt_aB_quantity.TabIndex = 6;
            this.txt_aB_quantity.TextChanged += new System.EventHandler(this.txt_aB_quantity_TextChanged);
            // 
            // lbl_aB_edate
            // 
            this.lbl_aB_edate.AutoSize = true;
            this.lbl_aB_edate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_aB_edate.Location = new System.Drawing.Point(56, 467);
            this.lbl_aB_edate.Name = "lbl_aB_edate";
            this.lbl_aB_edate.Size = new System.Drawing.Size(88, 21);
            this.lbl_aB_edate.TabIndex = 7;
            this.lbl_aB_edate.Text = "Expire Date";
            // 
            // lbl_aB_batchdetails
            // 
            this.lbl_aB_batchdetails.AutoSize = true;
            this.lbl_aB_batchdetails.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_aB_batchdetails.Location = new System.Drawing.Point(56, 43);
            this.lbl_aB_batchdetails.Name = "lbl_aB_batchdetails";
            this.lbl_aB_batchdetails.Size = new System.Drawing.Size(205, 36);
            this.lbl_aB_batchdetails.TabIndex = 8;
            this.lbl_aB_batchdetails.Text = "Batch Detaiils";
            // 
            // lbl_aB_quantity
            // 
            this.lbl_aB_quantity.AutoSize = true;
            this.lbl_aB_quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_aB_quantity.Location = new System.Drawing.Point(526, 294);
            this.lbl_aB_quantity.Name = "lbl_aB_quantity";
            this.lbl_aB_quantity.Size = new System.Drawing.Size(70, 21);
            this.lbl_aB_quantity.TabIndex = 9;
            this.lbl_aB_quantity.Text = "Quantity";
            // 
            // lbl_aB_unitprice
            // 
            this.lbl_aB_unitprice.AutoSize = true;
            this.lbl_aB_unitprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_aB_unitprice.Location = new System.Drawing.Point(526, 128);
            this.lbl_aB_unitprice.Name = "lbl_aB_unitprice";
            this.lbl_aB_unitprice.Size = new System.Drawing.Size(77, 21);
            this.lbl_aB_unitprice.TabIndex = 10;
            this.lbl_aB_unitprice.Text = "Unit Price";
            this.lbl_aB_unitprice.Click += new System.EventHandler(this.lbl_aB_unitprice_Click);
            // 
            // pnl_aB_middle
            // 
            this.pnl_aB_middle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.pnl_aB_middle.Location = new System.Drawing.Point(455, 90);
            this.pnl_aB_middle.Name = "pnl_aB_middle";
            this.pnl_aB_middle.Size = new System.Drawing.Size(6, 523);
            this.pnl_aB_middle.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(580, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTP_aB_expiredate
            // 
            this.dateTP_aB_expiredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTP_aB_expiredate.Location = new System.Drawing.Point(56, 508);
            this.dateTP_aB_expiredate.Name = "dateTP_aB_expiredate";
            this.dateTP_aB_expiredate.Size = new System.Drawing.Size(340, 23);
            this.dateTP_aB_expiredate.TabIndex = 13;
            // 
            // btn_aB_reset
            // 
            this.btn_aB_reset.BackColor = System.Drawing.Color.White;
            this.btn_aB_reset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_aB_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_aB_reset.Location = new System.Drawing.Point(693, 488);
            this.btn_aB_reset.Name = "btn_aB_reset";
            this.btn_aB_reset.Size = new System.Drawing.Size(95, 43);
            this.btn_aB_reset.TabIndex = 14;
            this.btn_aB_reset.Text = "Reset";
            this.btn_aB_reset.UseVisualStyleBackColor = false;
            this.btn_aB_reset.Click += new System.EventHandler(this.btn_aB_reset_Click);
            // 
            // btn_aB_back
            // 
            this.btn_aB_back.BackColor = System.Drawing.Color.White;
            this.btn_aB_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_aB_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_aB_back.Location = new System.Drawing.Point(806, 488);
            this.btn_aB_back.Name = "btn_aB_back";
            this.btn_aB_back.Size = new System.Drawing.Size(95, 43);
            this.btn_aB_back.TabIndex = 15;
            this.btn_aB_back.Text = "Back";
            this.btn_aB_back.UseVisualStyleBackColor = false;
            this.btn_aB_back.Click += new System.EventHandler(this.btn_aB_back_Click);
            // 
            // addBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 688);
            this.Controls.Add(this.btn_aB_back);
            this.Controls.Add(this.btn_aB_reset);
            this.Controls.Add(this.dateTP_aB_expiredate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl_aB_middle);
            this.Controls.Add(this.lbl_aB_unitprice);
            this.Controls.Add(this.lbl_aB_quantity);
            this.Controls.Add(this.lbl_aB_batchdetails);
            this.Controls.Add(this.lbl_aB_edate);
            this.Controls.Add(this.txt_aB_quantity);
            this.Controls.Add(this.txt_aB_unitprice);
            this.Controls.Add(this.txt_aB_sid);
            this.Controls.Add(this.lbl_aB_sid);
            this.Controls.Add(this.txt_aB_iid);
            this.Controls.Add(this.lbl_aB_iid);
            this.Name = "addBatch";
            this.Text = "addBatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_aB_iid;
        private TextBox txt_aB_iid;
        private Label lbl_aB_sid;
        private TextBox txt_aB_sid;
        private TextBox txt_aB_unitprice;
        private TextBox txt_aB_quantity;
        private Label lbl_aB_edate;
        private Label lbl_aB_batchdetails;
        private Label lbl_aB_quantity;
        private Label lbl_aB_unitprice;
        private Panel pnl_aB_middle;
        private Button button1;
        private DateTimePicker dateTP_aB_expiredate;
        private Button btn_aB_reset;
        private Button btn_aB_back;
    }
}