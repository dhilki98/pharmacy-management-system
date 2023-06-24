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
    public partial class Item_management : Form
    {
        UserContext ctx;
        Main paerntMain;
        String query;
        DataSet ds;

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
    }
}
