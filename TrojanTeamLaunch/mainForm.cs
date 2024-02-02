namespace TrojanTeamLaunch
{
    public partial class main_mainForm : Form
    {

      
        
        public main_mainForm()
        {
            InitializeComponent();

            Opacity = 0;
            ShowInTaskbar = false;
        }

        public void UserIsAuthed()
        {
            win_launchIcon launchIcon = new();
            launchIcon.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
