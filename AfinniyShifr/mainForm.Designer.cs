namespace AfinniyShifr
{
    partial class mainForm
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
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.encryptBox = new System.Windows.Forms.TextBox();
            this.decryptBox = new System.Windows.Forms.TextBox();
            this.betta2Box = new System.Windows.Forms.TextBox();
            this.alf2Box = new System.Windows.Forms.TextBox();
            this.alf1Box = new System.Windows.Forms.TextBox();
            this.betta1Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(26, 36);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(102, 23);
            this.encrypt.TabIndex = 0;
            this.encrypt.Text = "Зашифровать";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(152, 36);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(101, 23);
            this.decrypt.TabIndex = 1;
            this.decrypt.Text = "Расшифровать";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encryptBox
            // 
            this.encryptBox.Location = new System.Drawing.Point(12, 67);
            this.encryptBox.Multiline = true;
            this.encryptBox.Name = "encryptBox";
            this.encryptBox.Size = new System.Drawing.Size(259, 239);
            this.encryptBox.TabIndex = 2;
            // 
            // decryptBox
            // 
            this.decryptBox.Location = new System.Drawing.Point(280, 67);
            this.decryptBox.Multiline = true;
            this.decryptBox.Name = "decryptBox";
            this.decryptBox.Size = new System.Drawing.Size(259, 239);
            this.decryptBox.TabIndex = 3;
            // 
            // betta2Box
            // 
            this.betta2Box.Location = new System.Drawing.Point(470, 38);
            this.betta2Box.Name = "betta2Box";
            this.betta2Box.Size = new System.Drawing.Size(69, 20);
            this.betta2Box.TabIndex = 4;
            // 
            // alf2Box
            // 
            this.alf2Box.Location = new System.Drawing.Point(341, 38);
            this.alf2Box.Name = "alf2Box";
            this.alf2Box.Size = new System.Drawing.Size(69, 20);
            this.alf2Box.TabIndex = 5;
            // 
            // alf1Box
            // 
            this.alf1Box.Location = new System.Drawing.Point(341, 12);
            this.alf1Box.Name = "alf1Box";
            this.alf1Box.Size = new System.Drawing.Size(69, 20);
            this.alf1Box.TabIndex = 6;
            // 
            // betta1Box
            // 
            this.betta1Box.Location = new System.Drawing.Point(470, 12);
            this.betta1Box.Name = "betta1Box";
            this.betta1Box.Size = new System.Drawing.Size(69, 20);
            this.betta1Box.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Альфа 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Альфа 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Бетта 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Бетта 2:";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(29, 11);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(99, 17);
            this.checkBox.TabIndex = 12;
            this.checkBox.Text = "Рекуррентный";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 318);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betta1Box);
            this.Controls.Add(this.alf1Box);
            this.Controls.Add(this.alf2Box);
            this.Controls.Add(this.betta2Box);
            this.Controls.Add(this.decryptBox);
            this.Controls.Add(this.encryptBox);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Name = "mainForm";
            this.Text = "Аффинный шифр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox encryptBox;
        private System.Windows.Forms.TextBox decryptBox;
        private System.Windows.Forms.TextBox betta2Box;
        private System.Windows.Forms.TextBox alf2Box;
        private System.Windows.Forms.TextBox alf1Box;
        private System.Windows.Forms.TextBox betta1Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

