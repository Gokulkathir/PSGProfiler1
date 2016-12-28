using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        Form2 f = new Form2();
        String OFD;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //printForm1 f=new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm;
        }
        #region next
        private void button1_Click_2(object sender, EventArgs e)
        {
            String Gender;
            if (checkBox1.Checked)
                Gender = "Male";
            else if (checkBox2.Checked)
                Gender = "Female";
            else
                Gender = "";

            if (textBox1.Text == "" || dateTimePicker1.Text == "" || numericUpDown1.Value.ToString() == "" || Gender == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || textBox6.Text == " " || comboBox3.Text == "" || textBox8.Text == "" || textBox7.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox13.Text == "" || comboBox4.Text == "" || textBox9.Text == "" || textBox11.Text == "" || OFD == "")
                MessageBox.Show("Fill the missing fileds", "Missing Fileds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string query = "insert into UserInfo(Name, DOB, Age, Gender, FName, MName, MTongue, Paddr, PState, PDistrict, PPincode, Email, Mob, Caddr, CState, CDistrict, CPin, PictureOFD) values ('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + numericUpDown1.Value.ToString() + "','" + Gender + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + comboBox3.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox13.Text + "','" + comboBox4.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + OFD + "')";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb");
                OleDbCommand cmd = new OleDbCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                this.Hide();
                f.Show();
            }
        }

        #endregion
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Images |*.jpg; *.png; *.gif";
            openFileDialog1.Title = "Select a Image";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                OFD = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
               // this.pictureBox1 = new PictureBox(openFileDialog1.OpenFile());
               // this.Cursor = new Cursor(openFileDialog1.OpenFile());
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
