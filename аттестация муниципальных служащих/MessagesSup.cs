using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace аттестация_муниципальных_служащих
{
    public partial class MessagesSup : Form
    {
        private int currentMessageIndex = 0; // текущий индекс сообщения
        private List<string> allMessages;
        private int currentIndex;

        public MessagesSup()
        {
            InitializeComponent();

            // Важное: подключите обработчики событий кнопок
            this.button1.Click += new EventHandler(button1_Click);
            this.button2.Click += new EventHandler(button2_Click);

            // Можно добавить обработчик загрузки формы
            this.Load += MessagesSup_Load;
        }

        /// <summary>
        /// Метод для передачи сообщений и начального индекса
        /// </summary>
        /// <param name="messages">Список сообщений</param>
        /// <param name="index">Начальный индекс</param>
        public void SetMessages(List<string> messages, int index)
        {
            allMessages = messages;
            // Если список null или пустой, покажем сообщение "Нет сообщений"
            if (allMessages == null || allMessages.Count == 0)
            {
                allMessages = new List<string> { "Нет сообщений" };
                currentIndex = 0;
            }
            else
            {
                // Проверка, чтобы индекс был в пределах
                if (index < 0) index = 0;
                if (index >= allMessages.Count) index = allMessages.Count - 1;
                currentIndex = index;
            }
            DisplayCurrentMessage();
        }

        private void DisplayCurrentMessage()
        {
            if (allMessages == null || allMessages.Count == 0)
            {
                richTextBox1.Text = "Нет сообщений";
                button1.Enabled = false;
                button2.Enabled = false;
                return;
            }

            // Безопасно выберите сообщение по индексу
            if (currentIndex < 0) currentIndex = 0;
            if (currentIndex >= allMessages.Count) currentIndex = allMessages.Count - 1;

            richTextBox1.Text = allMessages[currentIndex];
            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            button1.Enabled = currentIndex > 0;
            button2.Enabled = currentIndex < allMessages.Count - 1;
        }

        // Обработчик кнопки "Вперед" (следующее сообщение)
        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex < allMessages.Count - 1)
            {
                currentIndex++;
                DisplayCurrentMessage();
            }
        }

        // Обработчик кнопки "Назад" (предыдущее сообщение)
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayCurrentMessage();
            }
        }

        private void MessagesSup_Load(object sender, EventArgs e)
        {
            // Можно оставить пустым или установить начальное сообщение
            if (allMessages != null && allMessages.Count > 0)
            {
                DisplayCurrentMessage();
            }
            else
            {
                richTextBox1.Text = "Нет сообщений";
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
    }
}