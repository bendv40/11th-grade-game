using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace pbl_game_ben_adar
{
    public partial class Form6 : Form
    {
        int counter=0;
        SoundPlayer play = new SoundPlayer("WhatsAppAudio20190113at20.wav");
       
       
        int x = 0;
        public Form6()
           
        {
            InitializeComponent();
            play.Stop();
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = @"yeet.mp4";


        }

    

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter ==45)
            {
                axWindowsMediaPlayer1.URL = @"epiclol2.mp4";


                /*play.Play();
                this.Close();
                f1.Show();
                */


            }
           else if (counter == 148)
            {
               


                play.Play();
                counter = 0;
               
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
                


            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x++;



            if (x == 2)
            {
                timer1.Enabled = false;
               
                this.Close();

                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                axWindowsMediaPlayer1.URL = @"epiclol2.mp4";
                counter = 45;
            }

        }
    }
}
