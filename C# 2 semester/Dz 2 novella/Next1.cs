using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_2_novella
{
    public partial class Next1 : Form
    {
        EndForm endForm;
        FinalChoiceForm finalForm;
        public Next1(EndForm endForm)
        {
            InitializeComponent();
            this.endForm = endForm;
        }

        private void kickButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            endForm.Show();
        }

        private void ignoreButton_Click(object sender, EventArgs e)
        {
            this.finalForm = new FinalChoiceForm(endForm);
            finalForm.Show();
            this.Close();
        }
    }
}
