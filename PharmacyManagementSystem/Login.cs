using System.Data;

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
                    Main mn = new Main(new UserContext("Root User", UserContext.Role.Administrator));
                    mn.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from USERS where userName = '" + txt_Login_username.Text + "' and password='" + txt_Login_password.Text + "'";
                ds = DBHelper.getData(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    String role = ds.Tables[0].Rows[0][5].ToString();
                    if (role == "Administrator")
                    {
                        Main mn = new Main(new UserContext(txt_Login_username.Text, UserContext.Role.Administrator));
                        mn.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacist")
                    {
                        Main mn = new Main(new UserContext(txt_Login_username.Text, UserContext.Role.Pharmacist));
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
