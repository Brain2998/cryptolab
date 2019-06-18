namespace Cryptography
{
    partial class DiffieHellmanSideB
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.getKey = new System.Windows.Forms.Button();
            this.recievedMessage = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.getY = new System.Windows.Forms.Button();
            this.sendedMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calculateSendedMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите простое число P, и натуральное A, меньшее P:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "P:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "A:";
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(40, 41);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(100, 20);
            this.p.TabIndex = 3;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(40, 68);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 4;
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(40, 313);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(100, 20);
            this.key.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "K:";
            // 
            // getKey
            // 
            this.getKey.Location = new System.Drawing.Point(91, 284);
            this.getKey.Name = "getKey";
            this.getKey.Size = new System.Drawing.Size(147, 23);
            this.getKey.TabIndex = 25;
            this.getKey.Text = "Вычислить общий ключ";
            this.getKey.UseVisualStyleBackColor = true;
            this.getKey.Click += new System.EventHandler(this.getKey_Click);
            // 
            // recievedMessage
            // 
            this.recievedMessage.Location = new System.Drawing.Point(40, 257);
            this.recievedMessage.Name = "recievedMessage";
            this.recievedMessage.Size = new System.Drawing.Size(100, 20);
            this.recievedMessage.TabIndex = 24;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(129, 219);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 23;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Полученное сообщение:";
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(40, 127);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(100, 20);
            this.y.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Y:";
            // 
            // getY
            // 
            this.getY.Location = new System.Drawing.Point(91, 98);
            this.getY.Name = "getY";
            this.getY.Size = new System.Drawing.Size(147, 23);
            this.getY.TabIndex = 19;
            this.getY.Text = "Сгенерировать число Y";
            this.getY.UseVisualStyleBackColor = true;
            this.getY.Click += new System.EventHandler(this.getY_Click);
            // 
            // sendedMessage
            // 
            this.sendedMessage.Location = new System.Drawing.Point(40, 193);
            this.sendedMessage.Name = "sendedMessage";
            this.sendedMessage.Size = new System.Drawing.Size(100, 20);
            this.sendedMessage.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Отправляемое сообщение:";
            // 
            // calculateSendedMessage
            // 
            this.calculateSendedMessage.Location = new System.Drawing.Point(73, 152);
            this.calculateSendedMessage.Name = "calculateSendedMessage";
            this.calculateSendedMessage.Size = new System.Drawing.Size(205, 23);
            this.calculateSendedMessage.TabIndex = 28;
            this.calculateSendedMessage.Text = "Получить отправляемое сообщение";
            this.calculateSendedMessage.UseVisualStyleBackColor = true;
            this.calculateSendedMessage.Click += new System.EventHandler(this.calculateSendedMessage_Click);
            // 
            // DiffieHellmanSideB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 345);
            this.Controls.Add(this.sendedMessage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calculateSendedMessage);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.getKey);
            this.Controls.Add(this.recievedMessage);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.y);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getY);
            this.Controls.Add(this.a);
            this.Controls.Add(this.p);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DiffieHellmanSideB";
            this.Text = "Схема Диффи-Хеллмана";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button getKey;
        private System.Windows.Forms.TextBox recievedMessage;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getY;
        private System.Windows.Forms.TextBox sendedMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calculateSendedMessage;
    }
}