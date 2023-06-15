namespace MyAllocator
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
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.AllocButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(52, 145);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 0;
            // 
            // AllocButton
            // 
            this.AllocButton.Location = new System.Drawing.Point(64, 206);
            this.AllocButton.Name = "AllocButton";
            this.AllocButton.Size = new System.Drawing.Size(75, 23);
            this.AllocButton.TabIndex = 1;
            this.AllocButton.Text = "Alloc";
            this.AllocButton.UseVisualStyleBackColor = true;
            this.AllocButton.Click += new System.EventHandler(this.AllocButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllocButton);
            this.Controls.Add(this.sizeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Button AllocButton;
    }
}

