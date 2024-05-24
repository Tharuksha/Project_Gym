using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Added for database operations

namespace Project_Gym
{
    public partial class searchequipment : Form
    {
        public searchequipment()
        {
            InitializeComponent();
        }

        private void cANCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchequipment_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DobA\DOBA;Initial Catalog=GymDB;User ID=sa;Password=Tharuksha@2001;Connect Timeout=30"; // Replace with your actual connection string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("GetAllEquipment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
