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
    public partial class Members : Form
    {
        public String str;
        public String m_id;
        public  static String toPassToMemberProfile;
        public Members()
        {
            InitializeComponent();

            MySqlDataReader rdr = null;
            String query = "select distinct(Membership_type) from membership";
            MySqlCommand cmd = new MySqlCommand(query, Form3.con);
            try
            { rdr = cmd.ExecuteReader();
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
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = comboBox1.GetItemText(comboBox1.SelectedItem);
            str= s;
        }


        private void Load_Click(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            MySqlConnection condataBase = new MySqlConnection(connectionString);
            MySqlCommand cmddataBase = new MySqlCommand("select * from member where membership_type = " + "'"+str+"'", condataBase);
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

            }catch(Exception ss)
            {
                MessageBox.Show(ss.Message);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditMembers o = new EditMembers();
            o.ShowDialog();

        }

        private void Go_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu a = new MainMenu();
            a.ShowDialog();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            m_id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
           
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            string Query = "delete from clubbed.member where m_id = '" + m_id + "'";
            MySqlConnection conDataBase = new MySqlConnection(connectionString);
            MySqlCommand cmdDataBAse = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBAse.ExecuteReader();
                MessageBox.Show("Deleted!");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            toPassToMemberProfile= dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            MySqlConnection condataBase = new MySqlConnection(connectionString);
            using (condataBase)
            {
                condataBase.Open();
                MySqlCommand cmd = new MySqlCommand("GetMember;", condataBase);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("tableref", int.Parse(toPassToMemberProfile)));
                MySqlParameter rv = new MySqlParameter();
                rv.Direction = System.Data.ParameterDirection.ReturnValue;
                rv.MySqlDbType = MySqlDbType.Int32;
                rv.ParameterName = "@retval";
                cmd.Parameters.Add(rv);
                //cmd.Parameters.Add("@ireturnvalue", MySqlDbType.Int32);
                //cmd.Parameters["@ireturnvalue"].Direction = ParameterDirection.ReturnValue;
                
                cmd.ExecuteScalar();
                object ret = cmd.Parameters["@retval"].Value;
               // MessageBox.Show(ret.ToString());
            }
            
            //MessageBox.Show(toPassToMemberProfile);
        }

        public static String getMember()
        {
            return toPassToMemberProfile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberProfile m = new MemberProfile();
            m.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MemberProfile m = new MemberProfile();
            m.ShowDialog();
        }
    }
}
