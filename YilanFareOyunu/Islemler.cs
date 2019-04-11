using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace YilanFareOyunu
{
    public class Islemler
    {
        public bool oyunDevamEdiyormu = false;
        public bool oyunBasladimi = false;
        public int puan = 0, level = 0, farehiz = 5;
        public int yilan1x, yilan1y, yilan2x, yilan2y, yilan3x, yilan3y, farekonumx, farekonumy;
        public bool yilan2basladimi = false, yilan3basladimi = false;
        string second, minute, hour;
        public int saniye = 0, dakika = 0, saat = 0;
        int hak = 5;
        public bool fareicondegistimi = false;
        Random random = new Random();

        public void YukariYon()
        {
            if (farehiz == 5 && YilanFareOyunu.yilan.fare.Location.Y >= 15)
            {
                YilanFareOyunu.yilan.fare.Top -= farehiz;
            }
            else if (farehiz == 7 && YilanFareOyunu.yilan.fare.Location.Y >= 17)
            {
                YilanFareOyunu.yilan.fare.Top -= farehiz;
            }
            else if (farehiz == 9 && YilanFareOyunu.yilan.fare.Location.Y >= 19)
            {
                YilanFareOyunu.yilan.fare.Top -= farehiz;
            }
            else if (farehiz == 11 && YilanFareOyunu.yilan.fare.Location.Y >= 21)
            {
                YilanFareOyunu.yilan.fare.Top -= farehiz;
            }
            else if (farehiz == 13 && YilanFareOyunu.yilan.fare.Location.Y >= 23)
            {
                YilanFareOyunu.yilan.fare.Top -= farehiz;
            }
            else if (farehiz == 15 && YilanFareOyunu.yilan.fare.Location.Y >= 25)
            {
                YilanFareOyunu.yilan.fare.Top -= farehiz;
            }
            else if (farehiz == 17 && YilanFareOyunu.yilan.fare.Location.Y >= 27)
            {
                YilanFareOyunu.yilan.fare.Top -= farehiz;
            }
        }

        public void SolYon()
        {
            if (farehiz == 5 && YilanFareOyunu.yilan.fare.Location.X >= 5)
            {
                YilanFareOyunu.yilan.fare.Left -= farehiz;
            }
            else if (farehiz == 7 && YilanFareOyunu.yilan.fare.Location.X >= 7)
            {
                YilanFareOyunu.yilan.fare.Left -= farehiz;
            }
            else if (farehiz == 9 && YilanFareOyunu.yilan.fare.Location.X >= 9)
            {
                YilanFareOyunu.yilan.fare.Left -= farehiz;
            }
            else if (farehiz == 11 && YilanFareOyunu.yilan.fare.Location.X >= 11)
            {
                YilanFareOyunu.yilan.fare.Left -= farehiz;
            }
            else if (farehiz == 13 && YilanFareOyunu.yilan.fare.Location.X >= 13)
            {
                YilanFareOyunu.yilan.fare.Left -= farehiz;
            }
            else if (farehiz == 15 && YilanFareOyunu.yilan.fare.Location.X >= 15)
            {
                YilanFareOyunu.yilan.fare.Left -= farehiz;
            }
            else if (farehiz == 17 && YilanFareOyunu.yilan.fare.Location.X >= 17)
            {
                YilanFareOyunu.yilan.fare.Left -= farehiz;
            }
        }

        public void FareKenaraDegdimi(int yonkod)
        {
            if (yonkod == 1)
            {
                SolYon();
            }
            else if (yonkod == 2)
            {
                if (farehiz == 5 && YilanFareOyunu.yilan.fare.Location.X <= 841)
                {
                    YilanFareOyunu.yilan.fare.Left += farehiz;
                }
                else if (farehiz == 7 && YilanFareOyunu.yilan.fare.Location.X <= 839)
                {
                    YilanFareOyunu.yilan.fare.Left += farehiz;
                }
                else if (farehiz == 9 && YilanFareOyunu.yilan.fare.Location.X <= 837)
                {
                    YilanFareOyunu.yilan.fare.Left += farehiz;
                }
                else if (farehiz == 11 && YilanFareOyunu.yilan.fare.Location.X <= 835)
                {
                    YilanFareOyunu.yilan.fare.Left += farehiz;
                }
                else if (farehiz == 13 && YilanFareOyunu.yilan.fare.Location.X <= 833)
                {
                    YilanFareOyunu.yilan.fare.Left += farehiz;
                }
                else if (farehiz == 15 && YilanFareOyunu.yilan.fare.Location.X <= 831)
                {
                    YilanFareOyunu.yilan.fare.Left += farehiz;
                }
                else if (farehiz == 17 && YilanFareOyunu.yilan.fare.Location.X <= 829)
                {
                    YilanFareOyunu.yilan.fare.Left += farehiz;
                }
            }
            else if (yonkod == 3)
            {
                YukariYon();
            }
            else if (yonkod == 4)
            {
                if (farehiz == 5 && YilanFareOyunu.yilan.fare.Location.Y <= 311)
                {
                    YilanFareOyunu.yilan.fare.Top += farehiz;
                }
                else if (farehiz == 7 && YilanFareOyunu.yilan.fare.Location.Y <= 309)
                {
                    YilanFareOyunu.yilan.fare.Top += farehiz;
                }
                else if (farehiz == 9 && YilanFareOyunu.yilan.fare.Location.Y <= 307)
                {
                    YilanFareOyunu.yilan.fare.Top += farehiz;
                }
                else if (farehiz == 11 && YilanFareOyunu.yilan.fare.Location.Y <= 305)
                {
                    YilanFareOyunu.yilan.fare.Top += farehiz;
                }
                else if (farehiz == 13 && YilanFareOyunu.yilan.fare.Location.Y <= 303)
                {
                    YilanFareOyunu.yilan.fare.Top += farehiz;
                }
                else if (farehiz == 15 && YilanFareOyunu.yilan.fare.Location.Y <= 301)
                {
                    YilanFareOyunu.yilan.fare.Top += farehiz;
                }
                else if (farehiz == 17 && YilanFareOyunu.yilan.fare.Location.Y <= 299)
                {
                    YilanFareOyunu.yilan.fare.Top += farehiz;
                }
            }
            if (yonkod == 5)
            {
                if (YilanFareOyunu.yilan.fare.Location.Y<30)
                {
                    if (farehiz == 5 && YilanFareOyunu.yilan.fare.Location.X >= 125)
                    {
                        YilanFareOyunu.yilan.fare.Left -= farehiz;
                    }
                    else if (farehiz == 7 && YilanFareOyunu.yilan.fare.Location.X >= 127)
                    {
                        YilanFareOyunu.yilan.fare.Left -= farehiz;
                    }
                    else if (farehiz == 9 && YilanFareOyunu.yilan.fare.Location.X >= 129)
                    {
                        YilanFareOyunu.yilan.fare.Left -= farehiz;
                    }
                    else if (farehiz == 11 && YilanFareOyunu.yilan.fare.Location.X >= 131)
                    {
                        YilanFareOyunu.yilan.fare.Left -= farehiz;
                    }
                    else if (farehiz == 13 && YilanFareOyunu.yilan.fare.Location.X >= 133)
                    {
                        YilanFareOyunu.yilan.fare.Left -= farehiz;
                    }
                    else if (farehiz == 15 && YilanFareOyunu.yilan.fare.Location.X >= 135)
                    {
                        YilanFareOyunu.yilan.fare.Left -= farehiz;
                    }
                    else if (farehiz == 17 && YilanFareOyunu.yilan.fare.Location.X >= 137)
                    {
                        YilanFareOyunu.yilan.fare.Left -= farehiz;
                    }
                }
                else
                {
                    SolYon();
                }
            }
            else if (yonkod == 6)
            {
                if (YilanFareOyunu.yilan.fare.Location.X<=120)
                {
                    if (farehiz == 5 && YilanFareOyunu.yilan.fare.Location.Y >= 35)
                    {
                        YilanFareOyunu.yilan.fare.Top -= farehiz;
                    }
                    else if (farehiz == 7 && YilanFareOyunu.yilan.fare.Location.Y >= 37)
                    {
                        YilanFareOyunu.yilan.fare.Top -= farehiz;
                    }
                    else if (farehiz == 9 && YilanFareOyunu.yilan.fare.Location.Y >= 39)
                    {
                        YilanFareOyunu.yilan.fare.Top -= farehiz;
                    }
                    else if (farehiz == 11 && YilanFareOyunu.yilan.fare.Location.Y >= 41)
                    {
                        YilanFareOyunu.yilan.fare.Top -= farehiz;
                    }
                    else if (farehiz == 13 && YilanFareOyunu.yilan.fare.Location.Y >= 43)
                    {
                        YilanFareOyunu.yilan.fare.Top -= farehiz;
                    }
                    else if (farehiz == 15 && YilanFareOyunu.yilan.fare.Location.Y >= 45)
                    {
                        YilanFareOyunu.yilan.fare.Top -= farehiz;
                    }
                    else if (farehiz == 17 && YilanFareOyunu.yilan.fare.Location.Y >= 47)
                    {
                        YilanFareOyunu.yilan.fare.Top -= farehiz;
                    }
                }
                else
                {
                    YukariYon();
                }
            }
        }

        public void Zaman()
        {
            if (Convert.ToString(saat).Length == 1)
            {
                hour = "0" + saat.ToString();
            }
            else
            {
                hour = saat.ToString();
            }
            if (Convert.ToString(dakika).Length == 1)
            {
                minute = "0" + dakika.ToString();
            }
            else
            {
                minute = dakika.ToString();
            }
            if (Convert.ToString(saniye).Length == 1)
            {
                second = "0" + saniye.ToString();
            }
            else
            {
                second = saniye.ToString();
            }
            YilanFareOyunu.yilan.lblsure.Text = hour + ":" + minute + ":" + second;
        }

        public void FareRandomKonum()
        {
            farekonumx = random.Next(250, 850);
            farekonumy = random.Next(5,290);
            YilanFareOyunu.yilan.fare.Location = new Point(farekonumx, farekonumy);
        }
        public void YilanRandomKonum(int yilankod)
        {
            if (yilankod == 1)
            {
                yilan1x = -150;
                yilan1y = random.Next(24,290);
                YilanFareOyunu.yilan.yilan1.Location = new Point(yilan1x, yilan1y);
                YilanlarCarpistimi(yilankod);
            }
            else if (yilankod == 2)
            {
                yilan2x = -150;
                yilan2y = random.Next(24,290);
                YilanFareOyunu.yilan.yilan2.Location = new Point(yilan2x, yilan2y);
                YilanlarCarpistimi(yilankod);
            }
            else if (yilankod == 3)
            {
                yilan3x = -150;
                yilan3y = random.Next(24,290);
                YilanFareOyunu.yilan.yilan3.Location = new Point(yilan3x, yilan3y);
                YilanlarCarpistimi(yilankod);
            }

        }

        public void YilanlarCarpistimi(int yilankod)
        {
            if (yilankod == 1)
            {
                if (YilanFareOyunu.yilan.yilan1.Bounds.IntersectsWith(YilanFareOyunu.yilan.yilan2.Bounds) || YilanFareOyunu.yilan.yilan1.Bounds.IntersectsWith(YilanFareOyunu.yilan.yilan3.Bounds))
                {
                    YilanRandomKonum(yilankod);
                }
            }
            else if (yilankod == 2)
            {
                if (YilanFareOyunu.yilan.yilan2.Bounds.IntersectsWith(YilanFareOyunu.yilan.yilan1.Bounds) || YilanFareOyunu.yilan.yilan2.Bounds.IntersectsWith(YilanFareOyunu.yilan.yilan3.Bounds))
                {
                    YilanRandomKonum(yilankod);
                }
            }
            else if (yilankod == 3)
            {
                if (YilanFareOyunu.yilan.yilan3.Bounds.IntersectsWith(YilanFareOyunu.yilan.yilan1.Bounds) || YilanFareOyunu.yilan.yilan3.Bounds.IntersectsWith(YilanFareOyunu.yilan.yilan2.Bounds))
                {
                    YilanRandomKonum(yilankod);
                }
            }
        }

        public void YilanHareketEdiyormu(int kod = 0)
        {
            if (kod == 0)
            {
                if (YilanFareOyunu.yilan.yilan1.Enabled)
                {
                    YilanFareOyunu.yilan.yilan1.Enabled = false;
                    YilanFareOyunu.yilan.yilan2.Enabled = false;
                    YilanFareOyunu.yilan.yilan3.Enabled = false;
                }
                else
                {
                    YilanFareOyunu.yilan.yilan1.Enabled = true;
                    YilanFareOyunu.yilan.yilan2.Enabled = true;
                    YilanFareOyunu.yilan.yilan3.Enabled = true;
                }
            }
            else if(kod==1)
            {
                YilanFareOyunu.yilan.yilan1.Enabled = false;
                YilanFareOyunu.yilan.yilan2.Enabled = false;
                YilanFareOyunu.yilan.yilan3.Enabled = false;
            }
        }

        public void TimerBasladimi(int kod = 0)
        {
            if (kod == 0)
            {
                if (YilanFareOyunu.yilan.tmrhareket.Enabled)
                {
                    YilanFareOyunu.yilan.tmrhareket.Stop();
                    YilanFareOyunu.yilan.timersure.Stop();
                    YilanFareOyunu.yilan.timerpuan.Stop();
                }
                else
                {
                    YilanFareOyunu.yilan.tmrhareket.Start();
                    YilanFareOyunu.yilan.timersure.Start();
                    YilanFareOyunu.yilan.timerpuan.Start();
                }
            }
            else
            {
                YilanFareOyunu.yilan.tmrhareket.Stop();
                YilanFareOyunu.yilan.timersure.Stop();
                YilanFareOyunu.yilan.timerpuan.Stop();
            }
        }
        public void DurumSifirla()
        {
            puan = 0;
            saniye = 0;
            dakika = 0;
            saat = 0;
            hak = 5;
            level = 0;
            farehiz = 5;
            oyunDevamEdiyormu = false;
            oyunBasladimi = false;
            YilanFareOyunu.yilan.btnbitir.Enabled = false;
        }
        public void DurumYazdir()
        {
            YilanFareOyunu.yilan.lblsure.Text = "00:00:00";
            YilanFareOyunu.yilan.lblhak.Text = hak.ToString();
            YilanFareOyunu.yilan.lblpuan.Text = puan.ToString();
            YilanFareOyunu.yilan.lbllevel.Text = level.ToString();
        }

        Thread msj;
        public void DurumGoster(string durum, int durumkod)
        {
            if (msj != null)
            {
                msj.Abort();
            }
            msj = new Thread(() => DurumRenklendir(durumkod));
            msj.Start();
            YilanFareOyunu.yilan.lblbaslik.Text = durum;
        }

        public void HangiYondenCarpti(int yilankod)
        {
            if (yilankod == 1)
            {
                if (YilanFareOyunu.yilan.fare.Location.X < yilan1x && YilanFareOyunu.yilan.fare.Location.X + YilanFareOyunu.yilan.fare.Width >= yilan1x)
                {
                    YilanFareOyunu.yilan.fare.Location = new Point(YilanFareOyunu.yilan.fare.Location.X - 10, YilanFareOyunu.yilan.fare.Location.Y);
                }
                if (YilanFareOyunu.yilan.fare.Location.Y < yilan1y && YilanFareOyunu.yilan.fare.Location.Y + YilanFareOyunu.yilan.fare.Height >= yilan1y)
                {
                    YilanFareOyunu.yilan.fare.Location = new Point(YilanFareOyunu.yilan.fare.Location.X, YilanFareOyunu.yilan.fare.Location.Y - 10);
                }
                if (yilan1x < YilanFareOyunu.yilan.fare.Location.X && yilan1x + YilanFareOyunu.yilan.yilan1.Width >= YilanFareOyunu.yilan.fare.Location.X)
                {
                    YilanFareOyunu.yilan.yilan1.Location = new Point(yilan1x - 10, yilan1y);
                }
                if (yilan1y < YilanFareOyunu.yilan.fare.Location.Y && yilan1y + yilan1y >= YilanFareOyunu.yilan.fare.Location.Y)
                {
                    YilanFareOyunu.yilan.yilan1.Location = new Point(yilan1x, yilan1y - 10);
                }
            }
            else if (yilankod == 2)
            {
                if (YilanFareOyunu.yilan.fare.Location.X < yilan2x && YilanFareOyunu.yilan.fare.Location.X + YilanFareOyunu.yilan.fare.Width >= yilan2x)
                {
                    YilanFareOyunu.yilan.fare.Location = new Point(YilanFareOyunu.yilan.fare.Location.X - 10, YilanFareOyunu.yilan.fare.Location.Y);
                }
                if (YilanFareOyunu.yilan.fare.Location.Y < yilan2y && YilanFareOyunu.yilan.fare.Location.Y + YilanFareOyunu.yilan.fare.Height >= yilan2y)
                {
                    YilanFareOyunu.yilan.fare.Location = new Point(YilanFareOyunu.yilan.fare.Location.X, YilanFareOyunu.yilan.fare.Location.Y - 10);
                }
                if (yilan2x < YilanFareOyunu.yilan.fare.Location.X && yilan2x + YilanFareOyunu.yilan.yilan2.Width >= YilanFareOyunu.yilan.fare.Location.X)
                {
                    YilanFareOyunu.yilan.yilan2.Location = new Point(yilan2x - 10, yilan2y);
                }
                if (yilan2y < YilanFareOyunu.yilan.fare.Location.Y && yilan2y + yilan2y >= YilanFareOyunu.yilan.fare.Location.Y)
                {
                    YilanFareOyunu.yilan.yilan2.Location = new Point(yilan2x, yilan2y - 10);
                }
            }
            else if (yilankod == 3)
            {
                if (YilanFareOyunu.yilan.fare.Location.X < yilan3x && YilanFareOyunu.yilan.fare.Location.X + YilanFareOyunu.yilan.fare.Width >= yilan3x)
                {
                    YilanFareOyunu.yilan.fare.Location = new Point(YilanFareOyunu.yilan.fare.Location.X - 10, YilanFareOyunu.yilan.fare.Location.Y);
                }
                if (YilanFareOyunu.yilan.fare.Location.Y < yilan3y && YilanFareOyunu.yilan.fare.Location.Y + YilanFareOyunu.yilan.fare.Height >= yilan3y)
                {
                    YilanFareOyunu.yilan.fare.Location = new Point(YilanFareOyunu.yilan.fare.Location.X, YilanFareOyunu.yilan.fare.Location.Y - 10);
                }
                if (yilan3x < YilanFareOyunu.yilan.fare.Location.X && yilan3x + YilanFareOyunu.yilan.yilan3.Width >= YilanFareOyunu.yilan.fare.Location.X)
                {
                    YilanFareOyunu.yilan.yilan3.Location = new Point(yilan3x - 10, yilan3y);
                }
                if (yilan3y < YilanFareOyunu.yilan.fare.Location.Y && yilan3y + yilan3y >= YilanFareOyunu.yilan.fare.Location.Y)
                {
                    YilanFareOyunu.yilan.yilan3.Location = new Point(yilan3x, yilan3y - 10);
                }
            }
        }

        public void FareIconDegistir()
        {

            YilanFareOyunu.yilan.fare.BackgroundImage = null;
            if (!fareicondegistimi)
            {
                YilanFareOyunu.yilan.fare.Image = Image.FromFile("resimler/mouseRed.png");
                fareicondegistimi = true;
            }
            else
            {
                YilanFareOyunu.yilan.fare.Image = Image.FromFile("resimler/mouse.png");
                fareicondegistimi = false;
            }
        }


        public void Ses(string sespath)
        {
            SoundPlayer player = new SoundPlayer("ses/"+sespath);
            player.Play();
        }

        public void BtnIconDegistir()
        {
            YilanFareOyunu.yilan.btnbaslat.BackgroundImage = null;
            if (!oyunDevamEdiyormu)
            {
                YilanFareOyunu.yilan.btnbaslat.Image = Image.FromFile("resimler/baslat.png");
            }
            else
            {
                YilanFareOyunu.yilan.btnbaslat.Image = Image.FromFile("resimler/duraklat.png");
            }
        }

        public void DurumRenklendir(int durumkod)
        {
            Color durumrenk = new Color();
            Color yazirenk = new Color();
            int baslangic = 0, bitis = 0;
            bool durumRenkb = false;
            if (durumkod == 1)
            {
                durumrenk = Color.FromArgb(255,165,0);
                bitis = 6;
            }
            else if (durumkod == 2)
            {
                durumrenk = Color.FromArgb(128, 0, 0);
                yazirenk = Color.FromArgb(255, 255, 255);
                bitis = 12;
            }
            else if (durumkod == 3)
            {
                durumrenk = Color.FromArgb(255, 0, 10);
            }
            else if (durumkod == 4)
            {
                durumrenk = Color.FromArgb(255, 255, 0);
            }

            while (durumkod < 3 ? baslangic < bitis : true)
            {
                if (durumkod == 2 || durumkod == 3)
                {
                    FareIconDegistir();
                }
                if (!durumRenkb)
                {
                    YilanFareOyunu.yilan.lblbaslik.BackColor = durumrenk;
                    YilanFareOyunu.yilan.lblbaslik.ForeColor = yazirenk;
                    durumRenkb = true;
                }
                else
                {
                    YilanFareOyunu.yilan.lblbaslik.BackColor = Color.FromArgb(255, 253, 208);
                    YilanFareOyunu.yilan.lblbaslik.ForeColor = Color.FromArgb(0,0,0);
                    durumRenkb = false;
                }
                baslangic++;
                Thread.Sleep(250);
            }
            if (durumkod != 3 && durumkod != 4)
            {
                YilanFareOyunu.yilan.lblbaslik.Text = "Durum";
            }
        }

        public void FareYakalandi(int yilankod)
        {
            hak--;
            YilanFareOyunu.yilan.lblhak.Text = hak.ToString();
            HangiYondenCarpti(yilankod);
            YilanHareketEdiyormu();

            if (hak == 0)
            {
                Ses("kazandiniz.wav");
                TimerBasladimi();
                oyunDevamEdiyormu = false;
                YilanFareOyunu.yilan.btnbitir.Enabled = false;
                BtnIconDegistir();
                DurumGoster("Tüm haklarınız tükendi.Oyunu kaybettiniz!", 3);
                DurumSifirla();
                yilan3basladimi = false;
                yilan2basladimi = false;
            }
            else
            {
                Ses("hakkaybettiniz.wav");
                DurumGoster("Yılan fareyi yedi! Kalan hakkınız:" + hak, 2);
                yilan3basladimi = false;
                yilan2basladimi = false;
                Task.Delay(3000).Wait();
                TimerBasladimi();
                FareRandomKonum();
                YilanRandomKonum(1);
                YilanRandomKonum(2);
                YilanRandomKonum(3);
                YilanHareketEdiyormu();
                TimerBasladimi();
            }
        }
        public void YilanYakaladimi()
        {
            if (YilanFareOyunu.yilan.yilan1.Bounds.IntersectsWith(YilanFareOyunu.yilan.fare.Bounds))
            {
                FareYakalandi(1);
            }
            else if (YilanFareOyunu.yilan.yilan2.Bounds.IntersectsWith(YilanFareOyunu.yilan.fare.Bounds))
            {
                FareYakalandi(2);
            }
            else if (YilanFareOyunu.yilan.yilan3.Bounds.IntersectsWith(YilanFareOyunu.yilan.fare.Bounds))
            {
                FareYakalandi(3);
            }
        }
    }
}