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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Gym
{
    public partial class newequipment : Form
    {
        public newequipment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void m_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cANCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_dis.Clear();
            txt_name.Clear();
            type_comboBox.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String dis = txt_dis.Text;
            String name = txt_name.Text;
            String comboBox = type_comboBox.Text;


            using (SqlConnection con = new SqlConnection(@"Data Source=DobA\DOBA;Initial Catalog=GymDB;User ID=sa;Password=Tharuksha@2001;Connect Timeout=30"))
            {
                using (SqlCommand cmd = new SqlCommand("InsertEquipment", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Dis", dis);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Type", comboBox); // Pass comboBox value to @Type parameter

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration Successful.");
                        ClearFields(); // Clear fields after successful registration
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
        }

        private void ClearFields()
        {
            txt_dis.Clear();
            txt_name.Clear();
            type_comboBox.ResetText();
        }
    }
}
