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
    public partial class Form8 : Form
    {
        Form7 frm7;
        public Form8(Form7 form7)
        {
            frm7 = form7;
            InitializeComponent();
            P = form7.P;
            G = form7.G;
            OpenKey = form7.OpenKey;
            Message = form7.Message;
            Signature = form7.Signature;
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
                    this.textBox5.Text += value[i].ToString();
            }
        }        
        public string Message
        {
            get { return this.textBox4.Text; }
            set
            {
                int valueLength = value.Length;
                for (int i = 0; i < valueLength; ++i)
                    this.textBox4.Text += value[i].ToString();
            }
        }
        public ulong P
        {
            get { return Convert.ToUInt64(this.textBox2.Text); }
            set { this.textBox2.Text = value.ToString(); }
        }
        public ulong G
        {
            get { return Convert.ToUInt64(this.textBox1.Text); }
            set { this.textBox1.Text = value.ToString(); }
        }
        public ulong OpenKey
        {
            get { return Convert.ToUInt64(this.textBox3.Text); }
            set { this.textBox3.Text = value.ToString(); }
        }
        public string FirstVerification
        {
            get { return this.textBox6.Text; }
            set{this.textBox6.Text=value.ToString();}
        }
        public string SecondVerification
        {
            get { return this.textBox7.Text; }
            set { this.textBox7.Text = value.ToString(); }
        }
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong[] CodedText = Coding.Encoding(Message);
            ulong hash = Hash.GetHash(CodedText,OpenKey,P);
            FirstVerification = ExpByModule.Exponentiation(G, hash, P).ToString();
            SecondVerification = ((ExpByModule.Exponentiation(OpenKey, Signature[0], P)*ExpByModule.Exponentiation(Signature[0],Signature[1],P))%P).ToString();
            if (FirstVerification == SecondVerification)
                this.label9.Text = "Цифровая подпись действительна";
            else this.label9.Text = "Цифровая подпись не действительна";
        }
    }
}
