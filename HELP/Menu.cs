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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Filters.fillperss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person form2 = new Person();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clans form3 = new Clans();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Spravka form8 = new Spravka();
            form8.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Filters form8 = new Filters();
            //form8.Show();
            form8.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Team f = new Team();
            f.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Savevfile f = new Savevfile();
            f.Show();
        }

        public static string LANG = "RU";
        public static Dictionary<string, string> EnW = new Dictionary<string, string>();
        public static Dictionary<string, string> RuW = new Dictionary<string, string>();

        private void Menu_Load_1(object sender, EventArgs e)
        {
            EnW.Add("ПЕРСОНАЖИ", "CHARACTERS");
            EnW.Add("СЮЖЕТНЫЕ АРКИ", "STORY ARCHES");
            EnW.Add("СПРАВКА", "HELP");
            EnW.Add("ДОБАВИТЬ ПЕРСОНАЖА", "ADD CHARACTER");
            EnW.Add("ФИЛЬТР", "FILTER");
            RuW.Add("ПЕРСОНАЖИ", "ПЕРСОНАЖИ");
            RuW.Add("СЮЖЕТНЫЕ АРКИ", "СЮЖЕТНЫЕ АРКИ");
            RuW.Add("СПРАВКА", "СПРАВКА");
            RuW.Add("ДОБАВИТЬ ПЕРСОНАЖА", "ДОБАВИТЬ ПЕРСОНАЖА");
            RuW.Add("ФИЛЬТР", "ФИЛЬТР");

            EnW.Add("ПЕРСОНАЖИ, ФИГУРИРУЮЩИЕ В СЮЖЕТНОЙ АРКЕ", "CHARACTERS IN THE STORY ARCH");
            EnW.Add("ВЫБЕРИТЕ АРКУ", "SELECT ARCH");
            EnW.Add("ПРИЗРАЧНАЯ КРОВЬ", "Phantom Blood");
            EnW.Add("БОЕВОЕ СТРЕМЛЕНИЕ", "Battle Tendency");
            EnW.Add("РЫЦАРИ ЗВЕЗДНОЙ ПЫЛИ", "Stardust Crusaders");
            EnW.Add("НЕСОКРУШИМЫЙ АЛМАЗ", "Diamond is Unbreakable");
            EnW.Add("ЗОЛОТОЙ ВЕТЕР", "Vento Aureo");
            EnW.Add("КАМЕННЫЙ ОКЕАН", "Stone Ocean");
            EnW.Add("ГОНКА «СТАЛЬНОЙ ШАР»", "Steel Ball Run");
            EnW.Add("ДЖОДЖОЛИОН", "JoJolion");
            RuW.Add("ПЕРСОНАЖИ, ФИГУРИРУЮЩИЕ В СЮЖЕТНОЙ АРКЕ", "ПЕРСОНАЖИ, ФИГУРИРУЮЩИЕ В СЮЖЕТНОЙ АРКЕ");
            RuW.Add("ВЫБЕРИТЕ АРКУ", "ВЫБЕРИТЕ АРКУ");
            RuW.Add("ПРИЗРАЧНАЯ КРОВЬ", "Призрачная Кровь");
            RuW.Add("БОЕВОЕ СТРЕМЛЕНИЕ", "Боевое Стремление");
            RuW.Add("РЫЦАРИ ЗВЕЗДНОЙ ПЫЛИ", "Рыцари Звездной Пыли");
            RuW.Add("НЕСОКРУШИМЫЙ АЛМАЗ", "Несокрушимый Алмаз");
            RuW.Add("ЗОЛОТОЙ ВЕТЕР", " Золотой Ветер");
            RuW.Add("КАМЕННЫЙ ОКЕАН", "Каменный Океан");
            RuW.Add("ГОНКА «СТАЛЬНОЙ ШАР»", "Гонка «Стальной Шар»");
            RuW.Add("ДЖОДЖОЛИОН", "ДжоДжолион");

            EnW.Add("ОБРАТНАЯ СВЯЗЬ", "FEEDBACK");
            EnW.Add("ССЫЛКИ НА ТОМА МАНГИ", "Links to manga volumes");
            RuW.Add("ОБРАТНАЯ СВЯЗЬ", "ОБРАТНАЯ СВЯЗЬ");
            RuW.Add("ССЫЛКИ НА ТОМА МАНГИ", "ССЫЛКИ НА ТОМА МАНГИ");

            EnW.Add("ЧИТАТЬ МАНГУ JOJO'S BIZZARE ADVENTURE", "READ MANGA JOJO'S BIZZARE ADVENTURE");
            RuW.Add("ЧИТАТЬ МАНГУ JOJO'S BIZZARE ADVENTURE", "ЧИТАТЬ МАНГУ JOJO'S BIZZARE ADVENTURE");

            EnW.Add("СКАЧАТЬ МАНГУ JOJO'S BIZZARE ADVENTURE: PHANTOM BLOOD", "DOWNLOAD MANGA JOJO'S BIZZARE ADVENTURE: PHANTOM BLOOD");
            EnW.Add("СКАЧАТЬ ТОМ 1", "DOWNLOAD VOLUME 1");
            EnW.Add("СКАЧАТЬ ТОМ 2", "DOWNLOAD VOLUME 2");
            EnW.Add("СКАЧАТЬ ТОМ 3", "DOWNLOAD VOLUME 3");
            EnW.Add("СКАЧАТЬ ТОМ 4", "DOWNLOAD VOLUME 4");
            EnW.Add("СКАЧАТЬ ТОМ 5", "DOWNLOAD VOLUME 5");
            RuW.Add("СКАЧАТЬ МАНГУ JOJO'S BIZZARE ADVENTURE: PHANTOM BLOOD", "СКАЧАТЬ МАНГУ JOJO'S BIZZARE ADVENTURE: PHANTOM BLOOD");
            RuW.Add("СКАЧАТЬ ТОМ 1", "СКАЧАТЬ ТОМ 1");
            RuW.Add("СКАЧАТЬ ТОМ 2", "СКАЧАТЬ ТОМ 2");
            RuW.Add("СКАЧАТЬ ТОМ 3", "СКАЧАТЬ ТОМ 3");
            RuW.Add("СКАЧАТЬ ТОМ 4", "СКАЧАТЬ ТОМ 4");
            RuW.Add("СКАЧАТЬ ТОМ 5", "СКАЧАТЬ ТОМ 5");

            EnW.Add("ТЕМА МЕССАДЖА", "MESSAGE SUBJECT");
            EnW.Add("ВАША ПОЧТА", "YOUR E-MAIL");
            EnW.Add("СООБЩЕНИЕ", "MESSAGE");
            EnW.Add("КАРТИНКА", "PICTURE");
            EnW.Add("Отправляй чо хочешь все равно я ничо читать не буду", "Send what you want i still will not read it");
            RuW.Add("ТЕМА МЕССАДЖА", "ТЕМА МЕССАДЖА");
            RuW.Add("ВАША ПОЧТА", "ВАША ПОЧТА");
            RuW.Add("СООБЩЕНИЕ", "СООБЩЕНИЕ");
            RuW.Add("КАРТИНКА", "КАРТИНКA");
            RuW.Add("Отправляй чо хочешь все равно я ничо читать не буду", "Отправляй чо хочешь все равно я ничо читать не буду");

            EnW.Add("ПОИСК", "SEARCH");
            EnW.Add("ИМЯ", "NAME");
            EnW.Add("СОСТОЯНИЕ", "STATE");
            EnW.Add("СТОРОНА", "SIDE");
            EnW.Add("ЧАСТЬ", "STORY ARCH");
            EnW.Add("ИСКАТЬ", "SEARCH");
            RuW.Add("ПОИСК", "ПОИСК");
            RuW.Add("ИМЯ", "ИМЯ");
            RuW.Add("СОСТОЯНИЕ", "СОСТОЯНИЕ");
            RuW.Add("СТОРОНА", "СТОРОНА");
            RuW.Add("ЧАСТЬ", "АРКА");
            RuW.Add("ИСКАТЬ", "ИСКАТЬ");

            EnW.Add("ДОБАВЛЕНИЕ ПЕРСОНАЖА", "ADDING CHARACTER");
            EnW.Add("СОХРАНИТЬ", "SAVE");
            EnW.Add("ОПИСАНИЕ ПЕРСОНАЖА БЛОК 1", "CHARACTER DESCRIPTION BLOCK 1");
            EnW.Add("БЛОК 2", "BLOCK 2");
            EnW.Add("БЛОК 3", "BLOCK 3");
            RuW.Add("ДОБАВЛЕНИЕ ПЕРСОНАЖА", "ДОБАВЛЕНИЕ ПЕРСОНАЖА");
            RuW.Add("СОХРАНИТЬ", "СОХРАНИТЬ");
            RuW.Add("ОПИСАНИЕ ПЕРСОНАЖА БЛОК 1", "ОПИСАНИЕ ПЕРСОНАЖА БЛОК 1");
            RuW.Add("БЛОК 2", "БЛОК 2");
            RuW.Add("БЛОК 3", "БЛОК 3");

            EnW.Add("СПИСОК ПЕРСОНАЖЕЙ, ВЫБРАННЫХ ВАМИ", "LIST OF CHARACTERS YOU HAVE SELECTED");
            RuW.Add("СПИСОК ПЕРСОНАЖЕЙ, ВЫБРАННЫХ ВАМИ", "СПИСОК ПЕРСОНАЖЕЙ, ВЫБРАННЫХ ВАМИ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LANG = "EN";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LANG = "RU";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dictionary<string, string> words = EnW;
            if (LANG == "RU") words = RuW;
            button1.Text = words["ПЕРСОНАЖИ"];
            button3.Text = words["СЮЖЕТНЫЕ АРКИ"];
            button4.Text = words["СПРАВКА"];
            button5.Text = words["ДОБАВИТЬ ПЕРСОНАЖА"];
            button6.Text = words["ФИЛЬТР"];
        }
    }
}
