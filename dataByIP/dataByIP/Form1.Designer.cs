namespace dataByIP
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
            this.InputIPTextBox = new System.Windows.Forms.TextBox();
            this.GetDataByIpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataLabel = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputIPTextBox
            // 
            this.InputIPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputIPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputIPTextBox.Location = new System.Drawing.Point(12, 45);
            this.InputIPTextBox.Multiline = true;
            this.InputIPTextBox.Name = "InputIPTextBox";
            this.InputIPTextBox.Size = new System.Drawing.Size(144, 23);
            this.InputIPTextBox.TabIndex = 0;
            // 
            // GetDataByIpButton
            // 
            this.GetDataByIpButton.FlatAppearance.BorderSize = 0;
            this.GetDataByIpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetDataByIpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetDataByIpButton.Location = new System.Drawing.Point(12, 74);
            this.GetDataByIpButton.Name = "GetDataByIpButton";
            this.GetDataByIpButton.Size = new System.Drawing.Size(81, 28);
            this.GetDataByIpButton.TabIndex = 1;
            this.GetDataByIpButton.Text = "Получить";
            this.GetDataByIpButton.UseVisualStyleBackColor = true;
            this.GetDataByIpButton.Click += new System.EventHandler(this.GetDataByIpButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataLabel.Location = new System.Drawing.Point(13, 153);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(0, 23);
            this.DataLabel.TabIndex = 3;
            this.DataLabel.Click += new System.EventHandler(this.DataLabel_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.FlatAppearance.BorderSize = 0;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoButton.Location = new System.Drawing.Point(99, 74);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(57, 28);
            this.InfoButton.TabIndex = 4;
            this.InfoButton.Text = "Инфо";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Данные:";
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(204, 486);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 28);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 526);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetDataByIpButton);
            this.Controls.Add(this.InputIPTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Узнать данные по IP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputIPTextBox;
        private System.Windows.Forms.Button GetDataByIpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CloseButton;
    }
}

