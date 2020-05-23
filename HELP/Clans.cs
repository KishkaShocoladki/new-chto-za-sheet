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
    public partial class Clans : Form
    {
        public Clans()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            clan f = new clan(btn.Tag.ToString());
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

        private void Clans_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dictionary<string, string> words = HELP.Menu.EnW;
            if (HELP.Menu.LANG == "RU") words = HELP.Menu.RuW;

            Text = words["СЮЖЕТНЫЕ АРКИ"];
            button7.Text = words["ПРИЗРАЧНАЯ КРОВЬ"];
            button2.Text = words["БОЕВОЕ СТРЕМЛЕНИЕ"];
            button5.Text = words["РЫЦАРИ ЗВЕЗДНОЙ ПЫЛИ"];
            button1.Text = words["НЕСОКРУШИМЫЙ АЛМАЗ"];
            button6.Text = words["ЗОЛОТОЙ ВЕТЕР"];
            button4.Text = words["КАМЕННЫЙ ОКЕАН"];
        }
    }
}
