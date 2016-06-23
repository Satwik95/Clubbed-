using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubbed_
{
    public partial class MainMenu : Form
    {
   
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = comboBox1.GetItemText(comboBox1.SelectedItem);

            if (s.Equals("Members"))
            {

                this.Hide();
                    Members m = new Members();
                    m.ShowDialog();

            }
            else if (s.Equals("Staff"))
            {
                this.Hide();
                Staff m = new Staff();
                m.ShowDialog();
            }
            else if (s.Equals("Enrolled members"))
            {
                this.Hide();
                Enrolled m = new Enrolled();
                m.ShowDialog();
            }
            else if (s.Equals("Activity"))
            {
                this.Hide();
                Activity c = new Activity();
                c.ShowDialog();
            }
            else if (s.Equals("Class"))
            {
                this.Hide();
                Class c = new Class();
                c.ShowDialog();
            }
            else if (s.Equals("Restaurant"))
            {
                this.Hide();
                Restaurant c = new Restaurant();
                c.ShowDialog();
            }
            else if (s.Equals("Rooms"))
            {
                this.Hide();
                Room c = new Room();
                c.ShowDialog();
            }

            else if(s.Equals("Party Hall"))
            {
                this.Hide();
                PartyHall c = new PartyHall();
                c.ShowDialog();
            }
            else if (s.Equals("Archive"))
            {
                this.Hide();
                Archive c = new Archive();
                c.ShowDialog();
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
