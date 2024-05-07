namespace shar_predskazaniy
{
    partial class Form1
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
            this.probabilitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.generateButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.Событие = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вероятность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.probabilitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // probabilitiesDataGridView
            // 
            this.probabilitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.probabilitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Событие,
            this.Вероятность});
            this.probabilitiesDataGridView.Location = new System.Drawing.Point(506, 29);
            this.probabilitiesDataGridView.Name = "probabilitiesDataGridView";
            this.probabilitiesDataGridView.Size = new System.Drawing.Size(480, 406);
            this.probabilitiesDataGridView.TabIndex = 0;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(30, 210);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(380, 99);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(30, 29);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(380, 152);
            this.resultTextBox.TabIndex = 2;
            // 
            // Событие
            // 
            this.Событие.DataPropertyName = "Sobitie";
            this.Событие.HeaderText = "Sobitie";
            this.Событие.Name = "Событие";
            this.Событие.Width = 300;
            // 
            // Вероятность
            // 
            this.Вероятность.DataPropertyName = "Veroyatnost";
            this.Вероятность.HeaderText = "Veroyatnost";
            this.Вероятность.Name = "Вероятность";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 495);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.probabilitiesDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.probabilitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView probabilitiesDataGridView;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Событие;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вероятность;
    }
}

