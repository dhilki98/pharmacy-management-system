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
            String mobile = txt_nE_mobileno.Text;
            String email = txt_nE_eaddress.Text;
            String phamlicense = txt_nE_pln.Text;
            String username = txt_nE_username.Text;
            String password = txt_nE_password.Text;

            try
            {
                query = "insert into users (fullName,userName,password,nic,userRole,email,contactNo,pharmLicense) values ('"+name+"','"+username+"','"+password+"','"+nic+"','"+role+"','"+email+"','"+mobile+"','"+phamlicense+"')";
                DBHelper.setData(query, "Add Sucessful.");
            }
            catch (Exception)
            {
                MessageBox.Show("User Allready Exist.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_nE_reset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txt_nE_eaddress.Clear();
            txt_nE_mobileno.Clear();
            txt_nE_name.Clear();
            txt_nE_nic.Clear();
            txt_nE_password.Clear();
            txt_nE_pln.Clear();
            txt_nE_username.Clear();
            txt_nE_search.Clear();
            cmbBox_nE_userrole.SelectedIndex = -1;
        }

        private void txt_nE_username_TextChanged(object sender, EventArgs e)
        {
            query = "select * from USERS where userName='"+txt_nE_username.Text+"'";
            DataSet ds = DBHelper.getData(query);

            if(ds.Tables[0].Rows.Count == 0)
            {
                pctBox_nE_username.ImageLocation = @"L:\\BIT\\L1S2\\6. project\\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pctBox_nE_username.ImageLocation = @"L:\BIT\L1S2\6. project\Pharmacy Management System in C#\no.png";
            }
        }
    }
}
