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
    public partial class Form4 : Form
    {
        
        Random rnd = new Random();

        int direction;
        int bulletspeed = 9;
        Timer Clock = new Timer();
        int chat = 0;
        PictureBox player1 = new PictureBox();
 

        PictureBox player2 = new PictureBox();

        PictureBox fireball = new PictureBox();
        PictureBox fireball2 = new PictureBox();
        PictureBox fireball3 = new PictureBox();
        int placeX = 0;
        int placeY = 200;
      
        int deadplayers = 0;
        int olddirection = 1;
        int fireballx = 0;
        int firebally = 0;
        bool iffired = false;
        int fireballdirection = 1;

        bool isenemy1dead = false;
        bool isenemy2dead = false;
        int fireball2x = 0;
        int fireball2y =450;
        int fireball3x = 700;
        int fireball3y = 450;
        int enemyx = 1300;
        int enemyy = 100;
        bool haskey = false;

        Form5 f5 = new Form5();


        public Form4()
        {
            InitializeComponent();


            timer1.Enabled = true;

            player1.Size = new Size(100, 100);
          
            player1.Image = Image.FromFile("‏‏pixel-a.png");
            player1.BackColor = Color.Transparent;
            fireball.Location = new Point(0, 0);
            fireball.Size = new Size(50, 50);
            fireball.Image = Image.FromFile("fireball.png");
            fireball.BackColor = Color.Transparent;
            this.Controls.Add(fireball);

            Clock.Interval = 1;
            Clock.Start();
            Clock.Tick += new EventHandler(Timer_Tick);

            player1.Location = new Point(placeX, placeY);
            this.Controls.Add(player1);
            fireball.Visible = false;
            player2.Size = new Size(100, 100);
           player2.BackColor = Color.Transparent;
            player2.Image = Image.FromFile("badguy - a 3d2.png");
            player2.Location = new Point(970, 450);
            this.Controls.Add(player2);
            fireball2.Location = new Point(0, 0);
            fireball2.Size = new Size(50, 50);
            fireball2.Image = Image.FromFile("bullet.png");
            fireball2.BackColor = Color.Transparent;
            fireball3.Location = new Point(0, 0);
            fireball3.Size = new Size(50, 50);
            fireball3.Image = Image.FromFile("bullet.png");

            fireball3.BackColor = Color.Transparent;
            this.Controls.Add(fireball3);
            this.Controls.Add(fireball2);
            pictureBox1.BringToFront();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (39):
                    {
                     
                        Clock.Enabled = true;
                        direction = 1;
                       
                        player1.Image = Image.FromFile("pixel-b 3d2.png");

                    }
                    break;
                case (38):
                    {
                     
                        Clock.Enabled = true;
                        olddirection = direction;
                        direction = 2;
                      
                        player1.Image = Image.FromFile("pixel- c 3d2.png");

                    }
                    break;
                case (37):
                    {
                       
                        olddirection = direction;
                        direction = 3;
                       
                        Clock.Enabled = true;

                        player1.Image = Image.FromFile("pixel- d 3d2.png");
                    }
                    break;
                case (40):
                    {
                      
                        olddirection = direction;
                        direction = 4;
                       
                        Clock.Enabled = true;
                        player1.Image = Image.FromFile("pixel-a 3d2.png");

                    }

                    break;


            }
        }
        public void Timer_Tick(object sender, EventArgs eArgs)
        {
            if(player1.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pictureBox3.Visible = false;
                haskey = true;
            }
            if (haskey&& player1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                timer9.Enabled = false;
                Form9 f9 = new Form9();
                player1.Location = new Point(50000, 50000);
                f9.Show();
                haskey = false;
                this.Close();

                Form3.play.Stop();
            }
            switch (direction)
            {
                case (1):
                    {
                        if (player1.Bounds.IntersectsWith(player2.Bounds) == false && player1.Bounds.IntersectsWith(label1.Bounds) == false && player1.Bounds.IntersectsWith(label2.Bounds) == false )
                        {

                            player1.Location = new Point(placeX += 6, placeY);

                        }

                        if (player1.Bounds.IntersectsWith(player2.Bounds) == true || player1.Bounds.IntersectsWith(label1.Bounds) == true || player1.Bounds.IntersectsWith(label2.Bounds) == true || placeX > 1900  ||player1.Bounds.IntersectsWith(player2.Bounds) == true || player1.Bounds.IntersectsWith(label1.Bounds) == true || player1.Bounds.IntersectsWith(label2.Bounds) == true || placeY < 0 || player1.Bounds.IntersectsWith(label3.Bounds) == true || player1.Bounds.IntersectsWith(label4.Bounds) == true || player1.Bounds.IntersectsWith(label5.Bounds) == true || player1.Bounds.IntersectsWith(label6.Bounds) == true) 
                       

                            player1.Location = new Point(placeX -= 6, placeY);



                            break;
                    }
                case (2):
                    {


                        if (player1.Bounds.IntersectsWith(player2.Bounds) == false && player1.Bounds.IntersectsWith(label1.Bounds) == false && player1.Bounds.IntersectsWith(label2.Bounds) == false)

                            player1.Location = new Point(placeX, placeY -= 6);

                        if (player1.Bounds.IntersectsWith(player2.Bounds) == true || player1.Bounds.IntersectsWith(label1.Bounds) == true || player1.Bounds.IntersectsWith(label2.Bounds) == true || placeY > 1000 ||player1.Bounds.IntersectsWith(player2.Bounds) == true || player1.Bounds.IntersectsWith(label1.Bounds) == true || player1.Bounds.IntersectsWith(label2.Bounds) == true || placeY < 0 || player1.Bounds.IntersectsWith(label3.Bounds) == true || player1.Bounds.IntersectsWith(label4.Bounds) == true || player1.Bounds.IntersectsWith(label5.Bounds) == true || player1.Bounds.IntersectsWith(label6.Bounds) == true)


                            player1.Location = new Point(placeX, placeY += 6);



                    }
                    break;
                case (3):
                    {


                        if (player1.Bounds.IntersectsWith(player2.Bounds) == false && player1.Bounds.IntersectsWith(label1.Bounds) == false && player1.Bounds.IntersectsWith(label2.Bounds) == false)

                            player1.Location = new Point(placeX -= 6, placeY);


                        if (player1.Bounds.IntersectsWith(player2.Bounds) == true || player1.Bounds.IntersectsWith(label1.Bounds) == true || player1.Bounds.IntersectsWith(label2.Bounds) == true || placeX < 0 || player1.Bounds.IntersectsWith(label3.Bounds) == true || player1.Bounds.IntersectsWith(label4.Bounds) == true || player1.Bounds.IntersectsWith(label5.Bounds) == true || player1.Bounds.IntersectsWith(label6.Bounds) == true)


                            player1.Location = new Point(placeX += 6, placeY );



                    }

                    break;
                case (4):
                    {
                        if (player1.Bounds.IntersectsWith(player2.Bounds) == false && player1.Bounds.IntersectsWith(label1.Bounds) == false && player1.Bounds.IntersectsWith(label2.Bounds) == false)

                            player1.Location = new Point(placeX, placeY += 6);

                        if (player1.Bounds.IntersectsWith(player2.Bounds) == true || player1.Bounds.IntersectsWith(label1.Bounds) == true || player1.Bounds.IntersectsWith(label2.Bounds) == true || placeY< 0 || player1.Bounds.IntersectsWith(label3.Bounds) == true || player1.Bounds.IntersectsWith(label4.Bounds) == true || player1.Bounds.IntersectsWith(label5.Bounds) == true || player1.Bounds.IntersectsWith(label6.Bounds) == true)


                            player1.Location = new Point(placeX , placeY -= 6);



                    }
                    break;
            }
        }
       

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 32)
            {
                
                Clock.Enabled = false;
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
        
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
           
            //Form2 f2 = new Form2();
            //f2.Show();
            //this.Hide();

            if (fireballdirection == 1)
            {
                if (fireball.Bounds.IntersectsWith(player2.Bounds) == false && fireball.Bounds.IntersectsWith(label2.Bounds) == false && fireball.Bounds.IntersectsWith(label1.Bounds) == false && fireballx < 1810 && iffired == true )
                {
                    iffired = true;
                    fireballx += bulletspeed;

                    fireball.Location = new Point(fireballx, firebally);

                }
                else if (fireball.Bounds.IntersectsWith(player2.Bounds)  || fireball.Bounds.IntersectsWith(label2.Bounds) == false || fireball.Bounds.IntersectsWith(label1.Bounds) == false || fireballx > 1800 || fireball.Bounds.IntersectsWith(pictureBox1.Bounds) == false || fireball.Bounds.IntersectsWith(label3.Bounds) == true || fireball.Bounds.IntersectsWith(label4.Bounds) == false || fireball.Bounds.IntersectsWith(label5.Bounds) == true || fireball.Bounds.IntersectsWith(label6.Bounds) == true)
                {
                    iffired = false;
                    fireball.Visible = false;

                }
            }

            else if (fireballdirection == 2)
            {
                if (fireball.Bounds.IntersectsWith(player2.Bounds) == false && fireball.Bounds.IntersectsWith(label2.Bounds) == false && fireball.Bounds.IntersectsWith(label1.Bounds) == false && firebally > 0 && iffired == true)
                {
                    iffired = true;
                    firebally -= bulletspeed;

                    fireball.Location = new Point(fireballx, firebally);



                }
                else if (fireball.Bounds.IntersectsWith(player2.Bounds) || fireball.Bounds.IntersectsWith(label2.Bounds) == false || fireball.Bounds.IntersectsWith(label1.Bounds) == false || firebally < 0 || fireball.Bounds.IntersectsWith(pictureBox1.Bounds) == false || fireball.Bounds.IntersectsWith(label3.Bounds) == true || fireball.Bounds.IntersectsWith(label4.Bounds) == false || fireball.Bounds.IntersectsWith(label5.Bounds) == true || fireball.Bounds.IntersectsWith(label6.Bounds) == true)
                {
                    iffired = false;
                    fireball.Visible = false;

                }
            }
            else if (fireballdirection == 3)
            {
                if (fireball.Bounds.IntersectsWith(player2.Bounds) == false && fireball.Bounds.IntersectsWith(label2.Bounds) == false && fireball.Bounds.IntersectsWith(label1.Bounds) == false && fireballx > -1 && iffired == true )
                {
                    iffired = true;
                    fireballx -= bulletspeed;

                    fireball.Location = new Point(fireballx, firebally);

                }
                else if (fireball.Bounds.IntersectsWith(player2.Bounds) || fireball.Bounds.IntersectsWith(label2.Bounds) == false || fireball.Bounds.IntersectsWith(label1.Bounds) == false || fireballx < -1 || fireball.Bounds.IntersectsWith(pictureBox1.Bounds) == false || fireball.Bounds.IntersectsWith(label3.Bounds) == true || fireball.Bounds.IntersectsWith(label4.Bounds) == false || fireball.Bounds.IntersectsWith(label5.Bounds) == true || fireball.Bounds.IntersectsWith(label6.Bounds) == true)
                {
                    iffired = false;
                    fireball.Visible = false;


                }
            }
            else if (fireballdirection == 4)
            {
                if (fireball.Bounds.IntersectsWith(player2.Bounds) == false && fireball.Bounds.IntersectsWith(label2.Bounds) == false && fireball.Bounds.IntersectsWith(label1.Bounds) == false && firebally < 1000 && iffired == true )
                {
                    iffired = true;
                    firebally += bulletspeed;

                    fireball.Location = new Point(fireballx, firebally);

                }
                else if (fireball.Bounds.IntersectsWith(player2.Bounds)  || fireball.Bounds.IntersectsWith(label2.Bounds) == false || fireball.Bounds.IntersectsWith(label1.Bounds) == false || firebally > 999|| fireball.Bounds.IntersectsWith(pictureBox1.Bounds) == false || fireball.Bounds.IntersectsWith(label3.Bounds) == true || fireball.Bounds.IntersectsWith(label4.Bounds) == true || fireball.Bounds.IntersectsWith(label5.Bounds) == true || fireball.Bounds.IntersectsWith(label6.Bounds) == true)
                {
                    iffired = false;
                    fireball.Visible = false;

                }
            }

        }

        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
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

                            timer9.Enabled = true;

                            fireball.Visible = true;
                            fireball.Location = new Point(fireballx, fireballx);


                        }
                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fireball2.Visible = true;
          
             fireball2y +=4;
            fireball2.Location = new Point(970, fireball2y);

            if (fireball2y > 1000)
                fireball2y = 470;

            if (fireball.Bounds.IntersectsWith(player2.Bounds))
            {
                fireball2.Visible = false;
                fireball2.Location = new Point(-900, -900);
                player2.Location = new Point(-800, -800);
                timer1.Enabled = false;
            }
            if (fireball2.Bounds.IntersectsWith(player1.Bounds))
            {

                this.Hide();

                f5.Show();

            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (fireball.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
               
                fireball3.Location = new Point(-900, -900);
                pictureBox1.Location = new Point(-800, -800);
                fireball3x =-600;
                fireball3.Visible = false;
                timer2.Enabled = false;

            }



            if (fireball3.Bounds.IntersectsWith(player1.Bounds))
            {

                this.Hide();
               
                    f5.Show();

            }



            fireball3.Visible = true;

            fireball3x += 6;
            fireball3.Location = new Point(fireball3x, 950);

            if (fireball3x > 1500)
                fireball3x = 700;
        }
    }
}

