using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Clock
{
    public partial class Form1 : Form
    {

        DateTime strtime1;
        DateTime strtime2;
        DateTime strtime3;

        int h1 = 0;
        int h2 = 0;
        int h3 = 0;
        int m1 = 0;
        int m2 = 0;
        int m3 = 0;
        int s1 = 40;
        int s2 = 40;
        int s3 = 40;
        int color1 = 5;
        int color2 = 5;
        int color3 = 5;
        int colorm1 = 5;
        int colorm2 = 5;
        int colorm3 = 5;
        int alh1 = 0;
        int alm1 = 0;
        int alh2 = 0;
        int alm2 = 0;
        int alh3 = 0;
        int alm3 = 0;
        int al1 = 0;
        int al2 = 0;
        int al3 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            al1 = 1; //будильник включен
            alh1 = Convert.ToInt32(maskedTextBox2.Text.Substring(0, 2));
            alm1 = Convert.ToInt32(maskedTextBox2.Text.Substring(3, 2));
            if ((alh1 > 23) || (alm1 > 59))
            {
                MessageBox.Show("Проверьте введенное время");
                maskedTextBox2.Select();
            }
            else
            {
                maskedTextBox2.BackColor = Color.Bisque;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (strtime1.AddSeconds(s1)).ToShortTimeString();
            strtime1 = strtime1.AddSeconds(s1);
            
            color1 = Convert.ToInt32(strtime1.Hour.ToString()); //Часы
            colorm1 = Convert.ToInt32(strtime1.Minute.ToString()); //Минуты

            
            if ((timer1.Enabled == true) && (al1 == 1) && (color1 == alh1) && (colorm1 == alm1)) {
                maskedTextBox2.BackColor = Color.White;
                al1 = 0; //будильник выключен
                playSound();
            }

            if ((color1 >= 4) && (color1 < 23))
            {
                textBox1.BackColor = Color.White;
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                textBox1.BackColor = Color.Black;
                textBox1.ForeColor = Color.White;
            }
            

            s1 = +40;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox2.Text = (strtime2.AddSeconds(s2)).ToShortTimeString();
            strtime2 = strtime2.AddSeconds(s2);
            color2 = Convert.ToInt32(strtime2.Hour.ToString()); //Часы
            colorm2 = Convert.ToInt32(strtime2.Minute.ToString()); //Минуты
            if ((timer2.Enabled == true) && (al2 == 1) && (color2 == alh2) && (colorm2 == alm2))
            {
                maskedTextBox3.BackColor = Color.White;
                al2 = 0; //будильник выключен
                playSound();
            }

            if ((color2 >= 4) && (color2 < 23))
            {
                textBox2.BackColor = Color.White;
                textBox2.ForeColor = Color.Black;
            }
            else
            {
                textBox2.BackColor = Color.Black;
                textBox2.ForeColor = Color.White;
            }
            s2 = +40;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            textBox3.Text = (strtime3.AddSeconds(s3)).ToShortTimeString();
            strtime3 = strtime3.AddSeconds(s3);
            color3 = Convert.ToInt32(strtime3.Hour.ToString()); //Часы
            colorm3 = Convert.ToInt32(strtime3.Minute.ToString()); //Минуты
            if ((timer3.Enabled == true) && (al3 == 1) && (color3 == alh3) && (colorm3 == alm3))
            {
                maskedTextBox5.BackColor = Color.White;
                al3 = 0; //будильник выключен
                playSound();
            }

            if ((color3 >= 4) && (color3 < 23))
            {
                textBox3.BackColor = Color.White;
                textBox3.ForeColor = Color.Black;
            }
            else
            {
                textBox3.BackColor = Color.Black;
                textBox3.ForeColor = Color.White;
            }
            s3 = +40;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            h1 = Convert.ToInt32(maskedTextBox1.Text.Substring(0, 2));
            m1 = Convert.ToInt32(maskedTextBox1.Text.Substring(3, 2));
            if ((h1 > 23) || (m1 > 59))
            {
                MessageBox.Show("Проверьте введенное время");
                maskedTextBox1.Select();
            }
            else {
                strtime1 = new DateTime(2010, 1, 1, h1, m1, 0);
                timer1.Enabled = true;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            h2 = Convert.ToInt32(maskedTextBox4.Text.Substring(0, 2));
            m2 = Convert.ToInt32(maskedTextBox4.Text.Substring(3, 2));
            if ((h2 > 23) || (m2 > 59))
            {
                MessageBox.Show("Проверьте введенное время");
                maskedTextBox4.Select();
            }
            else
            {
                strtime2 = new DateTime(2010, 1, 1, h2, m2, 0);
                timer2.Enabled = true;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            h3 = Convert.ToInt32(maskedTextBox6.Text.Substring(0, 2));
            m3 = Convert.ToInt32(maskedTextBox6.Text.Substring(3, 2));
            if ((h3 > 23) || (m3 > 59))
            {
                MessageBox.Show("Проверьте введенное время");
                maskedTextBox6.Select();
            }
            else
            {
                strtime3 = new DateTime(2010, 1, 1, h3, m2, 0);
                timer3.Enabled = true;
            }
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = "00:00";
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            textBox2.Text = "00:00";
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;
        }

        private void textBox3_DoubleClick(object sender, EventArgs e)
        {
            textBox3.Text = "00:00";
            textBox3.BackColor = Color.White;
            textBox3.ForeColor = Color.Black;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            al2 = 1; //будильник включен
            alh2 = Convert.ToInt32(maskedTextBox3.Text.Substring(0, 2));
            alm2 = Convert.ToInt32(maskedTextBox3.Text.Substring(3, 2));
            if ((alh2 > 23) || (alm2 > 59))
            {
                MessageBox.Show("Проверьте введенное время");
                maskedTextBox3.Select();
            }
            else
            {
                maskedTextBox3.BackColor = Color.Bisque;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            al3 = 1; //будильник включен
            alh3 = Convert.ToInt32(maskedTextBox5.Text.Substring(0, 2));
            alm3 = Convert.ToInt32(maskedTextBox5.Text.Substring(3, 2));
            if ((alh3 > 23) || (alm3 > 59))
            {
                MessageBox.Show("Проверьте введенное время");
                maskedTextBox5.Select();
            }
            else
            {
                maskedTextBox5.BackColor = Color.Bisque;
            }
        }

        private void playSound()
        {
            //string path = "./";
            try
            {
                if (File.Exists(@"C:\Windows\Media\tada.wav"))
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\tada.wav");
                    simpleSound.Play();
                }
            }
            catch {
            }

        }

    }
}
