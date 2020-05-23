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
    public partial class download : Form
    {
        public download()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mangalib.me/jojo-no-kimyou-na-bouken-part-7-steel-ball-run-solored");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mangalib.me/phantom-blood%28colored%29");
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mangalib.me/diamond-wa-kudakenai");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mangalib.me/battle-tendency-colored");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mangalib.me/jojo-no-kimyou-na-bouken-part-3-sutadasuto-kuruseidasu-full-colored");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mangalib.me/jojo-no-kimyou-na-bouken-part-5-vento-aureo");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mangalib.me/jojo-no-kimyou-na-bouken-part-6-stone-ocean-solored");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mangalib.me/jojo-no-kimyou-na-bouken-part-8-jojorion");
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

            Text = words["ЧИТАТЬ МАНГУ JOJO'S BIZZARE ADVENTURE"];
        }
    }
}
