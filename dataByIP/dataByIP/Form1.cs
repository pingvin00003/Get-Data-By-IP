using System;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace dataByIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();    
        }

        // Получение IP и чтение данных с IP
        private void GetDataByIpButton_Click(object sender, EventArgs e)
        {
            DataLabel.Text = "";
            string line = "";
            Match match;

            // Проверка если в TextBox ничего нету то данные читаются по IP пользователя
            if (InputIPTextBox == null)
            {
                // Читаем сайт чтобы получить IP пользователя
                using (WebClient wc = new WebClient())
                    line = wc.DownloadString($"http://free.ipwhois.io/xml/");

                // Получаем IP пользователя
                match = Regex.Match(line, "<ip>(.*?)</ip>");
                InputIPTextBox.Text = match.Groups[1].Value;
            }

            // Читаем сайт чтобы в последствии получить данные пользователя по IP который узнали выше
            using (WebClient wc = new WebClient())
                line = wc.DownloadString($"https://ipwho.is/{InputIPTextBox.Text}");

            // Тут и так все понятно
            match = Regex.Match(line, "{\"ip\":\"(.*?)\",");
            DataLabel.Text += match.Groups[1].Value;

            match = Regex.Match(line, "\"country\":\"(.*?)\",");
            DataLabel.Text += "\n" + match.Groups[1].Value;

            match = Regex.Match(line, "\"country_code\":\"(.*?)\",");
            DataLabel.Text += "\n" + match.Groups[1].Value;

            match = Regex.Match(line, "\"region\":\"(.*?)\",");
            DataLabel.Text += "\n" + match.Groups[1].Value;

            match = Regex.Match(line, "\"city\":\"(.*?)\",");
            DataLabel.Text += "\n" + match.Groups[1].Value;

            match = Regex.Match(line, "\"latitude\":(.*?),");
            DataLabel.Text += "\n" + match.Groups[1].Value;

            match = Regex.Match(line, "\"longitude\":(.*?),");
            DataLabel.Text += "\n" + match.Groups[1].Value;

            match = Regex.Match(line, "\"postal\":\"(.*?)\",");
            DataLabel.Text += "\n" + match.Groups[1].Value;

            match = Regex.Match(line, "\"org\":\"(.*?)\",");
            DataLabel.Text += "\n" + match.Groups[1].Value;

            match = Regex.Match(line, "\"isp\":\"(.*?)\",");
            DataLabel.Text += "\n" + match.Groups[1].Value;

            match = Regex.Match(line, "\"domain\":\"(.*?)\"},");
            DataLabel.Text += "\n" + match.Groups[1].Value;

            match = Regex.Match(line, "\"utc\":\"(.*?)\",");
            DataLabel.Text += "\n" + match.Groups[1].Value;

            match = Regex.Match(line, "\"current_time\":\"(.*?)\"}");
            DataLabel.Text += "\n" + match.Groups[1].Value;
        }
        
        // Кнопка информаци
        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Получить свой IP а так же данные по своему IP можно нажав на кнопку \"Получить\" без указания IP.", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Устанавливаем цвета для различных контролов при загрузки формы
        private void Form1_Load(object sender, EventArgs e)
        {
            #region DesignMainSettingsForm
            BackColor = Color.FromArgb(19, 22, 27);
            ForeColor = Color.White;
            //ForeColor = Color.FromArgb(87, 181, 223);
            #endregion

            #region DesignButtons
            GetDataByIpButton.BackColor = Color.FromArgb(41, 50, 57);
            InfoButton.BackColor = Color.FromArgb(41, 50, 57);
            CloseButton.BackColor = Color.FromArgb(41, 50, 57);
            #endregion

            #region DesignTextBox
            InputIPTextBox.BackColor = Color.FromArgb(41, 50, 57);
            InputIPTextBox.ForeColor = Color.White;
            #endregion

            #region DesignText
            label1.ForeColor = Color.FromArgb(87, 181, 223);
            label2.ForeColor = Color.FromArgb(87, 181, 223);
            CloseButton.ForeColor = Color.FromArgb(87, 181, 223);
            #endregion
        }

        // Кнопка закрытия программы
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // При наведении на данные которые получили, мы копируем их в буффер и выводим соответствующее сообщение
        private void DataLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DataLabel.Text);
            MessageBox.Show("Скопированно в буффер обмена !", "Инфо", MessageBoxButtons.OK);
        }
    }
}