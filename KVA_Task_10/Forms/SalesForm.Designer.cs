namespace KVA_Task_10.Forms
{
    partial class SalesForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxShip = new TextBox();
            comboBoxSort = new ComboBox();
            dataGridView1 = new DataGridView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            buttonAdd = new Button();
            label4 = new Label();
            comboBoxCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.Location = new Point(36, 26);
            label1.Name = "label1";
            label1.Size = new Size(206, 31);
            label1.TabIndex = 0;
            label1.Text = "Название товара:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(539, 82);
            label2.Name = "label2";
            label2.Size = new Size(185, 31);
            label2.TabIndex = 1;
            label2.Text = "Сортировка по:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(36, 147);
            label3.Name = "label3";
            label3.Size = new Size(216, 31);
            label3.TabIndex = 2;
            label3.Text = "Результат запроса:";
            // 
            // textBoxShip
            // 
            textBoxShip.Location = new Point(248, 26);
            textBoxShip.Name = "textBoxShip";
            textBoxShip.Size = new Size(282, 27);
            textBoxShip.TabIndex = 3;
            textBoxShip.TextChanged += textBoxShip_TextChanged;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(730, 85);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(271, 28);
            comboBoxSort.TabIndex = 4;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1014, 362);
            dataGridView1.TabIndex = 5;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 547);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1013, 26);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(59, 20);
            toolStripStatusLabel1.Text = "Логин: ";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(64, 20);
            toolStripStatusLabel2.Text = "Доступ: ";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(770, 11);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(117, 51);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Добавить товар";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(36, 79);
            label4.Name = "label4";
            label4.Size = new Size(131, 31);
            label4.TabIndex = 12;
            label4.Text = "Категория:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(248, 85);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(282, 28);
            comboBoxCategory.TabIndex = 13;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 573);
            Controls.Add(comboBoxCategory);
            Controls.Add(label4);
            Controls.Add(buttonAdd);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxSort);
            Controls.Add(textBoxShip);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SalesForm";
            Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxShip;
        private ComboBox comboBoxSort;
        private DataGridView dataGridView1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Button buttonAdd;
        private Label label4;
        private ComboBox comboBoxCategory;
    }
}