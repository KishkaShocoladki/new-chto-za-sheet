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
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
        }

        private void persons1_Click(object sender, EventArgs e)
        {
            Persons1 f = new Persons1(persons1.Tag.ToString());
            f.Show();
        }

        private void persons2_Click(object sender, EventArgs e)
        {
            Persons1 f = new Persons1(persons2.Tag.ToString());
            f.Show();
        }

        private void persons3_Click(object sender, EventArgs e)
        {
            Persons1 f = new Persons1(persons3.Tag.ToString());
            f.Show();
        }

        private void persons4_Click(object sender, EventArgs e)
        {
            Persons1 f = new Persons1(persons4.Tag.ToString());
            f.Show();
        }

        private void persons5_Click(object sender, EventArgs e)
        {
            Persons1 f = new Persons1(persons5.Tag.ToString());
            f.Show();
        }

        private void persons6_Click(object sender, EventArgs e)
        {
            Persons1 f = new Persons1(persons6.Tag.ToString());
            f.Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            HELP.Menu.LANG = "EN";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HELP.Menu.LANG = "RU";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dictionary<string, string> words = HELP.Menu.EnW;
            if (HELP.Menu.LANG == "RU") words = HELP.Menu.RuW;

            Text = words["ВЫБЕРИТЕ АРКУ"];
            button6.Text = words["ПРИЗРАЧНАЯ КРОВЬ"];
            button1.Text = words["БОЕВОЕ СТРЕМЛЕНИЕ"];
            button2.Text = words["РЫЦАРИ ЗВЕЗДНОЙ ПЫЛИ"];
            button5.Text = words["НЕСОКРУШИМЫЙ АЛМАЗ"];
            button3.Text = words["ЗОЛОТОЙ ВЕТЕР"];
            button4.Text = words["КАМЕННЫЙ ОКЕАН"];
        }

        private void Person_Load(object sender, EventArgs e)
        {

        }
    }
}
