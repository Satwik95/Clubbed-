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
    public partial class EditMembers : Form
    {
        public String name;
        public String address;
        public String phone;
        public String m_id;
        public String expi;
        public String mem_t;

        public EditMembers()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;database=Clubbed;userid = root;password = nfsmwps2!";
            string Query = "insert into clubbed.member(M_ID,membership_type,name,address,m_phone,expiry) values('" + m_id + "','" + mem_t + "','" + name + "','" + address + "','" + phone + "','" + expi + "')";
            MySqlConnection conDataBase = new MySqlConnection(connectionString);
            MySqlCommand cmdDataBAse = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                if (phone.Length != 10)
                {
                    MessageBox.Show("Invalid number!");
                }
                else
                {
                    conDataBase.Open();
                    myReader = cmdDataBAse.ExecuteReader();
                    MessageBox.Show("Saved!");
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void mid_TextChanged(object sender, EventArgs e)
        {
            m_id = mid.Text;
        }

        private void n_TextChanged(object sender, EventArgs e)
        {
            name = n.Text;
        }

        private void addr_TextChanged(object sender, EventArgs e)
        {
            address = addr.Text;
        }

        private void mob_TextChanged(object sender, EventArgs e)
        {
            phone = mob.Text;
         
        }

        private void memty_TextChanged(object sender, EventArgs e)
        {
            mem_t = memty.Text;
        }

        private void expiry_TextChanged(object sender, EventArgs e)
        {
            expi = expiry.Text;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Members mo = new Members();
            mo.ShowDialog();
        }

      
    }
}
