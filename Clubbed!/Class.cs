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
    public partial class Class : Form
    {
        String str;
        public Class()
        {
            InitializeComponent();

            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            MySqlDataReader rdr = null;
            String query = "select distinct(class_type) from class";
            MySqlCommand cmd = new MySqlCommand(query, Form3.con);
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    class_t.Items.Add(rdr.GetString(0));
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            rdr.Close();
        }

        private void class_t_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = class_t.GetItemText(class_t.SelectedItem);
            str = s;
        }

        private void Loadclass_Click(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            MySqlConnection condataBase = new MySqlConnection(connectionString);
            MySqlCommand cmddataBase = new MySqlCommand("select * from class where class_type = " + "'" + str + "'", condataBase);
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

        private void go_back_Click(object sender, EventArgs e)
        {

            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            EditClass mm = new EditClass();
            mm.ShowDialog();
        }
    }
}
