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


    public partial class Form1 : Form
    {
        Form5 f5 = new Form5();
        int enemydirection = 3;
        Random rnd = new Random();

        int direction;
        int bulletspeed = 9;
        Timer Clock = new Timer();
        int chat = 0;
        PictureBox player = new PictureBox();
        PictureBox movingenemy = new PictureBox();

        PictureBox player2 = new PictureBox();

        PictureBox fireball = new PictureBox();
        int placeX = 0;
        int placeY = 0;
       
        int deadplayers = 0;
        int olddirection = 1;
        int fireballx = 0;
        int firebally = 0;
        bool iffired = false;
        int fireballdirection = 1;

        bool isenemy1dead = false;
        bool isenemy2dead = false;

        int enemyx = 1300;
        int enemyy = 100;

     


        public Form1()
        {
            InitializeComponent();


            Form3.play.Play();

            player.Size = new Size(100, 100);

            player.Image = Image.FromFile("pixel-a 3d2.png");

            player.BackColor = Color.Transparent;
            fireball.Location = new Point(0, 0);
            fireball.Size = new Size(50, 50);
            fireball.Image = Image.FromFile("fireball.png");
            fireball.BackColor = Color.Transparent;
            this.Controls.Add(fireball);
            player2.Size = new Size(100, 100);
            movingenemy.Size = new Size(100, 100);
            player2.Image = Image.FromFile("badguy - a 3d2.png");
            player2.Location = new Point(1300, 100);
            movingenemy.Location = new Point(450, 600);
            movingenemy.Image = Image.FromFile("badguy - a 3d2.png");

            Clock.Interval = 1;
            Clock.Start();
            Clock.Tick += new EventHandler(Timer_Tick);

            player.Location = new Point(placeX, placeY);
            this.Controls.Add(player);
            this.Controls.Add(player2);
            this.Controls.Add(fireball);
            this.Controls.Add(movingenemy);
            fireball.Visible = false;

            player.BringToFront();
            player2.BringToFront();
            movingenemy.BringToFront();
            fireball.BringToFront();
            player2.BackColor = Color.Transparent;
            movingenemy.BackColor = Color.Transparent;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyValue)
            {
                case (39):
                    {
                        if (placeX == 0 && placeY == 0)
                            timer4.Enabled = true;
                        Clock.Enabled = true;
                        direction = 1;
                        timer1.Enabled = true;
                        timer3.Enabled = true;
                        player.Image = Image.FromFile("pixel-b 3d2.png");

                    }
                    break;
                case (38):
                    {
                        if (placeX == 0 && placeY == 0)
                            timer4.Enabled = true;
                        Clock.Enabled = true;
                        olddirection = direction;
                        direction = 2;
                        timer1.Enabled = true;
                        timer3.Enabled = true;
                        player.Image = Image.FromFile("pixel- c 3d2.png");

                    }
                    break;
                case (37):
                    {
                        if (placeX == 0 && placeY == 0)
                            timer4.Enabled = true;
                        olddirection = direction;
                        direction = 3;
                        timer1.Enabled = true;
                        timer3.Enabled = true;
                        Clock.Enabled = true;

                        player.Image = Image.FromFile("pixel- d 3d2.png");
                    }
                    break;
                case (40):
                    {
                        if (placeX == 0 && placeY == 0)
                            timer4.Enabled = true;
                        olddirection = direction;
                        direction = 4;
                        timer1.Enabled = true;
                        timer3.Enabled = true;
                        Clock.Enabled = true;
                        player.Image = Image.FromFile("pixel-a 3d2.png");

                    }

                    break;


            }



        }
        public void Timer_Tick(object sender, EventArgs eArgs)
        {


            switch (direction)
            {
                case (1):
                    {
                        if (player.Bounds.IntersectsWith(player2.Bounds) == false && player.Bounds.IntersectsWith(label1.Bounds) == false && player.Bounds.IntersectsWith(label2.Bounds) == false && player.Bounds.IntersectsWith(label3.Bounds) == false)
                        {

                            player.Location = new Point(placeX += 6, placeY);
                            if (deadplayers == 2 && placeX > 1800)
                            {

                                this.Hide();
                                timer1.Enabled = false;
                                timer2.Enabled = false;
                                timer3.Enabled = false;
                                timer4.Enabled = false;
                                timer5.Enabled = false;
                                Clock.Enabled = false;
                                Form7 f4 = new Form7();
                                f4.Show();

                            }
                            if (player.Bounds.IntersectsWith(player2.Bounds) == true || player.Bounds.IntersectsWith(label1.Bounds) == true || player.Bounds.IntersectsWith(label2.Bounds) == true || placeX > 1900 || player.Bounds.IntersectsWith(label3.Bounds) == true)
                            {

                                player.Location = new Point(placeX -= 6, placeY);
                                if (deadplayers == 2 && placeX > 1800)
                                {
                                    this.Hide();
                                    timer1.Enabled = false;
                                    timer2.Enabled = false;
                                    timer3.Enabled = false;
                                    timer4.Enabled = false;
                                    timer5.Enabled = false;
                                    Clock.Enabled = false;
                                    Form7 f4 = new Form7();
                                    f4.Show();
                                }
                            }

                        }

                        break;
                    }
                case (2):
                    {


                        if (player.Bounds.IntersectsWith(player2.Bounds) == false && player.Bounds.IntersectsWith(label1.Bounds) == false && player.Bounds.IntersectsWith(label2.Bounds) == false && player.Bounds.IntersectsWith(label3.Bounds) == false)
                        {

                            player.Location = new Point(placeX, placeY -= 6);
                            if (deadplayers == 2 && placeX > 1800)
                            {
                                this.Hide();
                                timer1.Enabled = false;
                                timer2.Enabled = false;
                                timer3.Enabled = false;
                                timer4.Enabled = false;
                                timer5.Enabled = false;
                                Clock.Enabled = false;
                                Form7 f4 = new Form7();
                                f4.Show();
                            }


                            if (player.Bounds.IntersectsWith(player2.Bounds) == true || player.Bounds.IntersectsWith(label1.Bounds) == true || player.Bounds.IntersectsWith(label2.Bounds) == true || placeY < 0 || player.Bounds.IntersectsWith(label3.Bounds) == true)
                            {

                                player.Location = new Point(placeX, placeY += 6);
                                if (deadplayers == 2 && placeX > 1800)
                                {
                                    this.Hide();
                                    timer1.Enabled = false;
                                    timer2.Enabled = false;
                                    timer3.Enabled = false;
                                    timer4.Enabled = false;
                                    timer5.Enabled = false;
                                    Clock.Enabled = false;

                                    Form7 f4 = new Form7(); f4.Show();
                                }
                            }
                        }
                    }
                    break;
                case (3):
                    {


                        if (player.Bounds.IntersectsWith(player2.Bounds) == false && player.Bounds.IntersectsWith(label1.Bounds) == false && player.Bounds.IntersectsWith(label2.Bounds) == false && player.Bounds.IntersectsWith(label3.Bounds) == false)
                        {

                            player.Location = new Point(placeX -= 6, placeY);
                            if (deadplayers == 2 && placeX > 1800)
                            {
                                this.Hide();
                                timer1.Enabled = false;
                                timer2.Enabled = false;
                                timer3.Enabled = false;
                                timer4.Enabled = false;
                                timer5.Enabled = false;
                                Clock.Enabled = false;

                                Form7 f4 = new Form7();
                                f4.Show();
                            }
                            if (player.Bounds.IntersectsWith(player2.Bounds) == true || player.Bounds.IntersectsWith(label1.Bounds) == true || player.Bounds.IntersectsWith(label2.Bounds) == true || placeX < 0 || player.Bounds.IntersectsWith(label3.Bounds) == true)
                            {

                                player.Location = new Point(placeX += 6, placeY);
                                if (deadplayers == 2 && placeX > 1800)
                                {
                                    this.Hide();
                                    timer1.Enabled = false;
                                    timer2.Enabled = false;
                                    timer3.Enabled = false;
                                    timer4.Enabled = false;
                                    timer5.Enabled = false;
                                    Clock.Enabled = false;
                                    Form7 f4 = new Form7();
                                    f4.Show();
                                }
                            }
                        }
                    }

                    break;
                case (4):
                    {

                        if (player.Bounds.IntersectsWith(player2.Bounds) == false && player.Bounds.IntersectsWith(label1.Bounds) == false && player.Bounds.IntersectsWith(label2.Bounds) == false && player.Bounds.IntersectsWith(label3.Bounds) == false)
                        {
                            player.Location = new Point(placeX, placeY += 6);
                            if (deadplayers == 2 && placeX > 1800)
                                this.Hide();


                            if (player.Bounds.IntersectsWith(player2.Bounds) == true || player.Bounds.IntersectsWith(label1.Bounds) == true || player.Bounds.IntersectsWith(label2.Bounds) == true || placeY > 1000 || player.Bounds.IntersectsWith(label3.Bounds) == true)
                            {
                                player.Location = new Point(placeX, placeY -= 6);
                                if (deadplayers == 2 && placeX > 1800)
                                {
                                    this.Hide();
                                    timer1.Enabled = false;
                                    timer2.Enabled = false;
                                    timer3.Enabled = false;
                                    timer4.Enabled = false;
                                    timer5.Enabled = false;
                                    Clock.Enabled = false;

                                    Form7 f4 = new Form7();
                                    f4.Show();
                                }
                            }
                        }
                    }
                    break;
            }
        }



        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 32)
            {
                timer1.Enabled = false;
                Clock.Enabled = false;

            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*  movementPhase++;
              if (movementPhase > 3) movementPhase = 1;
              if (direction == 1)
              //determining which image is currently displayed
              {
                  if (movementPhase == 1)
                      player.Image = Image.FromFile("Mariowalkcycle1.jpg");
                  else if (movementPhase == 2)
                      player.Image = Image.FromFile("Mariowalkcycle2.jpg");
                  else if (movementPhase == 3)
                      player.Image = Image.FromFile("Mariowalkcycle3.jpg");

              }
              else if (direction == 4)
              {
                  if (movementPhase == 1)
                      player.Image = Image.FromFile("Mariowalkcycledawn1.jpg");
                  else if (movementPhase == 2)
                      player.Image = Image.FromFile("Mariowalkcycledawn2.jpg");
                  else if (movementPhase == 3)
                      player.Image = Image.FromFile("Mariowalkcycledawn3.jpg");
              }
              else if (direction == 2)
              {
                  if (movementPhase == 1)
                      player.Image = Image.FromFile("Mariowalkcycleup1.png");
                  else if (movementPhase == 2)
                      player.Image = Image.FromFile("Mariowalkcycleup2.png");
                  else if (movementPhase == 3)
                      player.Image = Image.FromFile("Mariowalkcycleup3.png");
              }
              else if (direction == 3)
              {
                  if (movementPhase == 1)
                      player.Image = Image.FromFile("Mariowalkcycleleft1.jpg");
                  else if (movementPhase == 2)
                      player.Image = Image.FromFile("Mariowalkcycleleft2.png");
                  else if (movementPhase == 3)
                      player.Image = Image.FromFile("Mariowalkcycleleft3.jpg");
              }*/

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            //Form2 f2 = new Form2();
            //f2.Show();
            //this.Hide();

            if (fireballdirection == 1)
            {
                if (fireball.Bounds.IntersectsWith(player2.Bounds) == false && fireball.Bounds.IntersectsWith(label2.Bounds) == false && fireball.Bounds.IntersectsWith(label1.Bounds) == false && fireballx < 1810 && iffired == true && player.Bounds.IntersectsWith(label3.Bounds) == false)
                {
                    iffired = true;
                    fireballx += bulletspeed;

                    fireball.Location = new Point(fireballx, firebally);

                }
                else if (fireball.Bounds.IntersectsWith(player2.Bounds) == false || fireball.Bounds.IntersectsWith(label2.Bounds) == false || fireball.Bounds.IntersectsWith(label1.Bounds) == false || fireballx > 1800 || player.Bounds.IntersectsWith(label3.Bounds) == false)
                {
                    iffired = false;
                    fireball.Visible = false;

                }
            }

            else if (fireballdirection == 2)
            {
                if (fireball.Bounds.IntersectsWith(player2.Bounds) == false && fireball.Bounds.IntersectsWith(label2.Bounds) == false && fireball.Bounds.IntersectsWith(label1.Bounds) == false && firebally > 0 && iffired == true && player.Bounds.IntersectsWith(label3.Bounds) == false)
                {
                    iffired = true;
                    firebally -= bulletspeed;

                    fireball.Location = new Point(fireballx, firebally);



                }
                else if (fireball.Bounds.IntersectsWith(player2.Bounds) == false || fireball.Bounds.IntersectsWith(label2.Bounds) == false || fireball.Bounds.IntersectsWith(label1.Bounds) == false || firebally < 0 || player.Bounds.IntersectsWith(label3.Bounds) == false)
                {
                    iffired = false;
                    fireball.Visible = false;

                }
            }
            else if (fireballdirection == 3)
            {
                if (fireball.Bounds.IntersectsWith(player2.Bounds) == false && fireball.Bounds.IntersectsWith(label2.Bounds) == false && fireball.Bounds.IntersectsWith(label1.Bounds) == false && fireballx > -1 && iffired == true && player.Bounds.IntersectsWith(label3.Bounds) == false)
                {
                    iffired = true;
                    fireballx -= bulletspeed;

                    fireball.Location = new Point(fireballx, firebally);

                }
                else if (fireball.Bounds.IntersectsWith(player2.Bounds) == false || fireball.Bounds.IntersectsWith(label2.Bounds) == false || fireball.Bounds.IntersectsWith(label1.Bounds) == false || fireballx < -1 || player.Bounds.IntersectsWith(label3.Bounds) == false)
                {
                    iffired = false;
                    fireball.Visible = false;


                }
            }
            else if (fireballdirection == 4)
            {
                if (fireball.Bounds.IntersectsWith(player2.Bounds) == false && fireball.Bounds.IntersectsWith(label2.Bounds) == false && fireball.Bounds.IntersectsWith(label1.Bounds) == false && firebally < 1000 && iffired == true && player.Bounds.IntersectsWith(label3.Bounds) == false)
                {
                    iffired = true;
                    firebally += bulletspeed;

                    fireball.Location = new Point(fireballx, firebally);

                }
                else if (fireball.Bounds.IntersectsWith(player2.Bounds) == false || fireball.Bounds.IntersectsWith(label2.Bounds) == false || fireball.Bounds.IntersectsWith(label1.Bounds) == false || firebally > 999 || player.Bounds.IntersectsWith(label3.Bounds) == false)
                {
                    iffired = false;
                    fireball.Visible = false;

                }
            }

        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (' '):
                    {
                        if (iffired == false)
                        {

                            fireballx = placeX;
                            firebally = placeY;
                            if (iffired == false)
                                fireballdirection = direction;
                            if (fireballdirection == 0)
                                fireballdirection = 1;


                            iffired = true;

                            timer2.Enabled = true;

                            fireball.Visible = true;
                            fireball.Location = new Point(fireballx, fireballx);


                            /*   if (direction == 1)
                            //   {
                            //       fireballx += 4;
                            //
                            //          fireball.Location = new Point(fireballx, firebally);
                            //
                            //       }

                               //     if (direction == 2)
                               //     {
                               //         firebally -= 4;

                               //        fireball.Location = new Point(fireballx, firebally);

                               //      }
                               //      if (direction == 3)
                               //       {
                               //            fireballx -= 4;

                               //           fireball.Location = new Point(fireballx, firebally);

                               //        }
                               //        if (direction == 4)
                               //         {
                               ///             firebally += 4;

                               //               fireball.Location = new Point(fireballx, firebally);

                                      }

        */
                        }
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void timer3_Tick(object sender, EventArgs e)
        {


            if (player2.Bounds.IntersectsWith(label2.Bounds))
            {
                enemydirection = rnd.Next(1, 4);
                player2.Location = new Point(enemyx -= 5, enemyy -= 6);
            }
            if (player2.Bounds.IntersectsWith(label1.Bounds))
            {
                enemydirection = rnd.Next(1, 4);
                player2.Location = new Point(enemyx += 5, enemyy += 6);
            }
            if (enemyy < 0)
            {
                enemydirection = 3;
            }
            if (enemyy > 900)
            {
                enemydirection = 4;
            }
            if (enemyx > 1800)
            {
                enemydirection = 3;
            }
            if (enemyx < 0)
            {
                enemydirection = 3;
            }


            if (enemydirection == 1)
            {
                player2.Location = new Point(enemyx += 3, enemyy);
                player2.Image = Image.FromFile("badguy- b 3d.png");
            }
            if (enemydirection == 2)
            {
                player2.Location = new Point(enemyx -= 3, enemyy);
                player2.Image = Image.FromFile("badguy - d 3d2.png");
            }
            if (enemydirection == 3)
            {
                player2.Location = new Point(enemyx -= 3, enemyy += 2);
                player2.Image = Image.FromFile("badguy - d 3d2.png");
            }
            if (enemydirection == 4)
            {
                player2.Location = new Point(enemyx += 3, enemyy -= 2);
                player2.Image = Image.FromFile("badguy- b 3d.png");
            }
            if (fireball.Bounds.IntersectsWith(player2.Bounds))
            {
                isenemy2dead = true;
                player2.Location = new Point(-10000, -10000);
                timer5.Enabled = true;
                timer3.Enabled = false;
                enemyx = -10000;
                enemyy = -100000;


                deadplayers++;
            }
            if (deadplayers == 2)
            {


               
                timer3.Enabled = false;
                timer4.Enabled = false;
            }





            if (player2.Bounds.IntersectsWith(player.Bounds) && player.Bounds.IntersectsWith(player2.Bounds) && !isenemy2dead)
            {
                player.Location = new Point(-100, -100);
                timer1.Enabled = false;

                f5.Show();
                this.Hide();

            }
        }
    
        private void timer4_Tick(object sender, EventArgs e)
        {

            if (fireball.Bounds.IntersectsWith(movingenemy.Bounds))
            {
                isenemy1dead = true;
                movingenemy.Visible = false;
                timer4.Enabled = false;
                movingenemy.Location = new Point(-70,-70);
                deadplayers++;
           
                if (deadplayers == 2)
                {
                
                  
                 
                }
               

            }


            if (movingenemy.Bounds.IntersectsWith(player.Bounds)&& !isenemy1dead && player.Bounds.IntersectsWith(movingenemy.Bounds))
            {


                player.Location = new Point(-100, -100);
                timer4.Enabled = false;
                timer1.Enabled = false;
                f5.Show();
                this.Hide();
             
            }

            if (movingenemy.Left <= player.Left)
            {
                movingenemy.Location = new Point(movingenemy.Left += 10, movingenemy.Top);
                movingenemy.Image = Image.FromFile("badguy- b 3d.png");
            }
           
            else if (movingenemy.Left> player.Left)
            {
                movingenemy.Location = new Point(movingenemy.Left -= 10, movingenemy.Top);
                movingenemy.Image = Image.FromFile("badguy - d 3d2.png");
            }
            else
            {
                movingenemy.Location = new Point(movingenemy.Left -= 10, movingenemy.Top);
                movingenemy.Image = Image.FromFile("badguy - d 3d2.png");
            }
          
           if (movingenemy.Top > player.Top)
            {
                movingenemy.Location = new Point(movingenemy.Left, movingenemy.Top -= 10);
                movingenemy.Image = Image.FromFile("badguy- c 3d2.png");
            }

            else if (movingenemy.Top == player.Top)
            {
                movingenemy.Location = new Point(movingenemy.Left , movingenemy.Top -= 10);
                movingenemy.Image = Image.FromFile("badguy- c 3d2.png");
            }
            else 
            {
                movingenemy.Location = new Point(movingenemy.Left, movingenemy.Top += 10);
                movingenemy.Image = Image.FromFile("badguy - a 3d2.png");
            }















        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            player2.Visible = false;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            maneger.f.Close();
        }
    }
}
