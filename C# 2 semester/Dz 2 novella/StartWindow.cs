namespace Dz_2_novella
{
    public partial class StartWindow : Form
    {
        EndForm endForm;
        Next1 nextWin;
        public StartWindow()
        {
            InitializeComponent();
            this.endForm = new EndForm(this);
        }

        private void KickButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            endForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.nextWin = new Next1(endForm);
            nextWin.Show();
        }
    }
}
