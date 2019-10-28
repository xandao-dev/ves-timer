using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Timer
{
    public partial class Form1 : Form
    {
        private int temprest;
        private int tempextra;
        private int tempoquestao;
        private int tempototalX;
        SoundPlayer AAA = new SoundPlayer(Timer.Properties.Resources.f);
        SoundPlayer BBB = new SoundPlayer(Timer.Properties.Resources.i);
        SoundPlayer CCC = new SoundPlayer(Timer.Properties.Resources.d);
        SoundPlayer DDD = new SoundPlayer(Timer.Properties.Resources.b);
        SoundPlayer EEE = new SoundPlayer(Timer.Properties.Resources.g);
        SoundPlayer FFF = new SoundPlayer(Timer.Properties.Resources.e);
        SoundPlayer GGG = new SoundPlayer(Timer.Properties.Resources.x);
        SoundPlayer HHH = new SoundPlayer(Timer.Properties.Resources.z);

        public Form1()
        {
            InitializeComponent();
        }


        public int TimeExtra()
        {
            decimal temptot = (MinQuestao.Value * 60 + SegQuestao.Value) * (QutQuestoes.Value);
            int temptotR = Convert.ToInt32(temptot);
            label14.Text = Convert.ToString(temptotR / 60) + "Min " + Convert.ToString(temptotR % 60) + "Seg";
            tempextra = temptotR;
            return tempextra;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)

            {
                Proxima.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)

            {
                Naocons.PerformClick();
            }


        }

        private void Zerar_Click(object sender, EventArgs e)
        {
            FFF.Play();
            Tempo.Enabled = false;
            tempototalX = 0;
            Tempo.Enabled = false;
            Iniciar.Visible = true;
            Iniciar.Enabled = true;
            label14.Text = "0Min 0Seg";
            MinQuestao.Value = 3; SegQuestao.Value = 0; QutQuestoes.Value = 10; ttotal.Text = "0Min 0Seg"; tmedio.Text = "0Min 0Seg"; Resolvidas.Value = 0; NaoResolvidas.Value = 0; trestante.Text = "0Min 0Seg";
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            Start();
            Iniciar.Visible = false;
            Iniciar.Enabled = false;


        }

        private void TEMPOALFA_Tick(object sender, EventArgs e)
        {
            TimeExtra();
            int tempR = Convert.ToInt32(tempextra - tempototalX);
            label21.Text = Convert.ToString(tempR / 60) + "Min " + Convert.ToString(tempR % 60) + "Seg";
            if (tempR >= 1)
            {
                tempR--;
                trestante.Text = ((tempR / 60).ToString() + "Min " + (tempR % 60).ToString() + "Seg");

            }
            else
            {
                TEMPOALFA.Stop();
            }

        }

        public int Time()
        {
            int MIN = Convert.ToInt32(MinQuestao.Value) * 60;
            int SEG = Convert.ToInt32(SegQuestao.Value);

            tempoquestao = MIN + SEG; //em segundos
            AAA.Play();
            return tempoquestao;
        }

        public int TimeR()
        {
            TEMPOALFA.Start();

            return temprest;
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            tempototalX++;
            int k = tempototalX / 60;
            int l = (tempototalX % 60);
            ttotal.Text = ((k).ToString() + "Min " + (++l).ToString() + "Seg");

            if (tempoquestao == 12) { EEE.Play(); }

            if (tempoquestao >= 2)
            {
                TimeExtra();
                --tempoquestao;
                int x = tempoquestao / 60;
                int y = tempoquestao % 60;
                trestante.Text = ((x).ToString() + "Min " + (--y).ToString() + "Seg");
            }
            else
            {
                if (QutQuestoes.Value <= 1)
                {
                    TimeExtra();
                    TimeR();
                    {
                        BBB.Play();
                        QutQuestoes.Value--;
                        NaoResolvidas.Value++;
                        Naocons_Click(sender, e);
                        Tempo.Enabled = false;
                        Iniciar.Enabled = true;
                        Iniciar.Visible = true;
                        trestante.Text = "00:00";

                    }


                }
                else if (QutQuestoes.Value > 1)
                {
                    Naocons_Click(sender, e);
                    Time();
                }
            }


        }

        void Start()
        {
            Time();
            Tempo.Enabled = true;


        }

        private void Naocons_Click(object sender, EventArgs e)
        {


            if (QutQuestoes.Value >= 2 && Tempo.Enabled == true)
            {

                Time();
                QutQuestoes.Value--;
                NaoResolvidas.Value++;
            }
            else if (QutQuestoes.Value == 1 && Tempo.Enabled == true)
            {

                QutQuestoes.Value--;
                Tempo.Enabled = false;
                NaoResolvidas.Value++;
                trestante.Text = "00:00";
            }
            if (Resolvidas.Value + NaoResolvidas.Value > 0)
            {
                int Formula = Convert.ToInt32(tempototalX / (Resolvidas.Value + NaoResolvidas.Value));
                int x = Formula / 60;
                int y = (Formula % 60);
                if (Formula >= 0)
                { tmedio.Text = ((x).ToString() + "Min " + (y).ToString() + "Seg"); }
            }
        }

        private void Proxima_Click(object sender, EventArgs e)
        {


            if (QutQuestoes.Value >= 2 && Tempo.Enabled == true)
            {
                Time();
                QutQuestoes.Value--;
                Resolvidas.Value++;
            }
            else if (QutQuestoes.Value == 1 && Tempo.Enabled == true)
            {
                QutQuestoes.Value--;
                Resolvidas.Value++;

            }

            if (Resolvidas.Value + NaoResolvidas.Value > 0)
            {
                int Formula = Convert.ToInt32(tempototalX / (Resolvidas.Value + NaoResolvidas.Value));
                int x = Formula / 60;
                int y = (Formula % 60);
                if (Formula >= 0)
                { tmedio.Text = ((x).ToString() + "Min " + (y).ToString() + "Seg"); }
            }
        }

        private void Pausar_Click(object sender, EventArgs e)
        {

            if (Tempo.Enabled == true)
            {
                CCC.Play();
                Tempo.Stop();
                Pausar.Visible = false;
                Pausar.Enabled = false;
                continuar.Visible = true;
                continuar.Enabled = true;
            }
            if (Resolvidas.Value + NaoResolvidas.Value > 0)
            {
                int Formula = Convert.ToInt32(tempototalX / (Resolvidas.Value + NaoResolvidas.Value));
                int x = Formula / 60;
                int y = (Formula % 60);
                if (Formula >= 0)
                { tmedio.Text = ((x).ToString() + "Min " + (y).ToString() + "Seg"); }
            }
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            DDD.Play();
            Tempo.Start();
            continuar.Visible = false;
            continuar.Enabled = false;
            Pausar.Visible = true;
            Pausar.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void Ajuda_Click(object sender, EventArgs e)
        {
            GGG.Play();
            MessageBox.Show("# Como usar:" + " \n" + "     1)Escolha o tempo para as questões" + " \n" + "     2)Escolha o Número de Questões" + " \n" + "     3)Pressione 'Iniciar'" + " \n" + "     4)Quando terminar uma questão aperte 'Espaço'" + " \n" + "     5)Se não conseguir resolver aperte 'Esc'" + " \n" + " \n" + "# Obs: Caso não pressionar 'Espaço' antes do tempo acabar" + " \n" + "a questão será considerada não resolvida" + " \n" + " \n" + "# Made by: Alexandre Calil", "Ajuda");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/alexandre.calil.54");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HHH.Play();
        }

        
    }
}

