using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELP
{
    public partial class prsn : Form
    {
        Per person;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Filters.team.Contains(person))
                Filters.team.Add(person);
            //Filters.team.Add(person);
        }

        public prsn(Per person1)
        {
            person = person1;
            InitializeComponent();
            Text = "Информация о " + person.name;

            try
            {
                pictureBox1.Load("../../Pictures/Persons/" + person.name + ".jpg");
                pictureBox2.Load("../../Pictures/Persons/" + person.name + "2" + ".jpg");
                textBox1.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person.name + "Б1" + ".txt");
                textBox2.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person.name + "Б2" + ".txt");
                textBox3.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + person.name + ".txt");
            }
            catch (Exception) { }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            HELP.Menu.LANG = "EN";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HELP.Menu.LANG = "RU";
        }

        private void prsn_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dictionary<string, string> words = HELP.Menu.EnW;
            if (HELP.Menu.LANG == "RU") words = HELP.Menu.RuW;

            Text = "INFORMATION ABOUT CHARACTER";
        }
    }
}
