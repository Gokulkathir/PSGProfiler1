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
    public partial class Form4 : Form
    {
        String search;
        public Form4(String qs)
        {
            InitializeComponent();
            search = qs;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            string query = "select * from UserInfo where Email='" + search + "'";
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.mdb");
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                label7.Text = reader.GetValue(1).ToString();
                label8.Text = reader.GetValue(5).ToString();
                label9.Text = reader.GetValue(12).ToString();
                label10.Text = reader.GetValue(13).ToString();
                label6.Text = reader.GetValue(2).ToString();
                pictureBox1.Image = Image.FromFile(@reader.GetValue(18).ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            reader.Close();
            con.Close();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string query = "insert into UserGoal( ID, Lgoals) values ('" + label9.Text + "','" + textBox1.Text + "')";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb");
                OleDbCommand cmd = new OleDbCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter Your Goal First", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        
            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select Lgoals from UserGoal where ID='" + label9.Text + "'";
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb");
            OleDbDataAdapter adapt = new OleDbDataAdapter(query, con);
            con.Open();
            adapt.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt.DefaultView; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();
            string query = "select Lgoals from UserGoal where ID='" + label9.Text + "'";
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb");
            OleDbDataAdapter adapt = new OleDbDataAdapter(query, con);
            con.Open();
            adapt.Fill(dt);
            con.Close();
            comboBox1.DataSource = dt.Tables[0];
            comboBox1.DisplayMember = "Lgoals";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "delete * from UserGoal where Lgoals='" + comboBox1.Text+"'";
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb");
            OleDbCommand adapt = new OleDbCommand(query, con);
            con.Open();
            adapt.ExecuteNonQuery();
            con.Close();
        }
    }
}
