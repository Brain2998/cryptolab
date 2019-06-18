namespace Cryptography
{
    partial class ChaumSchemeSideA
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
            this.label1 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.hideMessage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hidedMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openKey = new System.Windows.Forms.TextBox();
            this.module = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendHideMessage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.recievedSignature = new System.Windows.Forms.TextBox();
            this.getSignature = new System.Windows.Forms.Button();
            this.signature = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите сообщение:";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(16, 100);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(256, 112);
            this.message.TabIndex = 1;
            // 
            // hideMessage
            // 
            this.hideMessage.Location = new System.Drawing.Point(58, 218);
            this.hideMessage.Name = "hideMessage";
            this.hideMessage.Size = new System.Drawing.Size(169, 23);
            this.hideMessage.TabIndex = 2;
            this.hideMessage.Text = "Замаскировать сообщение";
            this.hideMessage.UseVisualStyleBackColor = true;
            this.hideMessage.Click += new System.EventHandler(this.hideMessage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Замаскированное сообщение:";
            // 
            // hidedMessage
            // 
            this.hidedMessage.Location = new System.Drawing.Point(186, 248);
            this.hidedMessage.Name = "hidedMessage";
            this.hidedMessage.Size = new System.Drawing.Size(100, 20);
            this.hidedMessage.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Полученная информация:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Открытый ключ:";
            // 
            // openKey
            // 
            this.openKey.Location = new System.Drawing.Point(186, 31);
            this.openKey.Name = "openKey";
            this.openKey.Size = new System.Drawing.Size(100, 20);
            this.openKey.TabIndex = 7;
            // 
            // module
            // 
            this.module.Location = new System.Drawing.Point(186, 57);
            this.module.Name = "module";
            this.module.Size = new System.Drawing.Size(100, 20);
            this.module.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Модуль:";
            // 
            // sendHideMessage
            // 
            this.sendHideMessage.Location = new System.Drawing.Point(47, 284);
            this.sendHideMessage.Name = "sendHideMessage";
            this.sendHideMessage.Size = new System.Drawing.Size(225, 23);
            this.sendHideMessage.TabIndex = 10;
            this.sendHideMessage.Text = "Отправить замаскированное сообщение";
            this.sendHideMessage.UseVisualStyleBackColor = true;
            this.sendHideMessage.Click += new System.EventHandler(this.sendHideMessage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Полученная слепая подпись:";
            // 
            // recievedSignature
            // 
            this.recievedSignature.Location = new System.Drawing.Point(186, 320);
            this.recievedSignature.Name = "recievedSignature";
            this.recievedSignature.Size = new System.Drawing.Size(100, 20);
            this.recievedSignature.TabIndex = 12;
            // 
            // getSignature
            // 
            this.getSignature.Location = new System.Drawing.Point(102, 355);
            this.getSignature.Name = "getSignature";
            this.getSignature.Size = new System.Drawing.Size(125, 23);
            this.getSignature.TabIndex = 13;
            this.getSignature.Text = "Получить подпись";
            this.getSignature.UseVisualStyleBackColor = true;
            this.getSignature.Click += new System.EventHandler(this.getSignature_Click);
            // 
            // signature
            // 
            this.signature.Location = new System.Drawing.Point(186, 385);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(100, 20);
            this.signature.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Подпись:";
            // 
            // ChaumSchemeSideA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 417);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signature);
            this.Controls.Add(this.getSignature);
            this.Controls.Add(this.recievedSignature);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sendHideMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.module);
            this.Controls.Add(this.openKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hidedMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hideMessage);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label1);
            this.Name = "ChaumSchemeSideA";
            this.Text = "Схема Чаума";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button hideMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hidedMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox openKey;
        private System.Windows.Forms.TextBox module;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sendHideMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox recievedSignature;
        private System.Windows.Forms.Button getSignature;
        private System.Windows.Forms.TextBox signature;
        private System.Windows.Forms.Label label7;
    }
}