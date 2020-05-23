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
    public partial class clan : Form
    {
        void drawPicture(Button button, PictureBox pictureBox)
        {
            if (button.Text != "")
            {
                pictureBox.Load("../../Pictures/Persons/" + button.Text + ".jpg");
                for (int i = 0; i < Filters.persons.Count; i++)
                {
                    if (button.Text == Filters.persons[i].name)
                    {
                        pictureBox.Image = Filters.persons[i].pix.Image;
                    }
                }
            }
            else
            {
                button.Visible = false;
                pictureBox.Visible = false;
            }
        }
        public clan(string clan)
        {
            InitializeComponent();

            if (clan == "Призрачная Кровь")
            {
                pictureBox1.Load("../../Pictures/phantomb.jpg");
            }
            else if (clan == "Боевое Стремление")
            {
                pictureBox1.Load("../../Pictures/battletendency.jpg");
            }
            else if (clan == "Рыцари Звездной Пыли")
            {
                pictureBox1.Load("../../Pictures/stardustcrusaders.jpg");
            }
            else if (clan == "Несокрушимый Алмаз")
            {
                pictureBox1.Load("../../Pictures/diamondisunbreakable.jpg");
            }
            else if (clan == "Золотой Ветер")
            {
                pictureBox1.Load("../../Pictures/ventoaureo.jpg");
            }
            else if (clan == "Каменный Океан")
            {
                pictureBox1.Load("../../Pictures/stoneocean.jpg");
            }
            else if (clan == "Гонка Стальной Шар")
            {
                pictureBox1.Load("../../Pictures/steelballrun.jpg");
            }
            else if (clan == "ДжоДжолион")
            {
                pictureBox1.Load("../../Pictures/jojolion.jpg");
            }

            int x = 650;
            int y = 35;
            foreach (Per per in Filters.persons)
            {
                if (per.chapter == clan)
                {
                    PictureBox pix = new PictureBox();
                    Label but = new Label();


                    pix.Text = per.pix.Text;
                    pix.Size = new Size(280, 280);
                    pix.SizeMode = per.pix.SizeMode;
                    pix.Location = new Point(x, y);
                    pix.Click += new EventHandler(Filters.button2_Click);
                    pix.Image = per.pix.Image;

                    but.Location = new Point(x, y + 280);
                    but.Size = new Size(280, 45);
                    but.Text = per.b.Text;
                    but.TextAlign = ContentAlignment.MiddleCenter;
                    but.Font = new Font("Arial", 14);

                    Controls.Add(pix);
                    Controls.Add(but);

                    x = x + 280;
                    if (x + 280 > Width)
                    {
                        x = 650;
                        y = y + 300;
                    }
                }
            }
            
            Text = "ИНФОРМАЦИЯ ОБ АРКЕ: " + clan;

            if (clan == "Призрачная кровь")
            {
                pictureBox1.Load("../../Pictures/phantomb.jpg");
            }
            else if (clan == "Боевое стремление")
            {
                pictureBox1.Load("../../Pictures/battletendency.jpg");
            }
            else if (clan == "Рыцари звездной пыли")
            {
                pictureBox1.Load("../../Pictures/stardustcrusaders.jpg");
            }
            else if (clan == "Несокрушимый алмаз")
            {
                pictureBox1.Load("../../Pictures/diamondisunbreakable.jpg");
            }
            else if (clan == "Золотой ветер")
            {
                pictureBox1.Load("../../Pictures/ventoaureo.jpg");
            }
            else if (clan == "Каменный океан")
            {
                pictureBox1.Load("../../Pictures/stoneocean.jpg");
            }
            else if (clan == "Гонка стальной шар")
            {
                pictureBox1.Load("../../Pictures/steelballrun.jpg");
            }
            else if (clan == "ДжоДжолион")
            {
                pictureBox1.Load("../../Pictures/jojolion.jpg");
            }

            try
            {
                textBox1.Lines =
                  System.IO.File.ReadAllLines("../../Pictures/" + clan + "Б1" + ".txt");
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

        private void clan_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dictionary<string, string> words = HELP.Menu.EnW;
            if (HELP.Menu.LANG == "RU") words = HELP.Menu.RuW;
            if (HELP.Menu.LANG == "EN") Text = "INFORMATION ABOUT ARCH";
            label1.Text = words["ПЕРСОНАЖИ, ФИГУРИРУЮЩИЕ В СЮЖЕТНОЙ АРКЕ"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
