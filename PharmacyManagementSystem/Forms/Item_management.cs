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

namespace PharmacyManagementSystem
{
    public partial class Item_management : Form
    {
        UserContext ctx;
        Main paerntMain;
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
            addBatch addB = new addBatch(ctx,1,this);
            addB.Show();
            this.Hide();
        }

        private void Item_management_Load(object sender, EventArgs e)
        {

        }
    }
}
