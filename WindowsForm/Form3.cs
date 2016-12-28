using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                Form4 form1 = new Form4(textBox1.Text);
                form1.Show();
            }
            else
                MessageBox.Show("Enter Your Email", "Missing Fileds", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
