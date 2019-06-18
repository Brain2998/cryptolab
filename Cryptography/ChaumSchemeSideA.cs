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
    public partial class ChaumSchemeSideA : Form
    {
        ulong reverseK;
        ChaumSchemeSideB sideB;

        public ChaumSchemeSideA(ChaumSchemeSideB SideB)
        {
            sideB = SideB;
            InitializeComponent();
            OpenKey = sideB.OpenKey;
            Module = sideB.P * sideB.Q;
        }

        public ChaumSchemeSideA()
        {
            InitializeComponent();
        }

        public ulong OpenKey
        {
            get { return Convert.ToUInt64(this.openKey.Text); }
            set { this.openKey.Text = value.ToString(); }
        }

        public ulong Module
        {
            get { return Convert.ToUInt64(this.module.Text); }
            set { this.module.Text = value.ToString(); }
        }

        public string Message
        {
            get { return this.message.Text; }
            set { this.message.Text = value.ToString(); }
        }

        public ulong HidedMessage
        {
            get { return Convert.ToUInt64(this.hidedMessage.Text); }
            set { this.hidedMessage.Text = value.ToString(); }
        }

        public ulong RecievedSignature
        {
            get { return Convert.ToUInt64(this.recievedSignature.Text); }
            set { this.recievedSignature.Text = value.ToString(); }
        }

        public ulong Signature
        {
            get { return Convert.ToUInt64(this.signature.Text); }
            set { this.signature.Text = value.ToString(); }
        }

        private void hideMessage_Click(object sender, EventArgs e)
        {
            ulong[] CodedText = Coding.Encoding(Message);
            ulong hash = Hash.GetHash(CodedText, OpenKey, Module);
            ulong[] RandomStorage;
            List<ulong> Random = new List<ulong>();
            string StringRandomRange = "1";
            int EilerLength = Module.ToString().Length;
            for (int i = 0; i < EilerLength / 2; ++i)
            {
                StringRandomRange += "0";
            }
            ulong RandomRange = Module - Convert.ToUInt64(StringRandomRange);
            for (ulong i = RandomRange; i < Module; ++i)
            {
                if (1 == Euclid.FindGSD(i, Module))
                {
                    Random.Add(i);
                }
            }
            RandomStorage = Random.ToArray();
            Random rand = new Random();
            ulong k = RandomStorage[rand.Next(0, RandomStorage.Length)];
            reverseK = ExtendedEuclid.FindReverse(k,Module);
            HidedMessage = (hash * ExpByModule.Exponentiation(k, OpenKey, Module)) % Module;
        }

        private void sendHideMessage_Click(object sender, EventArgs e)
        {
            this.sideB.HidedMessage = HidedMessage;
            this.Hide();
            this.sideB.Show();
        }

        private void getSignature_Click(object sender, EventArgs e)
        {
            Signature = (reverseK * (RecievedSignature % Module)) % Module;
        }
    }
}
