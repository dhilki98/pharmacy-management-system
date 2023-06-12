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
        function fn = new function();
        String query;
        DataSet ds;

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

        private void Main_Load(object sender, EventArgs e)
        {
            query="select count(userRole) from USERS where userRole = 'Administrator'";
            ds = fn.getData(query);
            setLabel(ds, lbl_Main_noa);

            query = "select count(userRole) from USERS where userRole = 'Pharmacist'";
            ds = fn.getData(query);
            setLabel(ds, lbl_Main_nop);
        }

        private void setLabel(DataSet ds,Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text =ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void btn_Main_refresh_Click(object sender, EventArgs e)
        {
            Main_Load(this, null);
        }
    }
}
