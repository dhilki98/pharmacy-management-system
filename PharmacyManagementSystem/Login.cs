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
            if (txt_Login_password.Text == "111" && txt_Login_username.Text == "Dhilki")
            {
                Main mn = new Main();
                mn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show ("Invalid Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
