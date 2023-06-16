using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace PharmacyManagementSystem
{
    public partial class Billing : Form
    {
        UserContext ctx;
        public Billing(UserContext ctx)
        {
            InitializeComponent();
            this.ctx = ctx;
        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void txt_Bill_nou_TextChanged(object sender, EventArgs e)
        {
            if (txt_Bill_nou.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txt_Bill_nou.Text);
                Int64 noOfUnit = Int64.Parse(txt_Bill_nou.Text);
                Int64 totalAmount = unitPrice * noOfUnit;
                txt_Bill_tprice.Text = totalAmount.ToString();
            }
            else
            {
                txt_Bill_tprice.Clear();
            }
        }



        private void btn_Bill_back_Click(object sender, EventArgs e)
        {
            Main mnB = new Main(ctx);
            mnB.Show();
            this.Hide();
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;



        private void btn_Bill_atocart_Click(object sender, EventArgs e)
        {
            if (txt_Bill_id.Text != "")
            {
                if (newQuantity >= 0)
                {
                    if (newQuantity > 100)
                    {
                        n = dataGV_Bill.Rows.Add();
                        dataGV_Bill.Rows[n].Cells[0].Value = txt_Bill_id.Text;
                        dataGV_Bill.Rows[n].Cells[1].Value = txt_Bill_name.Text;
                        dataGV_Bill.Rows[n].Cells[2].Value = txt_Bill_ppu.Text;
                        dataGV_Bill.Rows[n].Cells[3].Value = txt_Bill_nou.Text;
                        dataGV_Bill.Rows[n].Cells[4].Value = txt_Bill_tprice.Text;

                        totalAmount = totalAmount + int.Parse(txt_Bill_tprice.Text);
                        lbl_Bill_total.Text = "Rs. " + totalAmount.ToString();
                    }
                    else
                    {
                        n = dataGV_Bill.Rows.Add();
                        dataGV_Bill.Rows[n].Cells[0].Value = txt_Bill_id.Text;
                        dataGV_Bill.Rows[n].Cells[1].Value = txt_Bill_name.Text;
                        dataGV_Bill.Rows[n].Cells[2].Value = txt_Bill_ppu.Text;
                        dataGV_Bill.Rows[n].Cells[3].Value = txt_Bill_nou.Text;
                        dataGV_Bill.Rows[n].Cells[4].Value = txt_Bill_tprice.Text;

                        totalAmount = totalAmount + int.Parse(txt_Bill_tprice.Text);
                        lbl_Bill_total.Text = "Rs. " + totalAmount.ToString();

                        MessageBox.Show("Only " + quantity + " Left.\n Make a Purchase");
                    }
                }
                else
                {
                    MessageBox.Show("Item is Out of Stock.", "Warning");
                }
                clearAll();
            }
            else
            {
                MessageBox.Show("Select Item First.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        int valueAmount;
        String valueID;
        protected Int64 noOfunit;



        private void dataGV_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(dataGV_Bill.Rows[e.RowIndex].Cells[4].Value.ToString());
                valueID = dataGV_Bill.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(dataGV_Bill.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception)
            {

            }
        }



        private void btn_Bill_remove_Click(object sender, EventArgs e)
        {
            if (valueID != null)
            {
                try
                {
                    dataGV_Bill.Rows.RemoveAt(this.dataGV_Bill.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {

                }
            }
        }

        private void btn_Bill_print_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Item Bill - Unity Pharmacy";
            print.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount : " + lbl_Bill_total.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGV_Bill);

            totalAmount = 0;
            lbl_Bill_total.Text = "Rs. 00";
            dataGV_Bill.DataSource = 0;
        }

        private void clearAll()
        {
            txt_Bill_id.Clear();
            txt_Bill_name.Clear();
            txt_Bill_nou.Clear();
            txt_Bill_ppu.Clear();
        }
    }
}
