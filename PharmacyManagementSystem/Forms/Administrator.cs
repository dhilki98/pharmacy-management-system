using System.Data;
using PharmacyManagementSystem.DataModels;
using PharmacyManagementSystem.Operationals;

namespace PharmacyManagementSystem
{
    public partial class Administrator : Form
    {
        UserContext ctx;
        Main parentMain;
        String query;
        DataSet ds;
        int selectedUserId = 0;

        public Administrator(UserContext ctx, Main main)
        {
            InitializeComponent();
            this.ctx = ctx;
            this.parentMain = main;
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            lbl_Adm_username.Text = ctx.getFullname();
            query = "select * from USERS";
            dataGV_Uv.DataSource = DBHelper.getData(query).Tables[0];
            btn_Adm_reset.Hide();
            btn_Adm_edit.Hide();
            btn_Adm_delete.Hide();
        }

        public void refreshTable()
        {
            query = "select * from USERS";
            dataGV_Uv.DataSource = DBHelper.getData(query).Tables[0];
        }

        private void removeUser(int userId)
        {
            try
            {
                query = "DELETE FROM users WHERE UserId='" + userId + "'";
                DBHelper.setData(query, "Removal Sucessful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Removal Unsuccessful." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Adm_adduser_Click(object sender, EventArgs e)
        {
            newEmployee newEmplo = new newEmployee(this);
            newEmplo.Show();
            this.Hide();
        }

        private void btn_Adm_back_Click(object sender, EventArgs e)
        {
            parentMain.Show();
            this.Close();
        }

        private void btn_Adm_search_Click(object sender, EventArgs e)
        {
            query = "select * from USERS where userName like '" + txt_Adm_search.Text + "%'";
            dataGV_Uv.DataSource = DBHelper.getData(query).Tables[0];
            btn_Adm_reset.Show();
        }

        private void btn_Adm_reset_Click(object sender, EventArgs e)
        {
            refreshTable();
            txt_Adm_search.Text = "";
            btn_Adm_reset.Hide();
        }

        private void DataGv_Uv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Adm_delete.Show();
            btn_Adm_edit.Show();
            selectedUserId = Convert.ToInt32(dataGV_Uv.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btn_Adm_edit_Click(object sender, EventArgs e)
        {
            newEmployee newEmplo = new newEmployee(selectedUserId, this);
            newEmplo.Show();
            this.Hide();
            selectedUserId = 0;
        }

        private void btn_Adm_delete_Click(object sender, EventArgs e)
        {
            removeUser(selectedUserId);
            selectedUserId = 0;
            refreshTable();
        }

        private void btn_Adm_spplier_Click(object sender, EventArgs e)
        {
            Suppliers sup = new Suppliers ();
            sup.Show();
            this.Hide();
        }
    }
}
