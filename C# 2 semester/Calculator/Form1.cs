using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, m1, m2;
            if (int.TryParse(n1Box.Text, out n1) && int.TryParse(n2Box.Text, out n2) && int.TryParse(m1Box.Text, out m1) && int.TryParse(m2Box.Text, out m2) && comboBox1.SelectedIndex != -1)
            {
                string action = comboBox1.SelectedItem.ToString();
                Rational rat1 = new Rational(m1, n1);
                Rational rat2 = new Rational(m2, n2);
                switch (action)
                {
                    case "+": ResultLabel.Text = $"{rat1.Plus(rat2).M}/{rat1.Plus(rat2).N}";
                        break;
                    case "-": ResultLabel.Text = "null";
                        break;
                    default: ResultLabel.Text = "null";
                        break;
                }
            }
        }
    }
}
