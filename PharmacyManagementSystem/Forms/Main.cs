
using System.Data;
using PharmacyManagementSystem.DataModels;
using PharmacyManagementSystem.Operationals;

namespace PharmacyManagementSystem
{
    public partial class Main : Form
    {
        UserContext ctx;
        String query;
        DataSet ds;

        public Main(UserContext ctx)
        {
            InitializeComponent();
            this.ctx = ctx;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_Main_username.Text = ctx.getFullname();
            populateStats();
            if (ctx.getUserRole() == UserContext.Role.Pharmacist)
            {
                btn_Main_administration.Hide();
            }
            else if (ctx.getUserRole() == UserContext.Role.Administrator)
            {
                btn_Main_administration.Show();
            }
        }

        private void populateStats()
        {
            query = "select count(userRole) from USERS where userRole = 'Administrator'";
            ds = DBHelper.getData(query);
            setLabel(ds, lbl_Main_noa);

            query = "select count(userRole) from USERS where userRole = 'Pharmacist'";
            ds = DBHelper.getData(query);
            setLabel(ds, lbl_Main_nop);
        }

        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void btn_Main_administration_Click(object sender, EventArgs e)
        {
            Administrator adm = new Administrator(ctx, this);
            adm.Show();
            this.Hide();
        }

        private void btn_Main_billing_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing(ctx);
            bill.Show();
            this.Hide();
        }

        private void btn_Main_im_Click(object sender, EventArgs e)
        {
            Item_management im = new Item_management(ctx);
            im.Show();
            this.Hide();
        }

        private void btn_Main_refresh_Click(object sender, EventArgs e)
        {
            Main_Load(this, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
