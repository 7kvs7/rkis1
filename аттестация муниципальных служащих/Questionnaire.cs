using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace аттестация_муниципальных_служащих
{
    public partial class Questionnaire : Form
    {
        private QuestionnaireData questionnaireData; // Экземпляр данных

        public Questionnaire()
        {
            InitializeComponent();

            // Создаем объект данных
            questionnaireData = new QuestionnaireData();

            // Привязка данных к элементам формы
            textBox1.DataBindings.Add("Text", questionnaireData, "FIO");
            textBox2.DataBindings.Add("Text", questionnaireData, "Age");
            // Добавьте остальные привязки по необходимости

            // Обработчик кнопки для сохранения
            button1.Click += (s, args) => {
                this.Validate(); // Обновляем привязки
                SaveToAttestation(questionnaireData);
            };

            // Подключаем событие закрытия формы
            this.FormClosed += Questionnaire_FormClosed;
        }

        private void SaveToAttestation(QuestionnaireData data)
        {
            // Реализуйте сохранение данных по необходимости
        }

        private void Questionnaire_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Находим форму attestation и показываем её
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
                // Восстановление позиции
                attestationForm.StartPosition = FormStartPosition.Manual;
                attestationForm.Left = this.Left;
                attestationForm.Top = this.Top;

                // Показываем attestation
                attestationForm.Show();
            }
            else
            {
                MessageBox.Show("Форма attestation не найдена!");
            }
        }
    }

    public class QuestionnaireData : INotifyPropertyChanged
    {
        private string fio;
        public string FIO
        {
            get => fio;
            set { fio = value; OnPropertyChanged(nameof(FIO)); }
        }

        private string age;
        public string Age
        {
            get => age;
            set { age = value; OnPropertyChanged(nameof(Age)); }
        }

        private string position;
        public string Position
        {
            get => position;
            set { position = value; OnPropertyChanged(nameof(Position)); }
        }

        private string department;
        public string Department
        {
            get => department;
            set { department = value; OnPropertyChanged(nameof(Department)); }
        }

        private string phone;
        public string Phone
        {
            get => phone;
            set { phone = value; OnPropertyChanged(nameof(Phone)); }
        }

        private string email;
        public string Email
        {
            get => email;
            set { email = value; OnPropertyChanged(nameof(Email)); }
        }

        private decimal workExperience;
        public decimal WorkExperience
        {
            get => workExperience;
            set { workExperience = value; OnPropertyChanged(nameof(WorkExperience)); }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set { birthDate = value; OnPropertyChanged(nameof(BirthDate)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}