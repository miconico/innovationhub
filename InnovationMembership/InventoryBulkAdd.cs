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
    public partial class InventoryBulkAdd : Form
    {
        public InventoryBulkAdd()
        {
            InitializeComponent();
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            fileDlg.ShowDialog(this);
            fileLocation.Text = fileDlg.FileName; 
        }

        private void addData_Click(object sender, EventArgs e)
        {
            if (fileLocation.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Please enter a valid fileName for uploading data");
                return;
            }

            var lines = System.IO.File.ReadAllLines(fileLocation.Text.Trim());

            if (lines.Count() == 0)
            {
                MessageBox.Show(this, "Please enter a valid fileName for uploading data");
                return;
            }
            var columns = lines[0].Split(',');
            var table = new DataTable();
            foreach (var c in columns)
                table.Columns.Add(c);

            for (int i = 1; i < lines.Count(); i++)
                table.Rows.Add(lines[i].Split(','));

            var connection = Settings.Default.InnovationHubConnectionString;
            var sqlBulk = new SqlBulkCopy(connection);
            sqlBulk.DestinationTableName = "Inventory";
            sqlBulk.WriteToServer(table);

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
