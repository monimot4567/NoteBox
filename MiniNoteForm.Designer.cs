namespace test
{
    partial class MiniNoteForm
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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.AcceptsTab = true;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(-1, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(296, 275);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.KeyDown += richTextBox1_KeyDown;
            // 
            // MiniNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 276);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MiniNoteForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
    }
}