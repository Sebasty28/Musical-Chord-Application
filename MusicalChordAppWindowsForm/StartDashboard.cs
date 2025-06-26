namespace MusicalChordAppWindowsForm
{
    public partial class StartDashboard : Form
    {
        public StartDashboard()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MainDashboard mainOpen = new MainDashboard();
            mainOpen.Show();
            this.Close();


        }

    }
}
