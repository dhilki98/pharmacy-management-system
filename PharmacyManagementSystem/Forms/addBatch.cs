using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagementSystem.DataModels;
using PharmacyManagementSystem.Operationals;

namespace PharmacyManagementSystem
{
    public partial class addBatch : Form
    {
        String query;
        DataSet ds;
        UserContext context;
        Item_management parentItemManage;
        int itemId;
        int selectedBatchId = 0;
        bool isEditing = false;

        public addBatch(UserContext uc, int itemId, Item_management im)
        {
            InitializeComponent();
            this.parentItemManage = im;
            this.context = uc;
            this.itemId = itemId;
        }

        private void addBatch_Load(object sender, EventArgs e)
        {
            dateTP_aB_expiredate.Format = DateTimePickerFormat.Custom;
            dateTP_aB_expiredate.CustomFormat = "MM/dd/yyyy";
            query = "select * from BATCHES where itemId = '" + itemId + "'";
            dataGridView1.DataSource = DBHelper.getData(query).Tables[0];
            dateTP_aB_expiredate.MinDate = DateTime.Now;
            btn_aB_remove.Hide();
            if(isEditing)
            {
                lbl_aB_quantity.Hide();
                txt_aB_quantity.Hide();
            }
        }

        private void saveResponse()
        {
            String itemID = txt_aB_iid.Text;
            String supplierID = txt_aB_sid.Text;
            String expireDate = dateTP_aB_expiredate.Value.Date.ToString("MM/dd/yyyy");
            String unitPrice = txt_aB_unitprice.Text;
            String quantity = txt_aB_quantity.Text;
            try
            {
                if (isEditing == false)
                {
                    query = "insert into BATCHES (itemId, supId, unitPrice, expireDate, quantity) values ('" + itemID + "', '" + supplierID + "', '" + unitPrice + "', '" + expireDate + "', '" + quantity + "');"
                        + "update ITEMS set availableQuantity = availableQuantity + '"+ quantity +"' where itemId = '"+itemID+"'";

                    DBHelper.setData(query, "Add Sucessful.");
                }
                else
                {
                    query = "update BATCHES set " +
                        "itemId = '" + itemID + "', " +
                        "supId = '" + supplierID + "', " +
                        "unitPrice = '" + unitPrice + "', " +
                        "expireDate = '" + expireDate + "' " +
                        "where batchId = '" + selectedBatchId + "'";
                    DBHelper.setData(query, "Update Sucessful");
                    isEditing = false; ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Unsucessful. "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void refreshTable()
        {
            query = "select * from BATCHES where itemId = '" + itemId + "'";
            dataGridView1.DataSource = DBHelper.getData(query).Tables[0];
            isEditing = false;
            btn_aB_add.Text = "Add";
            btn_aB_reset.Text = "Reset";
            btn_aB_remove.Hide();

        }

        private void loadEditingDetails()
        {
            isEditing = true;
            query = "select * from Batches where batchId='" + selectedBatchId + "'";
            DataSet ds = DBHelper.getData(query);
            txt_aB_iid.Text = ds.Tables[0].Rows[0][1].ToString();
            txt_aB_sid.Text = ds.Tables[0].Rows[0][2].ToString();
            txt_aB_unitprice.Text = ds.Tables[0].Rows[0][3].ToString();
            txt_aB_quantity.Text = ds.Tables[0].Rows[0][4].ToString();
            dateTP_aB_expiredate.Value = DateTime.Parse(ds.Tables[0].Rows[0][5].ToString());
            btn_aB_add.Text = "Update";
            btn_aB_reset.Text = "Cancel";
        }

        private void btn_aB_add_Click(object sender, EventArgs e)
        {
            saveResponse();
            refreshTable();
        }

        public void clearAll()
        {
            txt_aB_iid.Clear();
            txt_aB_quantity.Clear();
            txt_aB_sid.Clear();
            txt_aB_unitprice.Clear();
        }

        private void btn_aB_reset_Click(object sender, EventArgs e)
        {
            clearAll();
            if (isEditing == true)
            {
                isEditing = false;
                btn_aB_add.Text = "Add";
                btn_aB_reset.Text = "Reset";
                btn_aB_remove.Hide();
            }
        }

        private void btn_aB_back_Click(object sender, EventArgs e)
        {
            parentItemManage.refreshTable();
            parentItemManage.Show();
            this.Close();
        }

        private void dataGV_aB_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btn_aB_remove.Show();
            selectedBatchId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            loadEditingDetails();

        }

        private void removeBatch(int batchId)
        {
            try
            {
                query = "DELETE FROM BATCHERS WHERE batchId='" + batchId + "'";
                DBHelper.setData(query, "Removal Sucessful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Batch Removal Unsuccessful. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_aB_delete_Click(object sender, EventArgs e)
        {
            removeBatch(selectedBatchId);
            selectedBatchId = 0;
            refreshTable();
        }
    }
}
