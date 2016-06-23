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

    public partial class Enrolled : Form
    {
        String str1;
        String str2;
        public Enrolled()
        {
            InitializeComponent();
            enrolledComboBox1.Items.Add("class");
            enrolledComboBox1.Items.Add("activity");

        }



        private void loadButton_Click(object sender, EventArgs e)
        {
            
        }

        private void enrolledComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            enrolledComboBox2.Items.Clear();
            var s = enrolledComboBox1.GetItemText(enrolledComboBox1.SelectedItem);
            str1 = s;
            if (s == "class")
            {
                MySqlDataReader rdr = null;
                String query = "select distinct(class_type) from class";
                MySqlCommand cmd = new MySqlCommand(query, Form3.con);
                try
                {
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        enrolledComboBox2.Items.Add(rdr.GetString(0));
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
                rdr.Close();
            } 
            else if (s == "activity")
            {
                MySqlDataReader rdr = null;
                String query = "select distinct(activity_type) from activity";
                MySqlCommand cmd = new MySqlCommand(query, Form3.con);
                try
                {
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        enrolledComboBox2.Items.Add(rdr.GetString(0));
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
                rdr.Close();
            }
        }

        private void enrolledComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = enrolledComboBox2.GetItemText(enrolledComboBox2.SelectedItem);
            str2 = s;
        }

        private void loadButton_Click_1(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            MySqlConnection condataBase = new MySqlConnection(connectionString);
            MySqlCommand cmddataBase = new MySqlCommand("select * from " + str1 + " where " + str1 + "_type = " + "'" + str2 + "'", condataBase);
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

        private void button2_Click(object sender, EventArgs e)
        {
           // chart1.Dispose();
          chart1.Series["activity/class type"].Points.Clear();
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            MySqlConnection condataBase = new MySqlConnection(connectionString);
            MySqlCommand cmddataBase = new MySqlCommand("select " + str1+"_type,sum(tot_enrol) from  " + str1 + " group by " + str1 + "_type", condataBase);
           // MySqlCommand cmddataBase1 = new MySqlCommand("select activity_type,sum(tot_enrol) from activity group by  activity_type", condataBase);

            MySqlDataReader myReader;
            
            try
            {
                condataBase.Open();
                myReader = cmddataBase.ExecuteReader();
         

                while (myReader.Read())
                {
                 this.chart1.Series["activity/class type"].Points.AddXY(myReader.GetString(str1 + "_type"),myReader.GetInt32("sum(tot_enrol)"));

                }
               // myReader.Close();

                //myReader1 = cmddataBase1.ExecuteReader();
                //while (myReader1.Read())
                //{
                //    this.chart1.Series["activity_type"].Points.AddXY(myReader1.GetString("activity_type"), myReader1.GetInt32("sum(tot_enrol)"));
                //}
                //myReader1.Close();
            }
            catch (Exception ss)
            {
                MessageBox.Show(ss.Message);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();

        }
    }
}
