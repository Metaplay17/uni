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
    public partial class FinalChoiceForm : Form
    {
        EndForm endForm;
        LastChallengeForm lastForm;
        public FinalChoiceForm(EndForm endForm)
        {
            InitializeComponent();
            this.endForm = endForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.lastForm = new LastChallengeForm(endForm);
            lastForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            endForm.Show();
            this.Close();
        }
    }
}
