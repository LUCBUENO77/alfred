using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Synthesis;

namespace JARVIS
{
     public class Fala
    {

        public static Fala GerenciarInstancia = null;
        public static object objlock = new object();
        private static Button rfbotao = null;



        public int volume { get; set; }
        public int velocidade { get; set; }

        SpeechSynthesizer speechengine = new SpeechSynthesizer();

        public void Falar (string s)
        {
            speechengine.Volume = this.volume;
            speechengine.Rate = this.velocidade;

            speechengine.StateChanged += Speechengine_StateChanged;

            if (! string.IsNullOrWhiteSpace(s))
            {
                switch (speechengine.State)
                {
                    case SynthesizerState.Ready:
                        speechengine.SetOutputToDefaultAudioDevice();
                        speechengine.SpeakAsync(s);
                        break;
                    case SynthesizerState.Speaking:
                        speechengine.Pause();
                        break;
                    case SynthesizerState.Paused:
                        speechengine.Resume();
                        break;



                }
            }

        }

        private void Speechengine_StateChanged(object sender, StateChangedEventArgs e)
        {
            switch (e.State)
            {
                case SynthesizerState.Ready:
                    rfbotao.Text = "Falar";
                    break;
                case SynthesizerState.Speaking:
                    rfbotao.Text = "Pausar";
                    break;
                case SynthesizerState.Paused:
                    rfbotao.Text = "Continuar";
                    break;



            }

        }

        public static Fala getInstance ( ref Button botao)
        {
            lock (objlock)
            {
                if (GerenciarInstancia == null)
                {
                    GerenciarInstancia = new Fala();
                    rfbotao = botao;

                }

                return GerenciarInstancia;

            }
                   
                    
             
        }


    }
}
