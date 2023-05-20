namespace Курсач_Blowfish
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
            Encode_text = new TextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            расшифроватьToolStripMenuItem = new ToolStripMenuItem();
            standart_text = new Label();
            Key = new Label();
            Decode_text = new TextBox();
            shifr_text = new Label();
            Encode = new Button();
            key_text = new TextBox();
            swap_button = new Button();
            DeCode = new Button();
            version = new Label();
            openFileDialog1 = new OpenFileDialog();
            clear_encode = new Button();
            clear_decode = new Button();
            progressBar1 = new ProgressBar();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Encode_text
            // 
            Encode_text.Location = new Point(18, 106);
            Encode_text.Margin = new Padding(4, 5, 4, 5);
            Encode_text.Multiline = true;
            Encode_text.Name = "Encode_text";
            Encode_text.ScrollBars = ScrollBars.Vertical;
            Encode_text.Size = new Size(316, 236);
            Encode_text.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(790, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загрузитьToolStripMenuItem, расшифроватьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(58, 24);
            файлToolStripMenuItem.Text = "файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(194, 26);
            загрузитьToolStripMenuItem.Text = "Зашифровать";
            загрузитьToolStripMenuItem.Click += загрузитьToolStripMenuItem_Click;
            // 
            // расшифроватьToolStripMenuItem
            // 
            расшифроватьToolStripMenuItem.Name = "расшифроватьToolStripMenuItem";
            расшифроватьToolStripMenuItem.Size = new Size(194, 26);
            расшифроватьToolStripMenuItem.Text = "Расшифровать";
            расшифроватьToolStripMenuItem.Click += расшифроватьToolStripMenuItem_Click;
            // 
            // standart_text
            // 
            standart_text.AutoSize = true;
            standart_text.Location = new Point(98, 82);
            standart_text.Margin = new Padding(4, 0, 4, 0);
            standart_text.Name = "standart_text";
            standart_text.Size = new Size(139, 20);
            standart_text.TabIndex = 2;
            standart_text.Text = "Стандартный текст";
            // 
            // Key
            // 
            Key.AutoSize = true;
            Key.Location = new Point(18, 350);
            Key.Margin = new Padding(4, 0, 4, 0);
            Key.Name = "Key";
            Key.Size = new Size(46, 20);
            Key.TabIndex = 3;
            Key.Text = "Ключ";
            // 
            // Decode_text
            // 
            Decode_text.Cursor = Cursors.IBeam;
            Decode_text.Location = new Point(450, 106);
            Decode_text.Margin = new Padding(4, 5, 4, 5);
            Decode_text.Multiline = true;
            Decode_text.Name = "Decode_text";
            Decode_text.ReadOnly = true;
            Decode_text.ScrollBars = ScrollBars.Vertical;
            Decode_text.Size = new Size(316, 236);
            Decode_text.TabIndex = 4;
            // 
            // shifr_text
            // 
            shifr_text.AutoSize = true;
            shifr_text.Location = new Point(538, 82);
            shifr_text.Margin = new Padding(4, 0, 4, 0);
            shifr_text.Name = "shifr_text";
            shifr_text.Size = new Size(157, 20);
            shifr_text.TabIndex = 5;
            shifr_text.Text = "Зашифрованый текст";
            // 
            // Encode
            // 
            Encode.Location = new Point(16, 42);
            Encode.Margin = new Padding(4, 5, 4, 5);
            Encode.Name = "Encode";
            Encode.Size = new Size(132, 35);
            Encode.TabIndex = 6;
            Encode.Text = "Зашифровать";
            Encode.UseVisualStyleBackColor = true;
            Encode.Click += Encode_Click;
            // 
            // key_text
            // 
            key_text.Location = new Point(18, 374);
            key_text.Margin = new Padding(4, 5, 4, 5);
            key_text.MaxLength = 56;
            key_text.Name = "key_text";
            key_text.Size = new Size(424, 27);
            key_text.TabIndex = 7;
            key_text.Text = "Random Key";
            // 
            // swap_button
            // 
            swap_button.Location = new Point(342, 208);
            swap_button.Margin = new Padding(4, 5, 4, 5);
            swap_button.Name = "swap_button";
            swap_button.Size = new Size(100, 35);
            swap_button.TabIndex = 10;
            swap_button.Text = "<--->";
            swap_button.UseVisualStyleBackColor = true;
            swap_button.Click += swap_Click;
            // 
            // DeCode
            // 
            DeCode.Location = new Point(156, 42);
            DeCode.Margin = new Padding(4, 5, 4, 5);
            DeCode.Name = "DeCode";
            DeCode.Size = new Size(132, 35);
            DeCode.TabIndex = 11;
            DeCode.Text = "Расшифровать";
            DeCode.UseVisualStyleBackColor = true;
            DeCode.Click += DeCode_Click;
            // 
            // version
            // 
            version.AutoSize = true;
            version.Location = new Point(716, 386);
            version.Margin = new Padding(4, 0, 4, 0);
            version.Name = "version";
            version.Size = new Size(46, 20);
            version.TabIndex = 12;
            version.Text = "v1.3.1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Все файлы (*.*)|*.*";
            // 
            // clear_encode
            // 
            clear_encode.Location = new Point(342, 126);
            clear_encode.Margin = new Padding(4, 5, 4, 5);
            clear_encode.Name = "clear_encode";
            clear_encode.Size = new Size(100, 35);
            clear_encode.TabIndex = 13;
            clear_encode.Text = "<-- Clear";
            clear_encode.UseVisualStyleBackColor = true;
            clear_encode.Click += clear_encode_Click;
            // 
            // clear_decode
            // 
            clear_decode.Location = new Point(342, 286);
            clear_decode.Margin = new Padding(4, 5, 4, 5);
            clear_decode.Name = "clear_decode";
            clear_decode.Size = new Size(100, 35);
            clear_decode.TabIndex = 14;
            clear_decode.Text = "Clear -->";
            clear_decode.UseVisualStyleBackColor = true;
            clear_decode.Click += clear_decode_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(342, 42);
            progressBar1.Margin = new Padding(4, 5, 4, 5);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 35);
            progressBar1.TabIndex = 16;
            progressBar1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 426);
            Controls.Add(progressBar1);
            Controls.Add(clear_decode);
            Controls.Add(clear_encode);
            Controls.Add(version);
            Controls.Add(DeCode);
            Controls.Add(swap_button);
            Controls.Add(key_text);
            Controls.Add(Encode);
            Controls.Add(shifr_text);
            Controls.Add(Decode_text);
            Controls.Add(Key);
            Controls.Add(standart_text);
            Controls.Add(Encode_text);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Encode_text;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private Label standart_text;
        private Label Key;
        private TextBox Decode_text;
        private Label shifr_text;
        private Button Encode;
        private TextBox key_text;
        private Button swap_button;
        private Button DeCode;
        private Label version;
        private OpenFileDialog openFileDialog1;
        private Button clear_encode;
        private Button clear_decode;
        private ProgressBar progressBar1;
        private ToolStripMenuItem расшифроватьToolStripMenuItem;
    }
}