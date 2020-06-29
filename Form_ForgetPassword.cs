using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACNPM
{
    public partial class Form_ForgetPassword : Form
    {
        public Form_ForgetPassword()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
        }
    }
}