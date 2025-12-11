using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ToolTip nesnesi oluştur
            ToolTip tip = new ToolTip();

            // İpuçlarını ayarla
            tip.SetToolTip(buttonSave, "Save the text");
            tip.SetToolTip(buttonLoad, "Open the text");
            tip.SetToolTip(comboFormat, "Choose the save format");
            tip.SetToolTip(textBoxFileName, "Specify the file name");
            tip.SetToolTip(checkBoxMargin, "Add margin to the left of the text");
            tip.SetToolTip(checkBoxOneline, "Allow the text to remain on just one line");
            tip.SetToolTip(checkBoxWordWrap, "Prevent the text from stretching horizontally in the box");
            tip.SetToolTip(button1, "Make the text read-only");
            tip.SetToolTip(button2, "Enlarge the text");
            tip.SetToolTip(button3, "Reduce the text");
            tip.SetToolTip(button6, "Undo");
            tip.SetToolTip(button7, "Redo");
            tip.SetToolTip(checkBoxAcrostis, "Arrange the text as an acrostic");
            tip.SetToolTip(checkBoxVisible, "Hide all text");
            tip.SetToolTip(buttonMiniNote, "Create new mini note");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboFormat.SelectedIndex = 0; // Varsayılan TXT
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba C#!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!richTextBox1.ReadOnly)
            {
                richTextBox1.ReadOnly = true;
                button1.Text = "O";
            }

            else
            {
                richTextBox1.ReadOnly = false;
                button1.Text = "X";
            }
        }

        private void checkBoxAcrostis_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAcrostis.Checked)
            {
                // Akrostiş modu aktif
                richTextBox1.RightMargin = 1;
            }
            else
            {
                // Normal moda dön
                richTextBox1.RightMargin = 0;
            }
        }

        private void checkBoxMargin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMargin.Checked)
            {
                // Akrostiş modu aktif
                richTextBox1.ShowSelectionMargin = true;
            }
            else
            {
                // Normal moda dön
                richTextBox1.ShowSelectionMargin = false;
            }
        }

        private void checkBoxWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWordWrap.Checked)
            {
                // Akrostiş modu aktif
                richTextBox1.WordWrap = true;
            }
            else
            {
                // Normal moda dön
                richTextBox1.WordWrap = false;
            }
        }

        private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVisible.Checked)
            {
                // Akrostiş modu aktif
                richTextBox1.Visible = false;
            }
            else
            {
                // Normal moda dön
                richTextBox1.Visible = true;
            }
        }

        private void checkBoxOneline_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOneline.Checked)
            {
                // Akrostiş modu aktif
                richTextBox1.Multiline = false;
            }
            else
            {
                // Normal moda dön
                richTextBox1.Multiline = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;

            // Karakter sayısı (boşluklar dahil)
            int charCount = text.Length;

            // Kelime sayısı
            int wordCount = 0;

            if (!string.IsNullOrWhiteSpace(text))
            {
                // Birden fazla boşluğu yok saymak için split seçenekleri
                wordCount = text
                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Length;
            }

            // Label'a yaz
            lblStatus.Text = $"{wordCount} word | {charCount} character";

            labelStatus.Text = "Not Saved";
            labelStatus.ForeColor = Color.Black;
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            // 1) Satır numarasını al
            int line = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1;

            // 2) O satırdaki ilk karakterin global index'i
            int firstCharIndex = richTextBox1.GetFirstCharIndexOfCurrentLine();

            // 3) Kolon (sütun) = İmleç pozisyonu - satır başlangıcı
            int column = richTextBox1.SelectionStart - firstCharIndex + 1;

            // 4) Label'a yaz (örnek label ismi: labelCursorPos)
            labelCursorPos.Text = $"{line} line | {column} column";
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFileName.Text))
            {
                MessageBox.Show("Dosya adını yazmalısın!");
                return;
            }

            // Format seçimi
            string format = comboFormat.SelectedItem.ToString();

            // Dizin seçici
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (format == ".txt")
                {
                    sfd.Filter = "Text File (*.txt)|*.txt";
                    sfd.DefaultExt = "txt";
                }
                else
                {
                    sfd.Filter = "Rich Text Format (*.rtf)|*.rtf";
                    sfd.DefaultExt = "rtf";
                }

                sfd.FileName = textBoxFileName.Text;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (format == "TXT")
                    {
                        File.WriteAllText(sfd.FileName, richTextBox1.Text);
                    }
                    else
                    {
                        richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                    }

                    labelStatus.Text = "Saved";
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor < 5) // max 5x büyütme
                richTextBox1.ZoomFactor += 0.1f;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor > 0.2f)
                richTextBox1.ZoomFactor -= 0.1f;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
                richTextBox1.Undo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo)
                richTextBox1.Redo();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";
                ofd.Title = "Open a File";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(ofd.FileName).ToLower();

                    if (ext == ".rtf")
                    {
                        richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                    }

                    textBoxFileName.Text = Path.GetFileName(ofd.FileName);
                }
            }
        }

        private void buttonMiniNote_Click(object sender, EventArgs e)
        {
            MiniNoteForm mini = new MiniNoteForm();
            mini.Show();    // istediğin kadar Mini Note penceresi açılabilir
        }



    }
}
