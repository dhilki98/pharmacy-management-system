using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagementSystem.Operationals;

namespace PharmacyManagementSystem
{
    public partial class addBatch : Form
    {
        String query;

        public addBatch()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_aB_sid_Click(object sender, EventArgs e)
        {

        }

        private void lbl_aB_unitprice_Click(object sender, EventArgs e)
        {

        }

        private void txt_aB_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String itemID = txt_aB_iid.Text;
            String supplierID = txt_aB_sid.Text;
            String expireDate = dateTP_aB_expiredate.Text;
            String unitPrice = txt_aB_unitprice.Text;   
            String quantity = txt_aB_quantity.Text;

            try
            {
                query = "insert into users (itemId, supId, unitPrice, expireDate, quantity) values ('" + itemID + "', '" + supplierID + "', '" + unitPrice + "', '" + expireDate + "', '" + quantity + "')";
                DBHelper.setData(query, "Add Sucessful.");
            }
            catch(Exception)
            {
                MessageBox.Show("User Allready Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_aB_reset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txt_aB_iid.Clear();
            txt_aB_quantity.Clear();
            txt_aB_sid.Clear();
            txt_aB_unitprice.Clear();
            dateTP_aB_expiredate.Value = DateTime.Today;
        }
    }
}
