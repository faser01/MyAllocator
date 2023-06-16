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
            this.usedMemLabel = new System.Windows.Forms.Label();
            this.freeMemLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.freeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(52, 111);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 0;
            // 
            // AllocButton
            // 
            this.AllocButton.Location = new System.Drawing.Point(52, 149);
            this.AllocButton.Name = "AllocButton";
            this.AllocButton.Size = new System.Drawing.Size(75, 23);
            this.AllocButton.TabIndex = 1;
            this.AllocButton.Text = "выделить";
            this.AllocButton.UseVisualStyleBackColor = true;
            this.AllocButton.Click += new System.EventHandler(this.AllocButton_Click);
            // 
            // usedMemLabel
            // 
            this.usedMemLabel.AutoSize = true;
            this.usedMemLabel.Location = new System.Drawing.Point(49, 27);
            this.usedMemLabel.Name = "usedMemLabel";
            this.usedMemLabel.Size = new System.Drawing.Size(35, 13);
            this.usedMemLabel.TabIndex = 2;
            this.usedMemLabel.Text = "label1";
            // 
            // freeMemLabel
            // 
            this.freeMemLabel.AutoSize = true;
            this.freeMemLabel.Location = new System.Drawing.Point(49, 55);
            this.freeMemLabel.Name = "freeMemLabel";
            this.freeMemLabel.Size = new System.Drawing.Size(35, 13);
            this.freeMemLabel.TabIndex = 3;
            this.freeMemLabel.Text = "label2";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(49, 84);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(35, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "label1";
            // 
            // freeButton
            // 
            this.freeButton.Location = new System.Drawing.Point(146, 149);
            this.freeButton.Name = "freeButton";
            this.freeButton.Size = new System.Drawing.Size(75, 23);
            this.freeButton.TabIndex = 5;
            this.freeButton.Text = "освободить";
            this.freeButton.UseVisualStyleBackColor = true;
            this.freeButton.Click += new System.EventHandler(this.freeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 253);
            this.Controls.Add(this.freeButton);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.freeMemLabel);
            this.Controls.Add(this.usedMemLabel);
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
        private System.Windows.Forms.Label usedMemLabel;
        private System.Windows.Forms.Label freeMemLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button freeButton;
    }
}

