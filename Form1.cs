using System;
using System.Windows.Forms;

namespace Try69
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, jumping;

        int jumpSpeed = 12;
        int force= 16 ;
        int playerSpeed = 10;
        int enemyOneSpeed = 9;
        int enemyTwoSpeed = 6;
        int enemyThreeSpeed = -6;
        int enemyFourSpeed = -6;
        int enemyFifthSpeed = -3;
        int coinsCount = 0;
        bool spawnEnemyFlag = true;

        int verticalSpeed = 3;
        public Form1()
        {
            InitializeComponent();
        }
        #region Движение персонажа + кнопки, взаимодействие по тегам
        private void MainGameTimer(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;
            
            if (goLeft == true)
            {
                player.Left -= playerSpeed;
            }

            if (goRight == true)
            {
                player.Left += playerSpeed;
            }

            if (jumping && force < 0)
            {
                jumping = false;
            }
            
            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 15;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag != null) // Работа с тегами, взаимодействие
                {

                    if (x.Tag.ToString() == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 16;
                            player.Top = x.Top - player.Height;
                        }
                       x.BringToFront();
                    }

                    if (x.Tag.ToString() == "trap")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            label1.Visible = true;
                            label1.Text = "Ты умер!";
                        }
                    }

                    if (x.Tag.ToString() == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            label1.Visible = true;
                            label1.Text = "Ты умер!";
                        }
                    }

                    if (x.Tag.ToString() == "door" && coinsCount == 3)
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            label1.Visible = true;
                            label1.Text = "Игра завершена!";
                        }
                    }

                    if (x.Tag.ToString() == "coin")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.Controls.Remove(x);
                            coinsCount += 1;
                            txtCoins.Text = "Монеты " + coinsCount + "/3";
                        }
                    }

                    if (coinsCount == 1)
                    {
                        if (x.Tag.ToString() == "trap")
                            x.Visible = true;
                        SpawnTraps();
                        coin2.Visible = true;
                        coin2.Left = 195;
                        coin2.Top = 395;
                    }

                    if (coinsCount == 2 && spawnEnemyFlag)
                    {
                        SpawnEnemies();
                        coin3.Visible = true;
                        coin3.Left = 78;
                        coin3.Top = 468;
                        spawnEnemyFlag = false;
                    }
                }
                
            }
            EnemySpeed();
        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
                
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Enter)
                RestartGame();
        }
        #endregion
        private void RestartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            label1.Visible = false;

            if (coinsCount == 1)
            {
                SpawnTraps();
                coin2.Visible = true;
            }

            if (coinsCount == 2 && spawnEnemyFlag)
            {
                SpawnEnemies();
                coin3.Visible = true;
                spawnEnemyFlag = false;
            }
            player.Left = 12;
            player.Top = 540;
            gameTimer.Start();
        }
        #region SpawnAllProperties
        public void SpawnTraps()
        {
            trap1.Left = 279;
            trap1.Top = 796;
            trap1.Visible = true;
            trap2.Left = 305;
            trap2.Top = 796;
            trap2.Visible = true;
            trap3.Left = 621;
            trap3.Top = 793;
            trap3.Visible = true;
            trap4.Left = 653;
            trap4.Top = 793;
            trap4.Visible = true;
            trap5.Left = 688;
            trap5.Top = 793;
            trap5.Visible = true;
            trap6.Left = 1569;
            trap6.Top = 440;
            trap6.Visible = true;
            trap7.Left = 1467;
            trap7.Top = 440;
            trap7.Visible = true;
            trap8.Left = 1374;
            trap8.Top = 440;
            trap8.Visible = true;
            trap9.Left = 585;
            trap9.Top = 440;
            trap9.Visible = true;
        }

        public void SpawnEnemies()
        {
            enemy1.Left = 861;
            enemy1.Top = 793;
            enemy1.Visible = true;
            enemy2.Left = 1266;
            enemy2.Top = 793;
            enemy2.Visible = true;
            enemy3.Left = 1513;
            enemy3.Top = 793;
            enemy3.Visible = true;
            enemy4.Left = 1082;
            enemy4.Top = 440;
            enemy4.Visible = true;
            enemy5.Left = 1082;
            enemy5.Top = 440;
            enemy5.Visible = true;
        }
        #endregion
        public void EnemySpeed() //Скорость врагов(В общем ходьба вправа и влево)
        {
            enemy1.Left -= enemyOneSpeed;
            if (enemy1.Left < platform2.Left || enemy1.Left + enemy1.Width > platform2.Left + platform2.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            enemy2.Left -= enemyTwoSpeed;
            if (enemy2.Left < pictureBox9.Left || enemy2.Left + enemy2.Width > pictureBox9.Left + pictureBox9.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            enemy3.Left -= enemyThreeSpeed;
            if (enemy3.Left < pictureBox9.Left || enemy3.Left + enemy3.Width > pictureBox9.Left + pictureBox9.Width)
            {
                enemyThreeSpeed = -enemyThreeSpeed;
            }
            enemy4.Left -= enemyFourSpeed;
            if (enemy4.Left < pictureBox2.Left || enemy4.Left + enemy4.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyFourSpeed = -enemyFourSpeed;
            }
            enemy5.Left -= enemyFifthSpeed;
            if (enemy5.Left < pictureBox2.Left || enemy5.Left + enemy5.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyFifthSpeed = -enemyFifthSpeed;
            }

            movingplatformUp.Top += verticalSpeed;
            if (movingplatformUp.Top < 460 || movingplatformUp.Top > 820)
            {
                verticalSpeed = -verticalSpeed;
            }
        }
        private void txtCoins_Click(object sender, EventArgs e) { }
    }
}
