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
    public partial class Savevfile : Form
    {
        public Savevfile()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) ||
                String.IsNullOrEmpty(textBox4.Text) ||
                String.IsNullOrEmpty(textBox3.Text) ||
                String.IsNullOrEmpty(textBox5.Text) ||
                String.IsNullOrEmpty(comboBox1.Text) ||
                String.IsNullOrEmpty(comboBox5.Text) ||
                String.IsNullOrEmpty(comboBox4.Text))
            {
                MessageBox.Show("Am I a joke to you?..");
            }
            else
            {
                System.IO.File.AppendAllText("Персонажи.txt",
                Environment.NewLine + textBox1.Text + ", " + comboBox5.Text + ", " + comboBox1.Text + ", " + comboBox4.Text);

                System.IO.File.Copy(FileName, "../../Pictures/Persons/" + textBox1.Text + ".jpg");
                System.IO.File.Copy(FileName, "../../Pictures/Persons/" + textBox1.Text + "2" + ".jpg");

                System.IO.File.WriteAllText("../../Pictures/" + textBox1.Text + "Б1" + ".txt", textBox3.Text);
                System.IO.File.WriteAllText("../../Pictures/" + textBox1.Text + "Б2" + ".txt", textBox4.Text);
                System.IO.File.WriteAllText("../../Pictures/" + textBox1.Text + ".txt", textBox5.Text);

                MessageBox.Show("Персонаж сохранен");
            }
        }

        String FileName;

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                pictureBox1.Load(FileName);
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

            Text = words["ВЫБЕРИТЕ АРКУ"];
            label1.Text = words["ИМЯ"];
            label4.Text = words["СОСТОЯНИЕ"];
            label2.Text = words["СТОРОНА"];
            label3.Text = words["ЧАСТЬ"];
            button2.Text = words["КАРТИНКА"];
            button1.Text = words["СОХРАНИТЬ"];
            label6.Text = words["ОПИСАНИЕ ПЕРСОНАЖА БЛОК 1"];
            label7.Text = words["БЛОК 2"];
            label8.Text = words["БЛОК 3"];
        }
    }
}
