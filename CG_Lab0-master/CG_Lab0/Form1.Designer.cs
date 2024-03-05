namespace CG_Lab0
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
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            фильтрыToolStripMenuItem = new ToolStripMenuItem();
            точечныеToolStripMenuItem = new ToolStripMenuItem();
            конвертацияВОттенкиСерогоToolStripMenuItem = new ToolStripMenuItem();
            бинаризацияПоПорогуToolStripMenuItem = new ToolStripMenuItem();
            увеличениеЯркостиНаКонстантуToolStripMenuItem = new ToolStripMenuItem();
            матричныеToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 373);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, фильтрыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(121, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // фильтрыToolStripMenuItem
            // 
            фильтрыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { точечныеToolStripMenuItem, матричныеToolStripMenuItem });
            фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            фильтрыToolStripMenuItem.Size = new Size(69, 20);
            фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            точечныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { конвертацияВОттенкиСерогоToolStripMenuItem, бинаризацияПоПорогуToolStripMenuItem, увеличениеЯркостиНаКонстантуToolStripMenuItem });
            точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            точечныеToolStripMenuItem.Size = new Size(180, 22);
            точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // конвертацияВОттенкиСерогоToolStripMenuItem
            // 
            конвертацияВОттенкиСерогоToolStripMenuItem.Name = "конвертацияВОттенкиСерогоToolStripMenuItem";
            конвертацияВОттенкиСерогоToolStripMenuItem.Size = new Size(261, 22);
            конвертацияВОттенкиСерогоToolStripMenuItem.Text = "Конвертация в оттенки серого";
            конвертацияВОттенкиСерогоToolStripMenuItem.Click += конвертацияВОттенкиСерогоToolStripMenuItem_Click;
            // 
            // бинаризацияПоПорогуToolStripMenuItem
            // 
            бинаризацияПоПорогуToolStripMenuItem.Name = "бинаризацияПоПорогуToolStripMenuItem";
            бинаризацияПоПорогуToolStripMenuItem.Size = new Size(261, 22);
            бинаризацияПоПорогуToolStripMenuItem.Text = "Бинаризация по порогу";
            бинаризацияПоПорогуToolStripMenuItem.Click += бинаризацияПоПорогуToolStripMenuItem_Click;
            // 
            // увеличениеЯркостиНаКонстантуToolStripMenuItem
            // 
            увеличениеЯркостиНаКонстантуToolStripMenuItem.Name = "увеличениеЯркостиНаКонстантуToolStripMenuItem";
            увеличениеЯркостиНаКонстантуToolStripMenuItem.Size = new Size(261, 22);
            увеличениеЯркостиНаКонстантуToolStripMenuItem.Text = "Увеличение яркости на константу";
            увеличениеЯркостиНаКонстантуToolStripMenuItem.Click += увеличениеЯркостиНаКонстантуToolStripMenuItem_Click;
            // 
            // матричныеToolStripMenuItem
            // 
            матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            матричныеToolStripMenuItem.Size = new Size(180, 22);
            матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(351, 415);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem фильтрыToolStripMenuItem;
        private ToolStripMenuItem точечныеToolStripMenuItem;
        private ToolStripMenuItem конвертацияВОттенкиСерогоToolStripMenuItem;
        private ToolStripMenuItem бинаризацияПоПорогуToolStripMenuItem;
        private ToolStripMenuItem увеличениеЯркостиНаКонстантуToolStripMenuItem;
        private ToolStripMenuItem матричныеToolStripMenuItem;
        private TextBox textBox1;
    }
}