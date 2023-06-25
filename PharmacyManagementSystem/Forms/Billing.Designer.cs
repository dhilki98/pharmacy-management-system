namespace PharmacyManagementSystem
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.pnl_Bill_left = new System.Windows.Forms.Panel();
            this.lbl_Bill_username = new System.Windows.Forms.Label();
            this.btn_Bill_back = new System.Windows.Forms.Button();
            this.lbl_Bill_logo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Bill_search = new System.Windows.Forms.Label();
            this.txt_Bill_search = new System.Windows.Forms.TextBox();
            this.listBox_Bill = new System.Windows.Forms.ListBox();
            this.lbl_Bill_nou = new System.Windows.Forms.Label();
            this.lbl_Bill_name = new System.Windows.Forms.Label();
            this.lbl_Bill_ppu = new System.Windows.Forms.Label();
            this.txt_Bill_name = new System.Windows.Forms.TextBox();
            this.txt_Bill_nou = new System.Windows.Forms.TextBox();
            this.txt_Bill_tprice = new System.Windows.Forms.TextBox();
            this.txt_Bill_ppu = new System.Windows.Forms.TextBox();
            this.lbl_Bill_tprice = new System.Windows.Forms.Label();
            this.btn_Bill_atocart = new System.Windows.Forms.Button();
            this.dataGV_Bill = new System.Windows.Forms.DataGridView();
            this.clm_Bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Bill_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Bill_ppu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Bill_nou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Bill_tprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Bill_remove = new System.Windows.Forms.Button();
            this.btn_Bill_print = new System.Windows.Forms.Button();
            this.lbl_Bill_total = new System.Windows.Forms.Label();
            this.lbl_Bill_id = new System.Windows.Forms.Label();
            this.txt_Bill_id = new System.Windows.Forms.TextBox();
            this.btn_Bill_refreash = new System.Windows.Forms.Button();
            this.pnl_Bill_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Bill_left
            // 
            this.pnl_Bill_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Bill_left.Controls.Add(this.lbl_Bill_username);
            this.pnl_Bill_left.Controls.Add(this.btn_Bill_back);
            this.pnl_Bill_left.Controls.Add(this.lbl_Bill_logo);
            this.pnl_Bill_left.Controls.Add(this.pictureBox1);
            this.pnl_Bill_left.Location = new System.Drawing.Point(3, 2);
            this.pnl_Bill_left.Name = "pnl_Bill_left";
            this.pnl_Bill_left.Size = new System.Drawing.Size(275, 730);
            this.pnl_Bill_left.TabIndex = 0;
            // 
            // lbl_Bill_username
            // 
            this.lbl_Bill_username.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bill_username.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Bill_username.Location = new System.Drawing.Point(3, 644);
            this.lbl_Bill_username.Name = "lbl_Bill_username";
            this.lbl_Bill_username.Size = new System.Drawing.Size(269, 29);
            this.lbl_Bill_username.TabIndex = 6;
            this.lbl_Bill_username.Text = "username";
            this.lbl_Bill_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Bill_back
            // 
            this.btn_Bill_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Bill_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Bill_back.Location = new System.Drawing.Point(3, 532);
            this.btn_Bill_back.Name = "btn_Bill_back";
            this.btn_Bill_back.Size = new System.Drawing.Size(266, 31);
            this.btn_Bill_back.TabIndex = 4;
            this.btn_Bill_back.Text = "Back";
            this.btn_Bill_back.UseVisualStyleBackColor = false;
            this.btn_Bill_back.Click += new System.EventHandler(this.btn_Bill_back_Click);
            // 
            // lbl_Bill_logo
            // 
            this.lbl_Bill_logo.AutoSize = true;
            this.lbl_Bill_logo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bill_logo.ForeColor = System.Drawing.Color.White;
            this.lbl_Bill_logo.Location = new System.Drawing.Point(89, 206);
            this.lbl_Bill_logo.Name = "lbl_Bill_logo";
            this.lbl_Bill_logo.Size = new System.Drawing.Size(99, 39);
            this.lbl_Bill_logo.TabIndex = 1;
            this.lbl_Bill_logo.Text = "Billing";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Bill_search
            // 
            this.lbl_Bill_search.AutoSize = true;
            this.lbl_Bill_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bill_search.Location = new System.Drawing.Point(358, 56);
            this.lbl_Bill_search.Name = "lbl_Bill_search";
            this.lbl_Bill_search.Size = new System.Drawing.Size(57, 21);
            this.lbl_Bill_search.TabIndex = 1;
            this.lbl_Bill_search.Text = "Search";
            // 
            // txt_Bill_search
            // 
            this.txt_Bill_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Bill_search.ForeColor = System.Drawing.Color.Black;
            this.txt_Bill_search.Location = new System.Drawing.Point(299, 80);
            this.txt_Bill_search.Name = "txt_Bill_search";
            this.txt_Bill_search.Size = new System.Drawing.Size(210, 29);
            this.txt_Bill_search.TabIndex = 2;
            this.txt_Bill_search.TextChanged += new System.EventHandler(this.txt_Bill_search_TextChanged);
            // 
            // listBox_Bill
            // 
            this.listBox_Bill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_Bill.FormattingEnabled = true;
            this.listBox_Bill.ItemHeight = 21;
            this.listBox_Bill.Location = new System.Drawing.Point(299, 123);
            this.listBox_Bill.Name = "listBox_Bill";
            this.listBox_Bill.Size = new System.Drawing.Size(210, 571);
            this.listBox_Bill.TabIndex = 3;
            this.listBox_Bill.SelectedIndexChanged += new System.EventHandler(this.listBox_Bill_SelectedIndexChanged);
            // 
            // lbl_Bill_nou
            // 
            this.lbl_Bill_nou.AutoSize = true;
            this.lbl_Bill_nou.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bill_nou.Location = new System.Drawing.Point(976, 32);
            this.lbl_Bill_nou.Name = "lbl_Bill_nou";
            this.lbl_Bill_nou.Size = new System.Drawing.Size(126, 21);
            this.lbl_Bill_nou.TabIndex = 4;
            this.lbl_Bill_nou.Text = "Number of Units";
            // 
            // lbl_Bill_name
            // 
            this.lbl_Bill_name.AutoSize = true;
            this.lbl_Bill_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bill_name.Location = new System.Drawing.Point(533, 105);
            this.lbl_Bill_name.Name = "lbl_Bill_name";
            this.lbl_Bill_name.Size = new System.Drawing.Size(87, 21);
            this.lbl_Bill_name.TabIndex = 5;
            this.lbl_Bill_name.Text = "Item Name";
            // 
            // lbl_Bill_ppu
            // 
            this.lbl_Bill_ppu.AutoSize = true;
            this.lbl_Bill_ppu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bill_ppu.Location = new System.Drawing.Point(533, 178);
            this.lbl_Bill_ppu.Name = "lbl_Bill_ppu";
            this.lbl_Bill_ppu.Size = new System.Drawing.Size(137, 21);
            this.lbl_Bill_ppu.TabIndex = 6;
            this.lbl_Bill_ppu.Text = "Price Per Unit (Rs.)";
            // 
            // txt_Bill_name
            // 
            this.txt_Bill_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Bill_name.ForeColor = System.Drawing.Color.Black;
            this.txt_Bill_name.Location = new System.Drawing.Point(533, 129);
            this.txt_Bill_name.Name = "txt_Bill_name";
            this.txt_Bill_name.ReadOnly = true;
            this.txt_Bill_name.Size = new System.Drawing.Size(340, 29);
            this.txt_Bill_name.TabIndex = 7;
            // 
            // txt_Bill_nou
            // 
            this.txt_Bill_nou.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Bill_nou.ForeColor = System.Drawing.Color.Black;
            this.txt_Bill_nou.Location = new System.Drawing.Point(976, 56);
            this.txt_Bill_nou.Name = "txt_Bill_nou";
            this.txt_Bill_nou.Size = new System.Drawing.Size(340, 29);
            this.txt_Bill_nou.TabIndex = 8;
            // 
            // txt_Bill_tprice
            // 
            this.txt_Bill_tprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Bill_tprice.ForeColor = System.Drawing.Color.Black;
            this.txt_Bill_tprice.Location = new System.Drawing.Point(976, 138);
            this.txt_Bill_tprice.Name = "txt_Bill_tprice";
            this.txt_Bill_tprice.ReadOnly = true;
            this.txt_Bill_tprice.Size = new System.Drawing.Size(340, 29);
            this.txt_Bill_tprice.TabIndex = 9;
            // 
            // txt_Bill_ppu
            // 
            this.txt_Bill_ppu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Bill_ppu.ForeColor = System.Drawing.Color.Black;
            this.txt_Bill_ppu.Location = new System.Drawing.Point(533, 202);
            this.txt_Bill_ppu.Name = "txt_Bill_ppu";
            this.txt_Bill_ppu.ReadOnly = true;
            this.txt_Bill_ppu.Size = new System.Drawing.Size(340, 29);
            this.txt_Bill_ppu.TabIndex = 10;
            // 
            // lbl_Bill_tprice
            // 
            this.lbl_Bill_tprice.AutoSize = true;
            this.lbl_Bill_tprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bill_tprice.Location = new System.Drawing.Point(976, 114);
            this.lbl_Bill_tprice.Name = "lbl_Bill_tprice";
            this.lbl_Bill_tprice.Size = new System.Drawing.Size(114, 21);
            this.lbl_Bill_tprice.TabIndex = 11;
            this.lbl_Bill_tprice.Text = "Total Price (Rs.)";
            // 
            // btn_Bill_atocart
            // 
            this.btn_Bill_atocart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Bill_atocart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Bill_atocart.ForeColor = System.Drawing.Color.White;
            this.btn_Bill_atocart.Location = new System.Drawing.Point(1186, 197);
            this.btn_Bill_atocart.Name = "btn_Bill_atocart";
            this.btn_Bill_atocart.Size = new System.Drawing.Size(130, 36);
            this.btn_Bill_atocart.TabIndex = 12;
            this.btn_Bill_atocart.Text = "Add to Cart";
            this.btn_Bill_atocart.UseVisualStyleBackColor = false;
            this.btn_Bill_atocart.Click += new System.EventHandler(this.btn_Bill_atocart_Click);
            // 
            // dataGV_Bill
            // 
            this.dataGV_Bill.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGV_Bill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGV_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Bill_id,
            this.clm_Bill_name,
            this.clm_Bill_ppu,
            this.clm_Bill_nou,
            this.clm_Bill_tprice});
            this.dataGV_Bill.Location = new System.Drawing.Point(533, 260);
            this.dataGV_Bill.Name = "dataGV_Bill";
            this.dataGV_Bill.RowTemplate.Height = 25;
            this.dataGV_Bill.Size = new System.Drawing.Size(783, 321);
            this.dataGV_Bill.TabIndex = 13;
            this.dataGV_Bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Bill_CellClick);
            // 
            // clm_Bill_id
            // 
            this.clm_Bill_id.HeaderText = "Item ID";
            this.clm_Bill_id.Name = "clm_Bill_id";
            // 
            // clm_Bill_name
            // 
            this.clm_Bill_name.HeaderText = "Item Name";
            this.clm_Bill_name.Name = "clm_Bill_name";
            this.clm_Bill_name.Width = 250;
            // 
            // clm_Bill_ppu
            // 
            this.clm_Bill_ppu.HeaderText = "Price Per Unit (Rs.)";
            this.clm_Bill_ppu.Name = "clm_Bill_ppu";
            // 
            // clm_Bill_nou
            // 
            this.clm_Bill_nou.HeaderText = "Number of Units";
            this.clm_Bill_nou.Name = "clm_Bill_nou";
            // 
            // clm_Bill_tprice
            // 
            this.clm_Bill_tprice.HeaderText = "Total Price (Rs.)";
            this.clm_Bill_tprice.Name = "clm_Bill_tprice";
            // 
            // btn_Bill_remove
            // 
            this.btn_Bill_remove.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Bill_remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Bill_remove.ForeColor = System.Drawing.Color.White;
            this.btn_Bill_remove.Location = new System.Drawing.Point(533, 618);
            this.btn_Bill_remove.Name = "btn_Bill_remove";
            this.btn_Bill_remove.Size = new System.Drawing.Size(130, 36);
            this.btn_Bill_remove.TabIndex = 14;
            this.btn_Bill_remove.Text = "Remove";
            this.btn_Bill_remove.UseVisualStyleBackColor = false;
            this.btn_Bill_remove.Click += new System.EventHandler(this.btn_Bill_remove_Click);
            // 
            // btn_Bill_print
            // 
            this.btn_Bill_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Bill_print.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Bill_print.ForeColor = System.Drawing.Color.White;
            this.btn_Bill_print.Location = new System.Drawing.Point(1186, 618);
            this.btn_Bill_print.Name = "btn_Bill_print";
            this.btn_Bill_print.Size = new System.Drawing.Size(130, 36);
            this.btn_Bill_print.TabIndex = 15;
            this.btn_Bill_print.Text = "Print";
            this.btn_Bill_print.UseVisualStyleBackColor = false;
            this.btn_Bill_print.Click += new System.EventHandler(this.btn_Bill_print_Click);
            // 
            // lbl_Bill_total
            // 
            this.lbl_Bill_total.AutoSize = true;
            this.lbl_Bill_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_Bill_total.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bill_total.Location = new System.Drawing.Point(903, 622);
            this.lbl_Bill_total.Name = "lbl_Bill_total";
            this.lbl_Bill_total.Size = new System.Drawing.Size(76, 32);
            this.lbl_Bill_total.TabIndex = 16;
            this.lbl_Bill_total.Text = "Rs. 00";
            this.lbl_Bill_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Bill_id
            // 
            this.lbl_Bill_id.AutoSize = true;
            this.lbl_Bill_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bill_id.Location = new System.Drawing.Point(533, 32);
            this.lbl_Bill_id.Name = "lbl_Bill_id";
            this.lbl_Bill_id.Size = new System.Drawing.Size(60, 21);
            this.lbl_Bill_id.TabIndex = 17;
            this.lbl_Bill_id.Text = "Item ID";
            // 
            // txt_Bill_id
            // 
            this.txt_Bill_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Bill_id.ForeColor = System.Drawing.Color.Black;
            this.txt_Bill_id.Location = new System.Drawing.Point(533, 56);
            this.txt_Bill_id.Name = "txt_Bill_id";
            this.txt_Bill_id.ReadOnly = true;
            this.txt_Bill_id.Size = new System.Drawing.Size(340, 29);
            this.txt_Bill_id.TabIndex = 18;
            // 
            // btn_Bill_refreash
            // 
            this.btn_Bill_refreash.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Bill_refreash.ForeColor = System.Drawing.Color.White;
            this.btn_Bill_refreash.Location = new System.Drawing.Point(299, 12);
            this.btn_Bill_refreash.Name = "btn_Bill_refreash";
            this.btn_Bill_refreash.Size = new System.Drawing.Size(75, 31);
            this.btn_Bill_refreash.TabIndex = 19;
            this.btn_Bill_refreash.Text = "Refresh";
            this.btn_Bill_refreash.UseVisualStyleBackColor = false;
            this.btn_Bill_refreash.Click += new System.EventHandler(this.btn_Bill_refreash_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 729);
            this.Controls.Add(this.btn_Bill_refreash);
            this.Controls.Add(this.txt_Bill_id);
            this.Controls.Add(this.lbl_Bill_id);
            this.Controls.Add(this.lbl_Bill_total);
            this.Controls.Add(this.btn_Bill_print);
            this.Controls.Add(this.btn_Bill_remove);
            this.Controls.Add(this.dataGV_Bill);
            this.Controls.Add(this.btn_Bill_atocart);
            this.Controls.Add(this.lbl_Bill_tprice);
            this.Controls.Add(this.txt_Bill_ppu);
            this.Controls.Add(this.txt_Bill_tprice);
            this.Controls.Add(this.txt_Bill_nou);
            this.Controls.Add(this.txt_Bill_name);
            this.Controls.Add(this.lbl_Bill_ppu);
            this.Controls.Add(this.lbl_Bill_name);
            this.Controls.Add(this.lbl_Bill_nou);
            this.Controls.Add(this.listBox_Bill);
            this.Controls.Add(this.txt_Bill_search);
            this.Controls.Add(this.lbl_Bill_search);
            this.Controls.Add(this.pnl_Bill_left);
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.pnl_Bill_left.ResumeLayout(false);
            this.pnl_Bill_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_Bill_left;
        private PictureBox pictureBox1;
        private Label lbl_Bill_logo;
        private Button btn_Bill_back;
        private Label lbl_Bill_username;
        private Label lbl_Bill_search;
        private TextBox txt_Bill_search;
        private ListBox listBox_Bill;
        private Label lbl_Bill_nou;
        private Label lbl_Bill_name;
        private Label lbl_Bill_ppu;
        private TextBox txt_Bill_name;
        private TextBox txt_Bill_nou;
        private TextBox txt_Bill_tprice;
        private TextBox txt_Bill_ppu;
        private Label lbl_Bill_tprice;
        private Button btn_Bill_atocart;
        private DataGridView dataGV_Bill;
        private Button btn_Bill_remove;
        private Button btn_Bill_print;
        private Label lbl_Bill_total;
        private DataGridViewTextBoxColumn clm_Bill_id;
        private DataGridViewTextBoxColumn clm_Bill_name;
        private DataGridViewTextBoxColumn clm_Bill_ppu;
        private DataGridViewTextBoxColumn clm_Bill_nou;
        private DataGridViewTextBoxColumn clm_Bill_tprice;
        private Label lbl_Bill_id;
        private TextBox txt_Bill_id;
        private Button btn_Bill_refreash;
    }
}