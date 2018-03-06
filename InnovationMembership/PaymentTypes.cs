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
    public partial class PaymentTypes : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataTable dt = new DataTable();

        public PaymentTypes()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            da.Update(dt);
            dgPaymentTypes.Refresh();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.InnovationHubConnectionString);

                SqlCommand cmdMember = new SqlCommand("SearchPayments", conn);
                cmdMember.CommandType = CommandType.StoredProcedure;

                if (name.Text.Trim() != "")
                {
                    cmdMember.Parameters.Add(new SqlParameter("@desc", name.Text.Trim()));
                }
                
                da = new SqlDataAdapter(cmdMember);
                dt = new DataTable();

                da.Fill(dt);
                da.UpdateCommand = new SqlCommandBuilder(da).GetUpdateCommand();
                bindingSource1.DataSource = dt;

                dgPaymentTypes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error searching payments", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void PaymentTypes_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
