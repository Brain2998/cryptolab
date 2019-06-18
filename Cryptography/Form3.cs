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
    public partial class Form3 : Form
    {
        public ulong[] Cypher;
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ulong P = Convert.ToUInt64(this.textBox1.Text);
            ulong G = Convert.ToUInt64(this.textBox2.Text);
            ulong X = Convert.ToUInt64(this.textBox3.Text);
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
                ElGamal ElG = new ElGamal(P, G, X);
                this.textBox4.Text = G.ToString();
                this.textBox5.Text = P.ToString();
                this.textBox6.Text = ElG.GetOpenKey().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ulong P = Convert.ToUInt64(this.textBox1.Text);
            ulong G = Convert.ToUInt64(this.textBox2.Text);
            ulong X = Convert.ToUInt64(this.textBox3.Text);
            ElGamal ElG = new ElGamal(P, G, X);
            ElG.a = Cypher[0];
            int CypherLength = Cypher.Length - 1;
            ulong[] cypher = new ulong[CypherLength];
            for (int i = 0; i < CypherLength; ++i)
                cypher[i]=Cypher[i+1];
            ulong[] decypher = ElG.Decryption(cypher);
            this.textBox8.Text = Coding.Decoding(decypher);
        }
    }
}
