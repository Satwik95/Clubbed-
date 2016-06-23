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
    public partial class MemberProfile : Form
    {
        ListViewItem lvi1;
        ListViewItem lvi2;
        Image image;

        public MemberProfile()
        {
            InitializeComponent();

            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            if (Int32.Parse(Members.toPassToMemberProfile) == 1 || Int32.Parse(Members.toPassToMemberProfile) == 2)
            {
                image = Image.FromFile("C:\\Users\\satwik\\Desktop\\" + Members.toPassToMemberProfile + ".jpg");
            }
            else
            {
                image = Image.FromFile("C:\\Users\\satwik\\Desktop\\image1.jpg");
            }
            pictureBox1.Image = image;
            string Query1 = "select C_ID,class_type from clubbed.class T where exists (select C_ID from clubbed.member_class S where T.C_ID=S.C_ID and M_ID= '" + Members.toPassToMemberProfile + "')";
            MySqlConnection conDataBase = new MySqlConnection(connectionString);
            MySqlCommand cmdDataBAse = new MySqlCommand(Query1, conDataBase);


            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBAse;
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

            string Query2 = "select A_ID,activity_type from clubbed.activity T where exists (select A_ID from clubbed.member_activity S where T.A_ID=S.A_ID and M_ID= '" + Members.toPassToMemberProfile + "')";
            cmdDataBAse = new MySqlCommand(Query2, conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBAse;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ss)
            {
                MessageBox.Show(ss.Message);
            }

            string Query3 = "select distinct(name) from clubbed.staff natural join clubbed.teacher_class where C_ID in (select C_ID from clubbed.class T where exists (select C_ID from clubbed.member_class S where T.C_ID=S.C_ID and M_ID= '" + Members.toPassToMemberProfile + "'))";
            cmdDataBAse = new MySqlCommand(Query3, conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBAse;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView3.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ss)
            {
                MessageBox.Show(ss.Message);
            }

            string Query4 = "select distinct(name) from clubbed.staff natural join clubbed.trainer_activity where A_ID in (select A_ID from clubbed.activity T where exists (select A_ID from clubbed.member_activity S where T.A_ID=S.A_ID and M_ID= '" + Members.toPassToMemberProfile + "'))";
            cmdDataBAse = new MySqlCommand(Query4, conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBAse;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView4.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ss)
            {
                MessageBox.Show(ss.Message);
            }

            string Query5 = "select * from clubbed.member where m_ID=" + Members.toPassToMemberProfile;
            cmdDataBAse = new MySqlCommand(Query5, conDataBase);
            conDataBase.Open();
            MySqlDataReader rdr = cmdDataBAse.ExecuteReader();

            while(rdr.Read())
            {
                label7.Text = rdr.GetString(0);
                label8.Text = rdr.GetString(1);
                label9.Text = rdr.GetString(2);
                label10.Text = rdr.GetString(3);
                label11.Text = rdr.GetString(4);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Members m = new Members();
            m.ShowDialog();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
