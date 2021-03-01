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
   
    public partial class Form3 : Form
    {
       public static SoundPlayer play = new SoundPlayer("WhatsAppAudio20190113at20.wav");
        public Form3()
        {
            InitializeComponent();
            maneger.f = this;
          
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            play.Stop();
            f6.Show();
            this.Hide();
        }

        private void button1_DragOver(object sender, DragEventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
        }
    }
}
