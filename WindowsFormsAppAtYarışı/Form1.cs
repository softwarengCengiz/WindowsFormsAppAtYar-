using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int at1left, at2left, at3left;
        Random rastgele = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int at1genişlik = pictureBox1.Width;
            int at2genişlik = pictureBox2.Width;
            int at3genişlik = pictureBox3.Width;

            int finish = label5.Left;

            pictureBox1.Left += rastgele.Next(5, 15);
            pictureBox2.Left += rastgele.Next(5, 15);
            pictureBox3.Left += rastgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left  && pictureBox1.Left > pictureBox3.Left )
            {
                label6.Text = "1 NUMARALI EZOGELİN ATAK YAPTI !!";
            }
            if (pictureBox2.Left > pictureBox1.Left  && pictureBox2.Left > pictureBox3.Left )
            {
                label6.Text = "2 NUMARALI TARHANA ŞUAN ÖNE GEÇTİ !!";
            }
            if (pictureBox3.Left > pictureBox2.Left  && pictureBox3.Left > pictureBox1.Left )
            {
                label6.Text = "3 NUMARALI KELLE PAÇA HİPODROMU TOZA BOĞDU !!";
            }

            if (at1genişlik + pictureBox1.Left >= finish)
            {
                timer1.Enabled = false;
                label6.Text = "1 NUMARALI EZOGELİN YARIŞI TAMAMLIYOR..";
                webBrowser1.Visible = true; 
                webBrowser1.Navigate("https://www.youtube.com/watch?v=J3UxBWpVY2o");
            }
            if (at2genişlik + pictureBox2.Left >= finish)
            {
                timer1.Enabled = false;
                label6.Text = "2 NUMARALI TARHANA BİRİNCİLİKLE BİTİRİYOR..";
                webBrowser1.Visible = true;
                webBrowser1.Navigate("https://www.youtube.com/watch?v=9kmOW_eqdq8");
            }
            if (at3genişlik + pictureBox3.Left >= finish)
            {
                timer1.Enabled = false;
                label6.Text = "3 NUMARALI KELLE PAÇA BUGÜN DE RAKİPSİZ..";
                webBrowser1.Visible = true;
                webBrowser1.Navigate("https://www.youtube.com/watch?v=mBiUOG_RrFQ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            at1left = pictureBox1.Left;
            at2left = pictureBox2.Left;
            at3left = pictureBox3.Left;
        }




    }
}
