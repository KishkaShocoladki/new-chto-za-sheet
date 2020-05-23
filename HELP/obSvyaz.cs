using System;
using System.Net;
using System.Net.Mail;
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
    public partial class obSvyaz : Form
    {
        public obSvyaz()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region
            if (textBox1.Text.Length < 20)
            {
                MessageBox.Show("Заполни пожалуйста а");
            }
            if (textBox2.Text.Length < 6)
            {
                MessageBox.Show("Заполни пожалуйста а");
            }
            #endregion
            MailAddress fromAdress = new MailAddress("kishkashockoladki@gmail.com");
            MailAddress toAdress = new MailAddress("kishkashockoladki@gmail.com");
            MailMessage message = new MailMessage(fromAdress, toAdress);
            message.Subject = "к";
            message.Body = "Раздел: " + comboBox1.Text + Environment.NewLine +
            "Кто все сломал к чертям: " + textBox2.Text + Environment.NewLine +
            "ТЕкст сообщения: " + Environment.NewLine + textBox1.Text;

            if (adres1 != "")
                message.Attachments.Add(new Attachment(adres1));
            if (adres2 != "")
                message.Attachments.Add(new Attachment(adres2));

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "NightmareFredbear");

            smtpClient.Send(message);
            MessageBox.Show("Поздравляю, вы выиграли ничего");
        }

        private void obSvyaz_Load(object sender, EventArgs e)
        {

        }
        string adres1 = "";
        string adres2 = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adres1 = openFileDialog1.FileName;
                pictureBox1.Load(adres1);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adres2 = openFileDialog1.FileName;
                pictureBox2.Load(adres2);
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

            Text = words["ОБРАТНАЯ СВЯЗЬ"];
            label2.Text = words["ТЕМА МЕССАДЖА"];
            label4.Text = words["ВАША ПОЧТА"];
            label1.Text = words["СООБЩЕНИЕ"];
            label5.Text = words["КАРТИНКА"];
            button1.Text = words["Отправляй чо хочешь все равно я ничо читать не буду"];


        }
    }
}

