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
    public struct Per
    {
        public string name;
        public string sost;
        public Label b;
        public PictureBox pix;
        public string chapter;
        public string side;

        public Per(string name1, string sost1, string chapter1, string side1)
        {
            name = name1;
            sost = sost1;
            b = new Label();
            pix = new PictureBox();
            chapter = chapter1;
            side = side1;
        }
    }

    public partial class Filters : Form
    {
        public static List<Per> persons = new List<Per>();
        public static List<Per> team = new List<Per>();

        public static void fillperss()
        {
            string[] lines = System.IO.File.ReadAllLines("Персонажи.txt");
            foreach (string str in lines)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                persons.Add(new Per(parts[0], parts[1], parts[2], parts[3]));
            }
            #region
            /*
                        persons[0] = new Per("Цзинь Гуанъяо", "Мертв", 500);
                        persons[1] = new Per("Цзинь Гуань Шань", "Мертв", 500);
                        persons[2] = new Per("Цзинь Лин", "Жив", 15);
                        persons[3] = new Per("Цзинь Цзы Сюань", "Мертв", 500);
                        persons[4] = new Per("Цзян Фэн Мянь", "Мертв", 500);
                        persons[5] = new Per("Цзян Чэн", "Жив", 34);
                        persons[6] = new Per("Вей Усянь", "Мертв", 35);
                        persons[7] = new Per("Цзян Янь Ли", "Мертв", 500);
                        persons[8] = new Per("Лань Ван Цзы", "Жив", 35);
                        persons[9] = new Per("Лань Сичень", "Жив", 38);
                        persons[10] = new Per("Лань Сычжуй и Лань Цзинъи", "Жив", 15 - 16);
                        persons[11] = new Per("Лань Цижэнь", "Мертв", 500);
                        persons[12] = new Per("Вэнь Жо Хань", "Мертв", 500);
                        persons[13] = new Per("Вэнь Нин", "Мертв", 34);
                        persons[14] = new Per("Вэнь Цин", "Мертв", 500);
                        persons[15] = new Per("Вэнь Чжао", "Мертв", 500);
                        persons[16] = new Per("Не Хуай Сан", "Жив", 34);
                        persons[17] = new Per("Не Мин Цзюэ", "Мертв", 500);
                */
            #endregion
            int x = 20;
            int y = 250;
            for (int i = 0; i < persons.Count; i = i + 1)
            {
                persons[i].pix.Location = new Point(x, y);
                persons[i].pix.Size = new Size(300, 390);
                persons[i].pix.Text = persons[i].name;
                persons[i].pix.SizeMode = PictureBoxSizeMode.Zoom;
                persons[i].pix.Click += new EventHandler(button2_Click);
                try
                {
                    persons[i].pix.Load("../../Pictures/Persons/" + persons[i].name + ".jpg");
                }
                catch (Exception) { }

                persons[i].b.Location = new Point(x, y + 390);
                persons[i].b.Size = new Size(300, 40);
                persons[i].b.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                persons[i].b.ForeColor = System.Drawing.SystemColors.ControlDark;
                persons[i].b.Text = persons[i].name;

                x = x + 310;
                if (x + 300 > 800)
                {
                    x = 20;
                    y = y + 430;
                }
            }
        }

        public Filters()
        {
            InitializeComponent();
            foreach (Per per in persons)
            {
                Controls.Add(per.b);
                Controls.Add(per.pix);
            }

        }

        private void Filters_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 20;
            int y = 250;
            for (int i = 0; i < persons.Count; i = i + 1)
            {
                persons[i].b.Visible = false;
                persons[i].pix.Visible = false;
                bool show = true;

                if (nameBox1.Text != "" && persons[i].name != nameBox1.Text)
                {
                    show = false;
                }
                else if (sostBox2.Text != "" && persons[i].sost != sostBox2.Text)
                {
                    show = false;
                }
                else if (ageBox3.Text != "" && persons[i].side != ageBox3.Text)
                {
                    show = false;
                }
                else if (comboBox1.Text != "" && persons[i].chapter != comboBox1.Text)
                {
                    show = false;
                }

                if (show)
                {
                    persons[i].pix.Visible = true;
                    persons[i].pix.Location = new Point(x, y);
                    persons[i].b.Visible = true;
                    persons[i].b.Location = new Point(x, y + 390);
                    x = x + 310;
                    if (x + 300 > 800)
                    {
                        x = 20;
                        y = y + 430;
                    }
                }
            }
        }

        public static void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < persons.Count; i = i + 1)
            {
                if (((PictureBox)sender).Image == persons[i].pix.Image)
                {
                    prsn f = new prsn(persons[i]);
                    f.Show();
                }
            }
        }

       // int startTime = 0;

       /* private void неСмотриСюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startTime = Environment.TickCount;
            label5.Visible = true;
        }*/

       /* private void timer1_Tick(object sender, EventArgs e)
        {
            if (Environment.TickCount - startTime < 5000)
            {
                persons[5].pix.ForeColor = Color.Blue;
                persons[6].pix.ForeColor = Color.Blue;
                persons[8].pix.ForeColor = Color.Blue;
                persons[13].pix.ForeColor = Color.Blue;
                persons[16].pix.ForeColor = Color.Blue;
                label5.Visible = true;
            }
            else
            {
                persons[5].pix.ForeColor = Color.White;
                persons[6].pix.ForeColor = Color.White;
                persons[8].pix.ForeColor = Color.White;
                persons[13].pix.ForeColor = Color.White;
                persons[16].pix.ForeColor = Color.White;
                label5.Visible = false;
            }

        }*/
        private void button9_Click(object sender, EventArgs e)
        {
            HELP.Menu.LANG = "EN";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HELP.Menu.LANG = "RU";
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Dictionary<string, string> words = HELP.Menu.EnW;
            if (HELP.Menu.LANG == "RU") words = HELP.Menu.RuW;

            Text = words["ФИЛЬТР"];
            label1.Text = words["ПОИСК"];
            label2.Text = words["ИМЯ"];
            label3.Text = words["СОСТОЯНИЕ"];
            label4.Text = words["СТОРОНА"];
            label6.Text = words["ЧАСТЬ"];
            button1.Text = words["ИСКАТЬ"];
        }
    }
   
}
