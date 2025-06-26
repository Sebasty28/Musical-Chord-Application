namespace MusicalChordAppWindowsForm
{
    partial class StartDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartDashboard));
            buttonStart = new Button();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Anchor = AnchorStyles.Bottom;
            buttonStart.BackColor = Color.CornflowerBlue;
            buttonStart.FlatStyle = FlatStyle.Popup;
            buttonStart.Font = new Font("Courier New", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStart.ForeColor = Color.WhiteSmoke;
            buttonStart.Location = new Point(340, 553);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(389, 77);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // StartDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.StartDashBoard;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1062, 673);
            Controls.Add(buttonStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StartDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Musical Chord Application";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart;
    }
}
