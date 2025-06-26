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
            listBoxMain = new ListBox();
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
            buttonHelpChordName.Location = new Point(383, 83);
            buttonHelpChordName.Name = "buttonHelpChordName";
            buttonHelpChordName.Size = new Size(27, 29);
            buttonHelpChordName.TabIndex = 4;
            buttonHelpChordName.Text = "?";
            buttonHelpChordName.UseVisualStyleBackColor = false;
            buttonHelpChordName.Click += buttonHelpChordName_Click;
            // 
            // buttonHelpChordType
            // 
            buttonHelpChordType.Location = new Point(383, 149);
            buttonHelpChordType.Name = "buttonHelpChordType";
            buttonHelpChordType.Size = new Size(27, 29);
            buttonHelpChordType.TabIndex = 5;
            buttonHelpChordType.Text = "?";
            buttonHelpChordType.UseVisualStyleBackColor = true;
            buttonHelpChordType.Click += buttonHelpChordType_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.CornflowerBlue;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Courier New", 16F);
            buttonAdd.ForeColor = Color.WhiteSmoke;
            buttonAdd.Location = new Point(90, 239);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(287, 53);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.CornflowerBlue;
            buttonEdit.FlatStyle = FlatStyle.Popup;
            buttonEdit.Font = new Font("Courier New", 16F);
            buttonEdit.ForeColor = Color.WhiteSmoke;
            buttonEdit.Location = new Point(90, 313);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(287, 53);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "EDIT";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.CornflowerBlue;
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.Font = new Font("Courier New", 16F);
            buttonDelete.ForeColor = Color.WhiteSmoke;
            buttonDelete.Location = new Point(90, 386);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(287, 53);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonViewAll
            // 
            buttonViewAll.BackColor = Color.CornflowerBlue;
            buttonViewAll.FlatStyle = FlatStyle.Popup;
            buttonViewAll.Font = new Font("Courier New", 16F);
            buttonViewAll.ForeColor = Color.WhiteSmoke;
            buttonViewAll.Location = new Point(90, 457);
            buttonViewAll.Name = "buttonViewAll";
            buttonViewAll.Size = new Size(287, 53);
            buttonViewAll.TabIndex = 9;
            buttonViewAll.Text = "VIEW ALL";
            buttonViewAll.UseVisualStyleBackColor = false;
            // 
            // listBoxMain
            // 
            listBoxMain.BackColor = Color.AliceBlue;
            listBoxMain.BorderStyle = BorderStyle.FixedSingle;
            listBoxMain.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxMain.FormattingEnabled = true;
            listBoxMain.Location = new Point(550, 121);
            listBoxMain.Name = "listBoxMain";
            listBoxMain.Size = new Size(458, 402);
            listBoxMain.TabIndex = 10;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.CornflowerBlue;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Courier New", 10F);
            buttonSearch.ForeColor = Color.WhiteSmoke;
            buttonSearch.Location = new Point(784, 80);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(189, 32);
            buttonSearch.TabIndex = 11;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = false;
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
            // 
            // buttonHelpAdd
            // 
            buttonHelpAdd.Font = new Font("Segoe UI", 13F);
            buttonHelpAdd.Location = new Point(383, 241);
            buttonHelpAdd.Name = "buttonHelpAdd";
            buttonHelpAdd.Size = new Size(41, 53);
            buttonHelpAdd.TabIndex = 13;
            buttonHelpAdd.Text = "?";
            buttonHelpAdd.UseVisualStyleBackColor = true;
            buttonHelpAdd.Click += buttonHelpAdd_Click;
            // 
            // buttonHelpEdit
            // 
            buttonHelpEdit.Font = new Font("Segoe UI", 13F);
            buttonHelpEdit.Location = new Point(383, 313);
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
            buttonHelpDelete.Location = new Point(383, 385);
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
            buttonHelpViewAll.Location = new Point(383, 457);
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
            buttonExit.BackColor = Color.DarkRed;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.Font = new Font("Courier New", 12F);
            buttonExit.ForeColor = Color.WhiteSmoke;
            buttonExit.Location = new Point(770, 607);
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
            listBoxAllChords.Location = new Point(90, 563);
            listBoxAllChords.Name = "listBoxAllChords";
            listBoxAllChords.Size = new Size(334, 82);
            listBoxAllChords.TabIndex = 20;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainDashBoard;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1062, 673);
            Controls.Add(listBoxAllChords);
            Controls.Add(buttonExit);
            Controls.Add(buttonHelpSearch);
            Controls.Add(buttonHelpProgresion);
            Controls.Add(buttonHelpViewAll);
            Controls.Add(buttonHelpDelete);
            Controls.Add(buttonHelpEdit);
            Controls.Add(buttonHelpAdd);
            Controls.Add(buttonGenerateChordProg);
            Controls.Add(buttonSearch);
            Controls.Add(listBoxMain);
            Controls.Add(buttonViewAll);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(buttonHelpChordType);
            Controls.Add(buttonHelpChordName);
            Controls.Add(textBox_ChordType);
            Controls.Add(textBox_ChordName);
            Controls.Add(label_ChordType);
            Controls.Add(label_ChordName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainDashboard";
            Text = "Musical Chord Application";
            Load += MainDashboard_Load;
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
        private ListBox listBoxMain;
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
    }
}