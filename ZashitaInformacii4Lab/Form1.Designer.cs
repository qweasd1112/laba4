namespace ZashitaInformacii4Lab
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.generateKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.messageTxtBox = new System.Windows.Forms.TextBox();
            this.deshifrMessageTxtBox = new System.Windows.Forms.TextBox();
            this.shifrMessageTxtBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.keyLength = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openMessage = new System.Windows.Forms.Button();
            this.saveMessage = new System.Windows.Forms.Button();
            this.openShifr = new System.Windows.Forms.Button();
            this.saveShifr = new System.Windows.Forms.Button();
            this.openKey = new System.Windows.Forms.Button();
            this.saveKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ключ:";
            // 
            // key
            // 
            this.key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.key.Location = new System.Drawing.Point(54, 7);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(500, 20);
            this.key.TabIndex = 1;
            // 
            // generateKey
            // 
            this.generateKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateKey.Location = new System.Drawing.Point(560, 5);
            this.generateKey.Name = "generateKey";
            this.generateKey.Size = new System.Drawing.Size(101, 23);
            this.generateKey.TabIndex = 2;
            this.generateKey.Text = "Сгенерировать";
            this.generateKey.UseVisualStyleBackColor = true;
            this.generateKey.Click += new System.EventHandler(this.generateKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сообщение:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Зашифрованное сообщение";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дешифрованное сообщение";
            // 
            // messageTxtBox
            // 
            this.messageTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.messageTxtBox.Location = new System.Drawing.Point(12, 74);
            this.messageTxtBox.Multiline = true;
            this.messageTxtBox.Name = "messageTxtBox";
            this.messageTxtBox.Size = new System.Drawing.Size(275, 347);
            this.messageTxtBox.TabIndex = 6;
            // 
            // deshifrMessageTxtBox
            // 
            this.deshifrMessageTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.deshifrMessageTxtBox.Location = new System.Drawing.Point(606, 74);
            this.deshifrMessageTxtBox.Multiline = true;
            this.deshifrMessageTxtBox.Name = "deshifrMessageTxtBox";
            this.deshifrMessageTxtBox.ReadOnly = true;
            this.deshifrMessageTxtBox.Size = new System.Drawing.Size(275, 347);
            this.deshifrMessageTxtBox.TabIndex = 7;
            // 
            // shifrMessageTxtBox
            // 
            this.shifrMessageTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.shifrMessageTxtBox.Location = new System.Drawing.Point(325, 74);
            this.shifrMessageTxtBox.Multiline = true;
            this.shifrMessageTxtBox.Name = "shifrMessageTxtBox";
            this.shifrMessageTxtBox.Size = new System.Drawing.Size(275, 347);
            this.shifrMessageTxtBox.TabIndex = 8;
            this.shifrMessageTxtBox.TextChanged += new System.EventHandler(this.shifrMessageTxtBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Длина ключа:";
            // 
            // keyLength
            // 
            this.keyLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keyLength.Location = new System.Drawing.Point(750, 7);
            this.keyLength.Name = "keyLength";
            this.keyLength.Size = new System.Drawing.Size(131, 20);
            this.keyLength.TabIndex = 12;
            this.keyLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyLength_KeyPress);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt files (*.txt)|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            // 
            // openMessage
            // 
            this.openMessage.Location = new System.Drawing.Point(15, 439);
            this.openMessage.Name = "openMessage";
            this.openMessage.Size = new System.Drawing.Size(111, 23);
            this.openMessage.TabIndex = 13;
            this.openMessage.Text = "Открыть";
            this.openMessage.UseVisualStyleBackColor = true;
            this.openMessage.Click += new System.EventHandler(this.open_Click);
            // 
            // saveMessage
            // 
            this.saveMessage.Location = new System.Drawing.Point(176, 439);
            this.saveMessage.Name = "saveMessage";
            this.saveMessage.Size = new System.Drawing.Size(111, 23);
            this.saveMessage.TabIndex = 14;
            this.saveMessage.Text = "Сохранить";
            this.saveMessage.UseVisualStyleBackColor = true;
            this.saveMessage.Click += new System.EventHandler(this.save_Click);
            // 
            // openShifr
            // 
            this.openShifr.Location = new System.Drawing.Point(325, 439);
            this.openShifr.Name = "openShifr";
            this.openShifr.Size = new System.Drawing.Size(111, 23);
            this.openShifr.TabIndex = 15;
            this.openShifr.Text = "Открыть";
            this.openShifr.UseVisualStyleBackColor = true;
            this.openShifr.Click += new System.EventHandler(this.open_Click);
            // 
            // saveShifr
            // 
            this.saveShifr.Location = new System.Drawing.Point(489, 439);
            this.saveShifr.Name = "saveShifr";
            this.saveShifr.Size = new System.Drawing.Size(111, 23);
            this.saveShifr.TabIndex = 16;
            this.saveShifr.Text = "Сохранить";
            this.saveShifr.UseVisualStyleBackColor = true;
            this.saveShifr.Click += new System.EventHandler(this.save_Click);
            // 
            // openKey
            // 
            this.openKey.Location = new System.Drawing.Point(334, 31);
            this.openKey.Name = "openKey";
            this.openKey.Size = new System.Drawing.Size(107, 23);
            this.openKey.TabIndex = 17;
            this.openKey.Text = "Открыть ключ";
            this.openKey.UseVisualStyleBackColor = true;
            this.openKey.Click += new System.EventHandler(this.open_Click);
            // 
            // saveKey
            // 
            this.saveKey.Location = new System.Drawing.Point(447, 31);
            this.saveKey.Name = "saveKey";
            this.saveKey.Size = new System.Drawing.Size(107, 24);
            this.saveKey.TabIndex = 18;
            this.saveKey.Text = "Сохранить ключ";
            this.saveKey.UseVisualStyleBackColor = true;
            this.saveKey.Click += new System.EventHandler(this.save_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 466);
            this.Controls.Add(this.saveKey);
            this.Controls.Add(this.openKey);
            this.Controls.Add(this.saveShifr);
            this.Controls.Add(this.openShifr);
            this.Controls.Add(this.saveMessage);
            this.Controls.Add(this.openMessage);
            this.Controls.Add(this.keyLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.shifrMessageTxtBox);
            this.Controls.Add(this.deshifrMessageTxtBox);
            this.Controls.Add(this.messageTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateKey);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(903, 504);
            this.Name = "mainForm";
            this.Text = "Защита информации. Лабораторная работа №4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button generateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox messageTxtBox;
        private System.Windows.Forms.TextBox deshifrMessageTxtBox;
        private System.Windows.Forms.TextBox shifrMessageTxtBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox keyLength;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button openMessage;
        private System.Windows.Forms.Button saveMessage;
        private System.Windows.Forms.Button openShifr;
        private System.Windows.Forms.Button saveShifr;
        private System.Windows.Forms.Button openKey;
        private System.Windows.Forms.Button saveKey;
    }
}

