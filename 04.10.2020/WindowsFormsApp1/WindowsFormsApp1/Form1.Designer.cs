namespace WindowsFormsApp1
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
            this.nLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.mBox = new System.Windows.Forms.TextBox();
            this.kBox = new System.Windows.Forms.TextBox();
            this.kLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(74, 64);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(274, 32);
            this.nLabel.TabIndex = 0;
            this.nLabel.Text = "Количество строк n";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(74, 138);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(330, 32);
            this.mLabel.TabIndex = 0;
            this.mLabel.Text = "Количество столбцов m";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(438, 58);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(100, 38);
            this.nBox.TabIndex = 1;
            // 
            // mBox
            // 
            this.mBox.Location = new System.Drawing.Point(438, 132);
            this.mBox.Name = "mBox";
            this.mBox.Size = new System.Drawing.Size(100, 38);
            this.mBox.TabIndex = 1;
            // 
            // kBox
            // 
            this.kBox.Location = new System.Drawing.Point(1102, 58);
            this.kBox.Name = "kBox";
            this.kBox.Size = new System.Drawing.Size(100, 38);
            this.kBox.TabIndex = 2;
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(807, 58);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(238, 32);
            this.kLabel.TabIndex = 3;
            this.kLabel.Text = "Номер столбца k";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(922, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ColumnHeadersVisible = false;
            this.grid.Location = new System.Drawing.Point(71, 386);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 102;
            this.grid.RowTemplate.Height = 40;
            this.grid.Size = new System.Drawing.Size(1102, 592);
            this.grid.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 1083);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kLabel);
            this.Controls.Add(this.kBox);
            this.Controls.Add(this.mBox);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.nLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.TextBox mBox;
        private System.Windows.Forms.TextBox kBox;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView grid;
    }
}

