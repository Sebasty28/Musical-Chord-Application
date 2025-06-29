using ChordBLL;
using ChordDAL;
using ChordCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
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
            MessageBox.Show("Chord Names: A, B, C ... G.\nCan include flats/Bb and sharps/A#.", "Help [?]",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelpChordType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chord Types: Major, minor, Maj7 ... sus4.", "Help [?]",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Create a 4 chord progression.\n It needs minimun of 4 chords to create a progression.", "Help [?]",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelpViewAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It will view all the added chords.", "Help [?]",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelpNewName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edited Chord Names: A, B, C ... G.\nCan include flats/Bb and sharps/A#", "Help [?]",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelpNewType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edited Chord Types: Major, minor, Maj7 ... sus4.", "Help [?]",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool IsValidInput(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && !int.TryParse(input, out _);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ChordManager chordManager = new ChordManager();

            string chordName = textBox_ChordName.Text.Trim();
            string chordType = textBox_ChordType.Text.Trim();

            if (!IsValidInput(chordName) || !string.IsNullOrWhiteSpace(chordType))
            {
                MessageBox.Show("Chord name and type cannot be empty, numeric, or spaces.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string chordNotes = chordManager.GenerateChordNotes(chordName.ToUpper(), chordType.ToLower());

            if (chordNotes == "Unknown chord" || chordNotes == "Unknown chord type")
            {
                MessageBox.Show("Invalid chord name or type.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool added = chordManager.AddChord(chordName.ToUpper(), chordType.ToLower(), chordNotes.ToUpper());

            if (added)
            {
                MessageBox.Show("Chord added successfully!", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_ChordName.Clear();
                textBox_ChordType.Clear();
            }
            else
            {
                MessageBox.Show("Chord already exists.", "Duplicate Entry.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ChordManager chordManager = new ChordManager();

            string oldName = textBox_ChordName.Text.Trim();
            string oldType = textBox_ChordType.Text.Trim();
            string newName = textBox_NewChordName.Text.Trim();
            string newType = textBox_NewChordType.Text.Trim();

            if (!IsValidInput(oldName) || !string.IsNullOrWhiteSpace(oldType) || !IsValidInput(newName) || !string.IsNullOrWhiteSpace(newType))
            {
                MessageBox.Show("Chord names and types must not be empty, numeric, or whitespace.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = chordManager.EditChord(oldName, oldType, newName, newType, out string updatedNotes);

            if (success)
            {
                MessageBox.Show($"Chord updated successfully!\nNew Notes: {updatedNotes}", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chord not found or the new chord already exists.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ChordManager chordManager = new ChordManager();

            string name = textBox_ChordName.Text.Trim();
            string type = textBox_ChordType.Text.Trim();

            if (!IsValidInput(name) || !IsValidInput(type))
            {
                MessageBox.Show("Chord name and type cannot be empty, numeric, or whitespace.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool deleted = chordManager.DeleteChord(name, type);

            if (deleted)
            {
                MessageBox.Show("Chord deleted successfully.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chord not found.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            ChordManager chordManager = new ChordManager();
            listBoxAllChords.Items.Clear();

            var chords = chordManager.GetAllChords();

            if (chords.Count == 0)
            {
                MessageBox.Show("No chords available.", "Information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var chord in chords)
            {
                listBoxAllChords.Items.Add(chord.ToString());
            }
            MessageBox.Show("All Chords found.", "Found.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGenerateChordProg_Click(object sender, EventArgs e)
        {
            ChordManager chordManager = new ChordManager();
            var progression = chordManager.GenerateProgression();

            if (progression == null || progression.Count < 4)
            {
                MessageBox.Show("Not enough chords to generate a progression. Minimum 4 required.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var chord in progression)
            {
                listBoxProgression.Items.Add(chord.ToString());
            }
            listBoxProgression.Items.Add("---------------");
            MessageBox.Show("Chord progression created.", "Created.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ChordManager chordManager = new ChordManager();
            listBoxSearch.Items.Clear();

            string name = textBox_ChordName.Text.Trim();
            string type = textBox_ChordType.Text.Trim();

            if (!IsValidInput(name) || !IsValidInput(type))
            {
                MessageBox.Show("Chord name and type cannot be empty, numeric, or whitespace.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Chord result = chordManager.SearchChord(name, type);

            if (result != null)
            {
                listBoxSearch.Items.Add(result.ToString());
                MessageBox.Show("Chord found.", "Found.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chord not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
