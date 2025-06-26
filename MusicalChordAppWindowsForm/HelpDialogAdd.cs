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
    public partial class HelpDialogAdd : Form
    {
        public HelpDialogAdd(System.Drawing.Image image = null)
        {
            InitializeComponent();

            if (image != null)
                pictureBox1.Image = image;
        }

    }
}
