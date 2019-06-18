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
    public partial class Form9 : Form
    {
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
                    this.textBox7.Text += value[i].ToString();
            }
        }
        public ulong P
        {
            get { return Convert.ToUInt64(this.textBox1.Text); }
            set { this.textBox1.Text = value.ToString(); }
        }
        public ulong Q
        {
            get { return Convert.ToUInt64(this.textBox2.Text); }
            set { this.textBox2.Text = value.ToString(); }
        }
        public ulong A
        {
            get { return Convert.ToUInt64(this.textBox3.Text); }
            set { this.textBox3.Text = value.ToString(); }
        }
        public ulong SecretKey
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
            get { return this.textBox6.Text; }
            set { this.textBox6.Text = value.ToString(); }
        }
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Is_p_prime = IsPrime.Check(P);
            if (!Is_p_prime)
            {
                if (!Is_p_prime)
                    MessageBox.Show("Число P не простое", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ulong[] RandomStorage;
                List<ulong> Random = new List<ulong>();
                for (ulong i = 3; i < P/2; ++i)
                {
                    if (0==(P-1)%i && IsPrime.Check(i))
                    {
                        Random.Add(i);
                    }
                }
                RandomStorage = Random.ToArray();
                Random rand = new Random();
                Q = RandomStorage[rand.Next(0, RandomStorage.Length)];

                ulong[] RandomStorage2;
                List<ulong> Random2=new List<ulong>();
                for (ulong i = 1; i < P - 1; ++i)
                {
                    if (1 == ExpByModule.Exponentiation(i, Q, P))
                        Random2.Add(i);
                }
                RandomStorage2 = Random2.ToArray();
                Random rand2 = new Random();
                A = RandomStorage2[rand2.Next(0, RandomStorage2.Length)];

                Random rand3 = new Random();
                SecretKey = (ulong)rand3.Next(1, (int)Q-1);
                OpenKey = ExpByModule.Exponentiation(A, SecretKey, P);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = "";
            ulong[] CodedText = Coding.Encoding(Message);
            ulong hash = Hash.GetHash(CodedText, OpenKey, P)%Q;
            if (0 == hash)
                hash = 1;
            Random rand = new Random();
            ulong K = (ulong)rand.Next(0, (int)Q);
            ulong[] sign = new ulong[2];
            sign[0]=ExpByModule.Exponentiation(A, K, P)%Q;
            sign[1] = (SecretKey * sign[0] + K * hash) % Q;
            if (0 == sign[0])
            {
                bool check = true;
                while (check)
                {
                    K = (ulong)rand.Next(0, (int)Q);
                    sign[0] = ExpByModule.Exponentiation(A, K, P) % Q;
                    sign[1] = (SecretKey * sign[0] + K * hash) % Q;
                    if (0 != sign[0])
                        check = false;
                }
            }
            Signature = sign;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(this);
            form10.Show();
        }
    }
}
