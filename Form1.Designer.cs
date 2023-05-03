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
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            Key = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            Code = new Button();
            keyBox = new TextBox();
            button3 = new Button();
            button1 = new Button();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            button4 = new Button();
            зашифрованыйТекстToolStripMenuItem = new ToolStripMenuItem();
            стандартныйТекстToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 69);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 155);
            textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(740, 24);
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
            загрузитьToolStripMenuItem.Size = new Size(129, 22);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            загрузитьToolStripMenuItem.Click += загрузитьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зашифрованыйТекстToolStripMenuItem, стандартныйТекстToolStripMenuItem });
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(129, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 53);
            label1.Name = "label1";
            label1.Size = new Size(109, 13);
            label1.TabIndex = 2;
            label1.Text = "Стандартный текст";
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
            // textBox2
            // 
            textBox2.Location = new Point(338, 69);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 155);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 53);
            label2.Name = "label2";
            label2.Size = new Size(117, 13);
            label2.TabIndex = 5;
            label2.Text = "Зашифрованый текст";
            // 
            // Code
            // 
            Code.Location = new Point(12, 27);
            Code.Name = "Code";
            Code.Size = new Size(98, 23);
            Code.TabIndex = 6;
            Code.Text = "Зашифровать";
            Code.UseVisualStyleBackColor = true;
            Code.Click += button1_Click;
            // 
            // keyBox
            // 
            keyBox.Location = new Point(13, 243);
            keyBox.MaxLength = 72;
            keyBox.Name = "keyBox";
            keyBox.Size = new Size(328, 21);
            keyBox.TabIndex = 7;
            keyBox.Text = "Random Key";
            // 
            // button3
            // 
            button3.Location = new Point(257, 135);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "<--->";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(116, 27);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 11;
            button1.Text = "Расшифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(699, 255);
            label3.Name = "label3";
            label3.Size = new Size(29, 13);
            label3.TabIndex = 12;
            label3.Text = "v1.1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Все файлы (*.*)|*.*";
            // 
            // button2
            // 
            button2.Location = new Point(257, 82);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "<-- Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(257, 186);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 14;
            button4.Text = "Clear -->";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 277);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(keyBox);
            Controls.Add(Code);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(Key);
            Controls.Add(label1);
            Controls.Add(textBox1);
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

        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private Label label1;
        private Label Key;
        private TextBox textBox2;
        private Label label2;
        private Button Code;
        private TextBox keyBox;
        private Button button3;
        private Button button1;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private Button button4;
        private ToolStripMenuItem зашифрованыйТекстToolStripMenuItem;
        private ToolStripMenuItem стандартныйТекстToolStripMenuItem;
    }
}