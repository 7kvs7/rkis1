using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace аттестация_муниципальных_служащих
{
    public partial class attestation : Form
    {
        // Свойство для передачи ссылки на форму director
        public Form directorForm { get; set; }
        public Form QuestionnaireForm { get; set; }
        public Form comissionForm { get; set; }
        public attestation()
        {
            InitializeComponent();
            MessageBox.Show("Вы вошли в систему!");
        }

        private void Attestation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count > 0)
            {
                Form ifrm = Application.OpenForms[0];
                ifrm.StartPosition = FormStartPosition.Manual;
                ifrm.Left = this.Left;
                ifrm.Top = this.Top;
                ifrm.Show();
            }
            else
            {
                MessageBox.Show("Нет открытых форм для возврата.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Подготовительный")
            {
                Form formPodgot = new podgot();
                formPodgot.Left = this.Left;
                formPodgot.Top = this.Top;
                formPodgot.Show();
                this.Hide();
            }
        }

        private void sfsafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли ссылка на форму director
            if (this.directorForm != null)
            {
               
                // Или создаем новую форму director
                director formDirector = new director();
                formDirector.Left = this.Left;
                formDirector.Top = this.Top;
                formDirector.Show();

                this.Hide();
            }
            else
            {
                // Если ссылка не передана, создать и показать новую
                director formDirector = new director();
                formDirector.Left = this.Left;
                formDirector.Top = this.Top;
                formDirector.Show();

                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void asfafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.QuestionnaireForm != null)
            {

                // Или создаем новую форму director
                Questionnaire formQuestionnaire = new Questionnaire();
                formQuestionnaire.Left = this.Left;
                formQuestionnaire.Top = this.Top;
                formQuestionnaire.Show();

                this.Hide();
            }
            else
            {
                // Если ссылка не передана, создать и показать новую
                Questionnaire formQuestionnaire = new Questionnaire();
                formQuestionnaire.Left = this.Left;
                formQuestionnaire.Top = this.Top;
                formQuestionnaire.Show();

                this.Hide();
            }
        }

        private void ugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.comissionForm == null || this.comissionForm.IsDisposed)
            {
                // Создаем новую и сохраняем ссылку
                this.comissionForm = new comission();
                this.comissionForm.Left = this.Left;
                this.comissionForm.Top = this.Top;
                this.comissionForm.Show();

                this.Hide();
            }
            else
            {
                // Если форма уже есть, активируем её
                this.comissionForm.Show();
                this.comissionForm.BringToFront();
                this.Hide(); // или не скрывайте, зависит от логики
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}