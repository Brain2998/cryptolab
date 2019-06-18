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
    public partial class Form10 : Form
    {
        Form9 frm9;
        public Form10(Form9 form9)
        {
            frm9 = form9;
            InitializeComponent();
            P = form9.P;
            Q = form9.Q;
            A = form9.A;
            OpenKey = form9.OpenKey;
            Message = form9.Message;
            Signature = form9.Signature;
        }
        private ulong[] signature = new ulong[2];
        public ulong[] Signature
        {
            get { return this.signature; }
            set
            {
                this.signature[0] = value[0];
                this.signature[1] = value[1];
                int valueLength = value.Length;
                for (int i = 0; i < valueLength; ++i)
                    this.textBox6.Text += value[i].ToString();
            }
        }
        public ulong P
        {
            get { return Convert.ToUInt64(this.textBox2.Text); }
            set { this.textBox2.Text = value.ToString(); }
        }
        public ulong Q
        {
            get { return Convert.ToUInt64(this.textBox3.Text); }
            set { this.textBox3.Text = value.ToString(); }
        }
        public ulong A
        {
            get { return Convert.ToUInt64(this.textBox4.Text); }
            set { this.textBox4.Text = value.ToString(); }
        }
        public ulong OpenKey
        {
            get { return Convert.ToUInt64(this.textBox5.Text); }
            set { this.textBox5.Text = value.ToString(); }
        }
        public string Message
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value.ToString(); }
        }
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong[] CodedText = Coding.Encoding(Message);
            ulong hash = Hash.GetHash(CodedText, OpenKey, P)%Q;
            if (0 == hash)
                hash = 1;
            ulong v = ExpByModule.Exponentiation(hash, Q - 2, Q);
            ulong z1 = (Signature[1] * (v % Q)) % Q;
            ulong z2 = (((Q - Signature[0]) % Q) * v) % Q;
            ulong u = ((ExpByModule.Exponentiation(A, z1, P) * ExpByModule.Exponentiation(OpenKey, z2, P)) % P) % Q;
            this.textBox7.Text = u.ToString();
            this.textBox8.Text = Signature[0].ToString();
            if (u == Signature[0])
                this.label9.Text = "Цифровая подпись действительна";
            else this.label9.Text = "Цифровая подпись не действительна";
        }
    }
}
