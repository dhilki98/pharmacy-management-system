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
    public partial class Login : Form
    {
        String query;
        DataSet ds;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_clear_Click(object sender, EventArgs e)
        {
            txt_Login_password.Clear(); 
            txt_Login_username.Clear();
        }

        private void btn_Login_signin_Click(object sender, EventArgs e)
        {
            query = "select * from USERS";
            ds = DBHelper.getData(query);
            if(ds.Tables[0].Rows.Count == 0)
            {
                if(txt_Login_username.Text=="root" && txt_Login_password.Text == "root")
                {
                    Main mn = new Main();
                    mn.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from USERS where userName = '" + txt_Login_username.Text + "' and password='" + txt_Login_password.Text + "'";
                ds = DBHelper.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    Main mn = new Main(txt_Login_username.Text);
                    mn.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
