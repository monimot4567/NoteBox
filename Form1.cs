namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (string.IsNullOrWhiteSpace(textBoxFileName.Text))
                {
                    MessageBox.Show("Dosya adını yazmalısın!", "Uyarı");
                    return;
                }

                saveFileDialog.Filter = "Metin Dosyası (*.txt)|*.txt";
                saveFileDialog.Title = "Metin Dosyasını Kaydet";
                saveFileDialog.FileName = textBoxFileName.Text.Trim() + ".txt"; // Varsayılan isim

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);

                        // Durum yazısını güncelle
                        labelStatus.Text = "Saved";
                        labelStatus.ForeColor = Color.Green;
                    }
                    catch
                    {
                        labelStatus.Text = "Not Saved";
                        labelStatus.ForeColor = Color.Black;
                    }
                }
                else
                {
                    // Kullanıcı iptal etti → kaydedilmedi sayılır
                    labelStatus.Text = "Not Saved";
                    labelStatus.ForeColor = Color.Black;
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

    }
}
