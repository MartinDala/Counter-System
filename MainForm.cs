/*
 * Criado por Martin Dala.
 * Usuário: Martinho Dala
 * Data: 14/07/2019
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Speech.Recognition; 
using System.Threading;
using System.Speech.Synthesis;



namespace JARVIS
{
    
    public partial class MainForm : Form
    {

        int oruo=1;



        public MainForm()
        {
          
            InitializeComponent();

        
        }
        public SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public SpeechRecognitionEngine sre;

        //Metodo para chamar a hora
        public void WhatTimeIs()
        {
            Spell(systemInfo.GetCurrentTime());
        }
        //Metodo para chamar o dia
        public void WhatIsTodaysDate()
        {
            Spell(systemInfo.GetCurrentDate());
        }

        //pegar o idioma
        public List<string> voices = GetVoices.GetVoicesFromCulture("pt-BR");
        //Exepcao de erro se n exetir um idioma
        public void SelectVoice()
        {
            if (voices.Count == 0)
            {
                MessageBox.Show("Erro: Não foi encontrada uma voz instalada em português!");
            }
            else
            {
                for (int i = 0; i <= voices.Count; i++)
                {
                    try
                    {
                        synthesizer.SelectVoice(voices[i]);
                        SayStatusLoading();
                        break;
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
            }
        }

        //Processando o Sintetizador de voz
        public void SayStatusLoading()
        {
            Spell("Carregando o Sistema de Senha");
           
        }

        //Sintetizador de voz recebendo o parameetro i
        public void SetVoice(string i)
        {
            synthesizer.SelectVoice(i);
        }

        

        void MainFormLoad(object sender, EventArgs e)
        {
            //criando a primeira voz
            SelectVoice(); //chmar a voz e o idioma
            List<string> voces = GetVoices.GetVoicesFromCulture("pt-BR");
            foreach (string v in voces)
            {

            }

            //ler e inteder o idioma
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            sre = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("pt-BR"));

           


            //falar 
            Spell("Carregamento concluído... ");
        }
            
         
        //sintetizador de voz
        public bool stayInSilence = false; //verifica se esta falando
        public void Spell(string text)//reconhecendo texto na voz
        {
            //condicão caso haja silencio
            if (stayInSilence == true) 
            {
                synthesizer.Volume = 0;
            }
            else
            {
                synthesizer.Volume = 100;
                SpellItem.SpellIt(text);
            }
        }

      

        private void horaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //execuutar a funcao
            WhatTimeIs();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WhatIsTodaysDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {





        }

     
     

      

        private void timer1_Tick(object sender, EventArgs e)
        {//datas e horas na label
            //lblHora.Text = DateTime.Now.ToLongTimeString();
            //lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            string serviço = cbServices.Text;

            Spell("Serviço " + serviço + ".. Senha número: " + oruo + "Balcão 1");
            listBank.Items.Add("1");


            listSenha.Items.Add(serviço + "" + oruo++ );







        }

        private void button3_Click(object sender, EventArgs e)
        {
            string serviço = cbServices.Text;

            Spell("Serviço " + serviço + ".. Senha número: " + oruo + "Balcão 2");
            listBank.Items.Add("2");

            listSenha.Items.Add(serviço + "" + oruo++);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            string serviço = cbServices.Text;

       



            Spell("Serviço " + serviço + ".. Senha número: " + oruo + "Balcão 3");
            listBank.Items.Add("3");
            listSenha.Items.Add(serviço + "" + oruo++);
        }

        private void listSenha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


    


