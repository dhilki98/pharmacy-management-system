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
        public Item_management(UserContext ctx)
        {
            InitializeComponent();
            this.ctx = ctx;
        }

        private void btn_Im_back_Click(object sender, EventArgs e)
        {
            Main mnI = new Main(ctx);
            mnI.Show();
            this.Hide();
        }

        private void btn_Im_anb_Click(object sender, EventArgs e)
        {
            addBatch addB = new addBatch();
            addB.Show();
            this.Hide();
        }

        private void Item_management_Load(object sender, EventArgs e)
        {

        }
    }
}
