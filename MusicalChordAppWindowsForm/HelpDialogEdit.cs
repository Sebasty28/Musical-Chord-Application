using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MusicalChordAppWindowsForm
{
    public partial class HelpDialogEdit : Form
    {
        public HelpDialogEdit(System.Drawing.Image image)
        {
            InitializeComponent();

            if (image != null)
                pictureBox1.Image = image;
        }
    }
}
