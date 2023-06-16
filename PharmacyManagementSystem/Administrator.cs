using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Administrator : Form
    {
        UserContext ctx;
        String query;
        DataSet ds;
        String user = "";

        public Administrator(UserContext ctx)
        {
            InitializeComponent();
            this.ctx = ctx;
        }

        public string ID
        {
            get { return user.ToString(); }
        }

        public Administrator(String username)
        {
            InitializeComponent();
            lbl_Adm_username.Text = username;
            user = username;
            //Viewuser.ID = ID; look this error
        }

        public void loadform(object Form)
        {
            if (this.pnl_Adm_right.Controls.Count > 0)
                this.pnl_Adm_right.Controls.RemoveAt(0);
            Form f = new Form();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnl_Adm_right.Controls.Add(f);
            this.pnl_Adm_right.Tag = f;
            f.Show();
        }
        private void Administrator_Load(object sender, EventArgs e)
        {
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM USERS", "server = DESKTOP-F7UFU4N; database = PharmacyDB; ");
            //DataSet ds = new DataSet();
            //da.Fill(ds, "ÛSERS");
            //dataGV_Adm.DataSource = ds.Tables["USERS"].DefaultView;
        }

       

        private void btn_Adm_adduser_Click(object sender, EventArgs e)
        {
            loadform(new newEmployee());
           /* newEmployee newEmplo = new newEmployee();
            newEmplo.Show();
            this.Hide();*/
        }

        private void btn_Adm_back_Click(object sender, EventArgs e)
        {
            Main mnA = new Main(ctx);
            mnA.Show();
            this.Hide();
        }

        private void btn_Adm_viewusers_Click(object sender, EventArgs e)
        {
            loadform(new Viewuser());
            /*Viewuser vUser = new Viewuser();
            vUser.Show();
            this.Hide();*/
        }

        private void btn_Adm_update_Click(object sender, EventArgs e)
        {
            loadform(new newEmployee());
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

        
    }
}
