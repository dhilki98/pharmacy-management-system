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
    public partial class changePW : Form
    {

        String query;
        DataSet ds;
        UserContext context;
        Item_management parentItemManage;
        int itemId = 0;

        public changePW(UserContext uc, int itemId, Item_management im)
        {
            InitializeComponent();
            this.parentItemManage = im;
            this.context = uc;
            this.itemId = itemId;
        }

        public changePW(UserContext uc, Item_management im)
        {
            InitializeComponent();
            this.parentItemManage = im;
            this.context = uc;
        }

        private void Additem_Load(object sender, EventArgs e)
        {

        }

        private void saveResponse()
        {
            String itemName = txt_cPW_username.Text;
            String medName = txt_cPW_passwd.Text;
            String threshold = txt_cPW_retypepw.Text;
            try
            {
                if (itemId == 0)
                {
                    query = "insert into ITEMS (itemName, medicalName, threshold) values ('" + itemName + "', '" + medName + "', '" + threshold + "')";
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
            query = "select * from Items where ItemId='" + itemId + "'";
            DataSet ds = DBHelper.getData(query);
            txt_cPW_username.Text = ds.Tables[0].Rows[0][1].ToString();
            txt_cPW_passwd.Text = ds.Tables[0].Rows[0][2].ToString();
            txt_cPW_retypepw.Text = ds.Tables[0].Rows[0][3].ToString();
            btn_Ai_add.Text = "Update";
            btn_Ai_reset.Text = "Cancel";
        }

        private void btn_aB_add_Click(object sender, EventArgs e)
        {
            saveResponse();
        }

        public void clearAll()
        {
            txt_cPW_username.Clear();
            txt_cPW_passwd.Clear();
            txt_cPW_retypepw.Clear();
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
            parentItemManage.Show();
            this.Close();
        }

    }
}
