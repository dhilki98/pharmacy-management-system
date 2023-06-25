using System.Data;
using PharmacyManagementSystem.DataModels;
using PharmacyManagementSystem.Operationals;

namespace PharmacyManagementSystem
{
    public partial class Billing : Form
    {
        UserContext ctx;
        string query;
        DataSet ds;
        int selectedRowIndex = -1;

        public Billing(UserContext ctx)
        {
            InitializeComponent();
            this.ctx = ctx;
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            lbl_Bill_username.Text = ctx.getFullname();

            listBox_Bill.Items.Clear();
            query = "select itemName from ITEMS where availableQuantity > '0'";
            ds = DBHelper.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox_Bill.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btn_Bill_refreash_Click(object sender, EventArgs e)
        {
            Billing_Load(this, null);
        }

        private void txt_Bill_nou_TextChanged(object sender, EventArgs e)
        {
            if (txt_Bill_nou.Text != "")
            {
                double unitPrice = double.Parse(txt_Bill_ppu.Text);
                try
                {
                    int noOfUnit = int.Parse(txt_Bill_nou.Text);
                    double totalAmount = unitPrice * noOfUnit;
                    txt_Bill_tprice.Text = totalAmount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Number of Units must be an Integer.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                txt_Bill_tprice.Clear();
            }
        }

        private void refreshTable()
        {
            listBox_Bill.Items.Clear();
            query = "select itemName from ITEMS where availableQuantity > '0'";
            ds = DBHelper.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox_Bill.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btn_Bill_back_Click(object sender, EventArgs e)
        {
            Main mnB = new Main(ctx);
            mnB.Show();
            this.Hide();
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity, threshold;

        private void btn_Bill_atocart_Click(object sender, EventArgs e)
        {
            addToBill();
        }

        private void addToBill()
        {
            if (txt_Bill_id.Text != "" && txt_Bill_nou.Text != "")
            {
                query = "select availableQuantity,threshold from ITEMS where itemId = '" + txt_Bill_id.Text + "'";
                ds = DBHelper.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString() ?? "0");
                threshold = Int64.Parse(ds.Tables[0].Rows[0][1].ToString() ?? "100");
                newQuantity = quantity - Int64.Parse(txt_Bill_nou.Text);

                if (newQuantity >= 0)
                {
                    n = dataGV_Bill.Rows.Add();
                    dataGV_Bill.Rows[n].Cells[0].Value = txt_Bill_id.Text;
                    dataGV_Bill.Rows[n].Cells[1].Value = txt_Bill_name.Text;
                    dataGV_Bill.Rows[n].Cells[2].Value = txt_Bill_ppu.Text;
                    dataGV_Bill.Rows[n].Cells[3].Value = txt_Bill_nou.Text;
                    dataGV_Bill.Rows[n].Cells[4].Value = txt_Bill_tprice.Text;

                    totalAmount = totalAmount + int.Parse(txt_Bill_tprice.Text);
                    lbl_Bill_total.Text = "Rs. " + totalAmount.ToString();

                    query = "update ITEMS set availableQuantity = '" + newQuantity + "' where itemId = '" + txt_Bill_id.Text + "'";
                    DBHelper.setData(query, "Item Added");

                    if (newQuantity <= threshold)
                    {
                        MessageBox.Show("Only " + quantity + " Left.\n Threshold - " + threshold);
                    }
                }
                else
                {
                    MessageBox.Show("Item is Out of Stock.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                refreshTable();
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
                selectedRowIndex = e.RowIndex;
                valueAmount = int.Parse(dataGV_Bill.Rows[e.RowIndex].Cells[4].Value.ToString());
                valueID = dataGV_Bill.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = int.Parse(dataGV_Bill.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured.", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_Bill_remove_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {

                query = "select availableQuantity from ITEMS where itemId = '" + valueID + "'";
                ds = DBHelper.getData(query);
                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity + noOfunit;

                query = "update ITEMS set availableQuantity = '" + newQuantity + "' where itemId = '" + valueID + "'";
                DBHelper.setData(query, "Item removed from cart.");
                totalAmount = totalAmount - valueAmount;
                lbl_Bill_total.Text = "Rs. " + totalAmount.ToString();

                dataGV_Bill.Rows.RemoveAt(selectedRowIndex);
                selectedRowIndex = -1;
            }
        }

        private void txt_Bill_search_TextChanged(object sender, EventArgs e)
        {
            listBox_Bill.Items.Clear();
            query = "select itemName from ITEMS where itemName like '" + txt_Bill_search.Text + "%' and availableQuantity > '0'";
            ds = DBHelper.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox_Bill.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox_Bill_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Bill_nou.Clear();

            String name = listBox_Bill.GetItemText(listBox_Bill.SelectedItem);

            txt_Bill_name.Text = name;
            query = "select itemId from ITEMS where itemName = '" + name + "'";
            ds = DBHelper.getData(query);
            String id = ds.Tables[0].Rows[0][0].ToString();
            txt_Bill_id.Text = id;
            query = "select max(unitPrice) from BATCHES where itemId = '" + id + "'";
            ds = DBHelper.getData(query);
            txt_Bill_ppu.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void btn_Bill_print_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Item Bill - Unity Pharmacy";
            print.SubTitle = String.Format("Date: {0}\n\n Total Amount: {1}", DateTime.Now.ToString("MM/dd/yyyy"),lbl_Bill_total.Text);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.TitleSpacing = 30;
            print.SubTitleSpacing = 15;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.PrintDataGridView(dataGV_Bill);

            totalAmount = 0;
            lbl_Bill_total.Text = "Rs. 0.00";
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
