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
using MySql.Data.MySqlClient;

namespace Przvd_prkt_ZakirovDK
{
    public partial class Opros : Form
    {
        public Opros()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        MySqlCommand cmd;

        private void Opros_Load(object sender, EventArgs e)
        {
            string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_14;database=is_1_20_st14_KURS;password=45850148;";
            conn = new MySqlConnection(connStr);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("INSERT INTO t_Proizvod_ZAKIROV (male, age, marital_status, birthplace, citizenship, nationality, education, occupation)  VALUES (@male, @age, @marital_status, @birthplace, @citizenship, @nationality, @education, @occupation)", conn);
            cmd.Parameters.AddWithValue("@male", metroTextBox1.Text);
            cmd.Parameters.AddWithValue("@age", metroTextBox2.Text);
            cmd.Parameters.AddWithValue("@marital_status", metroTextBox3.Text);
            cmd.Parameters.AddWithValue("@birthplace", metroTextBox4.Text);
            cmd.Parameters.AddWithValue("@citizenship", metroTextBox5.Text);
            cmd.Parameters.AddWithValue("@nationality", metroTextBox6.Text);
            cmd.Parameters.AddWithValue("@education", metroTextBox7.Text);
            cmd.Parameters.AddWithValue("@occupation", metroTextBox8.Text);
            try
            { 
                cmd.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }
            conn.Close();
            this.Close();
        }
    }
}