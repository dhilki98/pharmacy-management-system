
using System.Data;

namespace PharmacyManagementSystem
{
    public partial class Main : Form
    {
        UserContext ctx;
        String query;
        DataSet ds;
        
        public Main(UserContext context)
        {
            InitializeComponent();
            ctx = context;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_Main_username.Text = ctx.getUsername();
            populateStats();
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

        private void populateStats()
        {
            query = "select count(userRole) from USERS where userRole = 'Administrator'";
            ds = DBHelper.getData(query);
            setLabel(ds, lbl_Main_noa);

            query = "select count(userRole) from USERS where userRole = 'Pharmacist'";
            ds = DBHelper.getData(query);
            setLabel(ds, lbl_Main_nop);
        }

        private void btn_Main_administration_Click(object sender, EventArgs e)
        {
            Administrator adm = new Administrator(ctx);
            adm.Show();
            this.Hide();
        }

        private void btn_Main_billing_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing();
            bill.Show();
            this.Hide();
        }

        private void btn_Main_im_Click(object sender, EventArgs e)
        {
            Item_management im = new Item_management();
            im.Show();
            this.Hide();
        }

        private void btn_Main_refresh_Click(object sender, EventArgs e)
        {
            Main_Load(this, null);
            
        }
    }
}
