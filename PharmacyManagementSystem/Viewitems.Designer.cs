namespace PharmacyManagementSystem
{
    partial class Viewitems
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clm_Vi_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Vi_itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Vi_itemno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Vi_md = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Vi_ed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Vi_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Vi_ppu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Vi_id,
            this.clm_Vi_itemname,
            this.clm_Vi_itemno,
            this.clm_Vi_md,
            this.clm_Vi_ed,
            this.clm_Vi_quantity,
            this.clm_Vi_ppu});
            this.dataGridView1.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(26, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(811, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // clm_Vi_id
            // 
            this.clm_Vi_id.HeaderText = "Item ID";
            this.clm_Vi_id.Name = "clm_Vi_id";
            // 
            // clm_Vi_itemname
            // 
            this.clm_Vi_itemname.HeaderText = "Item Name";
            this.clm_Vi_itemname.Name = "clm_Vi_itemname";
            // 
            // clm_Vi_itemno
            // 
            this.clm_Vi_itemno.HeaderText = "Item No";
            this.clm_Vi_itemno.Name = "clm_Vi_itemno";
            // 
            // clm_Vi_md
            // 
            this.clm_Vi_md.HeaderText = "Manufacturing Date";
            this.clm_Vi_md.Name = "clm_Vi_md";
            // 
            // clm_Vi_ed
            // 
            this.clm_Vi_ed.HeaderText = "Expire Date";
            this.clm_Vi_ed.Name = "clm_Vi_ed";
            // 
            // clm_Vi_quantity
            // 
            this.clm_Vi_quantity.HeaderText = "Quantity";
            this.clm_Vi_quantity.Name = "clm_Vi_quantity";
            // 
            // clm_Vi_ppu
            // 
            this.clm_Vi_ppu.HeaderText = "Price Per Unit";
            this.clm_Vi_ppu.Name = "clm_Vi_ppu";
            // 
            // Viewitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 688);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Viewitems";
            this.Text = "Viewitems";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clm_Vi_id;
        private DataGridViewTextBoxColumn clm_Vi_itemname;
        private DataGridViewTextBoxColumn clm_Vi_itemno;
        private DataGridViewTextBoxColumn clm_Vi_md;
        private DataGridViewTextBoxColumn clm_Vi_ed;
        private DataGridViewTextBoxColumn clm_Vi_quantity;
        private DataGridViewTextBoxColumn clm_Vi_ppu;
    }
}