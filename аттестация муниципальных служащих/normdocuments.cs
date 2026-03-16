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
    public partial class normdocuments : Form
        {
            public normdocuments()
            {
                InitializeComponent();
                this.FormClosed += normdocuments_FormClosed; // подписываемся на событие
            }

            private void normdocuments_FormClosed(object sender, FormClosedEventArgs e)
            {
                Form podgotForm = null;
                foreach (Form form in Application.OpenForms)
                {
                    if (form is podgot)
                    {
                        podgotForm = form;
                        break;
                    }
                }

                if (podgotForm != null)
                {
                    podgotForm.StartPosition = FormStartPosition.Manual;
                    podgotForm.Left = this.Left;
                    podgotForm.Top = this.Top;
                    podgotForm.Show();
                }
                else
                {
                    MessageBox.Show("Форма podgot не найдена!");
                }
            }
        }
    }
