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
            txt_fname.Clear();
            txt_lname.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_num.Clear();
            txt_weight.Clear();
            txt_height.Clear();

            btn_male.Checked = false;
            btn_female.Checked = false;

            m_comboBox.ResetText();
            join_dateTimePicker.Value = DateTime.Now;
            birth_dateTimePicker.Value = DateTime.Now;
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
            String dob = birth_dateTimePicker.Text;
            String jdate = join_dateTimePicker.Text;
            String membership = m_comboBox.Text;
            String nic = txt_nic.Text;
            int num = int.Parse(txt_num.Text);
            int h = int.Parse(txt_height.Text);
            int w = int.Parse(txt_weight.Text);

            String gender = "";
            bool isChecked = btn_male.Checked;

            if (isChecked)
            {
                gender = btn_male.Text;
            }
            else
            {
                gender = btn_female.Text;
            }

            
               SqlConnection con = new SqlConnection(@"Data Source=XOXO;Initial Catalog=GymDB;Integrated Security=false;User ID=sa;Password=test123;Connect Timeout=30");

            String qry = "INSERT INTO MEMBER (Nic,Fname,Lname,JDate,Dob,Mnumber,Gender,Membership,Height,Weight,Address,email)  VALUES ('"+nic+"','" + fname + "','" + lname + "','" + jdate + "','" + dob + "','" + num + "','"+gender+"','" + membership + "','" + h + "','" + w + "','" + address + "','"+email+"')";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful..");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
