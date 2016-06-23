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
    public partial class Activity : Form
    {
        public String str;
        public Activity()
        {
            InitializeComponent();
            MySqlDataReader rdr = null;
            String query = "select distinct(activity_type) from activity";
            MySqlCommand cmd = new MySqlCommand(query, Form3.con);
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboBox1.Items.Add(rdr.GetString(0));
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            rdr.Close();
        }

        private void load_Click(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            MySqlConnection condataBase = new MySqlConnection(connectionString);
            MySqlCommand cmddataBase = new MySqlCommand("select * from activity where activity_type = " + "'" + str + "'", condataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmddataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ss)
            {
                MessageBox.Show(ss.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = comboBox1.GetItemText(comboBox1.SelectedItem);
            str = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
        }
    }
}
