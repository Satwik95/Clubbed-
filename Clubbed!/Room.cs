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

    public partial class Room : Form
    {
        String str;
     public int room_id, floor_id, m_id;
       int flag = 0;
        public Room()
        {
            InitializeComponent();
          /*  MySqlDataReader rdr = null;
            String query = "select distinct(room_type) from room_type";
            MySqlCommand cmd = new MySqlCommand(query, Form3.con);
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    roomTypeComboBox.Items.Add(rdr.GetString(0));
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            rdr.Close(); */
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = roomTypeComboBox.GetItemText(roomTypeComboBox.SelectedItem);
            str = s;

            if(s.Equals("Rooms Available"))
            {
                flag = 1;
            }
            else if(s.Equals("Rooms Booked"))
            {
                flag = 0;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            MySqlConnection condataBase = new MySqlConnection(connectionString);
            MySqlCommand cmddataBase;
            if (flag == 1)
            {

                 cmddataBase = new MySqlCommand(" select * from room_type where (room_no,floor_no) not in (select room_no,floor_no from roombooked)", condataBase);
            }else
            {
                 cmddataBase = new MySqlCommand("select * from roombooked", condataBase);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try {
                m_id = Int32.Parse(textBox1.Text);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            room_id = int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            floor_id = int.Parse(dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // room_id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
           // floor_id = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
        string Query = "insert into clubbed.roombooked(room_no,floor_no,m_id,date_booked) values( "+room_id+","+floor_id+","+m_id+",null)";
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
    }
}
