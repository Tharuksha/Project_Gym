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
    }
}
