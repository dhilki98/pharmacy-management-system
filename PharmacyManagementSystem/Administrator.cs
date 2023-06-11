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
        public Administrator()
        {
            InitializeComponent();
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


    }
}
