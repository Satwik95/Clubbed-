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
    public partial class EditClass : Form
    {
        public String c_id, c_type, timing;
        public int tot_enrol;
        public EditClass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class mo = new Class();
            mo.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            c_id = textBox4.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tot_enrol = Int32.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            string Query = "insert into clubbed.class(C_ID,tot_enrol,timing,class_type) values('" + c_id + "'," + tot_enrol + ",'" + timing + "','" +c_type + "')";
            MySqlConnection conDataBase = new MySqlConnection(connectionString);
            MySqlCommand cmdDataBAse = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBAse.ExecuteReader();
                MessageBox.Show("Saved!");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void EditClass_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            timing = textBox3.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            c_type = textBox2.Text;
        }
    }
}
