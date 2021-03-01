using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl_game_ben_adar
{
    public partial class Form8 : Form
    {
        int counter = 0;
      
        public Form8()
        {
            
            InitializeComponent();
            Form3.play.Stop();
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = @"fuckme.mp4";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 70)
            {



                Form4 f6 = new Form4();
                Form3.play.Play();
                this.Close();
                f6.Show();
              


            }
        }
    }
}
