using System.Data;
using System.Security.Cryptography;
using System.Text;
using PharmacyManagementSystem.DataModels;
using PharmacyManagementSystem.Operationals;

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

        private void authenticateTheUser()
        {
            query = "select * from USERS";
            ds = DBHelper.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txt_Login_username.Text == "root" && txt_Login_password.Text == "root")
                {
                    Main mn = new Main(new UserContext("Root User", UserContext.Role.Administrator, "Default Root User", 0));
                    mn.Show();
                    this.Hide();
                }
            }
            else
            {
                string pw = BitConverter.ToString(SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(txt_Login_password.Text)));
                query = "select * from USERS where userName = '" + txt_Login_username.Text + "' and password='" + pw + "'";
                ds = DBHelper.getData(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    string username = txt_Login_username.Text;
                    string role = ds.Tables[0].Rows[0][5].ToString() ?? "Pharmacist";
                    string fullname = ds.Tables[0].Rows[0][1].ToString() ?? username;
                    int userId = int.Parse(ds.Tables[0].Rows[0][0].ToString() ?? "0");
                    if (role == "Administrator")
                    {
                        Main mn = new Main(new UserContext(username, UserContext.Role.Administrator, fullname, userId));
                        mn.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacist")
                    {
                        Main mn = new Main(new UserContext(username, UserContext.Role.Pharmacist, fullname, userId));
                        mn.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Login_clear_Click(object sender, EventArgs e)
        {
            txt_Login_password.Clear();
            txt_Login_username.Clear();
        }

        private void btn_Login_signin_Click(object sender, EventArgs e)
        {
            authenticateTheUser();
        }
    }
}
