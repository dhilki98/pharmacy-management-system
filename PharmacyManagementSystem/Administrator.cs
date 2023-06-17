using System.Data;

namespace PharmacyManagementSystem
{
    public partial class Administrator : Form
    {
        UserContext ctx;
        String query;
        DataSet ds;

        public Administrator(UserContext ctx)
        {
            InitializeComponent();
            this.ctx = ctx;
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            lbl_Adm_username.Text = ctx.getFullname();
            query = "select * from USERS";
            dataGV_Uv.DataSource = DBHelper.getData(query).Tables[0];
            btn_Adm_reset.Hide();
        }

        private void refreshTable()
        {
            query = "select * from USERS";
            dataGV_Uv.DataSource = DBHelper.getData(query).Tables[0];
        }
        
        private void btn_Adm_adduser_Click(object sender, EventArgs e)
        {
            newEmployee newEmplo = new newEmployee();
            newEmplo.Show();
            this.Hide();
        }

        private void btn_Adm_back_Click(object sender, EventArgs e)
        {
            Main mnA = new Main(ctx);
            mnA.Show();
            this.Hide();
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
    }
}
