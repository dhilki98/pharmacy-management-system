using PharmacyManagementSystem.DataModels;
using PharmacyManagementSystem.Operationals;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace PharmacyManagementSystem
{
    public partial class changePW : Form
    {

        String query;
        DataSet ds;
        UserContext context;
        Main parentMain;

        public changePW(UserContext uc, Main main)
        {
            InitializeComponent();
            this.parentMain = main;
            this.context = uc;
        }

        private void saveResponse()
        {
            string newPW = BitConverter.ToString(SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(txt_cPW_passwd.Text)));
            string retypePW = BitConverter.ToString(SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(txt_cPW_retypepw.Text)));
            try
            {
                if (newPW == retypePW)
                {
                    query = "update USERS set " +
                        "password = '" + newPW + "' " +
                        "where userId = '" + context.getUserId() + "'";
                    DBHelper.setData(query, "Update Sucessful");
                }
                else
                {
                    MessageBox.Show("Values in two fields are not same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Unsucessful. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_cPW_passwd.Clear();
            txt_cPW_retypepw.Clear();
        }

        private void btn_cPW_change_Click(object sender, EventArgs e)
        {
            saveResponse();
        }

        private void btn_cPW_cancel_Click(object sender, EventArgs e)
        {
            parentMain.Show();
            this.Close();
        }

    }
}
