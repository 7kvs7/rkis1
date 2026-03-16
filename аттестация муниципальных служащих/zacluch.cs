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
    public partial class zacluch : Form
    {
        public Form podgotForm { get; set; }
        public Form osnovForm { get; set; }
        public Form protocolForm { get; set; }
        public Form decisionsForm { get; set; }
        public Form decreesForm { get; set; }
        public zacluch()
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

        private void основнойToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.osnovForm != null)
            {


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

        private void протоколЗаседанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.protocolForm != null)
            {


                protocol formProtocol = new protocol();
                formProtocol.Left = this.Left;
                formProtocol.Top = this.Top;
                formProtocol.Show();

                this.Hide();
            }
            else
            {
                protocol formProtocol = new protocol();
                formProtocol.Left = this.Left;
                formProtocol.Top = this.Top;
                formProtocol.Show();

                this.Hide();
            }
        }

        private void кадровыеРешенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.decisionsForm != null)
            {


                decisions formDecisions = new decisions();
                formDecisions.Left = this.Left;
                formDecisions.Top = this.Top;
                formDecisions.Show();

                this.Hide();
            }
            else
            {
                decisions formDecisions = new decisions();
                formDecisions.Left = this.Left;
                formDecisions.Top = this.Top;
                formDecisions.Show();

                this.Hide();
            }
        }

        private void приказыИРаспоряженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.decisionsForm != null)
            {
                decrees formDecrees = new decrees();
                formDecrees.Left = this.Left;
                formDecrees.Top = this.Top;
                formDecrees.Show();

                this.Hide();
            }
            else
            {
                decrees formDecrees = new decrees();
                formDecrees.Left = this.Left;
                formDecrees.Top = this.Top;
                formDecrees.Show();

                this.Hide();
            }
        }
    }
}
