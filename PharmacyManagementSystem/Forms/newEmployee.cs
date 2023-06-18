using System.Data;
using PharmacyManagementSystem.Operationals;

namespace PharmacyManagementSystem
{
    public partial class newEmployee : Form
    {
        string query;
        Administrator parentAdministrator;
        int editingUserId = 0;

        public newEmployee(Administrator admin)
        {
            InitializeComponent();
            this.parentAdministrator = admin;
        }

        public newEmployee(int userID, Administrator admin)
        {
            InitializeComponent();
            this.editingUserId = userID;
            this.parentAdministrator = admin;
        }

        private void newEmployee_Load(object sender, EventArgs e)
        {
            pctBox_nE_username_no.Hide();
            pctBox_nE_username_yes.Hide();

            if (editingUserId > 0)
            {
                query = "select * from USERS where userId='" + editingUserId + "'";
                DataSet ds = DBHelper.getData(query);
                cmbBox_nE_userrole.SelectedIndex = ds.Tables[0].Rows[0][5].ToString() == "Administrator" ? 0 : 1;
                txt_nE_name.Text = ds.Tables[0].Rows[0][1].ToString();
                txt_nE_nic.Text = ds.Tables[0].Rows[0][4].ToString();
                txt_nE_mobileno.Text = ds.Tables[0].Rows[0][7].ToString();
                txt_nE_eaddress.Text = ds.Tables[0].Rows[0][6].ToString();
                txt_nE_pln.Text = ds.Tables[0].Rows[0][8].ToString();
                txt_nE_username.Hide();
                txt_nE_password.Hide();
                lbl_nE_username.Hide();
                lbl_nE_password.Hide();
                btn_nE_reset.Hide();
                btn_nE_add.Text = "Update";
            }
            else
            {
                btn_nE_add.Text = "Add";
            }
        }

        private void btn_nE_add_Click(object sender, EventArgs e)
        {
            saveResponse();
        }

        private void btn_nE_reset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btn_nE_cancel_Click(object sender, EventArgs e)
        {
            parentAdministrator.Show();
            parentAdministrator.refreshTable();
            this.Close();
        }
        private void txt_nE_username_TextChanged(object sender, EventArgs e)
        {
            validateUsername(txt_nE_username.Text);
        }


        private void clearAll()
        {
            txt_nE_eaddress.Clear();
            txt_nE_mobileno.Clear();
            txt_nE_name.Clear();
            txt_nE_nic.Clear();
            txt_nE_password.Clear();
            txt_nE_pln.Clear();
            txt_nE_username.Clear();
            pctBox_nE_username_no.Hide();
            pctBox_nE_username_yes.Hide();
            cmbBox_nE_userrole.SelectedIndex = -1;
        }

        private void validateUsername(string uname)
        {
            query = "select * from USERS where userName='" + uname + "'";
            DataSet ds = DBHelper.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pctBox_nE_username_no.Hide();
                pctBox_nE_username_yes.Show();
            }
            else
            {
                pctBox_nE_username_yes.Hide();
                pctBox_nE_username_no.Show();
            }
        }

        private void saveResponse()
        {
            string role = cmbBox_nE_userrole.Text;
            string name = txt_nE_name.Text;
            string nic = txt_nE_nic.Text;
            string mobile = txt_nE_mobileno.Text;
            string email = txt_nE_eaddress.Text;
            string phamlicense = txt_nE_pln.Text;
            string username = txt_nE_username.Text;
            string password = txt_nE_password.Text;

            try
            {
                if (editingUserId == 0)
                {
                    query = "insert into users (fullName,userName,password,nic,userRole,email,contactNo,pharmLicense) values ('" + name + "','" + username + "','" + password + "','" + nic + "','" + role + "','" + email + "','" + mobile + "','" + phamlicense + "')";
                    DBHelper.setData(query, "Add Sucessful");
                }
                else if (editingUserId > 0)
                {
                    query = "update users set " +
                        "fullName='" + name + "', " +
                        "nic='" + nic + "', " +
                        "userRole='" + role + "', " +
                        "email='" + email + "', " +
                        "contactNo='" + mobile + "', " +
                        "pharmLicense='" + phamlicense + "' " +
                        "where userId='" + editingUserId + "'";
                    DBHelper.setData(query, "Update Sucessful");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("User Allready Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
