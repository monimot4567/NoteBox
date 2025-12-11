using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class MiniNoteForm : Form
    {
        public MiniNoteForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl + = veya Ctrl + +  --> Zoom In
            if (e.Control && (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add))
            {
                if (richTextBox1.ZoomFactor < 5) // max 5x büyütme
                    richTextBox1.ZoomFactor += 0.1f;

                e.SuppressKeyPress = true; // default + yazmasını engeller
            }

            // Ctrl + -  --> Zoom Out
            if (e.Control && (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract))
            {
                if (richTextBox1.ZoomFactor > 0.2) // minimum zoom
                    richTextBox1.ZoomFactor -= 0.1f;

                e.SuppressKeyPress = true; // - karakterinin yazılmasını engeller
            }

            // Ctrl + 0  --> Reset Zoom
            if (e.Control && e.KeyCode == Keys.D0)
            {
                richTextBox1.ZoomFactor = 1.0f;
                e.SuppressKeyPress = true;
            }
        }
    }
}
