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
    public partial class ChaumSchemeSideB : Form
    {
        ChaumSchemeSideA sideA;
        public ChaumSchemeSideB()
        {
            InitializeComponent();
        }

        public ulong P
        {
            get { return Convert.ToUInt64(this.p.Text); }
            set { this.p.Text = value.ToString(); }
        }

        public ulong Q
        {
            get { return Convert.ToUInt64(this.q.Text); }
            set { this.q.Text = value.ToString(); }
        }

        public ulong OpenKey
        {
            get { return Convert.ToUInt64(this.openKey.Text); }
            set { this.openKey.Text = value.ToString(); }
        }

        public ulong SecretKey
        {
            get { return Convert.ToUInt64(this.secretKey.Text); }
            set { this.secretKey.Text = value.ToString(); }
        }

        public ulong HidedMessage
        {
            get { return Convert.ToUInt64(this.hidedMessage.Text); }
            set { this.hidedMessage.Text = value.ToString(); }
        }

        public ulong Signature
        {
            get { return Convert.ToUInt64(this.signature.Text); }
            set { this.signature.Text = value.ToString(); }
        }
    
        private void getKeys_Click(object sender, EventArgs e)
        {
            bool IsFirstPrime = IsPrime.Check(P);
            bool IsSecondPrime = IsPrime.Check(Q);
            if (!IsFirstPrime || !IsSecondPrime)
            {
                if (!IsFirstPrime)
                    MessageBox.Show("Первое число не простое", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!IsSecondPrime)
                    MessageBox.Show("Второе число не простое", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RSA rsa = new RSA(P, Q);
                ulong N = P * Q;
                RSA.Keys keys = rsa.GetKeys();
                OpenKey = keys.openKey;
                SecretKey = keys.secretKey;
            }
        }

        private void sendOpenKey_Click(object sender, EventArgs e)
        {
            sideA = new ChaumSchemeSideA(this);
            this.Hide();
            sideA.Show();
        }

        private void getSignature_Click(object sender, EventArgs e)
        {
            Signature = ExpByModule.Exponentiation(HidedMessage, SecretKey, P * Q);
        }

        private void sendSignature_Click(object sender, EventArgs e)
        {
            this.sideA.RecievedSignature = Signature;
            this.Hide();
            this.sideA.Show();
        }
    }
}
