namespace Cryptography
{
    partial class ChaumSchemeSideB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.secretKey = new System.Windows.Forms.TextBox();
            this.getKeys = new System.Windows.Forms.Button();
            this.openKey = new System.Windows.Forms.TextBox();
            this.q = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.TextBox();
            this.sendOpenKey = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.hidedMessage = new System.Windows.Forms.TextBox();
            this.getSignature = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.signature = new System.Windows.Forms.TextBox();
            this.sendSignature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Секретный ключ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Открытый ключ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Второе число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Первое число:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Выберите два простых числа:";
            // 
            // secretKey
            // 
            this.secretKey.Location = new System.Drawing.Point(114, 141);
            this.secretKey.Name = "secretKey";
            this.secretKey.Size = new System.Drawing.Size(100, 20);
            this.secretKey.TabIndex = 14;
            // 
            // getKeys
            // 
            this.getKeys.Location = new System.Drawing.Point(82, 86);
            this.getKeys.Name = "getKeys";
            this.getKeys.Size = new System.Drawing.Size(115, 23);
            this.getKeys.TabIndex = 13;
            this.getKeys.Text = "Получить ключи";
            this.getKeys.UseVisualStyleBackColor = true;
            this.getKeys.Click += new System.EventHandler(this.getKeys_Click);
            // 
            // openKey
            // 
            this.openKey.Location = new System.Drawing.Point(114, 115);
            this.openKey.Name = "openKey";
            this.openKey.Size = new System.Drawing.Size(100, 20);
            this.openKey.TabIndex = 12;
            // 
            // q
            // 
            this.q.Location = new System.Drawing.Point(114, 53);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(100, 20);
            this.q.TabIndex = 11;
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(114, 27);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(100, 20);
            this.p.TabIndex = 10;
            // 
            // sendOpenKey
            // 
            this.sendOpenKey.Location = new System.Drawing.Point(67, 167);
            this.sendOpenKey.Name = "sendOpenKey";
            this.sendOpenKey.Size = new System.Drawing.Size(161, 23);
            this.sendOpenKey.TabIndex = 20;
            this.sendOpenKey.Text = "Отправить открытый ключ";
            this.sendOpenKey.UseVisualStyleBackColor = true;
            this.sendOpenKey.Click += new System.EventHandler(this.sendOpenKey_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Полученное замаскированное сообщение:";
            // 
            // hidedMessage
            // 
            this.hidedMessage.Location = new System.Drawing.Point(114, 209);
            this.hidedMessage.Name = "hidedMessage";
            this.hidedMessage.Size = new System.Drawing.Size(100, 20);
            this.hidedMessage.TabIndex = 31;
            // 
            // getSignature
            // 
            this.getSignature.Location = new System.Drawing.Point(81, 235);
            this.getSignature.Name = "getSignature";
            this.getSignature.Size = new System.Drawing.Size(133, 23);
            this.getSignature.TabIndex = 30;
            this.getSignature.Text = "Поставить подпись";
            this.getSignature.Click += new System.EventHandler(this.getSignature_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(18, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Слепая подпись:";
            // 
            // signature
            // 
            this.signature.Location = new System.Drawing.Point(114, 264);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(100, 20);
            this.signature.TabIndex = 28;
            // 
            // sendSignature
            // 
            this.sendSignature.Location = new System.Drawing.Point(82, 293);
            this.sendSignature.Name = "sendSignature";
            this.sendSignature.Size = new System.Drawing.Size(115, 23);
            this.sendSignature.TabIndex = 27;
            this.sendSignature.Text = "Отправить подпись";
            this.sendSignature.UseVisualStyleBackColor = true;
            this.sendSignature.Click += new System.EventHandler(this.sendSignature_Click);
            // 
            // ChaumSchemeSideB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 335);
            this.Controls.Add(this.sendSignature);
            this.Controls.Add(this.signature);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.getSignature);
            this.Controls.Add(this.hidedMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sendOpenKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secretKey);
            this.Controls.Add(this.getKeys);
            this.Controls.Add(this.openKey);
            this.Controls.Add(this.q);
            this.Controls.Add(this.p);
            this.Name = "ChaumSchemeSideB";
            this.Text = "Схема Чаума";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secretKey;
        private System.Windows.Forms.Button getKeys;
        private System.Windows.Forms.TextBox openKey;
        private System.Windows.Forms.TextBox q;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.Button sendOpenKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hidedMessage;
        private System.Windows.Forms.Button getSignature;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox signature;
        private System.Windows.Forms.Button sendSignature;
    }
}