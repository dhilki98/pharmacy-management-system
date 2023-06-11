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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_Main_administration_Click(object sender, EventArgs e)
        {
            Administrator adm = new Administrator();
            adm.Show();
            this.Hide();
        }

        private void btn_Main_billing_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing();
            bill.Show();
            this.Hide();
        }

        private void btn_Main_im_Click(object sender, EventArgs e)
        {
            Item_management im = new Item_management();
            im.Show();
            this.Hide();
        }
    }
}
