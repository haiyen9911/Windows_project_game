namespace Game_cupid
{
    partial class Play
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.lbl_score = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ufo1 = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.pillar1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.t2 = new System.Windows.Forms.PictureBox();
            this.t3 = new System.Windows.Forms.PictureBox();
            this.t1 = new System.Windows.Forms.PictureBox();
            this.CountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.CountdownLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_score
            // 
            this.lbl_score.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.Green;
            this.lbl_score.Location = new System.Drawing.Point(12, 21);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(240, 52);
            this.lbl_score.TabIndex = 4;
            this.lbl_score.Text = "Score: 0";
            this.lbl_score.Click += new System.EventHandler(this.lbl_score_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_cupid.Properties.Resources.pillar1;
            this.pictureBox1.Location = new System.Drawing.Point(1716, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "pillar";
            // 
            // ufo1
            // 
            this.ufo1.Image = global::Game_cupid.Properties.Resources.alien6;
            this.ufo1.Location = new System.Drawing.Point(1641, 656);
            this.ufo1.Name = "ufo1";
            this.ufo1.Size = new System.Drawing.Size(125, 127);
            this.ufo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ufo1.TabIndex = 6;
            this.ufo1.TabStop = false;
            // 
            // ufo
            // 
            this.ufo.Image = global::Game_cupid.Properties.Resources.a2;
            this.ufo.Location = new System.Drawing.Point(1557, 83);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(136, 127);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ufo.TabIndex = 3;
            this.ufo.TabStop = false;
            // 
            // pillar2
            // 
            this.pillar2.Image = global::Game_cupid.Properties.Resources.pillar1;
            this.pillar2.Location = new System.Drawing.Point(1093, 336);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(173, 288);
            this.pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar2.TabIndex = 1;
            this.pillar2.TabStop = false;
            this.pillar2.Tag = "pillar";
            this.pillar2.Click += new System.EventHandler(this.pillar2_Click);
            // 
            // pillar1
            // 
            this.pillar1.Image = global::Game_cupid.Properties.Resources.pillar1;
            this.pillar1.Location = new System.Drawing.Point(385, 3);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(201, 301);
            this.pillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar1.TabIndex = 0;
            this.pillar1.TabStop = false;
            this.pillar1.Tag = "pillar";
            this.pillar1.Click += new System.EventHandler(this.pillar1_Click);
            // 
            // player
            // 
            this.player.Image = global::Game_cupid.Properties.Resources.Heart_Love_Sticker_by_cypru55_for_iOS___Android___GIPHY;
            this.player.Location = new System.Drawing.Point(12, 403);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(173, 139);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // t2
            // 
            this.t2.Image = global::Game_cupid.Properties.Resources.clouds2;
            this.t2.Location = new System.Drawing.Point(905, -10);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(292, 208);
            this.t2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t2.TabIndex = 8;
            this.t2.TabStop = false;
            // 
            // t3
            // 
            this.t3.Image = global::Game_cupid.Properties.Resources.Cloud_Transparent_Vector_Art_PNG__Cloud_Vector_Png_Transparent_Background__Cloud__Cloud_Vector__Png_PNG_Image_For_Free_Download_removebg_preview;
            this.t3.Location = new System.Drawing.Point(1600, 403);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(240, 167);
            this.t3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t3.TabIndex = 9;
            this.t3.TabStop = false;
            // 
            // t1
            // 
            this.t1.Image = global::Game_cupid.Properties.Resources.Cloud_Transparent_Vector_Art_PNG__Cloud_Vector_Png_Transparent_Background__Cloud__Cloud_Vector__Png_PNG_Image_For_Free_Download_removebg_preview;
            this.t1.Location = new System.Drawing.Point(274, 473);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(360, 301);
            this.t1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t1.TabIndex = 7;
            this.t1.TabStop = false;
            // 
            // CountdownTimer
            // 
            this.CountdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.BackColor = System.Drawing.Color.LavenderBlush;
            this.CountdownLabel.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CountdownLabel.Location = new System.Drawing.Point(685, 320);
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(106, 153);
            this.CountdownLabel.TabIndex = 11;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1864, 812);
            this.Controls.Add(this.CountdownLabel);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ufo1);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.Load += new System.EventHandler(this.Play_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pillar1;
        private System.Windows.Forms.PictureBox pillar2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ufo1;
        private System.Windows.Forms.PictureBox t1;
        private System.Windows.Forms.PictureBox t2;
        private System.Windows.Forms.PictureBox t3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer CountdownTimer;
        private System.Windows.Forms.Label CountdownLabel;
    }
}

