namespace PharmacyManagementSystem
{
    partial class ViewBatch
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
            this.dataGV_vBatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_vBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_vBatch
            // 
            this.dataGV_vBatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGV_vBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_vBatch.Location = new System.Drawing.Point(46, 34);
            this.dataGV_vBatch.Name = "dataGV_vBatch";
            this.dataGV_vBatch.RowTemplate.Height = 25;
            this.dataGV_vBatch.Size = new System.Drawing.Size(1014, 202);
            this.dataGV_vBatch.TabIndex = 0;
            // 
            // ViewBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 688);
            this.Controls.Add(this.dataGV_vBatch);
            this.Name = "ViewBatch";
            this.Text = "ViewBatch";
            this.Load += new System.EventHandler(this.ViewBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_vBatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGV_vBatch;
    }
}