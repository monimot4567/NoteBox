namespace test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            textBoxFileName = new TextBox();
            button1 = new Button();
            label1 = new Label();
            lblStatus = new Label();
            buttonSave = new Button();
            labelStatus = new Label();
            checkBoxAcrostis = new CheckBox();
            checkBoxMargin = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            labelCursorPos = new Label();
            checkBoxWordWrap = new CheckBox();
            checkBoxOneline = new CheckBox();
            checkBoxVisible = new CheckBox();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Cursor = Cursors.IBeam;
            richTextBox1.EnableAutoDragDrop = true;
            richTextBox1.Location = new Point(12, 111);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1156, 324);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.KeyDown += richTextBox1_KeyDown;
            // 
            // textBoxFileName
            // 
            textBoxFileName.Cursor = Cursors.IBeam;
            textBoxFileName.Location = new Point(12, 81);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(1156, 23);
            textBoxFileName.TabIndex = 1;
            textBoxFileName.Text = "New Text";
            // 
            // button1
            // 
            button1.Location = new Point(1143, 51);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 3;
            label1.Text = "NoteBox";
            label1.Click += label1_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(11, 442);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(110, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "0 word | 0 character";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1062, 51);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(1102, 14);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(61, 15);
            labelStatus.TabIndex = 6;
            labelStatus.Text = "Not Saved";
            // 
            // checkBoxAcrostis
            // 
            checkBoxAcrostis.AutoSize = true;
            checkBoxAcrostis.Location = new Point(982, 54);
            checkBoxAcrostis.Name = "checkBoxAcrostis";
            checkBoxAcrostis.Size = new Size(69, 19);
            checkBoxAcrostis.TabIndex = 7;
            checkBoxAcrostis.Text = "Acrostic";
            checkBoxAcrostis.UseVisualStyleBackColor = true;
            checkBoxAcrostis.CheckedChanged += checkBoxAcrostis_CheckedChanged;
            // 
            // checkBoxMargin
            // 
            checkBoxMargin.AutoSize = true;
            checkBoxMargin.Location = new Point(111, 20);
            checkBoxMargin.Name = "checkBoxMargin";
            checkBoxMargin.Size = new Size(143, 19);
            checkBoxMargin.TabIndex = 8;
            checkBoxMargin.Text = "Margin (experimental)";
            checkBoxMargin.UseVisualStyleBackColor = true;
            checkBoxMargin.CheckedChanged += checkBoxMargin_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(78, 56);
            button2.Name = "button2";
            button2.Size = new Size(22, 23);
            button2.TabIndex = 9;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(99, 56);
            button3.Name = "button3";
            button3.Size = new Size(22, 23);
            button3.TabIndex = 10;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // labelCursorPos
            // 
            labelCursorPos.AutoSize = true;
            labelCursorPos.Location = new Point(1062, 442);
            labelCursorPos.Name = "labelCursorPos";
            labelCursorPos.Size = new Size(94, 15);
            labelCursorPos.TabIndex = 11;
            labelCursorPos.Text = "1 line | 0 column";
            // 
            // checkBoxWordWrap
            // 
            checkBoxWordWrap.AutoSize = true;
            checkBoxWordWrap.Location = new Point(134, 59);
            checkBoxWordWrap.Name = "checkBoxWordWrap";
            checkBoxWordWrap.Size = new Size(86, 19);
            checkBoxWordWrap.TabIndex = 13;
            checkBoxWordWrap.Text = "Word Wrap";
            checkBoxWordWrap.UseVisualStyleBackColor = true;
            checkBoxWordWrap.CheckedChanged += checkBoxWordWrap_CheckedChanged;
            // 
            // checkBoxOneline
            // 
            checkBoxOneline.AutoSize = true;
            checkBoxOneline.Location = new Point(260, 20);
            checkBoxOneline.Name = "checkBoxOneline";
            checkBoxOneline.Size = new Size(146, 19);
            checkBoxOneline.TabIndex = 14;
            checkBoxOneline.Text = "Oneline (experimental)";
            checkBoxOneline.UseVisualStyleBackColor = true;
            checkBoxOneline.CheckedChanged += checkBoxOneline_CheckedChanged;
            // 
            // checkBoxVisible
            // 
            checkBoxVisible.AutoSize = true;
            checkBoxVisible.Location = new Point(127, 442);
            checkBoxVisible.Name = "checkBoxVisible";
            checkBoxVisible.Size = new Size(51, 19);
            checkBoxVisible.TabIndex = 15;
            checkBoxVisible.Text = "Hide";
            checkBoxVisible.UseVisualStyleBackColor = true;
            checkBoxVisible.CheckedChanged += checkBoxVisible_CheckedChanged;
            // 
            // button6
            // 
            button6.Location = new Point(12, 56);
            button6.Name = "button6";
            button6.Size = new Size(22, 23);
            button6.TabIndex = 17;
            button6.Text = "↶";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(33, 56);
            button7.Name = "button7";
            button7.Size = new Size(22, 23);
            button7.TabIndex = 18;
            button7.Text = "↷";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1180, 464);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(checkBoxVisible);
            Controls.Add(checkBoxOneline);
            Controls.Add(checkBoxWordWrap);
            Controls.Add(labelCursorPos);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(checkBoxMargin);
            Controls.Add(checkBoxAcrostis);
            Controls.Add(labelStatus);
            Controls.Add(buttonSave);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxFileName);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteBox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBoxFileName;
        private Button button1;
        private Label label1;
        private Label lblStatus;
        private Button buttonSave;
        private Label labelStatus;
        private CheckBox checkBoxAcrostis;
        private CheckBox checkBoxMargin;
        private Button button2;
        private Button button3;
        private Label labelCursorPos;
        private CheckBox checkBoxWordWrap;
        private CheckBox checkBoxOneline;
        private CheckBox checkBoxVisible;
        private Button button6;
        private Button button7;
    }
}
