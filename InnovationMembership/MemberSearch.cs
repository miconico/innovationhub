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
using InnovationMembership.Properties;

namespace InnovationMembership
{
    public partial class MemberSearch : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataTable dt = new DataTable();


        public MemberSearch()
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

                SqlCommand cmdMember = new SqlCommand("SearchMember", conn);
                cmdMember.CommandType = CommandType.StoredProcedure;

                if (name.Text.Trim() != "")
                {
                    cmdMember.Parameters.Add(new SqlParameter("@name", name.Text.Trim()));
                }
                if (email.Text.Trim() != "")
                {
                    cmdMember.Parameters.Add(new SqlParameter("@email", email.Text.Trim()));
                }
                if (addr.Text.Trim() != "")
                {
                    cmdMember.Parameters.Add(new SqlParameter("@addr", addr.Text.Trim()));
                }
                if (mobile.Text.Trim() != "")
                {
                    cmdMember.Parameters.Add(new SqlParameter("@mobile", mobile.Text.Trim()));
                }

                da = new SqlDataAdapter(cmdMember);
                dt = new DataTable();

                da.Fill(dt);
                da.UpdateCommand = new SqlCommandBuilder(da).GetUpdateCommand();
                bindingSource1.DataSource = dt;

                dgMembers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error searching member", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            da.Update(dt);
            dgMembers.Refresh();
        }

        private void mobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MemberSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
