using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesColors
{
    public partial class MainWindow : Form
    {
        Color selectedColor;
        public MainWindow()
        {
            InitializeComponent();
            selectedColor = colorButton.BackColor;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            selectedColor = colorDialog1.Color;
            colorButton.BackColor = selectedColor;
        }
    }
}
