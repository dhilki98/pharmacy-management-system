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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementSystem
{
    public partial class Administrator : Form
    {
        UserContext ctx;
        bool isEditing;
        String query;
        DataSet ds;

        public Administrator(UserContext ctx)
        {
            InitializeComponent();
            this.ctx = ctx;
            this.isEditing = false;
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            lbl_Adm_username.Text = ctx.getUsername();
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
        
    }
}
