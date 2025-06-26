using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicalChordAppWindowsForm
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();

        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void buttonHelpChordName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chord Names: A, B, C ... G.\nCan include flats/Bb and sharps/A#", "Help [?]",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelpChordType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chord Types: Major, minor, Maj7 ... sus4.", "Help [?]",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHelpAdd_Click(object sender, EventArgs e)
        {
            var dialog = new HelpDialogAdd(Properties.Resources.AddHelp1);
            dialog.ShowDialog();
        }

        private void buttonHelpEdit_Click(object sender, EventArgs e)
        {
            var dialog = new HelpDialogEdit(Properties.Resources.EditHelp);
            dialog.ShowDialog();
        }

        private void buttonHelpDelete_Click(object sender, EventArgs e)
        {
            var dialog = new HelpDialogDelete(Properties.Resources.DeleteHelp);
            dialog.ShowDialog();
        }

        private void buttonHelpSearch_Click(object sender, EventArgs e)
        {
            var dialog = new HelpDialogSearch(Properties.Resources.SearchHelp);
            dialog.ShowDialog();
        }

        private void buttonHelpProgresion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will create 4 chord progression.\n It needs minimun of 4 chords to create a progression.", "Help [?]",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelpViewAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It will view all the added chords.", "Help [?]",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
