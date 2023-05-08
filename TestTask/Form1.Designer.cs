namespace TestTask
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.minWords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minWordsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxWordsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.filesNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.acceptButton = new System.Windows.Forms.Button();
            this.folderNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseFolderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minWordsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWordsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesNumberNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // minWords
            // 
            this.minWords.AutoSize = true;
            this.minWords.Location = new System.Drawing.Point(78, 69);
            this.minWords.Name = "minWords";
            this.minWords.Size = new System.Drawing.Size(326, 16);
            this.minWords.TabIndex = 0;
            this.minWords.Text = "Укажите минимальное количество слов в файле";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Укажите максимальное количество слов в файле";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Укажите количество файлов, котрые необходимо сгенерировать";
            // 
            // minWordsNumericUpDown
            // 
            this.minWordsNumericUpDown.Location = new System.Drawing.Point(81, 106);
            this.minWordsNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.minWordsNumericUpDown.Name = "minWordsNumericUpDown";
            this.minWordsNumericUpDown.Size = new System.Drawing.Size(323, 22);
            this.minWordsNumericUpDown.TabIndex = 3;
            // 
            // maxWordsNumericUpDown
            // 
            this.maxWordsNumericUpDown.Location = new System.Drawing.Point(81, 182);
            this.maxWordsNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxWordsNumericUpDown.Name = "maxWordsNumericUpDown";
            this.maxWordsNumericUpDown.Size = new System.Drawing.Size(323, 22);
            this.maxWordsNumericUpDown.TabIndex = 4;
            // 
            // filesNumberNumericUpDown
            // 
            this.filesNumberNumericUpDown.Location = new System.Drawing.Point(81, 253);
            this.filesNumberNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.filesNumberNumericUpDown.Name = "filesNumberNumericUpDown";
            this.filesNumberNumericUpDown.Size = new System.Drawing.Size(323, 22);
            this.filesNumberNumericUpDown.TabIndex = 5;
            this.filesNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(186, 376);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(120, 50);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // folderNameTB
            // 
            this.folderNameTB.Location = new System.Drawing.Point(81, 322);
            this.folderNameTB.Name = "folderNameTB";
            this.folderNameTB.Size = new System.Drawing.Size(264, 22);
            this.folderNameTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите папку для генерации файлов";
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.Location = new System.Drawing.Point(351, 307);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(94, 43);
            this.chooseFolderButton.TabIndex = 9;
            this.chooseFolderButton.Text = "Выбрать";
            this.chooseFolderButton.UseVisualStyleBackColor = true;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.chooseFolderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderNameTB);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.filesNumberNumericUpDown);
            this.Controls.Add(this.maxWordsNumericUpDown);
            this.Controls.Add(this.minWordsNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генерация файлов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.minWordsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWordsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesNumberNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label minWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown minWordsNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxWordsNumericUpDown;
        private System.Windows.Forms.NumericUpDown filesNumberNumericUpDown;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox folderNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseFolderButton;
    }
}

