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
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();
            ReDraw();
        }

        void ReDraw()
        { 
            Controls.Clear();
            Controls.Add(button1);
            Controls.Add(button9);
            Controls.Add(button10);
            
            int x = 20;
            int y = 80;
            foreach (Per per in Filters.team)
            {
                PictureBox pix = new PictureBox();
                Label but = new Label();


                pix.Text = per.pix.Text;
                pix.Size = new Size(200, 266);
                pix.SizeMode = per.pix.SizeMode;
                pix.Location = new Point(x, y);
                pix.Click += new EventHandler(Filters.button2_Click);
                //pix.Location = per.pix.Location;
                pix.Image = per.pix.Image;

                but.Location = new Point(x, y + 100);
                but.Size = per.b.Size;
                but.Text = per.b.Text;
                
                Button b = new Button();
                b.Size = new Size(30, 266);
                b.Text = "DELETE";
                b.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                b.ForeColor = System.Drawing.SystemColors.ControlDark;
                b.Location = new Point(x + 210, y);
                b.Click += new EventHandler(Delete);

                Controls.Add(b);
                Controls.Add(pix);
                Controls.Add(but);
                
               
             //  x = x + 280;
              // if (x + 260 > 285)
               // {
                 //  x = 20;
                   y = y + 270;
               // }
            }


    void Delete(object sender, EventArgs e)
    {
        int i = 0;
        Button b = (Button)sender;

        List<Per> team1 = new List<Per>();

        foreach (Per per in Filters.team)
        {
          if (b.Location == new Point(20 + 210, 80 + 270 * i))
            { }
            else
            {
              team1.Add(per);
            }
            i = i + 1;
        }
        Filters.team = team1;
        ReDraw();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dictionary<string, string> words = HELP.Menu.EnW;
            if (HELP.Menu.LANG == "RU") words = HELP.Menu.RuW;

            button1.Text = words["СПИСОК ПЕРСОНАЖЕЙ, ВЫБРАННЫХ ВАМИ"];
        }

        private void Team_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Email f = new Email();
            f.Show();

        }
    }

}


        //private void button1_Click(object sender, EventArgs e)
        //{
          //  Email f = new Email();
          //  f.Show();
        //}



