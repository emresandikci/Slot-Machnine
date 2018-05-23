using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace WFASlotMakinasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Global Tanımlamalar

        Timer Basla = new Timer();

        Random rnd = new Random();
        SoundPlayer ses = new SoundPlayer();
        int check1 = 0, check2 = 0, check3 = 0, MusteriJeton = 0, KasadakiJeton = 0, Deger = 0, Deger2 = 0, Deger3 = 0, Kazanma = 0;

        string[] CheckPoints = { "apple", "Orange", "pear", "Banana", "melon", "pepper", "Cherry", "Peach", "pumpkin" };

        #endregion

        #region Buttons
        private void pbKol_Click(object sender, EventArgs e)
        {
            if (MusteriJeton > 0)
            {
                ses.SoundLocation = "../../Sounds/add.wav";
                ses.Play();
                OyunuBaslat();
                Basla.Tick += Basla_Tick;
            }
            else
            {
                lblDurum.Text = "Lütfen Jeton Atınız(Jeton Yazısına Tıkla)";
            }
        }

        private void pbKol_DoubleClick(object sender, EventArgs e)
        {
            if (MusteriJeton > 0)
            {
                KasadakiJeton += MusteriJeton;
                Basla.Stop();
                KazanmaOlayi();
            }
        }

        private void lblMusteriJeton_Click(object sender, EventArgs e)
        {
            ses.SoundLocation = "../../Sounds/jeton.wav";
            ses.Play(); MusteriJeton++;
            lblMusteriJeton.Text = MusteriJeton.ToString();
        } 
        #endregion

        #region Metodlar

        private void OyunuBaslat()
        {
            lblKasadakiJeton.Text = "Kasadaki Jeton :\n" + KasadakiJeton.ToString(); //i = 0;
            lblDurum.Text = "başladı(Durdurmak İçin Kola Çift Tıkla)";
            Basla.Start();
        }

        private void KazanmaOlayi()
        {

            check1 = Convert.ToInt32(pbCheckPoint1.Tag);
            check2 = Convert.ToInt32(pbCheckPoint2.Tag);
            check3 = Convert.ToInt32(pbCheckPoint3.Tag);
            label2.Text = "" + check1 + "-" + check2 + "-" + check3;
            if (check1 == check2 && check1 == check3 && check2 == check3)
            {
                lblDurum.Text = "KAZANDINIZ"; Kazanma++; lblKasadakiJeton.Text = "Kazandın";
            }
            else lblDurum.Text = "KAYBETTİNİZ"; lblKasadakiJeton.Text = "Kasadaki Jeton :\n" + KasadakiJeton.ToString();
        }

        #region Oyunu Kazanma Şansları

        private void KazanmaSansi05()
        {
            lblKazanmaSansi.Text = "%5";
            Deger = rnd.Next(0, 9); Deger2 = rnd.Next(0, 9); Deger3 = rnd.Next(0, 9);
        }

        private void KazanmaSansi20()
        {
            lblKazanmaSansi.Text = "%25";
            Deger = rnd.Next(0, 5); Deger2 = rnd.Next(0, 5); Deger3 = rnd.Next(0, 5);
        }

        #endregion

        #endregion

        void Basla_Tick(object sender, EventArgs e)
        {
            #region Kazanma Şansı Olayı

            #region Kazanma Şansı %5

            if (KasadakiJeton < 10)
            {
                KazanmaSansi05();
            }
            #endregion

            #region Kazanma Şansı %20

            else if (KasadakiJeton > 10)
            {

                if (Kazanma > 0)
                {
                    KazanmaSansi05();
                }
                else
                {
                    KazanmaSansi20();
                }
            }
            #endregion

            #endregion

            #region Resim Atamaları
            pbCheckPoint1.ImageLocation = "../../Resources/" + CheckPoints[Deger] + ".png";
            pbCheckPoint1.BackgroundImageLayout = ImageLayout.Stretch;
            pbCheckPoint1.Tag = Deger;
            pbCheckPoint2.ImageLocation = "../../Resources/" + CheckPoints[Deger2] + ".png";
            pbCheckPoint2.BackgroundImageLayout = ImageLayout.Stretch;
            pbCheckPoint2.Tag = Deger2;
            pbCheckPoint3.ImageLocation = "../../Resources/" + CheckPoints[Deger3] + ".png";
            pbCheckPoint3.Tag = Deger3;
            pbCheckPoint3.BackgroundImageLayout = ImageLayout.Stretch;
            //i++;
            #endregion

            //if (i == 50)
            //{
            //    Basla.Stop();
            //    KazanmaOlayi();
            //}
        }

        #region WindowsState

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Kol Ayarları
        private void pbKol_MouseEnter(object sender, EventArgs e)
        {
            pbKol.BackgroundImage = Image.FromFile("../../Resources/handle2.png");
            pbKol.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pbKol_MouseLeave(object sender, EventArgs e)
        {
            pbKol.BackgroundImage = Image.FromFile("../../Resources/handle.png");
            pbKol.BackgroundImageLayout = ImageLayout.Stretch;
        }
        #endregion

        #region EMRE SANDIKÇI

        #endregion
    }
}
