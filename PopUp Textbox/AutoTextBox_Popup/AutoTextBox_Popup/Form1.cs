using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace AutoTextBox_Popup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            cn.Open();
            string sql = "insert into Table1 values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
            SqlCommand cmd = new SqlCommand(sql,cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Data Is Inserted");
            cn.Close();
        }

    }
}
