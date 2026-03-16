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
    public partial class osnov : Form
    {
        public Form podgotForm { get; set; }
        public Form zacluchForm { get; set; }
        public Form partisipantsForm { get; set; }
        public Form QAForm { get; set; }
        public Form votingForm { get; set; }

        public osnov()
        {
            InitializeComponent();
        }

        private void подготовительныйToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.podgotForm == null)
            {
                this.podgotForm = new podgot();
            }
            else
            {

                this.podgotForm = new podgot();
            }


            this.podgotForm.Left = this.Left;
            this.podgotForm.Top = this.Top;

            this.podgotForm.Show();

            this.Hide();
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

        private void участникиАттестацииToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.partisipantsForm != null)
            {
                partisipants formPartisipants = new partisipants();
                formPartisipants.Left = this.Left;
                formPartisipants.Top = this.Top;
                formPartisipants.Show();

                this.Hide();
            }
            else
            {
                partisipants formPartisipants = new partisipants();
                formPartisipants.Left = this.Left;
                formPartisipants.Top = this.Top;
                formPartisipants.Show();

                this.Hide();
            }
        }

        private void вопросыИОтветыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.QAForm != null)
            {
                QA formQA = new QA();
                formQA.Left = this.Left;
                formQA.Top = this.Top;
                formQA.Show();

                this.Hide();
            }
            else
            {
                QA formQA = new QA();
                formQA.Left = this.Left;
                formQA.Top = this.Top;
                formQA.Show();

                this.Hide();
            }
        }

        private void голосованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.votingForm != null)
            {
                voting formVoting = new voting();
                formVoting.Left = this.Left;
                formVoting.Top = this.Top;
                formVoting.Show();

                this.Hide();
            }
            else
            {
                voting formVoting = new voting();
                formVoting.Left = this.Left;
                formVoting.Top = this.Top;
                formVoting.Show();

                this.Hide();
            }
        }
    }
    }

