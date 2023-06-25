using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using PharmacyManagementSystem.DataModels;
using PharmacyManagementSystem.Operationals;

namespace PharmacyManagementSystem
{
    public partial class Item_management : Form
    {
        UserContext ctx;
        Main paerntMain;
        String query;
        DataSet ds;
        int selectedItemId = -1;

        public Item_management(UserContext ctx, Main main)
        {
            InitializeComponent();
            this.ctx = ctx;
            this.paerntMain = main;
        }



        private void btn_Im_back_Click(object sender, EventArgs e)
        {
            paerntMain.Show();
            this.Close();
        }

        private void btn_Im_anb_Click(object sender, EventArgs e)
        {
            addBatch addB = new addBatch(ctx, 1, this);
            addB.Show();
            this.Hide();
        }

        private void Item_management_Load(object sender, EventArgs e)
        {
            lbl_Im_username.Text = ctx.getFullname();
            query = "select * from ITEMS";
            dataGridView1.DataSource = DBHelper.getData(query).Tables[0];
            btn_Im_edit.Hide();
            btn_Im_delete.Hide();
            if (ctx.getUserRole() != UserContext.Role.Administrator)
            {
                btn_Im_sd.Hide();
            }
        }

        private void btn_Im_ani_Click(object sender, EventArgs e)
        {
            Additem addI = new Additem(ctx, this);
            addI.Show();
            this.Hide();
        }

        public void refreshTable()
        {
            query = "select * from ITEMS";
            dataGridView1.DataSource = DBHelper.getData(query).Tables[0];
        }

        private void btn_Im_sd_Click(object sender, EventArgs e)
        {
            Suppliers sup = new Suppliers(ctx, this);
            sup.Show();
            this.Hide();
        }

        private void btn_Im_edit_Click(object sender, EventArgs e)
        {
            Additem item = new Additem(ctx,selectedItemId, this);
            item.Show();
            this.Hide();
            selectedItemId = -1;
        }
        private void DataGv_Im_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Im_delete.Show();
            btn_Im_edit.Show();
            selectedItemId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }


        private void btn_Im_delete_Click(object sender, EventArgs e)
        {
            try
            {
                query = "DELETE FROM batches WHERE itemId='" + selectedItemId + "';" +
                    " DELETE FROM items WHERE itemId='" + selectedItemId + "'";
                DBHelper.setData(query, "Removal Sucessful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Removal Unsuccessful." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            selectedItemId = -1;
            refreshTable();
        }
    }
}
