using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace JARVIS
{
    // class to speech synthesizer
    public static class SpellItem
    {
        public static string voice;
        private static SpeechSynthesizer speaker = new SpeechSynthesizer();

        public static void SetVoice(string voice)
        {
            speaker.SelectVoice(voice);
        }

        private static bool isSpeaking = false;


        // say in random ways openned item
        static Random rnd = new Random();
        public static void SpeelOpenning(string proc)
        {
            int num = rnd.Next(0, 12);

            switch (num)
            {
                case 0:
                    SpellIt("abrindo " + proc);
                    break;
                case 1:
                    SpellIt("certo, abrindo " + proc);
                    break;
                case 2:
                    SpellIt("tudo bem, abrindo " + proc);
                    break;
                case 3:
                    SpellIt("como quiser, abrindo " + proc);
                    break;
                case 4:
                    SpellIt("iniciando o " + proc);
                    break;
                case 5:
                    SpellIt("certo, iniciando o " + proc);
                    break;
                case 6:
                    SpellIt("tudo bem, iniciando o " + proc);
                    break;
                case 7:
                    SpellIt("como quiser, iniciando o " + proc);
                    break;
                case 8:
                    SpellIt("certo, iniciando " + proc);
                    break;
                case 9:
                    SpellIt("tudo bem. iniciando " + proc);
                    break;
                case 10:
                    SpellIt("como quiser, iniciadno " + proc);
                    break;
                case 11:
                    SpellIt("inicializando " + proc);
                    break;
                case 12:
                    SpellIt("inicializando o " + proc);
                    break;
            }
        }


        public static void SpellIt(string speak)
        {
            if (isSpeaking == true)
            {
                speaker.Resume();
                speaker.SpeakAsync(speak);
                isSpeaking = false;
            }
            else
            {
                speaker.SpeakAsync(speak);
                isSpeaking = true;
            }
            speaker.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(comp);
        }
        private static void comp(object sender, SpeakCompletedEventArgs e)
        {
            isSpeaking = false;
        }

        public static void SpellsSomeOkay()
        {
            List<string> phrases = new List<string>(); // list phrases
            phrases.Add("certo");
            phrases.Add("como quiser");
            phrases.Add("tudo bem");
            phrases.Add("irei fazer isso");
            phrases.Add("sim, como quiser");
            phrases.Add("sim, tudo bem");
            Random rnd = new Random();
            int num = rnd.Next(0, phrases.Count); // speak a random phrase
            SpellIt(phrases[num]);
        }
    }
}
