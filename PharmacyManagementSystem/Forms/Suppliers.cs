using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.Logging;
using PharmacyManagementSystem.DataModels;
using PharmacyManagementSystem.Operationals;

namespace PharmacyManagementSystem
{
    public partial class Suppliers : Form
    {
        String query;
        DataSet ds;
        UserContext context;
        Item_management parentAdm;
        int selectedSupplierId = 0;
        bool isEditing = false;

        public Suppliers(UserContext uc, Item_management im)
        {
            InitializeComponent();
            this.parentAdm = im;
            this.context = uc;
        }


        private void Suppliers_Load(object sender, EventArgs e)
        {
            query = "select * from SUPPLIERS";
            dataGV_sup.DataSource = DBHelper.getData(query).Tables[0];
            btn_sup_resetsearch.Hide();
            btn_sup_delete.Hide();
            btn_sup_edit.Hide();
            if (context.getUserRole() != UserContext.Role.Administrator)
            {
                btn_sup_add.Hide();
                btn_sup_reset.Hide();
            }
        }

        private void btn_sup_add_Click(object sender, EventArgs e)
        {
            saveResponse();
            refreshTable();
        }

        private void btn_sup_reset_Click(object sender, EventArgs e)
        {
            clearAll();
            if (isEditing == true)
            {
                isEditing = false;
                btn_sup_add.Text = "Add";
                btn_sup_reset.Text = "Reset";
                btn_sup_delete.Hide();
                btn_sup_edit.Hide();
            }
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
            query = "select * from SUPPLIERS where supName like '" + txt_sup_search.Text + "%'";
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
                if (isEditing == false)
                {
                    query = ("insert into SUPPLIERS (supName, address, contactNo, supLicenseNo) values ('" + supName + "', '" + supAddress + "', '" + supContactNo + "', '" + licenseNo + "')");
                    DBHelper.setData(query, "Add Sucessful.");
                }
                else
                {
                    query = "update SUPPLIERS set " +
                        "supName = '" + supName + "', " +
                        "address = '" + supAddress + "', " +
                        "contactNo = '" + supContactNo + "', " +
                        "supLicenseNo = '" + licenseNo + "' " +
                        "where supId = '" + selectedSupplierId + "'";
                    DBHelper.setData(query, "Update Sucessful");
                    isEditing = false;
                    btn_sup_delete.Hide();
                    btn_sup_edit.Hide();
                }
                clearAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation Unsucessful. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sup_back_Click(object sender, EventArgs e)
        {
            parentAdm.Show();
            this.Close();
        }

        public void refreshTable()
        {
            query = "select * from SUPPLIERS";
            dataGV_sup.DataSource = DBHelper.getData(query).Tables[0];
            isEditing = false;
            btn_sup_add.Text = "Add";
            btn_sup_reset.Text = "Reset";

        }

        private void btn_sup_resetsearch_Click(object sender, EventArgs e)
        {
            refreshTable();
            txt_sup_search.Text = "";
            btn_sup_resetsearch.Hide();
        }

        private void dataGV_sup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (context.getUserRole() == UserContext.Role.Administrator)
            {
                btn_sup_edit.Show();
                btn_sup_delete.Show();
            }
            selectedSupplierId = Convert.ToInt32(dataGV_sup.Rows[e.RowIndex].Cells[0].Value);

        }

        private void removeSupplier(int supId)
        {
            try
            {
                query = "DELETE FROM SUPPLIERS WHERE supId='" + supId + "'";
                DBHelper.setData(query, "Removal Sucessful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Supplier Removal Unsuccessful. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            isEditing = true;
            query = "select * from SUPPLIERS where supId='" + selectedSupplierId + "'";
            DataSet ds = DBHelper.getData(query);
            txt_sup_name.Text = ds.Tables[0].Rows[0][1].ToString();
            txt_sup_address.Text = ds.Tables[0].Rows[0][2].ToString();
            txt_sup_contactno.Text = ds.Tables[0].Rows[0][3].ToString();
            txt_sup_lino.Text = ds.Tables[0].Rows[0][4].ToString();
            btn_sup_add.Text = "Update";
            btn_sup_reset.Text = "Cancel";
        }
    }
}
