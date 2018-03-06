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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void MakePortMember_Load(object sender, EventArgs e)
        {
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                if (InsertMember())
                {
                    Email.SendMessage("MakePort", Settings.Default.HTMLTable.Replace("!TEXT!", "Welcome to MakePort - your membership number is " + memberId.Text.Trim()), "welcome@makeport.ie", email.Text.Trim(), "", "", Settings.Default.EmailImage_1);
                    Mobile.SendSMS(memberId.Text.Trim());    
                }
            }
        }

        
        /// <summary>
        /// Valdiate the user input to make sure data is correct in DB
        /// </summary>
        /// <returns>boolean</returns>
        private Boolean ValidateInput()
        {
            Boolean validateInput = true;
            String validationMessage = "";

            if (forename.Text.Trim().Equals(""))
            {
                validateInput = false;
                validationMessage = "Please enter a valid forename";
            }

            if (surname.Text.Trim().Equals("")  && validateInput)
            {
                validateInput = false;
                validationMessage = "Please enter a valid surname";
            }

            if (mobile.Text.Trim().Equals("") && validateInput)
            {
                validateInput = false;
                validationMessage = "Please enter a valid mobile";
            }

            if (email.Text.Trim().Equals("") && validateInput)
            {
                validateInput = false;
                validationMessage = "Please enter a valid email";
            }

            if (add1.Text.Trim().Equals("") && validateInput)
            {
                validateInput = false;
                validationMessage = "Please enter a valid address";
            }

            if (!validateInput)
            {
                MessageBox.Show(this, validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            return validateInput;
        }

        private Boolean InsertMember()
        {
            bool insertMember = false;

            using (SqlConnection conn = new SqlConnection(Settings.Default.InnovationHubConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("AddMember", conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ForeName", forename.Text));
                    cmd.Parameters.Add(new SqlParameter("@SurName", surname.Text));
                    cmd.Parameters.Add(new SqlParameter("@Email", email.Text));
                    cmd.Parameters.Add(new SqlParameter("@SMS", mobile.Text));
                    cmd.Parameters.Add(new SqlParameter("@Address1", add1.Text));
                    cmd.Parameters.Add(new SqlParameter("@Address2", add2.Text));
                    cmd.Parameters.Add(new SqlParameter("@Address3", add3.Text));
                    cmd.Parameters.Add(new SqlParameter("@Age", age.Text));
                    cmd.Parameters.Add(new SqlParameter("@Type", type.Text));

                    // execute the command
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        // iterate through results, printing each to console
                        while (rdr.Read())
                        {
                            memberId.Text = rdr[0].ToString();
                            insertMember = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message , "Error creating member", MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                }
            }
            return insertMember; 
        }
    }
}
