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
    public partial class Payment : Form
    {

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataTable dt = new DataTable();

        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void request_Click(object sender, EventArgs e)
        {
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.InnovationHubConnectionString);

                SqlCommand cmdMember = new SqlCommand("SearchMember", conn);
                cmdMember.CommandType = CommandType.StoredProcedure;

                if (memberName.Text.Trim() != "")
                {
                    cmdMember.Parameters.Add(new SqlParameter("@name", memberName.Text.Trim()));
                    cmdMember.Parameters.Add(new SqlParameter("@shortSearch", "Y"));

                    da = new SqlDataAdapter(cmdMember);
                    dt = new DataTable();

                    da.Fill(dt);
                    da.UpdateCommand = new SqlCommandBuilder(da).GetUpdateCommand();
                    bindingSource1.DataSource = dt;

                    dgMembers.DataSource = dt;
                }
                else {
                    MessageBox.Show(this, "Please enter member name", "Please enter member name", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error searching member", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgMembers.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgMembers.SelectedRows[0];
                memberId.Text = row.Cells["MemberId"].Value.ToString();
                memberName.Text = row.Cells["MemberName"].Value.ToString();
                email.Text = row.Cells["Email"].Value.ToString();
                mobile.Text = row.Cells["SMS"].Value.ToString();
            }
        }
    }
}
