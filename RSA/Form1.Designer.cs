namespace RSA
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
            this.encriptionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.decryptionButton = new System.Windows.Forms.Button();
            this.eBox = new System.Windows.Forms.TextBox();
            this.dBox = new System.Windows.Forms.TextBox();
            this.nOpenBox = new System.Windows.Forms.TextBox();
            this.nCloseBox = new System.Windows.Forms.TextBox();
            this.getKeysButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decryptBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.encryptBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // encriptionButton
            // 
            this.encriptionButton.Location = new System.Drawing.Point(24, 21);
            this.encriptionButton.Name = "encriptionButton";
            this.encriptionButton.Size = new System.Drawing.Size(158, 23);
            this.encriptionButton.TabIndex = 0;
            this.encriptionButton.Text = "Зашифровать";
            this.encriptionButton.UseVisualStyleBackColor = true;
            this.encriptionButton.Click += new System.EventHandler(this.EncriptionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Текст после выполнения операции";
            // 
            // decryptionButton
            // 
            this.decryptionButton.Location = new System.Drawing.Point(24, 60);
            this.decryptionButton.Name = "decryptionButton";
            this.decryptionButton.Size = new System.Drawing.Size(158, 23);
            this.decryptionButton.TabIndex = 6;
            this.decryptionButton.Text = "Расшифровать";
            this.decryptionButton.UseVisualStyleBackColor = true;
            this.decryptionButton.Click += new System.EventHandler(this.DecryptionButton_Click);
            // 
            // eBox
            // 
            this.eBox.Location = new System.Drawing.Point(165, 25);
            this.eBox.Name = "eBox";
            this.eBox.Size = new System.Drawing.Size(190, 20);
            this.eBox.TabIndex = 7;
            // 
            // dBox
            // 
            this.dBox.Location = new System.Drawing.Point(165, 64);
            this.dBox.Name = "dBox";
            this.dBox.Size = new System.Drawing.Size(190, 20);
            this.dBox.TabIndex = 8;
            // 
            // nOpenBox
            // 
            this.nOpenBox.Location = new System.Drawing.Point(361, 27);
            this.nOpenBox.Name = "nOpenBox";
            this.nOpenBox.Size = new System.Drawing.Size(175, 20);
            this.nOpenBox.TabIndex = 9;
            // 
            // nCloseBox
            // 
            this.nCloseBox.Location = new System.Drawing.Point(361, 64);
            this.nCloseBox.Name = "nCloseBox";
            this.nCloseBox.Size = new System.Drawing.Size(175, 20);
            this.nCloseBox.TabIndex = 10;
            // 
            // getKeysButton
            // 
            this.getKeysButton.Location = new System.Drawing.Point(33, 27);
            this.getKeysButton.Name = "getKeysButton";
            this.getKeysButton.Size = new System.Drawing.Size(123, 44);
            this.getKeysButton.TabIndex = 12;
            this.getKeysButton.Text = "Сгенерировать ключи";
            this.getKeysButton.UseVisualStyleBackColor = true;
            this.getKeysButton.Click += new System.EventHandler(this.GetKeysButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Открытый ключ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Закрытый ключ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getKeysButton);
            this.groupBox1.Controls.Add(this.nOpenBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.eBox);
            this.groupBox1.Controls.Add(this.dBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nCloseBox);
            this.groupBox1.Location = new System.Drawing.Point(188, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 95);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генератор ключей";
            // 
            // decryptBox
            // 
            this.decryptBox.Location = new System.Drawing.Point(387, 131);
            this.decryptBox.Multiline = true;
            this.decryptBox.Name = "decryptBox";
            this.decryptBox.Size = new System.Drawing.Size(343, 269);
            this.decryptBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Исходный текст";
            // 
            // encryptBox
            // 
            this.encryptBox.Location = new System.Drawing.Point(12, 131);
            this.encryptBox.Multiline = true;
            this.encryptBox.Name = "encryptBox";
            this.encryptBox.Size = new System.Drawing.Size(343, 269);
            this.encryptBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 412);
            this.Controls.Add(this.encryptBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.decryptBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.decryptionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encriptionButton);
            this.Name = "Form1";
            this.Text = "RSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encriptionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decryptionButton;
        private System.Windows.Forms.TextBox eBox;
        private System.Windows.Forms.TextBox dBox;
        private System.Windows.Forms.TextBox nOpenBox;
        private System.Windows.Forms.TextBox nCloseBox;
        private System.Windows.Forms.Button getKeysButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox decryptBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox encryptBox;
    }
}

