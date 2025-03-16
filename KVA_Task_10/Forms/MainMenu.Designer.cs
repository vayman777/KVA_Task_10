namespace KVA_Task_10
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            menuStrip1 = new MenuStrip();
            товарыToolStripMenuItem = new ToolStripMenuItem();
            продажиToolStripMenuItem = new ToolStripMenuItem();
            авторизацияToolStripMenuItem = new ToolStripMenuItem();
            контактыToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { товарыToolStripMenuItem, продажиToolStripMenuItem, авторизацияToolStripMenuItem, контактыToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // товарыToolStripMenuItem
            // 
            товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            товарыToolStripMenuItem.Size = new Size(76, 24);
            товарыToolStripMenuItem.Text = "Товары";
            товарыToolStripMenuItem.Click += товарыToolStripMenuItem_Click;
            // 
            // продажиToolStripMenuItem
            // 
            продажиToolStripMenuItem.Enabled = false;
            продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            продажиToolStripMenuItem.Size = new Size(88, 24);
            продажиToolStripMenuItem.Text = "Продажи";
            продажиToolStripMenuItem.Click += продажиToolStripMenuItem_Click;
            // 
            // авторизацияToolStripMenuItem
            // 
            авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
            авторизацияToolStripMenuItem.Size = new Size(115, 24);
            авторизацияToolStripMenuItem.Text = "Авторизация";
            авторизацияToolStripMenuItem.Click += авторизацияToolStripMenuItem_Click;
            // 
            // контактыToolStripMenuItem
            // 
            контактыToolStripMenuItem.Name = "контактыToolStripMenuItem";
            контактыToolStripMenuItem.Size = new Size(88, 24);
            контактыToolStripMenuItem.Text = "Контакты";
            контактыToolStripMenuItem.Click += контактыToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(67, 24);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(192, 75);
            label1.Name = "label1";
            label1.Size = new Size(442, 38);
            label1.TabIndex = 1;
            label1.Text = "Добро пожаловать на аукцион!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(594, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "Аукцион";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem товарыToolStripMenuItem;
        private ToolStripMenuItem продажиToolStripMenuItem;
        private ToolStripMenuItem авторизацияToolStripMenuItem;
        private ToolStripMenuItem контактыToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
