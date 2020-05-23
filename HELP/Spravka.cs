using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELP
{
    public partial class Spravka : Form
    {
        public Spravka()
        {
            InitializeComponent();
            textBox1.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + "JOJO" + ".txt");
        }
        private void персонажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Lines =
                    System.IO.File.ReadAllLines("../../Pictures/" + "Персонажи" + ".txt");
        }
        private void кланыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + "Арки" + ".txt");
        }
        private void button1_Click(object sender, EventArgs e)
        {
           download f = new download();
           f.Show();
            /* WebClient webC = new WebClient();
            webC.DownloadFileAsync(new Uri("https://royallib.com/get/txt/annette_liu/magistr_dyavolskogo_kulta.zip"),                                                 //"https://www.bookvoed.ru/files/3515/37/07/5.pdf"
                "C:\\Users\\" + Environment.UserName + "\\Downloads\\MDK.zip");
            MessageBox.Show("Сохранено в MDK.zip");*/
        }
        private void button2_Click(object sender, EventArgs e)
        {
            obSvyaz f = new obSvyaz();
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

            Text = words["СПРАВКА"];
            button2.Text = words["ОБРАТНАЯ СВЯЗЬ"];
            button1.Text = words["ССЫЛКИ НА ТОМА МАНГИ"];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
