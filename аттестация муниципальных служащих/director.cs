using System;
using System.Windows.Forms;

namespace аттестация_муниципальных_служащих
{
    public partial class director : Form
    {
        public director()
        {
            InitializeComponent();

            // Связываем событие с методом
            this.FormClosed += director_FormClosed;
        }

        private void director_FormClosed(object sender, FormClosedEventArgs e)
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
}

