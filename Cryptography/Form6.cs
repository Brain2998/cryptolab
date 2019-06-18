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
    public partial class Form6 : Form
    {
        Form5 frm5;
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(Form5 form5)
        {
            frm5 = form5;
            InitializeComponent();
            this.textBox1.Text = form5.textBox3.Text;
            this.textBox2.Text = (Convert.ToUInt32(form5.textBox1.Text) * Convert.ToUInt32(form5.textBox2.Text)).ToString();
            this.textBox3.Text = form5.textBox5.Text;
            this.textBox4.Text = form5.textBox6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong[] CodedText = Coding.Encoding(this.textBox3.Text);
            this.textBox5.Text = Hash.GetHash(CodedText, Convert.ToUInt64(this.textBox1.Text), Convert.ToUInt64(this.textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            this.textBox6.Text = ExpByModule.Exponentiation(Convert.ToUInt64(this.textBox4.Text), Convert.ToUInt64(this.textBox1.Text), Convert.ToUInt64(this.textBox2.Text)).ToString();
            if (this.textBox6.Text == this.textBox5.Text)
                this.label8.Text = "Цифровая подпись действительна";
            else
                this.label8.Text = "Цифровая подпись не действительна";
        }
    }
}
