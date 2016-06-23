using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clubbed_
{
    public partial class Form3 : Form
    {
        String p = " ";
        String u = " ";

        public static MySqlConnection con;
        public Form3()
        {
            InitializeComponent();
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

        }

        String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";

        private void login_TextChanged(object sender, EventArgs e)
        {
            u = login.Text;


        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            p = password.Text;
        }

        private void log_Click(object sender, EventArgs e)
        {
            String password = "password";
            String user = "user";
            if( p.Equals(password) && u.Equals(user))
            {
                using (con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        
                        this.Hide();
                        MainMenu mm = new MainMenu();
                        mm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show(" No connection.Try Again!");

                    }

                }


            }
            else
            {
                MessageBox.Show("User or Password not correct.Try Again!");

            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
