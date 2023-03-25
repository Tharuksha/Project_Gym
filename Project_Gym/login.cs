using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Gym
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username = txtusername.Text;
            String Password = txtpassword.Text;
            if (txtusername.Text != "" && txtpassword.Text != "")
            {
                if (Username == "Admin" && Password == "Admin@123")
                {
                    MessageBox.Show("Login Sucessfull !");
                    dashboard dash = new dashboard();
                    dash.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Incorrect Username Or Password");

            }
            else
                MessageBox.Show("Please Enter Relevant DATA !!");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
