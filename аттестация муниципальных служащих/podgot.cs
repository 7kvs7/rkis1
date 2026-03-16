using System;
using System.Drawing;
using System.Windows.Forms;

namespace аттестация_муниципальных_служащих
{
    public partial class podgot : Form
    {
        // Переменные для передачи данных
        public Form osnovForm { get; set; }
        public Form zacluchForm { get; set; }
        public Form metodicsForm { get; set; }
        public Form normdocumentsForm { get; set; }
        public Form MessagesSupForm { get; set; }
        public Form allquestionnairiesForm { get; set; }

        public User user;
        public string status;
        public DateTime? startDate;

        private int elapsedSeconds = 0;

        public podgot()
        {
            InitializeComponent();

            button1 = new Button
            {
                Text = "Утвердить дату",
                Visible = false 
            };
            button1.Click += Button1_Click;
            this.Controls.Add(button1);

            
            progressBar1 = new ProgressBar
            {
                Minimum = 0,
                Maximum = 60, // например, 60 секунд
                Value = 0
            };
            this.Controls.Add(progressBar1);

            // Настройка таймера
            timer1 = new Timer();
            timer1.Interval = 1000; // 1 секунда
            timer1.Tick += timer1_Tick;
            timer1.Start();

            this.FormClosed += podgot_FormClosed;
            this.Load += Form_Load; // Для вызова метода при загрузке формы
        }

        private void podgot_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ищем форму attestation
            Form attestationForm = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form is attestation)
                {
                    attestationForm = form;
                    break;
                }
            }

            if (attestationForm != null)
            {
                attestationForm.StartPosition = FormStartPosition.Manual;
                attestationForm.Left = this.Left;
                attestationForm.Top = this.Top;

                attestationForm.Show();
            }
            else
            {
                MessageBox.Show("Форма attestation не найдена!");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            progressBar1.Value = Math.Min(elapsedSeconds, progressBar1.Maximum);

            if (elapsedSeconds >= 60)
            {
                MessageBox.Show("Минуту прошло!");
                timer1.Stop();
            }
        }

        // Загрузка формы
        private void Form_Load(object sender, EventArgs e)
        {
            if (user != null && user.RoleName == "Директор")
            {
                // Для директора
                button1.Visible = true;
                label1.Text = "Статус: " + (status ?? "не утверджен");
                label2.Text = "Дата начала: " + (startDate?.ToString("dd.MM.yyyy") ?? "не утверджена");
            }
            else
            {
                // Для остальных
                button1.Visible = false;
                label1.Text = "Статус: " + (status ?? "не утверджен");
                label2.Text = "Дата начала: " + (startDate?.ToString("dd.MM.yyyy") ?? "не утверджена");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Утверждаем текущую дату
            startDate = DateTime.Now;
            // Обновляем метку (предполагается, что есть label2)
            label2.Text = startDate?.ToString("dd.MM.yyyy");
            MessageBox.Show("Дата утверждена!");
            // Здесь можно добавить сохранение в базу данных
        }

        private void основнойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли ссылка на форму director
            if (this.osnovForm != null)
            {

                // Или создаем новую форму director
                osnov formOsnov = new osnov();
                formOsnov.Left = this.Left;
                formOsnov.Top = this.Top;
                formOsnov.Show();

                this.Hide();
            }
            else
            {
                // Если ссылка не передана, создать и показать новую
                osnov formOsnov = new osnov();
                formOsnov.Left = this.Left;
                formOsnov.Top = this.Top;
                formOsnov.Show();

                this.Hide();
            }
        }

        private void заключительныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.zacluchForm != null)
            {

                // Или создаем новую форму director
                zacluch formZacluch = new zacluch();
                formZacluch.Left = this.Left;
                formZacluch.Top = this.Top;
                formZacluch.Show();

                this.Hide();
            }
            else
            {
                // Если ссылка не передана, создать и показать новую
                zacluch formZacluch = new zacluch();
                formZacluch.Left = this.Left;
                formZacluch.Top = this.Top;
                formZacluch.Show();

                this.Hide();
            }
        }

        private void разработкаМетодикПроведенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.metodicsForm != null)
            {

                // Или создаем новую форму director
                metodics formMetodics = new metodics();
                formMetodics.Left = this.Left;
                formMetodics.Top = this.Top;
                formMetodics.Show();

                this.Hide();
            }
            else
            {
                // Если ссылка не передана, создать и показать новую
                metodics formMetodics = new metodics();
                formMetodics.Left = this.Left;
                formMetodics.Top = this.Top;
                formMetodics.Show();

                this.Hide();
            }
        }

        private void подготовкаНормативныхДокументовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.normdocumentsForm != null)
            {

                // Или создаем новую форму director
                normdocuments formNormDocuments = new normdocuments();
                formNormDocuments.Left = this.Left;
                formNormDocuments.Top = this.Top;
                formNormDocuments.Show();
                this.Hide();
            }
            else
            {
                // Если ссылка не передана, создать и показать новую
                normdocuments formNormDocuments = new normdocuments();
                formNormDocuments.Left = this.Left;
                formNormDocuments.Top = this.Top;
                formNormDocuments.Show();
                this.Hide();
            }
        }

        private void сообщениеРуководителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MessagesSupForm != null)
            {

                // Или создаем новую форму director
                MessagesSup formMessagesSup = new MessagesSup();
                formMessagesSup.Left = this.Left;
                formMessagesSup.Top = this.Top;
                formMessagesSup.Show();
                this.Hide();
            }
            else
            {
                // Если ссылка не передана, создать и показать новую
                MessagesSup formMessagesSup = new MessagesSup();
                formMessagesSup.Left = this.Left;
                formMessagesSup.Top = this.Top;
                formMessagesSup.Show();
                this.Hide();
            }
        }

        private void анкетаСлужащегоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Объявляем переменную заранее
            allquestionnairies formAllquestionnairies;

            if (this.allquestionnairiesForm != null)
            {
                formAllquestionnairies = new allquestionnairies();
            }
            else
            {
                formAllquestionnairies = new allquestionnairies();
            }

            // Устанавливаем позицию
            formAllquestionnairies.Left = this.Left;
            formAllquestionnairies.Top = this.Top;
            formAllquestionnairies.Show();

            this.Hide();

    }
    }

    // Предположим, что есть класс User
    public class User
    {
        public string RoleName { get; set; }
        // другие свойства
    }

    // Тут предполагается, что у вас есть класс attestation
    public partial class attestation : Form
    {
        // реализация...
    }
}