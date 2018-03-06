using InnovationMembership.Properties;
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

namespace InnovationMembership
{
    public partial class InventorySearch : Form
    {

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataTable dt = new DataTable();

        public InventorySearch()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SearchInventory();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        public void LoadItems()
        {
            using (SqlConnection conn = new SqlConnection(Settings.Default.InnovationHubConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select InventoryType, RTRIM(Description) AS Description From InventoryType", conn);

                    cmd.CommandType = CommandType.Text;


                    // execute the command
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("inventoryType", typeof(string));
                        dt.Columns.Add("Description", typeof(string));

                        dt.Load(rdr);

                        cboSearchTypes.DataSource = dt.DefaultView;
                        cboSearchTypes.ValueMember = "inventoryType";
                        cboSearchTypes.DisplayMember = "Description";

                        conn.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error loading types", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void SearchInventory()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.InnovationHubConnectionString);

                SqlCommand cmdMember = new SqlCommand("SearchInventory", conn);
                cmdMember.CommandType = CommandType.StoredProcedure;

                cmdMember.Parameters.Add(new SqlParameter("@Type", cboSearchTypes.Text.Trim()));
                cmdMember.Parameters.Add(new SqlParameter("@Location", cboLocationSearch.Text.Trim()));

                da = new SqlDataAdapter(cmdMember);
                dt = new DataTable();

                da.Fill(dt);
                da.UpdateCommand = new SqlCommandBuilder(da).GetUpdateCommand();
                bindingSource1.DataSource = dt;

                dgInventory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error searching member", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventorySearch_Load(object sender, EventArgs e)
        {
            LoadItems();
            SearchInventory();
        }
    }
}
