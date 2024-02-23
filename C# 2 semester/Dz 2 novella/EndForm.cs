using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_2_novella
{
    public partial class EndForm : Form
    {
        StartWindow stWin;
        public EndForm(StartWindow stWin)
        {
            InitializeComponent();
            this.stWin = stWin;
        }

        private void againLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.stWin.Show();
        }
    }
}
