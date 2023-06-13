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
        function fn = new function();
        String query;
        DataSet ds;
        String user = "";

        public Administrator()
        {
            InitializeComponent();
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

        private void Administrator_Load(object sender, EventArgs e)
        {
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM USERS", "server = DESKTOP-F7UFU4N; database = PharmacyDB; ");
            //DataSet ds = new DataSet();
            //da.Fill(ds, "ÛSERS");
            //dataGV_Adm.DataSource = ds.Tables["USERS"].DefaultView;
        }

        private void btn_Adm_adduser_Click(object sender, EventArgs e)
        {
            newEmployee newEmplo = new newEmployee();
            newEmplo.Show();
            this.Hide();
        }

        private void btn_Adm_back_Click(object sender, EventArgs e)
        {
            Main mnA = new Main();
            mnA.Show();
            this.Hide();
        }

        private void btn_Adm_viewusers_Click(object sender, EventArgs e)
        {
            Viewuser vUser = new Viewuser();
            vUser.Show();
            this.Hide();
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
