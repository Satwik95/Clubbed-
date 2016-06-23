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
    public partial class EditStaff : Form
    {
        public int s_id,sal;
        public String name, dept;
        public EditStaff()
        {
            InitializeComponent();
        }

        private void sid_TextChanged(object sender, EventArgs e)
        {
            s_id = Int32.Parse(sid.Text);

        }

        private void nam_TextChanged(object sender, EventArgs e)
        {
            name = nam.Text;
        }

        private void department_TextChanged(object sender, EventArgs e)
        {
            dept = department.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            string Query = "insert into clubbed.staff(s_id,name,dept,salary) values(" +s_id+ ",'" + name + "','" + dept+ "'," + sal + ")";
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
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff a = new Staff();
            a.ShowDialog();

        }

        private void salary_TextChanged(object sender, EventArgs e)
        {
            sal = Int32.Parse(salary.Text);
        }

        private void EditStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
