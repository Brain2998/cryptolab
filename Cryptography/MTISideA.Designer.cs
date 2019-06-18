namespace Cryptography
{
    partial class MTISideA
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
            this.sendedMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calculateSendedMessage = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.getKey = new System.Windows.Forms.Button();
            this.recievedMessage = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.getNumbers = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.za = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.recievedZ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendedMessage
            // 
            this.sendedMessage.Location = new System.Drawing.Point(39, 249);
            this.sendedMessage.Name = "sendedMessage";
            this.sendedMessage.Size = new System.Drawing.Size(100, 20);
            this.sendedMessage.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Отправляемое сообщение:";
            // 
            // calculateSendedMessage
            // 
            this.calculateSendedMessage.Location = new System.Drawing.Point(65, 174);
            this.calculateSendedMessage.Name = "calculateSendedMessage";
            this.calculateSendedMessage.Size = new System.Drawing.Size(205, 23);
            this.calculateSendedMessage.TabIndex = 36;
            this.calculateSendedMessage.Text = "Получить отправляемое сообщение";
            this.calculateSendedMessage.UseVisualStyleBackColor = true;
            this.calculateSendedMessage.Click += new System.EventHandler(this.calculateSendedMessage_Click);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(39, 410);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(100, 20);
            this.key.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "K:";
            // 
            // getKey
            // 
            this.getKey.Location = new System.Drawing.Point(88, 381);
            this.getKey.Name = "getKey";
            this.getKey.Size = new System.Drawing.Size(147, 23);
            this.getKey.TabIndex = 33;
            this.getKey.Text = "Вычислить общий ключ";
            this.getKey.UseVisualStyleBackColor = true;
            this.getKey.Click += new System.EventHandler(this.getKey_Click);
            // 
            // recievedMessage
            // 
            this.recievedMessage.Location = new System.Drawing.Point(39, 355);
            this.recievedMessage.Name = "recievedMessage";
            this.recievedMessage.Size = new System.Drawing.Size(100, 20);
            this.recievedMessage.TabIndex = 32;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(129, 273);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 31;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Полученное сообщение:";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(39, 121);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(100, 20);
            this.x.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "X:";
            // 
            // getNumbers
            // 
            this.getNumbers.Location = new System.Drawing.Point(79, 92);
            this.getNumbers.Name = "getNumbers";
            this.getNumbers.Size = new System.Drawing.Size(174, 23);
            this.getNumbers.TabIndex = 27;
            this.getNumbers.Text = "Сгенерировать числа C и X";
            this.getNumbers.UseVisualStyleBackColor = true;
            this.getNumbers.Click += new System.EventHandler(this.getNumbers_Click);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(39, 66);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 26;
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(39, 39);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(100, 20);
            this.p.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "P:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Выберите простое число P, и натуральное A, меньшее P:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "C:";
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(39, 148);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 20);
            this.c.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Za:";
            // 
            // za
            // 
            this.za.Location = new System.Drawing.Point(39, 209);
            this.za.Name = "za";
            this.za.Size = new System.Drawing.Size(100, 20);
            this.za.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Z:";
            // 
            // recievedZ
            // 
            this.recievedZ.Location = new System.Drawing.Point(39, 316);
            this.recievedZ.Name = "recievedZ";
            this.recievedZ.Size = new System.Drawing.Size(100, 20);
            this.recievedZ.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Полученная информация:";
            // 
            // MTISideA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 440);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.recievedZ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.za);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.getNumbers);
            this.Controls.Add(this.a);
            this.Controls.Add(this.p);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MTISideA";
            this.Text = "MTI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sendedMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calculateSendedMessage;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button getKey;
        private System.Windows.Forms.TextBox recievedMessage;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getNumbers;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox za;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox recievedZ;
        private System.Windows.Forms.Label label11;

    }
}