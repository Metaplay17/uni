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
            Rational rat1, rat2;
            if (int.TryParse(n1Box.Text, out n1) && int.TryParse(n2Box.Text, out n2) && int.TryParse(m1Box.Text, out m1) && int.TryParse(m2Box.Text, out m2) && comboBox1.SelectedIndex != -1)
            {
                string action = comboBox1.SelectedItem.ToString();
                try
                {
                    rat1 = new Rational(m1, n1);
                    rat2 = new Rational(m2, n2);
                }
                catch (Exception)
                {
                    MessageBox.Show("You cannot divide by zero");
                    return;
                }
                switch (action)
                {
                    case "+": Rational ans = rat1 + rat2;
                        ResultLabel.Text = $"{ans.M}/{ans.N}";
                        break;
                    case "-": ans = rat1 - rat2;
                        ResultLabel.Text = $"{Rational.Minus(rat1, rat2).M}/{Rational.Minus(rat1, rat2).N}";
                        break;
                    case "*": ans = rat1 * rat2;
                        ResultLabel.Text = $"{Rational.Multiply(rat1, rat2).M}/{Rational.Multiply(rat1, rat2).N}";
                        break;
                    case "/": ans = rat1 / rat2;
                        ResultLabel.Text = $"{Rational.Divide(rat1, rat2).M}/{Rational.Divide(rat1, rat2).N}";
                        break;
                    default: ResultLabel.Text = "null";
                        break;
                }
            }
        }
    }
}
