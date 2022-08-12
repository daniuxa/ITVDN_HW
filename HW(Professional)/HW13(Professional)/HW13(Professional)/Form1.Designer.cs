namespace HW13_Professional_
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
            this.IsCompleteButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.CallbackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IsCompleteButton
            // 
            this.IsCompleteButton.Location = new System.Drawing.Point(138, 204);
            this.IsCompleteButton.Name = "IsCompleteButton";
            this.IsCompleteButton.Size = new System.Drawing.Size(121, 49);
            this.IsCompleteButton.TabIndex = 1;
            this.IsCompleteButton.Text = "IsComplete";
            this.IsCompleteButton.UseVisualStyleBackColor = true;
            this.IsCompleteButton.Click += new System.EventHandler(this.IsCompleteButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(340, 201);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(121, 49);
            this.EndButton.TabIndex = 3;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // CallbackButton
            // 
            this.CallbackButton.Location = new System.Drawing.Point(556, 204);
            this.CallbackButton.Name = "CallbackButton";
            this.CallbackButton.Size = new System.Drawing.Size(121, 49);
            this.CallbackButton.TabIndex = 4;
            this.CallbackButton.Text = "Callback";
            this.CallbackButton.UseVisualStyleBackColor = true;
            this.CallbackButton.Click += new System.EventHandler(this.CallbackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CallbackButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.IsCompleteButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button IsCompleteButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button CallbackButton;
    }
}

