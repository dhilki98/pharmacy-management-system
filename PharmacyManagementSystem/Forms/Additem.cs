using PharmacyManagementSystem.DataModels;
using PharmacyManagementSystem.Operationals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Additem : Form
    {

        String query;
        DataSet ds;
        UserContext context;
        Item_management parentItemManage;
        int itemId = 0;

        public Additem(UserContext uc, int itemId, Item_management im)
        {
            InitializeComponent();
            this.parentItemManage = im;
            this.context = uc;
            this.itemId = itemId;
        }

        public Additem(UserContext uc, Item_management im)
        {
            InitializeComponent();
            this.parentItemManage = im;
            this.context = uc;
        }

        private void saveResponse()
        {
            String itemName = txt_Ai_itemname.Text;
            String medName = txt_Ai_mname.Text;
            String threshold = txt_Ai_threshold.Text;
            try
            {
                if (itemId == 0)
                {
                    query = "insert into ITEMS (itemName, medicalName, threshold, availableQuantity) values ('" + itemName + "', '" + medName + "', '" + threshold + "', '0')";
                    DBHelper.setData(query, "Add Sucessful.");
                }
                else if (itemId > 0)
                {
                    query = "update ITEMS set " +
                        "itemName = '" + itemName + "', " +
                        "medicalName = '" + medName + "', " +
                        "threshold = '" + threshold + "' " +
                        "where itemId = '" + itemId + "'";
                    DBHelper.setData(query, "Update Sucessful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Unsucessful. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loadEditingDetails()
        {
            query = "select itemName, medicalName, threshold from Items where ItemId='" + itemId + "'";
            DataSet ds = DBHelper.getData(query);
            txt_Ai_itemname.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_Ai_mname.Text = ds.Tables[0].Rows[0][1].ToString();
            txt_Ai_threshold.Text = ds.Tables[0].Rows[0][2].ToString();
            btn_Ai_add.Text = "Update";
            btn_Ai_reset.Text = "Cancel";
        }

        private void btn_aB_add_Click(object sender, EventArgs e)
        {
            saveResponse();
        }

        public void clearAll()
        {
            txt_Ai_itemname.Clear();
            txt_Ai_mname.Clear();
            txt_Ai_threshold.Clear();
        }

        private void btn_Ai_add_Click(object sender, EventArgs e)
        {
            saveResponse();
        }

        private void btn_Ai_reset_Click(object sender, EventArgs e)
        {
            clearAll();
            itemId = 0;
            btn_Ai_add.Text = "Add";
            btn_Ai_reset.Text = "Reset";
        }

        private void btn_Ai_back_Click(object sender, EventArgs e)
        {
            parentItemManage.refreshTable();
            parentItemManage.Show();
            this.Close();
        }

        private void Additem_Load(object sender, EventArgs e)
        {
            if (itemId != 0)
            {
                loadEditingDetails();
            }
        }
    }
}
