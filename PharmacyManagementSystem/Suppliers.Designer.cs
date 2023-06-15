namespace PharmacyManagementSystem
{
    partial class Suppliers
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
            this.lbl_sup_supdetails = new System.Windows.Forms.Label();
            this.lbl_sup_address = new System.Windows.Forms.Label();
            this.lbl_sup_contactno = new System.Windows.Forms.Label();
            this.lbl_sup_lino = new System.Windows.Forms.Label();
            this.lbl_sup_name = new System.Windows.Forms.Label();
            this.txt_sup_name = new System.Windows.Forms.TextBox();
            this.txt_sup_contactno = new System.Windows.Forms.TextBox();
            this.txt_sup_lino = new System.Windows.Forms.TextBox();
            this.txt_sup_address = new System.Windows.Forms.TextBox();
            this.dataGV_sup = new System.Windows.Forms.DataGridView();
            this.btn_sup_add = new System.Windows.Forms.Button();
            this.btn_sup_delete = new System.Windows.Forms.Button();
            this.btn_sup_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_sup)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_sup_supdetails
            // 
            this.lbl_sup_supdetails.AutoSize = true;
            this.lbl_sup_supdetails.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sup_supdetails.Location = new System.Drawing.Point(64, 37);
            this.lbl_sup_supdetails.Name = "lbl_sup_supdetails";
            this.lbl_sup_supdetails.Size = new System.Drawing.Size(229, 36);
            this.lbl_sup_supdetails.TabIndex = 0;
            this.lbl_sup_supdetails.Text = "Supplier Details";
            // 
            // lbl_sup_address
            // 
            this.lbl_sup_address.AutoSize = true;
            this.lbl_sup_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sup_address.Location = new System.Drawing.Point(64, 182);
            this.lbl_sup_address.Name = "lbl_sup_address";
            this.lbl_sup_address.Size = new System.Drawing.Size(66, 21);
            this.lbl_sup_address.TabIndex = 1;
            this.lbl_sup_address.Text = "Address";
            this.lbl_sup_address.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_sup_contactno
            // 
            this.lbl_sup_contactno.AutoSize = true;
            this.lbl_sup_contactno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sup_contactno.Location = new System.Drawing.Point(64, 249);
            this.lbl_sup_contactno.Name = "lbl_sup_contactno";
            this.lbl_sup_contactno.Size = new System.Drawing.Size(88, 21);
            this.lbl_sup_contactno.TabIndex = 2;
            this.lbl_sup_contactno.Text = "Contact No";
            // 
            // lbl_sup_lino
            // 
            this.lbl_sup_lino.AutoSize = true;
            this.lbl_sup_lino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sup_lino.Location = new System.Drawing.Point(64, 305);
            this.lbl_sup_lino.Name = "lbl_sup_lino";
            this.lbl_sup_lino.Size = new System.Drawing.Size(86, 21);
            this.lbl_sup_lino.TabIndex = 3;
            this.lbl_sup_lino.Text = "Licence No";
            // 
            // lbl_sup_name
            // 
            this.lbl_sup_name.AutoSize = true;
            this.lbl_sup_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sup_name.Location = new System.Drawing.Point(64, 113);
            this.lbl_sup_name.Name = "lbl_sup_name";
            this.lbl_sup_name.Size = new System.Drawing.Size(132, 21);
            this.lbl_sup_name.TabIndex = 4;
            this.lbl_sup_name.Text = "Suppliers\'s Name";
            // 
            // txt_sup_name
            // 
            this.txt_sup_name.Location = new System.Drawing.Point(64, 143);
            this.txt_sup_name.Name = "txt_sup_name";
            this.txt_sup_name.Size = new System.Drawing.Size(340, 23);
            this.txt_sup_name.TabIndex = 5;
            // 
            // txt_sup_contactno
            // 
            this.txt_sup_contactno.Location = new System.Drawing.Point(64, 273);
            this.txt_sup_contactno.Name = "txt_sup_contactno";
            this.txt_sup_contactno.Size = new System.Drawing.Size(340, 23);
            this.txt_sup_contactno.TabIndex = 6;
            // 
            // txt_sup_lino
            // 
            this.txt_sup_lino.Location = new System.Drawing.Point(64, 339);
            this.txt_sup_lino.Name = "txt_sup_lino";
            this.txt_sup_lino.Size = new System.Drawing.Size(340, 23);
            this.txt_sup_lino.TabIndex = 7;
            // 
            // txt_sup_address
            // 
            this.txt_sup_address.Location = new System.Drawing.Point(64, 211);
            this.txt_sup_address.Name = "txt_sup_address";
            this.txt_sup_address.Size = new System.Drawing.Size(340, 23);
            this.txt_sup_address.TabIndex = 8;
            // 
            // dataGV_sup
            // 
            this.dataGV_sup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGV_sup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_sup.Location = new System.Drawing.Point(435, 113);
            this.dataGV_sup.Name = "dataGV_sup";
            this.dataGV_sup.RowTemplate.Height = 25;
            this.dataGV_sup.Size = new System.Drawing.Size(625, 459);
            this.dataGV_sup.TabIndex = 9;
            // 
            // btn_sup_add
            // 
            this.btn_sup_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_sup_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sup_add.ForeColor = System.Drawing.Color.White;
            this.btn_sup_add.Location = new System.Drawing.Point(64, 407);
            this.btn_sup_add.Name = "btn_sup_add";
            this.btn_sup_add.Size = new System.Drawing.Size(112, 35);
            this.btn_sup_add.TabIndex = 10;
            this.btn_sup_add.Text = "Add";
            this.btn_sup_add.UseVisualStyleBackColor = false;
            // 
            // btn_sup_delete
            // 
            this.btn_sup_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_sup_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sup_delete.ForeColor = System.Drawing.Color.White;
            this.btn_sup_delete.Location = new System.Drawing.Point(64, 537);
            this.btn_sup_delete.Name = "btn_sup_delete";
            this.btn_sup_delete.Size = new System.Drawing.Size(112, 35);
            this.btn_sup_delete.TabIndex = 11;
            this.btn_sup_delete.Text = "Delete";
            this.btn_sup_delete.UseVisualStyleBackColor = false;
            // 
            // btn_sup_update
            // 
            this.btn_sup_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_sup_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sup_update.ForeColor = System.Drawing.Color.White;
            this.btn_sup_update.Location = new System.Drawing.Point(64, 472);
            this.btn_sup_update.Name = "btn_sup_update";
            this.btn_sup_update.Size = new System.Drawing.Size(112, 35);
            this.btn_sup_update.TabIndex = 12;
            this.btn_sup_update.Text = "Update";
            this.btn_sup_update.UseVisualStyleBackColor = false;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 688);
            this.Controls.Add(this.btn_sup_update);
            this.Controls.Add(this.btn_sup_delete);
            this.Controls.Add(this.btn_sup_add);
            this.Controls.Add(this.dataGV_sup);
            this.Controls.Add(this.txt_sup_address);
            this.Controls.Add(this.txt_sup_lino);
            this.Controls.Add(this.txt_sup_contactno);
            this.Controls.Add(this.txt_sup_name);
            this.Controls.Add(this.lbl_sup_name);
            this.Controls.Add(this.lbl_sup_lino);
            this.Controls.Add(this.lbl_sup_contactno);
            this.Controls.Add(this.lbl_sup_address);
            this.Controls.Add(this.lbl_sup_supdetails);
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_sup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_sup_supdetails;
        private Label lbl_sup_address;
        private Label lbl_sup_contactno;
        private Label lbl_sup_lino;
        private Label lbl_sup_name;
        private TextBox txt_sup_name;
        private TextBox txt_sup_contactno;
        private TextBox txt_sup_lino;
        private TextBox txt_sup_address;
        private DataGridView dataGV_sup;
        private Button btn_sup_add;
        private Button btn_sup_delete;
        private Button btn_sup_update;
    }
}