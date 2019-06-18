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
    public partial class Form1 : Form
    {
        public ulong[] Cypher;
        public Form1()
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
                this.textBox5.Text = this.textBox3.Text;
                this.textBox6.Text = (P * Q).ToString();
                this.label4.Visible = true;
                this.label5.Visible = true;
                this.textBox3.Visible = true;
                this.textBox4.Visible = true;
                this.label6.Visible = true;
                this.textBox5.Visible = true;
                this.textBox6.Visible = true;
                this.label7.Visible = true;
                this.label8.Visible = true;
                this.button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label10.Visible = true;
            this.textBox8.Visible = true;
            ulong secretkey = Convert.ToUInt64(this.textBox4.Text);
            ulong module = Convert.ToUInt64(this.textBox6.Text);
            RSA rsa = new RSA(secretkey, "Закрытый");
            ulong[] decypher = rsa.Decription(this.Cypher, module);     
            this.textBox8.Text = Coding.Decoding(decypher);
        }        
    }
}
