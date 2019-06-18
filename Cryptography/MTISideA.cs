using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class MTISideA : Form
    {
        private MTISideB mtib;

        public MTISideB MTIB
        {
            get { return this.mtib; }
            set { this.mtib = value; }
        }
        public MTISideA()
        {
            InitializeComponent();
        }

        public ulong P
        {
            get { return Convert.ToUInt64(this.p.Text); }
            set { this.p.Text = value.ToString(); }
        }

        public ulong A
        {
            get { return Convert.ToUInt64(this.a.Text); }
            set { this.a.Text = value.ToString(); }
        }

        public ulong X
        {
            get { return Convert.ToUInt64(this.x.Text); }
            set { this.x.Text = value.ToString(); }
        }

        public ulong C
        {
            get { return Convert.ToUInt64(this.c.Text); }
            set { this.c.Text = value.ToString(); }
        }

        public ulong RecievedMessage
        {
            get { return Convert.ToUInt64(this.recievedMessage.Text); }
            set { this.recievedMessage.Text = value.ToString(); }
        }

        public ulong RecievedZ
        {
            get { return Convert.ToUInt64(this.recievedZ.Text); }
            set { this.recievedZ.Text = value.ToString(); }
        }

        public ulong SendedMessage
        {
            get { return Convert.ToUInt64(this.sendedMessage.Text); }
            set { this.sendedMessage.Text = value.ToString(); }
        }

        public ulong Za
        {
            get { return Convert.ToUInt64(this.za.Text); }
            set { this.za.Text = value.ToString(); }
        }

        public ulong Key
        {
            get { return Convert.ToUInt64(this.key.Text); }
            set { this.key.Text = value.ToString(); }
        }
        private void getNumbers_Click(object sender, EventArgs e)
        {
            bool IsFirstPrime = IsPrime.Check(P);
            bool IsAlesserP = A < P;
            if (!IsFirstPrime || !IsAlesserP)
            {
                if (!IsFirstPrime)
                    MessageBox.Show("Первое число не простое", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!IsAlesserP)
                    MessageBox.Show("Число А больше или равно Р", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Random rand = new Random();
                X = (ulong)rand.Next(1, (int)P - 2);
                C = (ulong)rand.Next(1, (int)P - 2);
            }
        }

        private void calculateSendedMessage_Click(object sender, EventArgs e)
        {
            SendedMessage = ExpByModule.Exponentiation(A, X, P);
            Za = ExpByModule.Exponentiation(A, C, P);
        }

        private void send_Click(object sender, EventArgs e)
        {
            mtib.RecievedMessage = SendedMessage;
            mtib.RecievedZ = Za;
        }

        private void getKey_Click(object sender, EventArgs e)
        {
            Key = (ExpByModule.Exponentiation(RecievedMessage, C, P) * ExpByModule.Exponentiation(RecievedZ, X, P)) % P;
        }
    }
}
