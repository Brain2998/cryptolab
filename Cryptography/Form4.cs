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
    public partial class Form4 : Form
    {
        Form3 frm3;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Form3 form3)
        {
            frm3 = form3;
            InitializeComponent();
            this.textBox3.Text = form3.textBox4.Text;
            this.textBox2.Text = form3.textBox5.Text;
            this.textBox1.Text = form3.textBox6.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox6.Text = "";
            ulong G = Convert.ToUInt64(this.textBox3.Text);
            ulong P = Convert.ToUInt64(this.textBox2.Text);
            ulong Y = Convert.ToUInt64(this.textBox1.Text);
            ElGamal ElG = new ElGamal(G, P, Y, true);
            ElG.k = ElG.GetK();
            ElG.a = ElG.GetFirstCypherPart();
            ulong[] code = Coding.Encoding(this.textBox4.Text);
            ulong[] cypher = ElG.Encription(code);
            ulong[] fullCypher = new ulong[cypher.Length + 1];
            fullCypher[0] = ElG.a;
            int fullCypherLength = fullCypher.Length;
            for (int i = 1; i < fullCypherLength; ++i)
            {
                fullCypher[i] = cypher[i - 1];
            }
            this.textBox5.Text = ElG.a.ToString();
            for (int i = 0; i < fullCypherLength; ++i)
                this.textBox6.Text += fullCypher[i].ToString();
            frm3.Cypher = fullCypher;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm3.textBox7.Text = this.textBox6.Text;
            this.Hide();
        }
    }
}
