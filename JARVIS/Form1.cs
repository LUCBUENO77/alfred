using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JARVIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnexecuta_Click(object sender, EventArgs e)
        {
            Fala speech = Fala.getInstance( ref btnexecuta);
            speech.velocidade = (int)tkbVelecidade.Value;
            speech.volume = (int)tkbVolume.Value;
            //Executar sítese  de fala


            speech.Falar(rTBTexto.Text);


         }
    }
}
