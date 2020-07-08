namespace lab_7c
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
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.recordID = new System.Windows.Forms.TextBox();
            this.records = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(579, 138);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(156, 44);
            this.delete.TabIndex = 14;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(579, 82);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(156, 43);
            this.update.TabIndex = 13;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(579, 27);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(156, 43);
            this.insert.TabIndex = 12;
            this.insert.Text = "INSERT";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.recordID);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 170);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "PHONE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(148, 93);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(237, 22);
            this.phone.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(148, 65);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(237, 22);
            this.name.TabIndex = 1;
            // 
            // recordID
            // 
            this.recordID.Location = new System.Drawing.Point(148, 37);
            this.recordID.Name = "recordID";
            this.recordID.Size = new System.Drawing.Size(237, 22);
            this.recordID.TabIndex = 0;
            // 
            // records
            // 
            this.records.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.records.Location = new System.Drawing.Point(28, 203);
            this.records.Name = "records";
            this.records.RowHeadersWidth = 51;
            this.records.RowTemplate.Height = 24;
            this.records.Size = new System.Drawing.Size(734, 266);
            this.records.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 478);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.records);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox recordID;
        private System.Windows.Forms.DataGridView records;
    }
}

