namespace test
{
    partial class SplashForm
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
            btnSkip = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSkip
            // 
            btnSkip.FlatStyle = FlatStyle.Flat;
            btnSkip.Location = new Point(409, 244);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(75, 23);
            btnSkip.TabIndex = 0;
            btnSkip.Text = "Skip";
            btnSkip.UseVisualStyleBackColor = true;
            btnSkip.Click += btnSkip_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.image_removebg_preview;
            pictureBox1.Location = new Point(-88, -45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(611, 325);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(511, 277);
            Controls.Add(btnSkip);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashForm";
            Load += SplashForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSkip;

        private void SplashForm_Load(object sender, EventArgs e)
        {
            // Splash ekranı açılınca yapılacak işlemler
        }

        private PictureBox pictureBox1;
    }
}