namespace Try69
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoins = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.trap9 = new System.Windows.Forms.PictureBox();
            this.trap8 = new System.Windows.Forms.PictureBox();
            this.enemy5 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.trap6 = new System.Windows.Forms.PictureBox();
            this.trap7 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.movingplatformUp = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.trap5 = new System.Windows.Forms.PictureBox();
            this.trap4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.trap3 = new System.Windows.Forms.PictureBox();
            this.trap1 = new System.Windows.Forms.PictureBox();
            this.trap2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.platform3 = new System.Windows.Forms.PictureBox();
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingplatformUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(735, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 50);
            this.label1.TabIndex = 21;
            this.label1.Text = "Игра пройдена!";
            this.label1.Visible = false;
            // 
            // txtCoins
            // 
            this.txtCoins.BackColor = System.Drawing.Color.Transparent;
            this.txtCoins.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoins.Location = new System.Drawing.Point(1492, 12);
            this.txtCoins.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.txtCoins.Name = "txtCoins";
            this.txtCoins.Size = new System.Drawing.Size(400, 267);
            this.txtCoins.TabIndex = 49;
            this.txtCoins.Text = "Монеты 0/3\nСоберите все монеты и идите к двери!\nИспользуйте стрелки для ходьбы\nНа" +
    "жмите пробел, чтобы прыгать\nНажмите клавишу Enter, чтобы перезапустить игру";
            this.txtCoins.Click += new System.EventHandler(this.txtCoins_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Try69.Properties.Resources._02e44c9e0f40b8b;
            this.pictureBox2.Location = new System.Drawing.Point(889, 468);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(339, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(18, 961);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1441, 32);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "trap";
            this.pictureBox1.Visible = false;
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.Transparent;
            this.coin3.Image = global::Try69.Properties.Resources.pixil_frame_0__6_;
            this.coin3.Location = new System.Drawing.Point(39, 498);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(31, 30);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.coin3.TabIndex = 32;
            this.coin3.TabStop = false;
            this.coin3.Tag = "coin";
            this.coin3.Visible = false;
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Transparent;
            this.coin2.Image = global::Try69.Properties.Resources.pixil_frame_0__6_;
            this.coin2.Location = new System.Drawing.Point(90, 328);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(31, 30);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.coin2.TabIndex = 31;
            this.coin2.TabStop = false;
            this.coin2.Tag = "coin";
            this.coin2.Visible = false;
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.Image = global::Try69.Properties.Resources.pixil_frame_0__6_;
            this.coin1.Location = new System.Drawing.Point(134, 551);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(31, 30);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.coin1.TabIndex = 30;
            this.coin1.TabStop = false;
            this.coin1.Tag = "coin";
            // 
            // trap9
            // 
            this.trap9.BackColor = System.Drawing.Color.Transparent;
            this.trap9.Image = global::Try69.Properties.Resources.pixil_frame_0__5_;
            this.trap9.Location = new System.Drawing.Point(1222, 963);
            this.trap9.Name = "trap9";
            this.trap9.Size = new System.Drawing.Size(30, 30);
            this.trap9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trap9.TabIndex = 29;
            this.trap9.TabStop = false;
            this.trap9.Tag = "trap";
            this.trap9.Visible = false;
            // 
            // trap8
            // 
            this.trap8.BackColor = System.Drawing.Color.Transparent;
            this.trap8.Image = global::Try69.Properties.Resources.pixil_frame_0__5_;
            this.trap8.Location = new System.Drawing.Point(257, 963);
            this.trap8.Name = "trap8";
            this.trap8.Size = new System.Drawing.Size(30, 30);
            this.trap8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trap8.TabIndex = 28;
            this.trap8.TabStop = false;
            this.trap8.Tag = "trap";
            this.trap8.Visible = false;
            // 
            // enemy5
            // 
            this.enemy5.BackColor = System.Drawing.Color.Transparent;
            this.enemy5.Image = global::Try69.Properties.Resources.pixil_frame_0__9_;
            this.enemy5.Location = new System.Drawing.Point(547, 963);
            this.enemy5.Name = "enemy5";
            this.enemy5.Size = new System.Drawing.Size(30, 40);
            this.enemy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy5.TabIndex = 27;
            this.enemy5.TabStop = false;
            this.enemy5.Tag = "enemy";
            this.enemy5.Visible = false;
            // 
            // enemy4
            // 
            this.enemy4.BackColor = System.Drawing.Color.Transparent;
            this.enemy4.Image = global::Try69.Properties.Resources.pixil_frame_0__9_;
            this.enemy4.Location = new System.Drawing.Point(1070, 963);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(30, 40);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy4.TabIndex = 26;
            this.enemy4.TabStop = false;
            this.enemy4.Tag = "enemy";
            this.enemy4.Visible = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::Try69.Properties.Resources._02e44c9e0f40b8b;
            this.pictureBox13.Location = new System.Drawing.Point(1345, 468);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(277, 38);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 24;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "platform";
            // 
            // trap6
            // 
            this.trap6.BackColor = System.Drawing.Color.Transparent;
            this.trap6.Image = global::Try69.Properties.Resources.pixil_frame_0__5_;
            this.trap6.Location = new System.Drawing.Point(349, 963);
            this.trap6.Name = "trap6";
            this.trap6.Size = new System.Drawing.Size(30, 30);
            this.trap6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trap6.TabIndex = 23;
            this.trap6.TabStop = false;
            this.trap6.Tag = "trap";
            this.trap6.Visible = false;
            // 
            // trap7
            // 
            this.trap7.BackColor = System.Drawing.Color.Transparent;
            this.trap7.Image = global::Try69.Properties.Resources.pixil_frame_0__5_;
            this.trap7.Location = new System.Drawing.Point(313, 963);
            this.trap7.Name = "trap7";
            this.trap7.Size = new System.Drawing.Size(30, 30);
            this.trap7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trap7.TabIndex = 22;
            this.trap7.TabStop = false;
            this.trap7.Tag = "trap";
            this.trap7.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::Try69.Properties.Resources.png_transparent_computer_icons_door_the_opening_of_doors2;
            this.pictureBox10.Location = new System.Drawing.Point(452, 395);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(60, 70);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 20;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "door";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Try69.Properties.Resources._02e44c9e0f40b8b;
            this.pictureBox8.Location = new System.Drawing.Point(1579, 816);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(113, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.Image = global::Try69.Properties.Resources.pixil_frame_0__9_;
            this.enemy3.Location = new System.Drawing.Point(1004, 963);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(30, 40);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy3.TabIndex = 18;
            this.enemy3.TabStop = false;
            this.enemy3.Tag = "enemy";
            this.enemy3.Visible = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = global::Try69.Properties.Resources.pixil_frame_0__9_;
            this.enemy2.Location = new System.Drawing.Point(782, 963);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(30, 40);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy2.TabIndex = 17;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "enemy";
            this.enemy2.Visible = false;
            // 
            // movingplatformUp
            // 
            this.movingplatformUp.BackColor = System.Drawing.Color.Transparent;
            this.movingplatformUp.Image = global::Try69.Properties.Resources._02e44c9e0f40b8b;
            this.movingplatformUp.Location = new System.Drawing.Point(1724, 714);
            this.movingplatformUp.Name = "movingplatformUp";
            this.movingplatformUp.Size = new System.Drawing.Size(168, 23);
            this.movingplatformUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movingplatformUp.TabIndex = 16;
            this.movingplatformUp.TabStop = false;
            this.movingplatformUp.Tag = "platform";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::Try69.Properties.Resources._02e44c9e0f40b8b;
            this.pictureBox9.Location = new System.Drawing.Point(1266, 822);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(277, 38);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "platform";
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = global::Try69.Properties.Resources.pixil_frame_0__9_;
            this.enemy1.Location = new System.Drawing.Point(435, 963);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(30, 40);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy1.TabIndex = 14;
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "enemy";
            this.enemy1.Visible = false;
            // 
            // trap5
            // 
            this.trap5.BackColor = System.Drawing.Color.Transparent;
            this.trap5.Image = global::Try69.Properties.Resources.pixil_frame_0__5_;
            this.trap5.Location = new System.Drawing.Point(90, 963);
            this.trap5.Name = "trap5";
            this.trap5.Size = new System.Drawing.Size(30, 30);
            this.trap5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trap5.TabIndex = 13;
            this.trap5.TabStop = false;
            this.trap5.Tag = "trap";
            this.trap5.Visible = false;
            // 
            // trap4
            // 
            this.trap4.BackColor = System.Drawing.Color.Transparent;
            this.trap4.Image = global::Try69.Properties.Resources.pixil_frame_0__5_;
            this.trap4.Location = new System.Drawing.Point(125, 963);
            this.trap4.Name = "trap4";
            this.trap4.Size = new System.Drawing.Size(30, 30);
            this.trap4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trap4.TabIndex = 12;
            this.trap4.TabStop = false;
            this.trap4.Tag = "trap";
            this.trap4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Try69.Properties.Resources._02e44c9e0f40b8b;
            this.pictureBox5.Location = new System.Drawing.Point(313, 468);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(387, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // trap3
            // 
            this.trap3.BackColor = System.Drawing.Color.Transparent;
            this.trap3.Image = global::Try69.Properties.Resources.pixil_frame_0__5_;
            this.trap3.Location = new System.Drawing.Point(158, 963);
            this.trap3.Name = "trap3";
            this.trap3.Size = new System.Drawing.Size(30, 30);
            this.trap3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trap3.TabIndex = 9;
            this.trap3.TabStop = false;
            this.trap3.Tag = "trap";
            this.trap3.Visible = false;
            // 
            // trap1
            // 
            this.trap1.BackColor = System.Drawing.Color.Transparent;
            this.trap1.Image = global::Try69.Properties.Resources.pixil_frame_0__5_;
            this.trap1.Location = new System.Drawing.Point(18, 965);
            this.trap1.Name = "trap1";
            this.trap1.Size = new System.Drawing.Size(30, 30);
            this.trap1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trap1.TabIndex = 8;
            this.trap1.TabStop = false;
            this.trap1.Tag = "trap";
            this.trap1.Visible = false;
            // 
            // trap2
            // 
            this.trap2.BackColor = System.Drawing.Color.Transparent;
            this.trap2.Image = global::Try69.Properties.Resources.pixil_frame_0__5_;
            this.trap2.Location = new System.Drawing.Point(54, 963);
            this.trap2.Name = "trap2";
            this.trap2.Size = new System.Drawing.Size(30, 30);
            this.trap2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trap2.TabIndex = 7;
            this.trap2.TabStop = false;
            this.trap2.Tag = "trap";
            this.trap2.Visible = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Try69.Properties.Resources.pixil_frame_0__8_;
            this.player.Location = new System.Drawing.Point(12, 881);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(22, 40);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // platform3
            // 
            this.platform3.BackColor = System.Drawing.Color.Transparent;
            this.platform3.Image = global::Try69.Properties.Resources._02e44c9e0f40b8b;
            this.platform3.Location = new System.Drawing.Point(562, 822);
            this.platform3.Name = "platform3";
            this.platform3.Size = new System.Drawing.Size(210, 38);
            this.platform3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform3.TabIndex = 3;
            this.platform3.TabStop = false;
            this.platform3.Tag = "platform";
            // 
            // platform2
            // 
            this.platform2.BackColor = System.Drawing.Color.Transparent;
            this.platform2.Image = global::Try69.Properties.Resources._02e44c9e0f40b8b;
            this.platform2.Location = new System.Drawing.Point(861, 822);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(277, 38);
            this.platform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2.TabIndex = 2;
            this.platform2.TabStop = false;
            this.platform2.Tag = "platform";
            // 
            // platform1
            // 
            this.platform1.BackColor = System.Drawing.Color.Transparent;
            this.platform1.Image = global::Try69.Properties.Resources._02e44c9e0f40b8b;
            this.platform1.Location = new System.Drawing.Point(231, 822);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(174, 38);
            this.platform1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1.TabIndex = 1;
            this.platform1.TabStop = false;
            this.platform1.Tag = "platform";
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Transparent;
            this.Ground.Image = global::Try69.Properties.Resources._02e44c9e0f40b8b;
            this.Ground.Location = new System.Drawing.Point(1, 927);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(253, 30);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            this.Ground.Tag = "platform";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1924, 992);
            this.Controls.Add(this.txtCoins);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.trap9);
            this.Controls.Add(this.trap8);
            this.Controls.Add(this.enemy5);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.trap6);
            this.Controls.Add(this.trap7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.movingplatformUp);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.trap5);
            this.Controls.Add(this.trap4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.trap3);
            this.Controls.Add(this.trap1);
            this.Controls.Add(this.trap2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.platform3);
            this.Controls.Add(this.platform2);
            this.Controls.Add(this.platform1);
            this.Controls.Add(this.Ground);
            this.Name = "Form1";
            this.Text = "GamePlatform";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingplatformUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trap2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox platform1;
        private System.Windows.Forms.PictureBox platform2;
        private System.Windows.Forms.PictureBox platform3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox trap2;
        private System.Windows.Forms.PictureBox trap1;
        private System.Windows.Forms.PictureBox trap3;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox trap4;
        private System.Windows.Forms.PictureBox trap5;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox movingplatformUp;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox trap7;
        private System.Windows.Forms.PictureBox trap6;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy5;
        private System.Windows.Forms.PictureBox trap8;
        private System.Windows.Forms.PictureBox trap9;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txtCoins;
    }
}

