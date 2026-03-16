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
    public partial class supervisor : Form
    {
        public supervisor()
        {
            InitializeComponent();
        }

        private List<string> messages = new List<string>();
        private void button1_Click(object sender, EventArgs e)
{
    var msgForm = new MessagesSup();

    string fioRukovoditelya = textBox1.Text;
    string fioAttestuemogo = textBox2.Text;
    string description = richTextBox1.Text;

    string message = $"Я, {fioRukovoditelya},\n" +
                     $"являясь руководителем {fioAttestuemogo},\n" +
                     $"подтверждаю, что:\n" +
                     $"{description}";


    msgForm.Show();
}
    }
}
