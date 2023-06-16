using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Viewuser : Form
    {
        String query;
        String cuurentUser = "";

        public Viewuser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { cuurentUser = value; }
        }

        private void Viewuser_Load(object sender, EventArgs e)
        {
            query = "select * from USERS";
            DataSet ds = DBHelper.getData(query);
            dataGV_Uv.DataSource = ds.Tables[0];
        }

        private void txt_Vu_username_TextChanged(object sender, EventArgs e)
        {
            query = "select * from USERS where userName like '" + txt_Vu_username.Text + "%'";
            DataSet ds = DBHelper.getData(query);
            dataGV_Uv.DataSource = ds.Tables[0];
        }

        String userName;
        private void dataGV_Uv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = dataGV_Uv.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch { }
        }

        private void btn_Vu_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (cuurentUser != userName)
                {
                    query = "delete from USERS where userName = '" + userName + "'";
                    DBHelper.setData(query, "Users records deleted.");
                    Viewuser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are trying to delete your own profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Uv_refresh_Click(object sender, EventArgs e)
        {
            Viewuser_Load(this, null);
        }
    }
}
