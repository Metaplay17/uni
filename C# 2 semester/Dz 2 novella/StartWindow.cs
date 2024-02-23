namespace Dz_2_novella
{
    public partial class StartWindow : Form
    {
        EndForm endForm;
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
    }
}
