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
    public partial class Suppliers : Form
    {
        function fn = new function();
        String query;

        public Suppliers()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_sup_add_Click(object sender, EventArgs e)
        {
            String supName = txt_sup_name.Text;
            String supAddress = txt_sup_address.Text;
            String supContactNo = txt_sup_contactno.Text;
            String licenseNo = txt_sup_lino.Text;

            try
            {
                query = ("insert into users (supName, address, contactNo, supLicenseNp) values ('" + supName + "', '" + supAddress + "', '" + supContactNo + "', '" + licenseNo + "')";
                fn.setData(query, "Add Sucessful.");
            }
            catch (Exception)
            {
                MessageBox.Show("Supplier Allready Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btn_sup_reset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txt_sup_address.Clear();
            txt_sup_contactno.Clear();
            txt_sup_lino.Clear();
            txt_sup_name.Clear();

        }

        private void btn_sup_viewsuppliers_Click(object sender, EventArgs e)
        {
            query = "select * from SUPPLIERS";
            DataSet ds = fn.getData(query);
            dataGV_sup.DataSource = ds.Tables[0];
        }
    }
}
