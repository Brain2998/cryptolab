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
    public partial class KeyManagement : Form
    {
        public KeyManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiffieHellmanSideA dha = new DiffieHellmanSideA();
            dha.Show();
            DiffieHellmanSideB dhb = new DiffieHellmanSideB(dha);
            dhb.Show();
            dha.DHB = dhb;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MTISideA mtia = new MTISideA();
            mtia.Show();
            MTISideB mtib = new MTISideB(mtia);
            mtib.Show();
            mtia.MTIB = mtib;
        }
    }
}
