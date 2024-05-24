using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Gym
{
    public partial class newmember : Form
    {
        public newmember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = txt_fname.Text;
            String lname = txt_lname.Text;
            String address = txt_address.Text;
            String email = txt_email.Text;
            String dob = birth_dateTimePicker.Value.ToString("yyyy-MM-dd");
            String jdate = join_dateTimePicker.Value.ToString("yyyy-MM-dd");
            String membership = m_comboBox.Text;
            String nic = txt_nic.Text;
            long num;
            int h;
            int w;

            if (!long.TryParse(txt_num.Text, out num) || !int.TryParse(txt_height.Text, out h) || !int.TryParse(txt_weight.Text, out w))
            {
                MessageBox.Show("Please enter valid numerical values for number, height, and weight.");
                return;
            }

            String gender = btn_male.Checked ? btn_male.Text : btn_female.Text;

            if (gender.Length > 10) // Assuming Gender column in DB is NVARCHAR(10)
            {
                MessageBox.Show("Gender value is too long.");
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=DobA\DOBA;Initial Catalog=GymDB;User ID=sa;Password=Tharuksha@2001;Connect Timeout=30"))
            {
                using (SqlCommand cmd = new SqlCommand("InsertMember", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nic", nic);
                    cmd.Parameters.AddWithValue("@Fname", fname);
                    cmd.Parameters.AddWithValue("@Lname", lname);
                    cmd.Parameters.AddWithValue("@JDate", jdate);
                    cmd.Parameters.AddWithValue("@Dob", dob);
                    cmd.Parameters.AddWithValue("@Mnumber", num);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Membership", membership);
                    cmd.Parameters.AddWithValue("@Height", h);
                    cmd.Parameters.AddWithValue("@Weight", w);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Email", email);

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
            txt_fname.Clear();
            txt_lname.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_num.Clear();
            txt_weight.Clear();
            txt_height.Clear();
            txt_nic.Clear();

            btn_male.Checked = false;
            btn_female.Checked = false;

            m_comboBox.ResetText();
            join_dateTimePicker.Value = DateTime.Now;
            birth_dateTimePicker.Value = DateTime.Now;
        }
    }
}
