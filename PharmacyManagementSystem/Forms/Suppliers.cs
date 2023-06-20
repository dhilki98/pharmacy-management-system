using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using PharmacyManagementSystem.Operationals;

namespace PharmacyManagementSystem
{
    public partial class Suppliers : Form
    {
        String query;
        DataSet ds;
        Administrator parentAdm;
        int selectedSupplierId = 0;

        public Suppliers()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_sup_add_Click(object sender, EventArgs e)
        {
            saveResponse(); 
            refreshTable();
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

        private void btn_sup_search_Click(object sender, EventArgs e)
        {
            query = "select * from SUPPLIERS where supName like '"+txt_sup_search+"%'";
            dataGV_sup.DataSource = DBHelper.getData(query).Tables[0];
            btn_sup_resetsearch.Show();
        }

        private void saveResponse()
        {
            String supName = txt_sup_name.Text;
            String supAddress = txt_sup_address.Text;
            String supContactNo = txt_sup_contactno.Text;
            String licenseNo = txt_sup_lino.Text;

            try
            {
                if(selectedSupplierId == 0)
                {
                    query = ("insert into SUPPLIERS (supName, address, contactNo, supLicenseNp) values ('" + supName + "', '" + supAddress + "', '" + supContactNo + "', '" + licenseNo + "')");
                    DBHelper.setData(query, "Add Sucessful.");
                }else if (selectedSupplierId > 0)
                {
                    query = "update SUPPLIERS set" +
                        "supName = '" + supName + "', " +
                        "address = '" + supAddress + "', " +
                        "contactNo = '" + supContactNo + "', " +
                        "supLicenseNo = '" + licenseNo + "', ";
                    DBHelper.setData(query, "Update Sucessful");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Operation Unsucessful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btn_sup_back_Click(object sender, EventArgs e)
        {
            parentAdm.Show();
            this.Close();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            query = "select * from SUPPLIERS";
            dataGV_sup.DataSource = DBHelper.getData(query).Tables[0];
            btn_sup_resetsearch.Hide();

            
        }

        public void refreshTable()
        {
            query = "select * from SUPPLIERS";
            dataGV_sup.DataSource = DBHelper.getData(query).Tables[0];
        }

        private void btn_sup_resetsearch_Click(object sender, EventArgs e)
        {
            refreshTable();
            txt_sup_search.Text = "";
            btn_sup_resetsearch.Hide();
        }

        private void dataGV_sup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_sup_edit.Show();
            btn_sup_delete.Show();
            selectedSupplierId = Convert.ToInt32(dataGV_sup.Rows[e.RowIndex].Cells[0].Value);
        }

        private void removeSupplier(int supId)
        {
            try
            {
                query = "DELETE FROM SUPPLIERS WHERE supId='" + supId + "'";
                DBHelper.setData(query, "Removal Sucessful");

            } catch (Exception ex)
            {
                MessageBox.Show("Supplier Removal Unsuccessful." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sup_delete_Click(object sender, EventArgs e)
        {
            removeSupplier(selectedSupplierId);
            selectedSupplierId = 0;
            refreshTable();
        }

        private void btn_sup_edit_Click(object sender, EventArgs e)
        {
            query = "select * from SUPPLIERS where supId='" + selectedSupplierId + "'";
            DataSet ds = DBHelper.getData(query);
            txt_sup_name.Text = ds.Tables[0].Rows[0][1].ToString();
            txt_sup_address.Text = ds.Tables[0].Rows[0][2].ToString();
            txt_sup_contactno.Text = ds.Tables[0].Rows[0][3].ToString();
            txt_sup_lino.Text = ds.Tables[0].Rows[0][1].ToString();
            btn_sup_add.Text = "Update";
        }
    }
}
