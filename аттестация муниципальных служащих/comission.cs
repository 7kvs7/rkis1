using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace аттестация_муниципальных_служащих
{
    public partial class comission : Form
    {
        public comission()
        {
            InitializeComponent();

            this.FormClosed += comissionFormClosed;
        }
        private void comissionFormClosed(object sender, FormClosedEventArgs e)
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

