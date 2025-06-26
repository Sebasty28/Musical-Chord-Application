namespace MusicalChordAppWindowsForm
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            label_ChordName = new Label();
            label_ChordType = new Label();
            textBox_ChordName = new TextBox();
            textBox_ChordType = new TextBox();
            buttonHelpChordName = new Button();
            buttonHelpChordType = new Button();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonViewAll = new Button();
            listBoxProgression = new ListBox();
            buttonSearch = new Button();
            buttonGenerateChordProg = new Button();
            buttonHelpAdd = new Button();
            buttonHelpEdit = new Button();
            buttonHelpDelete = new Button();
            buttonHelpViewAll = new Button();
            buttonHelpProgresion = new Button();
            buttonHelpSearch = new Button();
            buttonExit = new Button();
            listBoxAllChords = new ListBox();
            buttonHelpNewType = new Button();
            buttonHelpNewName = new Button();
            textBox_NewChordType = new TextBox();
            textBox_NewChordName = new TextBox();
            label_NewType = new Label();
            label_NewName = new Label();
            panelEdit = new Panel();
            labelEdit = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            labelProgression = new Label();
            listBoxSearch = new ListBox();
            labelMain = new Label();
            labelView = new Label();
            labelSearch = new Label();
            labelViewAll = new Label();
            panelEdit.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label_ChordName
            // 
            label_ChordName.AutoSize = true;
            label_ChordName.BackColor = Color.Transparent;
            label_ChordName.FlatStyle = FlatStyle.Popup;
            label_ChordName.Font = new Font("Courier New", 15F);
            label_ChordName.ForeColor = SystemColors.ButtonFace;
            label_ChordName.Location = new Point(90, 80);
            label_ChordName.Name = "label_ChordName";
            label_ChordName.Size = new Size(178, 29);
            label_ChordName.TabIndex = 1;
            label_ChordName.Text = "Chord Name:";
            // 
            // label_ChordType
            // 
            label_ChordType.AutoSize = true;
            label_ChordType.BackColor = Color.Transparent;
            label_ChordType.FlatStyle = FlatStyle.Popup;
            label_ChordType.Font = new Font("Courier New", 15F);
            label_ChordType.ForeColor = SystemColors.ButtonFace;
            label_ChordType.Location = new Point(90, 145);
            label_ChordType.Name = "label_ChordType";
            label_ChordType.Size = new Size(178, 29);
            label_ChordType.TabIndex = 1;
            label_ChordType.Text = "Chord Type:";
            // 
            // textBox_ChordName
            // 
            textBox_ChordName.BackColor = Color.AliceBlue;
            textBox_ChordName.Cursor = Cursors.IBeam;
            textBox_ChordName.Font = new Font("Courier New", 10F, FontStyle.Bold);
            textBox_ChordName.ForeColor = Color.Black;
            textBox_ChordName.Location = new Point(274, 83);
            textBox_ChordName.Name = "textBox_ChordName";
            textBox_ChordName.PlaceholderText = "...";
            textBox_ChordName.Size = new Size(103, 26);
            textBox_ChordName.TabIndex = 2;
            // 
            // textBox_ChordType
            // 
            textBox_ChordType.BackColor = Color.AliceBlue;
            textBox_ChordType.Cursor = Cursors.IBeam;
            textBox_ChordType.Font = new Font("Courier New", 10F, FontStyle.Bold);
            textBox_ChordType.ForeColor = Color.Black;
            textBox_ChordType.Location = new Point(274, 149);
            textBox_ChordType.Name = "textBox_ChordType";
            textBox_ChordType.PlaceholderText = "...";
            textBox_ChordType.Size = new Size(103, 26);
            textBox_ChordType.TabIndex = 3;
            // 
            // buttonHelpChordName
            // 
            buttonHelpChordName.BackColor = SystemColors.Control;
            buttonHelpChordName.ForeColor = SystemColors.ControlText;
            buttonHelpChordName.Location = new Point(306, 10);
            buttonHelpChordName.Name = "buttonHelpChordName";
            buttonHelpChordName.Size = new Size(27, 29);
            buttonHelpChordName.TabIndex = 4;
            buttonHelpChordName.Text = "?";
            buttonHelpChordName.UseVisualStyleBackColor = false;
            buttonHelpChordName.Click += buttonHelpChordName_Click;
            // 
            // buttonHelpChordType
            // 
            buttonHelpChordType.BackColor = SystemColors.Control;
            buttonHelpChordType.ForeColor = SystemColors.ControlText;
            buttonHelpChordType.Location = new Point(306, 75);
            buttonHelpChordType.Name = "buttonHelpChordType";
            buttonHelpChordType.Size = new Size(27, 29);
            buttonHelpChordType.TabIndex = 5;
            buttonHelpChordType.Text = "?";
            buttonHelpChordType.UseVisualStyleBackColor = false;
            buttonHelpChordType.Click += buttonHelpChordType_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.CornflowerBlue;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Courier New", 16F);
            buttonAdd.ForeColor = Color.WhiteSmoke;
            buttonAdd.Location = new Point(90, 207);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(320, 53);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.CornflowerBlue;
            buttonEdit.FlatStyle = FlatStyle.Popup;
            buttonEdit.Font = new Font("Courier New", 16F);
            buttonEdit.ForeColor = Color.WhiteSmoke;
            buttonEdit.Location = new Point(90, 384);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(320, 53);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "EDIT";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.CornflowerBlue;
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.Font = new Font("Courier New", 16F);
            buttonDelete.ForeColor = Color.WhiteSmoke;
            buttonDelete.Location = new Point(90, 266);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(320, 53);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonViewAll
            // 
            buttonViewAll.BackColor = Color.CornflowerBlue;
            buttonViewAll.FlatStyle = FlatStyle.Popup;
            buttonViewAll.Font = new Font("Courier New", 16F);
            buttonViewAll.ForeColor = Color.WhiteSmoke;
            buttonViewAll.Location = new Point(90, 325);
            buttonViewAll.Name = "buttonViewAll";
            buttonViewAll.Size = new Size(320, 53);
            buttonViewAll.TabIndex = 9;
            buttonViewAll.Text = "VIEW ALL";
            buttonViewAll.UseVisualStyleBackColor = false;
            buttonViewAll.Click += buttonViewAll_Click;
            // 
            // listBoxProgression
            // 
            listBoxProgression.BackColor = Color.AliceBlue;
            listBoxProgression.BorderStyle = BorderStyle.FixedSingle;
            listBoxProgression.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxProgression.FormattingEnabled = true;
            listBoxProgression.Location = new Point(550, 159);
            listBoxProgression.Name = "listBoxProgression";
            listBoxProgression.Size = new Size(228, 362);
            listBoxProgression.TabIndex = 10;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.CornflowerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Courier New", 10F);
            buttonSearch.ForeColor = Color.WhiteSmoke;
            buttonSearch.Location = new Point(784, 80);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(195, 32);
            buttonSearch.TabIndex = 11;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonGenerateChordProg
            // 
            buttonGenerateChordProg.BackColor = Color.CornflowerBlue;
            buttonGenerateChordProg.FlatStyle = FlatStyle.Popup;
            buttonGenerateChordProg.Font = new Font("Courier New", 10F);
            buttonGenerateChordProg.ForeColor = Color.WhiteSmoke;
            buttonGenerateChordProg.Location = new Point(550, 81);
            buttonGenerateChordProg.Name = "buttonGenerateChordProg";
            buttonGenerateChordProg.Size = new Size(195, 32);
            buttonGenerateChordProg.TabIndex = 12;
            buttonGenerateChordProg.Text = "CHORD PROGRESSION";
            buttonGenerateChordProg.UseVisualStyleBackColor = false;
            buttonGenerateChordProg.Click += buttonGenerateChordProg_Click;
            // 
            // buttonHelpAdd
            // 
            buttonHelpAdd.BackColor = SystemColors.Control;
            buttonHelpAdd.Font = new Font("Segoe UI", 13F);
            buttonHelpAdd.ForeColor = SystemColors.ControlText;
            buttonHelpAdd.Location = new Point(339, 133);
            buttonHelpAdd.Name = "buttonHelpAdd";
            buttonHelpAdd.Size = new Size(41, 53);
            buttonHelpAdd.TabIndex = 13;
            buttonHelpAdd.Text = "?";
            buttonHelpAdd.UseVisualStyleBackColor = false;
            buttonHelpAdd.Click += buttonHelpAdd_Click;
            // 
            // buttonHelpEdit
            // 
            buttonHelpEdit.Font = new Font("Segoe UI", 13F);
            buttonHelpEdit.ForeColor = SystemColors.ControlText;
            buttonHelpEdit.Location = new Point(339, 310);
            buttonHelpEdit.Name = "buttonHelpEdit";
            buttonHelpEdit.Size = new Size(41, 53);
            buttonHelpEdit.TabIndex = 14;
            buttonHelpEdit.Text = "?";
            buttonHelpEdit.UseVisualStyleBackColor = true;
            buttonHelpEdit.Click += buttonHelpEdit_Click;
            // 
            // buttonHelpDelete
            // 
            buttonHelpDelete.Font = new Font("Segoe UI", 13F);
            buttonHelpDelete.ForeColor = SystemColors.ControlText;
            buttonHelpDelete.Location = new Point(339, 192);
            buttonHelpDelete.Name = "buttonHelpDelete";
            buttonHelpDelete.Size = new Size(41, 53);
            buttonHelpDelete.TabIndex = 15;
            buttonHelpDelete.Text = "?";
            buttonHelpDelete.UseVisualStyleBackColor = true;
            buttonHelpDelete.Click += buttonHelpDelete_Click;
            // 
            // buttonHelpViewAll
            // 
            buttonHelpViewAll.Font = new Font("Segoe UI", 13F);
            buttonHelpViewAll.ForeColor = SystemColors.ControlText;
            buttonHelpViewAll.Location = new Point(339, 251);
            buttonHelpViewAll.Name = "buttonHelpViewAll";
            buttonHelpViewAll.Size = new Size(41, 53);
            buttonHelpViewAll.TabIndex = 16;
            buttonHelpViewAll.Text = "?";
            buttonHelpViewAll.UseVisualStyleBackColor = true;
            buttonHelpViewAll.Click += buttonHelpViewAll_Click;
            // 
            // buttonHelpProgresion
            // 
            buttonHelpProgresion.Location = new Point(751, 83);
            buttonHelpProgresion.Name = "buttonHelpProgresion";
            buttonHelpProgresion.Size = new Size(27, 29);
            buttonHelpProgresion.TabIndex = 17;
            buttonHelpProgresion.Text = "?";
            buttonHelpProgresion.UseVisualStyleBackColor = true;
            buttonHelpProgresion.Click += buttonHelpProgresion_Click;
            // 
            // buttonHelpSearch
            // 
            buttonHelpSearch.Location = new Point(979, 82);
            buttonHelpSearch.Name = "buttonHelpSearch";
            buttonHelpSearch.Size = new Size(27, 29);
            buttonHelpSearch.TabIndex = 18;
            buttonHelpSearch.Text = "?";
            buttonHelpSearch.UseVisualStyleBackColor = true;
            buttonHelpSearch.Click += buttonHelpSearch_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.DarkGray;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.Font = new Font("Courier New", 12F);
            buttonExit.ForeColor = Color.WhiteSmoke;
            buttonExit.Location = new Point(784, 607);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(238, 41);
            buttonExit.TabIndex = 19;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // listBoxAllChords
            // 
            listBoxAllChords.BackColor = Color.AliceBlue;
            listBoxAllChords.BorderStyle = BorderStyle.FixedSingle;
            listBoxAllChords.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxAllChords.FormattingEnabled = true;
            listBoxAllChords.Location = new Point(250, 185);
            listBoxAllChords.Name = "listBoxAllChords";
            listBoxAllChords.Size = new Size(228, 262);
            listBoxAllChords.TabIndex = 20;
            // 
            // buttonHelpNewType
            // 
            buttonHelpNewType.Location = new Point(430, 602);
            buttonHelpNewType.Name = "buttonHelpNewType";
            buttonHelpNewType.Size = new Size(27, 29);
            buttonHelpNewType.TabIndex = 26;
            buttonHelpNewType.Text = "?";
            buttonHelpNewType.UseVisualStyleBackColor = true;
            buttonHelpNewType.Click += buttonHelpNewType_Click;
            // 
            // buttonHelpNewName
            // 
            buttonHelpNewName.BackColor = SystemColors.Control;
            buttonHelpNewName.ForeColor = SystemColors.ControlText;
            buttonHelpNewName.Location = new Point(353, 33);
            buttonHelpNewName.Name = "buttonHelpNewName";
            buttonHelpNewName.Size = new Size(27, 29);
            buttonHelpNewName.TabIndex = 25;
            buttonHelpNewName.Text = "?";
            buttonHelpNewName.UseVisualStyleBackColor = false;
            buttonHelpNewName.Click += buttonHelpNewName_Click;
            // 
            // textBox_NewChordType
            // 
            textBox_NewChordType.BackColor = Color.AliceBlue;
            textBox_NewChordType.Cursor = Cursors.IBeam;
            textBox_NewChordType.Font = new Font("Courier New", 10F, FontStyle.Bold);
            textBox_NewChordType.ForeColor = Color.Black;
            textBox_NewChordType.Location = new Point(321, 604);
            textBox_NewChordType.Name = "textBox_NewChordType";
            textBox_NewChordType.PlaceholderText = "...";
            textBox_NewChordType.Size = new Size(103, 26);
            textBox_NewChordType.TabIndex = 24;
            // 
            // textBox_NewChordName
            // 
            textBox_NewChordName.BackColor = Color.AliceBlue;
            textBox_NewChordName.Cursor = Cursors.IBeam;
            textBox_NewChordName.Font = new Font("Courier New", 10F, FontStyle.Bold);
            textBox_NewChordName.ForeColor = Color.Black;
            textBox_NewChordName.Location = new Point(321, 537);
            textBox_NewChordName.Name = "textBox_NewChordName";
            textBox_NewChordName.PlaceholderText = "...";
            textBox_NewChordName.Size = new Size(103, 26);
            textBox_NewChordName.TabIndex = 23;
            // 
            // label_NewType
            // 
            label_NewType.AutoSize = true;
            label_NewType.BackColor = Color.Transparent;
            label_NewType.FlatStyle = FlatStyle.Popup;
            label_NewType.Font = new Font("Courier New", 15F);
            label_NewType.ForeColor = SystemColors.ButtonFace;
            label_NewType.Location = new Point(90, 600);
            label_NewType.Name = "label_NewType";
            label_NewType.Size = new Size(238, 29);
            label_NewType.TabIndex = 21;
            label_NewType.Text = "New Chord Type:";
            // 
            // label_NewName
            // 
            label_NewName.AutoSize = true;
            label_NewName.BackColor = Color.Transparent;
            label_NewName.FlatStyle = FlatStyle.Popup;
            label_NewName.Font = new Font("Courier New", 15F);
            label_NewName.ForeColor = SystemColors.ButtonFace;
            label_NewName.Location = new Point(90, 534);
            label_NewName.Name = "label_NewName";
            label_NewName.Size = new Size(238, 29);
            label_NewName.TabIndex = 22;
            label_NewName.Text = "New Chord Name:";
            // 
            // panelEdit
            // 
            panelEdit.BackColor = Color.Transparent;
            panelEdit.BorderStyle = BorderStyle.Fixed3D;
            panelEdit.Controls.Add(buttonHelpNewName);
            panelEdit.ForeColor = SystemColors.ActiveCaption;
            panelEdit.Location = new Point(75, 502);
            panelEdit.Name = "panelEdit";
            panelEdit.RightToLeft = RightToLeft.No;
            panelEdit.Size = new Size(393, 146);
            panelEdit.TabIndex = 27;
            // 
            // labelEdit
            // 
            labelEdit.AutoSize = true;
            labelEdit.BackColor = Color.Transparent;
            labelEdit.FlatStyle = FlatStyle.Popup;
            labelEdit.Font = new Font("Courier New", 15F);
            labelEdit.ForeColor = SystemColors.ButtonFace;
            labelEdit.Location = new Point(75, 470);
            labelEdit.Name = "labelEdit";
            labelEdit.Size = new Size(193, 29);
            labelEdit.TabIndex = 28;
            labelEdit.Text = "Editing Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(buttonHelpChordName);
            panel1.Controls.Add(buttonHelpChordType);
            panel1.Controls.Add(buttonHelpAdd);
            panel1.Controls.Add(buttonHelpDelete);
            panel1.Controls.Add(buttonHelpViewAll);
            panel1.Controls.Add(buttonHelpEdit);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(75, 72);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(393, 376);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(labelViewAll);
            panel2.Controls.Add(labelSearch);
            panel2.Controls.Add(labelProgression);
            panel2.Controls.Add(listBoxSearch);
            panel2.Controls.Add(listBoxAllChords);
            panel2.ForeColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(532, 72);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(490, 465);
            panel2.TabIndex = 29;
            // 
            // labelProgression
            // 
            labelProgression.AutoSize = true;
            labelProgression.BackColor = Color.Transparent;
            labelProgression.FlatStyle = FlatStyle.Popup;
            labelProgression.Font = new Font("Courier New", 15F);
            labelProgression.ForeColor = SystemColors.ButtonFace;
            labelProgression.Location = new Point(16, 53);
            labelProgression.Name = "labelProgression";
            labelProgression.Size = new Size(178, 29);
            labelProgression.TabIndex = 32;
            labelProgression.Text = "Progression";
            // 
            // listBoxSearch
            // 
            listBoxSearch.BackColor = Color.AliceBlue;
            listBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            listBoxSearch.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxSearch.FormattingEnabled = true;
            listBoxSearch.Location = new Point(250, 85);
            listBoxSearch.Name = "listBoxSearch";
            listBoxSearch.Size = new Size(228, 62);
            listBoxSearch.TabIndex = 21;
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.BackColor = Color.Transparent;
            labelMain.FlatStyle = FlatStyle.Popup;
            labelMain.Font = new Font("Courier New", 15F);
            labelMain.ForeColor = SystemColors.ButtonFace;
            labelMain.Location = new Point(75, 40);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(148, 29);
            labelMain.TabIndex = 30;
            labelMain.Text = "Main Form";
            // 
            // labelView
            // 
            labelView.AutoSize = true;
            labelView.BackColor = Color.Transparent;
            labelView.FlatStyle = FlatStyle.Popup;
            labelView.Font = new Font("Courier New", 15F);
            labelView.ForeColor = SystemColors.ButtonFace;
            labelView.Location = new Point(532, 40);
            labelView.Name = "labelView";
            labelView.Size = new Size(148, 29);
            labelView.TabIndex = 31;
            labelView.Text = "View Form";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.BackColor = Color.Transparent;
            labelSearch.FlatStyle = FlatStyle.Popup;
            labelSearch.Font = new Font("Courier New", 15F);
            labelSearch.ForeColor = SystemColors.ButtonFace;
            labelSearch.Location = new Point(250, 53);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(103, 29);
            labelSearch.TabIndex = 33;
            labelSearch.Text = "Search";
            // 
            // labelViewAll
            // 
            labelViewAll.AutoSize = true;
            labelViewAll.BackColor = Color.Transparent;
            labelViewAll.FlatStyle = FlatStyle.Popup;
            labelViewAll.Font = new Font("Courier New", 15F);
            labelViewAll.ForeColor = SystemColors.ButtonFace;
            labelViewAll.Location = new Point(250, 157);
            labelViewAll.Name = "labelViewAll";
            labelViewAll.Size = new Size(163, 29);
            labelViewAll.TabIndex = 34;
            labelViewAll.Text = "All Chords";
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainDashBoard;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1062, 673);
            Controls.Add(labelView);
            Controls.Add(labelMain);
            Controls.Add(buttonExit);
            Controls.Add(labelEdit);
            Controls.Add(buttonHelpNewType);
            Controls.Add(textBox_NewChordType);
            Controls.Add(textBox_NewChordName);
            Controls.Add(label_NewType);
            Controls.Add(label_NewName);
            Controls.Add(buttonHelpSearch);
            Controls.Add(buttonHelpProgresion);
            Controls.Add(buttonGenerateChordProg);
            Controls.Add(buttonSearch);
            Controls.Add(listBoxProgression);
            Controls.Add(buttonViewAll);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBox_ChordType);
            Controls.Add(textBox_ChordName);
            Controls.Add(label_ChordType);
            Controls.Add(label_ChordName);
            Controls.Add(panelEdit);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Musical Chord Application";
            Load += MainDashboard_Load;
            panelEdit.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ChordName;
        private Label label_ChordType;
        private TextBox textBox_ChordName;
        private TextBox textBox_ChordType;
        private Button buttonHelpChordName;
        private Button buttonHelpChordType;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonViewAll;
        private ListBox listBoxProgression;
        private Button buttonSearch;
        private Button buttonGenerateChordProg;
        private Button buttonHelpAdd;
        private Button buttonHelpEdit;
        private Button buttonHelpDelete;
        private Button buttonHelpViewAll;
        private Button buttonHelpProgresion;
        private Button buttonHelpSearch;
        private Button buttonExit;
        private ListBox listBoxAllChords;
        private Button buttonHelpNewType;
        private Button buttonHelpNewName;
        private TextBox textBox_NewChordType;
        private TextBox textBox_NewChordName;
        private Label label_NewType;
        private Label label_NewName;
        private Panel panelEdit;
        private Label labelEdit;
        private Panel panel1;
        private Panel panel2;
        private ListBox listBoxSearch;
        private Label labelProgression;
        private Label labelMain;
        private Label labelView;
        private Label labelViewAll;
        private Label labelSearch;
    }
}