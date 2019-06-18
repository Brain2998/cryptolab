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
    public partial class Form2 : Form
    {
        Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 form1)
        {
            frm1 = form1;
            InitializeComponent();
            this.textBox1.Text = form1.textBox5.Text;
            this.textBox2.Text = form1.textBox6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label5.Visible = true;
            this.textBox4.Visible = true;
            this.button2.Visible = true;
            ulong openkey = Convert.ToUInt64(this.textBox1.Text);
            ulong module = Convert.ToUInt64(this.textBox2.Text);
            RSA rsa = new RSA(openkey, "Открытый");
            ulong[] code = Coding.Encoding(this.textBox3.Text);
            ulong[] cypher = rsa.Encription(code, module);
            int CypherLength = cypher.Length;
            for (int i = 0; i < CypherLength; ++i)
            {
                this.textBox4.Text += cypher[i].ToString();
            }
            frm1.Cypher = cypher;
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            frm1.textBox7.Text = this.textBox4.Text;
            this.Hide();
            frm1.label9.Visible = true;
            frm1.textBox7.Visible = true;
            frm1.button3.Visible = true;
        }
    }
}
