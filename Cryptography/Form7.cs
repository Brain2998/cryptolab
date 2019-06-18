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
    public partial class Form7 : Form
    {
        private ulong[] signature=new ulong[2];
        public ulong[] Signature
        {
            get { return this.signature; }
            set 
            { 
                this.signature[0] = value[0];
                this.signature[1] = value[1];
                int valueLength = value.Length;
                for (int i = 0; i < valueLength; ++i)
                    this.textBox5.Text += value[i].ToString(); 
            }
        }
        public ulong P
        {
            get { return Convert.ToUInt64(this.textBox1.Text); }
            set { this.textBox1.Text = value.ToString(); }
        }
        public ulong G
        {
            get { return Convert.ToUInt64(this.textBox2.Text); }
            set { this.textBox2.Text = value.ToString(); }
        }
        public ulong X
        {
            get { return Convert.ToUInt64(this.textBox3.Text); }
            set { this.textBox3.Text = value.ToString(); }
        }
        public ulong OpenKey
        {
            get { return Convert.ToUInt64(this.textBox6.Text); }
            set { this.textBox6.Text = value.ToString(); }
        }
        public string Message
        {
            get { return this.textBox4.Text; }
            set { this.textBox4.Text = value.ToString(); }
        }
        public Form7()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool Is_p_prime = IsPrime.Check(P);
            bool Is_g_lesser_p = G < P;
            bool Is_x_lesser_p = X < P;
            if (!Is_p_prime || !Is_g_lesser_p || !Is_x_lesser_p)
            {
                if (!Is_p_prime)
                    MessageBox.Show("Число P не простое", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!Is_g_lesser_p)
                    MessageBox.Show("Число G больше P", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!Is_x_lesser_p)
                    MessageBox.Show("Число X больше P", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ElGamal elG = new ElGamal(P, G, X);
                OpenKey = elG.GetOpenKey();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElGamal elG = new ElGamal(P, G, X);
            ulong K = elG.GetK();
            ulong[] CodedText=Coding.Encoding(Message);
            ulong hash = Hash.GetHash(CodedText, OpenKey, P);
            ulong a = ExpByModule.Exponentiation(G, K, P);
            ulong reverseK = ExtendedEuclid.FindReverse(K, P - 1);
            ulong b;
            for (ulong i = 1; ; ++i)
            {
                if (hash == ((X * a + i * K) % (P-1)))
                {
                    b = i;
                    break;
                }
            }
            ulong[] sign = new ulong[2]; 
            sign[0] = a;
            sign[1] = b;
            Signature = sign;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 form8= new Form8(this);
            form8.Show();
        }
    }
}
