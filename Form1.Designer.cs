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
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            зашифрованыйТекстToolStripMenuItem = new ToolStripMenuItem();
            стандартныйТекстToolStripMenuItem = new ToolStripMenuItem();
            standart_text = new Label();
            Key = new Label();
            Decode_text = new TextBox();
            shifr_text = new Label();
            Code = new Button();
            key_text = new TextBox();
            swap_button = new Button();
            DeCode = new Button();
            version = new Label();
            openFileDialog1 = new OpenFileDialog();
            clear_encode = new Button();
            clear_decode = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Encode_text
            // 
            Encode_text.Location = new Point(13, 69);
            Encode_text.Multiline = true;
            Encode_text.Name = "Encode_text";
            Encode_text.Size = new Size(238, 155);
            Encode_text.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(725, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загрузитьToolStripMenuItem, сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(45, 20);
            файлToolStripMenuItem.Text = "файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(180, 22);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            загрузитьToolStripMenuItem.Click += загрузитьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зашифрованыйТекстToolStripMenuItem, стандартныйТекстToolStripMenuItem });
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(180, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // зашифрованыйТекстToolStripMenuItem
            // 
            зашифрованыйТекстToolStripMenuItem.Name = "зашифрованыйТекстToolStripMenuItem";
            зашифрованыйТекстToolStripMenuItem.Size = new Size(184, 22);
            зашифрованыйТекстToolStripMenuItem.Text = "Зашифрованый текст";
            // 
            // стандартныйТекстToolStripMenuItem
            // 
            стандартныйТекстToolStripMenuItem.Name = "стандартныйТекстToolStripMenuItem";
            стандартныйТекстToolStripMenuItem.Size = new Size(184, 22);
            стандартныйТекстToolStripMenuItem.Text = "Стандартный текст";
            // 
            // standart_text
            // 
            standart_text.AutoSize = true;
            standart_text.Location = new Point(73, 53);
            standart_text.Name = "standart_text";
            standart_text.Size = new Size(109, 13);
            standart_text.TabIndex = 2;
            standart_text.Text = "Стандартный текст";
            // 
            // Key
            // 
            Key.AutoSize = true;
            Key.Location = new Point(13, 227);
            Key.Name = "Key";
            Key.Size = new Size(35, 13);
            Key.TabIndex = 3;
            Key.Text = "Ключ";
            // 
            // Decode_text
            // 
            Decode_text.Cursor = Cursors.IBeam;
            Decode_text.Location = new Point(338, 69);
            Decode_text.Multiline = true;
            Decode_text.Name = "Decode_text";
            Decode_text.Size = new Size(373, 155);
            Decode_text.TabIndex = 4;
            // 
            // shifr_text
            // 
            shifr_text.AutoSize = true;
            shifr_text.Location = new Point(477, 53);
            shifr_text.Name = "shifr_text";
            shifr_text.Size = new Size(117, 13);
            shifr_text.TabIndex = 5;
            shifr_text.Text = "Зашифрованый текст";
            // 
            // Code
            // 
            Code.Location = new Point(12, 27);
            Code.Name = "Code";
            Code.Size = new Size(99, 23);
            Code.TabIndex = 6;
            Code.Text = "Зашифровать";
            Code.UseVisualStyleBackColor = true;
            Code.Click += code_Click;
            // 
            // key_text
            // 
            key_text.Location = new Point(13, 243);
            key_text.MaxLength = 72;
            key_text.Name = "key_text";
            key_text.Size = new Size(319, 21);
            key_text.TabIndex = 7;
            key_text.Text = "Random Key";
            // 
            // swap_button
            // 
            swap_button.Location = new Point(257, 135);
            swap_button.Name = "swap_button";
            swap_button.Size = new Size(75, 23);
            swap_button.TabIndex = 10;
            swap_button.Text = "<--->";
            swap_button.UseVisualStyleBackColor = true;
            swap_button.Click += swap_Click;
            // 
            // DeCode
            // 
            DeCode.Location = new Point(117, 27);
            DeCode.Name = "DeCode";
            DeCode.Size = new Size(99, 23);
            DeCode.TabIndex = 11;
            DeCode.Text = "Расшифровать";
            DeCode.UseVisualStyleBackColor = true;
            DeCode.Click += DeCode_Click;
            // 
            // version
            // 
            version.AutoSize = true;
            version.Location = new Point(682, 255);
            version.Name = "version";
            version.Size = new Size(29, 13);
            version.TabIndex = 12;
            version.Text = "v1.1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Все файлы (*.*)|*.*";
            // 
            // clear_encode
            // 
            clear_encode.Location = new Point(257, 82);
            clear_encode.Name = "clear_encode";
            clear_encode.Size = new Size(75, 23);
            clear_encode.TabIndex = 13;
            clear_encode.Text = "<-- Clear";
            clear_encode.UseVisualStyleBackColor = true;
            clear_encode.Click += clear_encode_Click;
            // 
            // clear_decode
            // 
            clear_decode.Location = new Point(257, 186);
            clear_decode.Name = "clear_decode";
            clear_decode.Size = new Size(75, 23);
            clear_decode.TabIndex = 14;
            clear_decode.Text = "Clear -->";
            clear_decode.UseVisualStyleBackColor = true;
            clear_decode.Click += clear_decode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 277);
            Controls.Add(clear_decode);
            Controls.Add(clear_encode);
            Controls.Add(version);
            Controls.Add(DeCode);
            Controls.Add(swap_button);
            Controls.Add(key_text);
            Controls.Add(Code);
            Controls.Add(shifr_text);
            Controls.Add(Decode_text);
            Controls.Add(Key);
            Controls.Add(standart_text);
            Controls.Add(Encode_text);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private Label standart_text;
        private Label Key;
        private TextBox Decode_text;
        private Label shifr_text;
        private Button Code;
        private TextBox key_text;
        private Button swap_button;
        private Button DeCode;
        private Label version;
        private OpenFileDialog openFileDialog1;
        private Button clear_encode;
        private Button clear_decode;
        private ToolStripMenuItem зашифрованыйТекстToolStripMenuItem;
        private ToolStripMenuItem стандартныйТекстToolStripMenuItem;
    }
}