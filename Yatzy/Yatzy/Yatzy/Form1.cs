using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //summera poäng
        private void BtnSummera_Click(object sender, EventArgs e)
        {
            //spelare 1 summa innan bonus
            //summera poäng
            //Spelare 1
            int Spelare1kontroll = int.Parse(tbxEttorEtt.Text);
            if (Spelare1kontroll > -0.01)
            {
                //Ettor 
                int ettor1 = int.Parse(tbxEttorEtt.Text);
                //Tvåor
                int tvåor1 = int.Parse(tbxTvåorEtt.Text);
                //Treor
                int treor1 = int.Parse(tbxTreorEtt.Text);
                //Fyror
                int fyror1 = int.Parse(tbxFyrorEtt.Text);
                //Femmor
                int femmor1 = int.Parse(tbxFemmorEtt.Text);
                //Femmor
                int sexor1 = int.Parse(tbxSexorEtt.Text);

                int svarSpelare1 = ettor1 + tvåor1 + treor1 + fyror1 + femmor1 + sexor1;
       
                lblSumma11.Text = svarSpelare1.ToString();

                if (svarSpelare1 > 63)
                {
                    int bonus1 = 50;
                    lblBonus1.Text = bonus1.ToString();
                   
                }
            }

            //spelare 2 summa innan bonus
            //summera poäng
            //Spelare 2
            int Spelare2kontroll = int.Parse(tbxEttorTvå.Text);
            if (Spelare2kontroll > -0.01)
            {
                //Ettor 
                int ettor2 = int.Parse(tbxEttorTvå.Text);
                //Tvåor
                int tvåor2 = int.Parse(tbxTvåorTvå.Text);
                //Treor
                int treor2 = int.Parse(tbxTreorTvå.Text);
                //Fyror
                int fyror2 = int.Parse(tbxFyrorTvå.Text);
                //Femmor
                int femmor2 = int.Parse(tbxFemmorTvå.Text);
                //Sexor
                int sexor2 = int.Parse(tbxSexorTvå.Text);

                int svarSpelare2 = ettor2 + tvåor2 + treor2 + fyror2 + femmor2 + sexor2;
                lblSumma12.Text = svarSpelare2.ToString();

                if (svarSpelare2 > 63)
                {
                    int bonus2 = 50;
                    lblBonus2.Text = bonus2.ToString();
                }

                //spelare 3 summa innan bonus
                //summera poäng
                //Spelare 3
                int Spelare3kontroll = int.Parse(tbxEttorTre.Text);
                if (Spelare3kontroll > -0.01)
                {
                    //Ettor 
                    int ettor3 = int.Parse(tbxEttorTre.Text);
                    //Tvåor
                    int tvåor3 = int.Parse(tbxTvåorTre.Text);
                    //Treor
                    int treor3 = int.Parse(tbxTreorTre.Text);
                    //Fyror
                    int fyror3 = int.Parse(tbxFyrorTre.Text);
                    //Femmor
                    int femmor3 = int.Parse(tbxFemmorTre.Text);
                    //Sexor
                    int sexor3 = int.Parse(tbxSexorTre.Text);

                    int svarSpelare3 = ettor3 + tvåor3 + treor3 + fyror3 + femmor3 + sexor3;
                    lblSumma13.Text = svarSpelare3.ToString();

                    if (svarSpelare3 > 63)
                    {
                        int bonus3 = 50;
                        lblBonus3.Text = bonus3.ToString();
                    }
                }
                //spelare 4 summa innan bonus
                //summera poäng   
                //Spelare 4
                int Spelare4kontroll = int.Parse(tbxEttorFyra.Text);
                if (Spelare4kontroll > -0.01)
                {
                    //Ettor 
                    int ettor4 = int.Parse(tbxEttorFyra.Text);
                    //Tvåor
                    int tvåor4 = int.Parse(tbxTvåorFyra.Text);
                    //Treor
                    int treor4 = int.Parse(tbxTreorFyra.Text);
                    //Fyror
                    int fyror4 = int.Parse(tbxFyrorFyra.Text);
                    //Femmor
                    int femmor4 = int.Parse(tbxFemmorFyra.Text);
                    //Sexor
                    int sexor4 = int.Parse(tbxSexorFyra.Text);

                    int svarSpelare4 = ettor4 + tvåor4 + treor4 + fyror4 + femmor4 + sexor4;
                    lblSumma14.Text = svarSpelare4.ToString();
                    if (svarSpelare4 > 63)
                    {
                        int bonus4 = 50;
                        lblBonus4.Text = bonus4.ToString();
                    }
                }


            }
        
    }

        private void BtnSummeraAllt_Click(object sender, EventArgs e)
        {
            //summera poäng efter bonus
            //Spelare 1
            int Spelare1kontroll = int.Parse(tbxEttorEtt.Text);
            if (Spelare1kontroll > -0.01)
            {
                //Ett Par
                int EttPar1 = int.Parse(tbx1Par1.Text);
                //Två Par
                int TvåPar1 = int.Parse(tbx2Par1.Text);
                //Tretal
                int Tretal1 = int.Parse(tbx3Tal1.Text);
                //Fyrtal
                int Fyrtal1 = int.Parse(tbx4Tal1.Text);
                //Kåk
                int Kak1 = int.Parse(tbxKak1.Text);
                //Liten Stege
                int LS1 = int.Parse(tbxLS1.Text);
                //Stor Stege
                int SS1 = int.Parse(tbxLS1.Text);
                //Chans
                int Chans1 = int.Parse(tbxChans1.Text);
                //Yatzy
                int Yatzy1 = int.Parse(tbxYatzy1.Text);

                
                //Steg1
                int SummaDel1 = int.Parse(lblSumma11.Text);
                int Bonus11 = int.Parse(lblBonus1.Text);



                int svarSpelare11 = EttPar1 + TvåPar1 + Tretal1 + Fyrtal1 + Kak1 + LS1 + SS1 +Chans1 + Yatzy1 + SummaDel1 + Bonus11;

                lblSummaA1.Text = svarSpelare11.ToString();

               
            }
            //summera poäng efter bonus
            //Spelare 2
            int Spelare2kontroll = int.Parse(tbxEttorTvå.Text);
            if (Spelare2kontroll > -0.01)
            {
                //Ett Par
                int EttPar2 = int.Parse(tbx1Par2.Text);
                //Två Par
                int TvåPar2 = int.Parse(tbx2Par2.Text);
                //Tretal
                int Tretal2 = int.Parse(tbx3Tal2.Text);
                //Fyrtal
                int Fyrtal2 = int.Parse(tbx4Tal2.Text);
                //Kåk
                int Kak2 = int.Parse(tbxkak2.Text);
                //Liten Stege
                int LS2 = int.Parse(tbxLS2.Text);
                //Stor Stege
                int SS2 = int.Parse(tbxLS2.Text);
                //Chans
                int Chans2 = int.Parse(tbxChans2.Text);
                //Yatzy
                int Yatzy2 = int.Parse(tbxYatzy2.Text);

                //steg1
                int SummaDel2 = int.Parse(lblSumma12.Text);
                int Bonus22 = int.Parse(lblBonus2.Text);

                int svarSpelare22 = EttPar2 + TvåPar2 + Tretal2 + Fyrtal2 + Kak2 + LS2 + SS2 + Chans2 + Yatzy2 + SummaDel2 + Bonus22;

                lblSummaA2.Text = svarSpelare22.ToString();

                if (svarSpelare22 > 63)
                {
                    int bonus1 = 50;
                    lblBonus1.Text = bonus1.ToString();

                }
            }
            //summera poäng efter bonus
            //Spelare 3
            int Spelare1kontro33 = int.Parse(tbxEttorTre.Text);
            if (Spelare1kontro33 > -0.01)
            {
                //Ett Par
                int EttPar3 = int.Parse(tbx1Par3.Text);
                //Två Par
                int TvåPar3 = int.Parse(tbx2Par3.Text);
                //Tretal
                int Tretal3 = int.Parse(tbx3Tal3.Text);
                //Fyrtal
                int Fyrtal3 = int.Parse(tbx4Tal3.Text);
                //Kåk
                int Kak3 = int.Parse(tbxKak3.Text);
                //Liten Stege
                int LS3 = int.Parse(tbxLS3.Text);
                //Stor Stege
                int SS3 = int.Parse(tbxLS3.Text);
                //Chans
                int Chans3 = int.Parse(tbxChans3.Text);
                //Yatzy
                int Yatzy3 = int.Parse(tbxYatzy3.Text);

                //steg1
                int SummaDel3 = int.Parse(lblSumma13.Text);
                int Bonus33 = int.Parse(lblBonus3.Text);
                int svarSpelare33 = EttPar3 + TvåPar3 + Tretal3 + Fyrtal3 + Kak3 + LS3 + SS3 + Chans3 + Yatzy3 + SummaDel3 + Bonus33;

                lblSummaA3.Text = svarSpelare33.ToString();


            }
            //summera poäng efter bonus
            //Spelare 4
            int Spelare4kontroll = int.Parse(tbxEttorFyra.Text);
            if (Spelare4kontroll > -0.01)
            {
                //Ett Par
                int EttPar4 = int.Parse(tbx1Par4.Text);
                //Två Par
                int TvåPar4 = int.Parse(tbx2Par4.Text);
                //Tretal
                int Tretal4 = int.Parse(tbx3Tal4.Text);
                //Fyrtal
                int Fyrtal4 = int.Parse(tbx4Tal4.Text);
                //Kåk
                int Kak4 = int.Parse(tbxKak4.Text);
                //Liten Stege
                int LS4 = int.Parse(tbxLS4.Text);
                //Stor Stege
                int SS4 = int.Parse(tbxLS4.Text);
                //Chans
                int Chans4 = int.Parse(tbxChans4.Text);
                //Yatzy
                int Yatzy4 = int.Parse(tbxYatzy4.Text);

                //steg1
                int SummaDel4 = int.Parse(lblSumma14.Text);
                int Bonus44 = int.Parse(lblBonus4.Text);
                int svarSpelare44 = EttPar4 + TvåPar4 + Tretal4 + Fyrtal4 + Kak4 + LS4 + SS4 + Chans4 + Yatzy4 + SummaDel4 + Bonus44;

                lblSummaA4.Text = svarSpelare44.ToString();


            }












        }
        //Tärningskod
        private void BtnSlå_Click(object sender, EventArgs e)
        {




            Random r = new Random();

            int iRnd = new int();
            if(cB1.Checked)  //Låser tärningen
            {

            }
            else {
                //Tärning 1

                iRnd = r.Next(0, 6); //Slumpar tärningen mellan numrena 1 till 6

                if (iRnd == 0)
                    pB1.Image = pB1Dold.Image;
                else if (iRnd == 1)
                    pB1.Image = pB2Dold.Image;
                else if (iRnd == 2)
                    pB1.Image = pB3Dold.Image;
                else if (iRnd == 3)
                    pB1.Image = pB4Dold.Image;
                else if (iRnd == 4)
                    pB1.Image = pB5Dold.Image;
                else
                    pB1.Image = pB6Dold.Image;
            }

            if (cB2.Checked)  //Låser tärningen
            {

            }
            else {
             //Tärning 2
            iRnd = r.Next(0, 6); //Slumpar tärningen mellan numrena 1 till 6
            
                if (iRnd == 0)
                    pB2.Image = pB1Dold.Image;
                else if (iRnd == 1)
                    pB2.Image = pB2Dold.Image;
                else if (iRnd == 2)
                    pB2.Image = pB3Dold.Image;
                else if (iRnd == 3)
                    pB2.Image = pB4Dold.Image;
                else if (iRnd == 4)
                    pB2.Image = pB5Dold.Image;
                else
                    pB2.Image = pB6Dold.Image;

            }

            if (cB3.Checked)  //Låser tärningen
            {

            }
            else
            {


                //Tärning 3
                iRnd = r.Next(0, 6); //Slumpar tärningen mellan numrena 1 till 6

                if (iRnd == 0)
                    pB3.Image = pB1Dold.Image; //
                else if (iRnd == 1)
                    pB3.Image = pB2Dold.Image;
                else if (iRnd == 2)
                    pB3.Image = pB3Dold.Image;
                else if (iRnd == 3)
                    pB3.Image = pB4Dold.Image;
                else if (iRnd == 4)
                    pB3.Image = pB5Dold.Image;
                else
                    pB3.Image = pB6Dold.Image;
            }
            if (cB4.Checked) //Låser tärningen
            {

            }
            else
            {
                //Tärning 4
                iRnd = r.Next(0, 6); //Slumpar tärningen mellan numrena 1 till 6
                if (iRnd == 0)
                    pB4.Image = pB1Dold.Image;
                else if (iRnd == 1)
                    pB4.Image = pB2Dold.Image;
                else if (iRnd == 2)
                    pB4.Image = pB3Dold.Image;
                else if (iRnd == 3)
                    pB4.Image = pB4Dold.Image;
                else if (iRnd == 4)
                    pB4.Image = pB5Dold.Image;
                else
                    pB4.Image = pB6Dold.Image;
            }




            if (cB5.Checked)  //Låser tärningen
            {

            }
            else
            {
                //Tärning 5
                iRnd = r.Next(0, 6); //Slumpar tärningen mellan numrena 1 till 6
                if (iRnd == 0)
                    pB5.Image = pB1Dold.Image;
                else if (iRnd == 1)
                    pB5.Image = pB2Dold.Image;
                else if (iRnd == 2)
                    pB5.Image = pB3Dold.Image;
                else if (iRnd == 3)
                    pB5.Image = pB4Dold.Image;
                else if (iRnd == 4)
                    pB5.Image = pB5Dold.Image;
                else
                    pB5.Image = pB6Dold.Image;
            }


        }
        //Omknapp
        private void OmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //HjälpKnapp
        private void HjälpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
