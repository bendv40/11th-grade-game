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
    public partial class Form7 : Form
    {
        int direction;
        int bulletspeed = 9;
      
        int chat = 0;
        PictureBox player = new PictureBox();



        int placeX = 0;
        int placeY = 640;
       
        int deadplayers = 0;
        public Form7()
        {
            InitializeComponent();
            player.Size = new Size(100, 100);

            player.Image = Image.FromFile("pixel-a 3d2.png");

            player.BackColor = Color.Transparent;
            player.Location = new Point(placeX, placeY);
            this.Controls.Add(player);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (placeX>1800)
            {
                player.Location = new Point(0, 0);
                this.Close();
                Form8 f4 = new Form8();
                f4.Show();
            }
            switch (direction)
            {
                case (1):
                    {


                        player.Location = new Point(placeX += 6, placeY);




                    }




                    break;

                case (2):
                    {



                        player.Location = new Point(placeX, placeY -= 6);


                    }






                    break;
                case (3):
                    {




                        player.Location = new Point(placeX -= 6, placeY);


                    }


                    break;
                case (4):
                    {


                        player.Location = new Point(placeX, placeY += 6);


                    }
                    break;
            }
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (39):
                    {

                    
                        direction = 1;
                        timer1.Enabled = true;

                        player.Image = Image.FromFile("pixel-b 3d2.png");

                    }
                    break;
                case (38):
                    {

                        

                        direction = 2;
                        timer1.Enabled = true;

                        player.Image = Image.FromFile("pixel- c 3d2.png");

                    }
                    break;
                case (37):
                    {

                        direction = 3;
                        timer1.Enabled = true;

                      

                        player.Image = Image.FromFile("pixel- d 3d2.png");
                    }
                    break;
                case (40):
                    {


                        direction = 4;
                        timer1.Enabled = true;

                        
                        player.Image = Image.FromFile("pixel-a 3d2.png");

                    }

                    break;
            }
        }

        private void Form7_KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Enabled = false;
           
        }
    }
}

    

    

