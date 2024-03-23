namespace WorkspaceTuning
{
    public partial class MainWindow : Form
    {
        Workspace workspace;
        public MainWindow()
        {
            InitializeComponent();
            workspace = new Workspace(new OldMonitor(Properties.Resources.oldMonitor), new StrangeMouse(Properties.Resources.strangeMouse), new PoorKeyboard(Properties.Resources.poorKeyboard));
            monitorComboBox.SelectedIndex = 0;
            mouseComboBox.SelectedIndex = 0;
            keyboardComboBox.SelectedIndex = 0;
        }

        private void monitorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (monitorComboBox.SelectedIndex)
            {
                case 0:
                    workspace.ChangeMonitor(new OldMonitor(Properties.Resources.oldMonitor));
                    break;
                case 1:
                    workspace.ChangeMonitor(new NewMonitor(Properties.Resources.newMonitor));
                    break;
            }
            Refresh();
        }

        private void mouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mouseComboBox.SelectedIndex)
            {
                case 0:
                    workspace.ChangeMouse(new StrangeMouse(Properties.Resources.strangeMouse));
                    break;
                case 1:
                    workspace.ChangeMouse(new CoolMouse(Properties.Resources.coolMouse));
                    break;
            }
            Refresh();
        }

        private void keyboardComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (keyboardComboBox.SelectedIndex)
            {
                case 0:
                    workspace.ChangeKeyboard(new PoorKeyboard(Properties.Resources.poorKeyboard));
                    break;
                case 1:
                    workspace.ChangeKeyboard(new RichKeyboard(Properties.Resources.richKeyboard));
                    break;
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            workspace.Draw(e.Graphics);
        }
    }
}
