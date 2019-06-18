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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong P = Convert.ToUInt64(this.textBox1.Text);
            ulong Q = Convert.ToUInt64(this.textBox2.Text);
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
                RSA.Keys keys = rsa.GetKeys();
                this.textBox3.Text = keys.openKey.ToString();
                this.textBox4.Text = keys.secretKey.ToString();
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ulong[] CodedText = Coding.Encoding(this.textBox5.Text);            
            ulong hash = Hash.GetHash(CodedText, Convert.ToUInt64(this.textBox3.Text), Convert.ToUInt64(this.textBox1.Text) * Convert.ToUInt64(this.textBox2.Text));
            this.textBox6.Text = ExpByModule.Exponentiation(hash, Convert.ToUInt64(this.textBox4.Text), Convert.ToUInt64(this.textBox1.Text) * Convert.ToUInt64(this.textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();
        }
    }
}
