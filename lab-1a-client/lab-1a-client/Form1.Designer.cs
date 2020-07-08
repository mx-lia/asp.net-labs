namespace lab_1a_client
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
            this.Number1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.NumericUpDown();
            this.Result = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Number1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number2)).BeginInit();
            this.SuspendLayout();
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(14, 44);
            this.Number1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(120, 22);
            this.Number1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(163, 44);
            this.Number2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(120, 22);
            this.Number2.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(337, 47);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 17);
            this.Result.TabIndex = 4;
            this.Result.UseWaitCursor = true;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(289, 44);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(42, 23);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "=";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 104);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Number1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Number1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Number2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Calculate;
    }
}

