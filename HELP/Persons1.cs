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
    public partial class Persons1 : Form
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


        public Persons1(string chapter)
        {
            InitializeComponent();

            int x = 10;
            int y = 10;
            foreach (Per per in Filters.persons)
            {
                if (per.chapter == chapter)
                {
                    PictureBox pix = new PictureBox();
                    Label but = new Label();


                    pix.Text = per.pix.Text;
                    pix.Size = new Size(280, 280);
                    pix.SizeMode = per.pix.SizeMode;
                    pix.Location = new Point(x, y);
                    pix.Click += new EventHandler(Filters.button2_Click);
                    pix.Image = per.pix.Image;

                    but.Location = new Point(x, y + 283);
                    but.Size = new Size(280, 40);
                    but.Text = per.b.Text;
                    but.TextAlign = ContentAlignment.MiddleCenter;
                    but.Font = new Font("Arial", 18);

                    Controls.Add(pix);
                    Controls.Add(but);

                    x = x + 280;
                    if (x + 250 > Width)
                    {
                        x = 10;
                        y = y + 300;
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HELP.Menu.LANG = "EN";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HELP.Menu.LANG = "RU";
        }
        private void Persons1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dictionary<string, string> words = HELP.Menu.EnW;
            if (HELP.Menu.LANG == "RU") words = HELP.Menu.RuW;

            Text = words["ПЕРСОНАЖИ"];
        }
    }
}