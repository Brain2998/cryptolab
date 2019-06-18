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
    public partial class DiffieHellmanSideB : Form
    {
        DiffieHellmanSideA dha;
        public DiffieHellmanSideB()
        {
            InitializeComponent();
        }

        public DiffieHellmanSideB(DiffieHellmanSideA dhA)
        {
            dha = dhA;
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

        public ulong Y
        {
            get { return Convert.ToUInt64(this.y.Text); }
            set { this.y.Text = value.ToString(); }
        }

        public ulong SendedMessage
        {
            get { return Convert.ToUInt64(this.sendedMessage.Text); }
            set { this.sendedMessage.Text = value.ToString(); }
        }

        public ulong RecievedMessage
        {
            get { return Convert.ToUInt64(this.recievedMessage.Text); }
            set { this.recievedMessage.Text = value.ToString(); }
        }

        public ulong Key
        {
            get { return Convert.ToUInt64(this.key.Text); }
            set { this.key.Text = value.ToString(); }
        }

        private void getY_Click(object sender, EventArgs e)
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
                Y = (ulong)rand.Next(1, (int)P - 2);
            }
        }

        private void calculateSendedMessage_Click(object sender, EventArgs e)
        {
            SendedMessage = ExpByModule.Exponentiation(A, Y, P);
        }

        private void send_Click(object sender, EventArgs e)
        {
            dha.RecievedMessage = SendedMessage;
        }

        private void getKey_Click(object sender, EventArgs e)
        {
            Key = ExpByModule.Exponentiation(RecievedMessage, Y, P);
        }
    }
}
