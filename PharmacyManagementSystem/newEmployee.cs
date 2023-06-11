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
    public partial class newEmployee : Form
    {
        function fn = new function();
        String query;

        public newEmployee()
        {
            InitializeComponent();
        }

        private void newEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btn_nE_add_Click(object sender, EventArgs e)
        {
            String role = cmbBox_nE_userrole.Text;
            String name = txt_nE_name.Text;
            String nic = txt_nE_nic.Text;
            Int64 mobile = Int64.Parse(txt_nE_mobileno.Text);
            String email = txt_nE_eaddress.Text;
            String phamlicense = txt_nE_pln.Text;
            String username = txt_nE_username.Text;
            String password = txt_nE_password.Text;

            try
            {
                query = "";
            }
            catch (Exception)
            {
                MessageBox.Show("User Allready Exist.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
