namespace shifrHilla
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
            this.enterConsole = new System.Windows.Forms.TextBox();
            this.encryptionButton = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.decryptionButton = new System.Windows.Forms.Button();
            this.encryptionConsole = new System.Windows.Forms.TextBox();
            this.keyBox1 = new System.Windows.Forms.TextBox();
            this.genKeyButton = new System.Windows.Forms.Button();
            this.keyBox2 = new System.Windows.Forms.TextBox();
            this.checkKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterConsole
            // 
            this.enterConsole.BackColor = System.Drawing.SystemColors.MenuText;
            this.enterConsole.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.enterConsole.Location = new System.Drawing.Point(19, 130);
            this.enterConsole.Multiline = true;
            this.enterConsole.Name = "enterConsole";
            this.enterConsole.Size = new System.Drawing.Size(235, 228);
            this.enterConsole.TabIndex = 0;
            // 
            // encryptionButton
            // 
            this.encryptionButton.Location = new System.Drawing.Point(19, 38);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.Size = new System.Drawing.Size(103, 23);
            this.encryptionButton.TabIndex = 1;
            this.encryptionButton.Text = "Зашифровать";
            this.encryptionButton.UseVisualStyleBackColor = true;
            this.encryptionButton.Click += new System.EventHandler(this.EncryptionButton_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(19, 12);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(93, 17);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "Рекурентный";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // decryptionButton
            // 
            this.decryptionButton.Location = new System.Drawing.Point(19, 67);
            this.decryptionButton.Name = "decryptionButton";
            this.decryptionButton.Size = new System.Drawing.Size(103, 23);
            this.decryptionButton.TabIndex = 3;
            this.decryptionButton.Text = "Расшифровать";
            this.decryptionButton.UseVisualStyleBackColor = true;
            this.decryptionButton.Click += new System.EventHandler(this.DecryptionButton_Click);
            // 
            // encryptionConsole
            // 
            this.encryptionConsole.BackColor = System.Drawing.SystemColors.MenuText;
            this.encryptionConsole.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.encryptionConsole.Location = new System.Drawing.Point(260, 130);
            this.encryptionConsole.Multiline = true;
            this.encryptionConsole.Name = "encryptionConsole";
            this.encryptionConsole.Size = new System.Drawing.Size(236, 228);
            this.encryptionConsole.TabIndex = 4;
            // 
            // keyBox1
            // 
            this.keyBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.keyBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.keyBox1.Location = new System.Drawing.Point(236, 21);
            this.keyBox1.Multiline = true;
            this.keyBox1.Name = "keyBox1";
            this.keyBox1.Size = new System.Drawing.Size(126, 69);
            this.keyBox1.TabIndex = 5;
            this.keyBox1.Text = "key 1";
            // 
            // genKeyButton
            // 
            this.genKeyButton.Location = new System.Drawing.Point(128, 21);
            this.genKeyButton.Name = "genKeyButton";
            this.genKeyButton.Size = new System.Drawing.Size(102, 35);
            this.genKeyButton.TabIndex = 6;
            this.genKeyButton.Text = "Сгенерировать ключ";
            this.genKeyButton.UseVisualStyleBackColor = true;
            this.genKeyButton.Click += new System.EventHandler(this.GenKeyButton_Click);
            // 
            // keyBox2
            // 
            this.keyBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.keyBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.keyBox2.Location = new System.Drawing.Point(368, 21);
            this.keyBox2.Multiline = true;
            this.keyBox2.Name = "keyBox2";
            this.keyBox2.Size = new System.Drawing.Size(128, 69);
            this.keyBox2.TabIndex = 7;
            this.keyBox2.Text = "key 2";
            // 
            // checkKey
            // 
            this.checkKey.Location = new System.Drawing.Point(128, 62);
            this.checkKey.Name = "checkKey";
            this.checkKey.Size = new System.Drawing.Size(102, 28);
            this.checkKey.TabIndex = 8;
            this.checkKey.Text = "Ввести ключ";
            this.checkKey.UseVisualStyleBackColor = true;
            this.checkKey.Click += new System.EventHandler(this.CheckKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Текст после обработки";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkKey);
            this.Controls.Add(this.keyBox2);
            this.Controls.Add(this.genKeyButton);
            this.Controls.Add(this.keyBox1);
            this.Controls.Add(this.encryptionConsole);
            this.Controls.Add(this.decryptionButton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.encryptionButton);
            this.Controls.Add(this.enterConsole);
            this.Name = "mainForm";
            this.Text = "Шифр Хилла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterConsole;
        private System.Windows.Forms.Button encryptionButton;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button decryptionButton;
        private System.Windows.Forms.TextBox encryptionConsole;
        private System.Windows.Forms.TextBox keyBox1;
        private System.Windows.Forms.Button genKeyButton;
        private System.Windows.Forms.TextBox keyBox2;
        private System.Windows.Forms.Button checkKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

