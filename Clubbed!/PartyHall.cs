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
    public partial class PartyHall : Form
    {
        int flag = 0;
        public String str,hallname;
        public int mid;
        public PartyHall()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            MySqlConnection condataBase = new MySqlConnection(connectionString);
            MySqlCommand cmddataBase;
            if (flag == 1)
            {

                cmddataBase = new MySqlCommand(" select * from partyhall where hall_name not in (select hall_name from booked)", condataBase);
            }
            else
            {
                cmddataBase = new MySqlCommand("select * from booked", condataBase);
            }
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

            if (s.Equals("Halls Available"))
            {
                flag = 1;
            }
            else if (s.Equals("Halls Booked"))
            {
                flag = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            string Query = "insert into clubbed.booked(m_id,hall_name,date_booked,booked_till) values( " + mid + "," + hallname + ", ' null' ,'null ')";
            MySqlConnection conDataBase = new MySqlConnection(connectionString);
            MySqlCommand cmdDataBAse = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBAse.ExecuteReader();
                MessageBox.Show("Room Booked!");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mid = Int32.Parse(textBox1.Text);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hallname = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
        }
    }
}
