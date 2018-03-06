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
    public partial class PaymentsSearch : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataTable dt = new DataTable();

        public PaymentsSearch()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
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

                dgPayments.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error searching member", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            da.Update(dt);
            dgPayments.Refresh();
        }
    }
}
