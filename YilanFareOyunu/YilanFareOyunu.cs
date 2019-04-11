using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace YilanFareOyunu
{

    public partial class YilanFareOyunu : Form
    {
        public static YilanFareOyunu yilan;
        public YilanFareOyunu()
        {
            InitializeComponent();
            yilan = this;
        }

        Islemler islem = new Islemler();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (islem.oyunDevamEdiyormu)
            {
                if (keyData == Keys.Left)
                {
                    if(fare.Location.X<=137 && fare.Location.Y<=37)
                    {
                        islem.FareKenaraDegdimi(5);
                    }
                    else if (fare.Location.X <=17)
                    {
                        islem.FareKenaraDegdimi(1);
                    }
                    else
                    {
                        fare.Left -= islem.farehiz;
                    }
                    return true;
                }
                else if (keyData == Keys.Right)
                {
                    if (fare.Location.X >= 829)
                    {
                       islem.FareKenaraDegdimi(2);
                    }
                    else
                    {
                        fare.Left += islem.farehiz;
                    }
                    return true;
                }
                else if (keyData == Keys.Up)
                {
                    if (fare.Location.X <= 137 && fare.Location.Y <= 37)
                    {
                        islem.FareKenaraDegdimi(6);
                    }
                   else if (fare.Location.Y <= 27)
                    {
                        islem.FareKenaraDegdimi(3);
                    }
                    else
                    {
                        fare.Top -= islem.farehiz;
                    }
                    return true;
                }
                else if (keyData == Keys.Down)
                {
                    if (fare.Location.Y >= 299)
                    {
                        islem.FareKenaraDegdimi(4);
                    }
                    else
                    {
                        fare.Top += islem.farehiz;
                    }
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {

            if (islem.level == 20 && islem.oyunDevamEdiyormu == false)
            {
                islem.DurumSifirla();
                islem.DurumYazdir();
            }
            if (islem.oyunDevamEdiyormu == false)
            {
                islem.DurumGoster("Oyun Devam Ediyor!",1);
                islem.TimerBasladimi();
                if (islem.oyunBasladimi == false)
                {
                    islem.DurumGoster("Yeni Oyun Başladı!",1);
                    islem.YilanRandomKonum(1);
                    islem.YilanRandomKonum(2);
                    islem.YilanRandomKonum(3);
                    islem.FareRandomKonum();
                    islem.oyunBasladimi = true;
                    islem.level = 1;
                    islem.DurumYazdir();
                    if (islem.fareicondegistimi)
                    {
                        islem.FareIconDegistir();
                    }
                }
                islem.YilanHareketEdiyormu();
                btnbitir.Enabled = true;
                islem.oyunDevamEdiyormu = true;
             
            }
            else
            {
                islem.DurumGoster("Oyun Duraklatıldı!",1);
                islem.TimerBasladimi();
                islem.YilanHareketEdiyormu();
                islem.oyunDevamEdiyormu = false;
            }
            islem.BtnIconDegistir();
        }

               
        private void timerpuan_Tick(object sender, EventArgs e)
        {
            islem.puan++;
            lblpuan.Text = islem.puan.ToString();
            if (islem.puan %100==0)
            {
                islem.level++;
                lbllevel.Text = islem.level.ToString();
                if (islem.level % 3 == 0)
                {
                    islem.farehiz += 2;
                }
            }
            if (islem.level ==20)
            {
                islem.Ses("kazandiniz.wav");
                islem.TimerBasladimi();
                islem.YilanHareketEdiyormu();
                islem.oyunDevamEdiyormu = false;
                islem.DurumGoster("Tebrikler oyunu başarıyla tamamladınız!",4);
                btnbitir.Enabled = false;
                islem.BtnIconDegistir();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            islem.DurumSifirla();
            islem.DurumYazdir();
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        private void btnbitir_Click(object sender, EventArgs e)
        {
            islem.DurumGoster("Oyun durduruldu!", 1);
            islem.DurumSifirla();
            islem.DurumYazdir();
            islem.TimerBasladimi(1);
            islem.YilanHareketEdiyormu(1);
            islem.BtnIconDegistir();
            islem.yilan2basladimi = false;
            islem.yilan3basladimi = false;
        }

        private void timersure_Tick(object sender, EventArgs e)
        {
            islem.saniye++;
            if (islem.saniye == 60)
            {
                islem.saniye = 0;
                islem.dakika++;
            }
            if (islem.dakika == 60)
            {
                islem.saniye = 0;
                islem.dakika = 0;
                islem.saat++;
            }
            islem.Zaman();
        }

        private void tmrhareket_Tick(object sender, EventArgs e)
        {

            if (islem.puan > 1 && islem.yilan3basladimi ==false)
            {
                if (islem.puan % 50 == 0 && islem.yilan2basladimi == false)
                {
                    islem.YilanRandomKonum(2);
                    islem.yilan2basladimi = true;
                }
                if (islem.puan % 200 == 0 && islem.yilan3basladimi == false)
                {
                    islem.YilanRandomKonum(3);
                    islem.yilan3basladimi = true;
                }
            }

            if (islem.level >1)
            {
                islem.yilan1x += 9 * (int)(islem.level / 1.5);
                islem.yilan2x += 9 * (int)(islem.level / 1.5);
                islem.yilan3x += 9 * (int)(islem.level / 1.5);
            }
            else
            {
                islem.yilan1x += 9;
                islem.yilan2x += 9;
                islem.yilan3x += 9;
            }

            if (islem.yilan1x > 880)
            {
                islem.YilanRandomKonum(1);
            }
            else
            {
                yilan1.Location = new Point(islem.yilan1x, islem.yilan1y);
            }

            if (islem.yilan2basladimi)
            {
                if (islem.yilan2x > 880)
                {
                    islem.YilanRandomKonum(2);
                }
                else
                {
                    yilan2.Location = new Point(islem.yilan2x, islem.yilan2y);
                }
            }
            if(islem.yilan3basladimi)
            {
                if (islem.yilan3x > 880)
                {
                    islem.YilanRandomKonum(3);
                }
                else
                {
                    yilan3.Location = new Point(islem.yilan3x, islem.yilan3y);
                }
            }
            islem.YilanYakaladimi();
        }

        private void oyunKullanimiHakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OyunHakkinda oyun = new OyunHakkinda();
            oyun.Show();
        }

        private void gelistiricihakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OyunGelistiricisiHakkinda gelistirici = new OyunGelistiricisiHakkinda();
            gelistirici.Show();
        }
        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (islem.oyunDevamEdiyormu)
            {
                islem.DurumGoster("Oyun Duraklatıldı!", 1);
                islem.TimerBasladimi();
                islem.YilanHareketEdiyormu();
                islem.oyunDevamEdiyormu = false;
                islem.BtnIconDegistir();
            }
        }
    }
}
