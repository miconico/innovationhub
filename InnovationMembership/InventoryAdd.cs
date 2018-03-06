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
    public partial class InventoryAdd : Form
    {

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataTable dt = new DataTable();

        public InventoryAdd()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddInventory_Load(object sender, EventArgs e)
        {
            LoadItems();
            SearchInventory();
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

                        cboTypes.DataSource = dt.DefaultView;
                        cboTypes.ValueMember = "inventoryType";
                        cboTypes.DisplayMember = "Description";

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

        private Boolean ValidateInput()
        {
            Boolean validateInput = true;
            String validationMessage = "";

            if (name.Text.Trim().Equals(""))
            {
                validateInput = false;
                validationMessage = "Please enter a valid name";
            }


            if (!validateInput)
            {
                MessageBox.Show(this, validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            return validateInput;

        }

        private void create_Click(object sender, EventArgs e)
        {
            int inventoryId = -1;

            if (!ValidateInput())
            {
                return;
            }

            using (SqlConnection conn = new SqlConnection(Settings.Default.InnovationHubConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("AddInventory", conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ItemType", cboTypes.SelectedValue.ToString().Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ItemName", name.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ItemDesc", description.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ItemReceived", received.Text));
                    cmd.Parameters.Add(new SqlParameter("@ItemQuantity", quantity.Text));
                    cmd.Parameters.Add(new SqlParameter("@ItemLocation", cboLocation.Text));
                    cmd.Parameters.Add(new SqlParameter("@ItemInStock", (cboInStock.Text == "Yes" ? 1 : 0)));
                    cmd.Parameters.Add(new SqlParameter("@ItemTakenDate", received.Text));
                    cmd.Parameters.Add(new SqlParameter("@ItemTakenByMemberId", "0"));
                    cmd.Parameters.Add(new SqlParameter("@ItemPurchaseCost", purchaseCost.Text));
                    cmd.Parameters.Add(new SqlParameter("@ItemSaleValue", saleValue.Text));
                    cmd.Parameters.Add(new SqlParameter("@Consumable", (cboConsumable.Text == "Yes" ? 1 : 0)));
                    cmd.Parameters.Add(new SqlParameter("@Active", 1));

                    inventoryId = cmd.ExecuteNonQuery();

                    if (inventoryId.Equals(1))
                    {
                        MessageBox.Show(this, "Item added successfully!", "Item added successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        SearchInventory();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error adding inventory item", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        private void search_Click_1(object sender, EventArgs e)
        {
            SearchInventory();
        }

        private void update_Click(object sender, EventArgs e)
        {
            da.Update(dt);
            dgInventory.Refresh();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
