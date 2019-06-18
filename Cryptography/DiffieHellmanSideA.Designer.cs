namespace Cryptography
{
    partial class DiffieHellmanSideA
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
            this.a = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getX = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.recievedMessage = new System.Windows.Forms.TextBox();
            this.getKey = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.calculateSendedMessage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.sendedMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(37, 65);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 9;
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(37, 38);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(100, 20);
            this.p.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "P:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите простое число P, и натуральное A, меньшее P:";
            // 
            // getX
            // 
            this.getX.Location = new System.Drawing.Point(86, 91);
            this.getX.Name = "getX";
            this.getX.Size = new System.Drawing.Size(147, 23);
            this.getX.TabIndex = 10;
            this.getX.Text = "Сгенерировать число X";
            this.getX.UseVisualStyleBackColor = true;
            this.getX.Click += new System.EventHandler(this.getX_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X:";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(37, 120);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(100, 20);
            this.x.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Полученное сообщение:";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(127, 212);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 14;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // recievedMessage
            // 
            this.recievedMessage.Location = new System.Drawing.Point(37, 255);
            this.recievedMessage.Name = "recievedMessage";
            this.recievedMessage.Size = new System.Drawing.Size(100, 20);
            this.recievedMessage.TabIndex = 15;
            // 
            // getKey
            // 
            this.getKey.Location = new System.Drawing.Point(86, 281);
            this.getKey.Name = "getKey";
            this.getKey.Size = new System.Drawing.Size(147, 23);
            this.getKey.TabIndex = 16;
            this.getKey.Text = "Вычислить общий ключ";
            this.getKey.UseVisualStyleBackColor = true;
            this.getKey.Click += new System.EventHandler(this.getKey_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "K:";
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(37, 310);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(100, 20);
            this.key.TabIndex = 18;
            // 
            // calculateSendedMessage
            // 
            this.calculateSendedMessage.Location = new System.Drawing.Point(55, 146);
            this.calculateSendedMessage.Name = "calculateSendedMessage";
            this.calculateSendedMessage.Size = new System.Drawing.Size(205, 23);
            this.calculateSendedMessage.TabIndex = 19;
            this.calculateSendedMessage.Text = "Получить отправляемое сообщение";
            this.calculateSendedMessage.UseVisualStyleBackColor = true;
            this.calculateSendedMessage.Click += new System.EventHandler(this.calculateSendedMessage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Отправляемое сообщение:";
            // 
            // sendedMessage
            // 
            this.sendedMessage.Location = new System.Drawing.Point(37, 188);
            this.sendedMessage.Name = "sendedMessage";
            this.sendedMessage.Size = new System.Drawing.Size(100, 20);
            this.sendedMessage.TabIndex = 21;
            // 
            // DiffieHellmanSideA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 346);
            this.Controls.Add(this.sendedMessage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calculateSendedMessage);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.getKey);
            this.Controls.Add(this.recievedMessage);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getX);
            this.Controls.Add(this.a);
            this.Controls.Add(this.p);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DiffieHellmanSideA";
            this.Text = "Схема Диффи-Хеллмана";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox recievedMessage;
        private System.Windows.Forms.Button getKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button calculateSendedMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sendedMessage;
    }
}