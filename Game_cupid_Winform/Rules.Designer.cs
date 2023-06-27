namespace Game_cupid
{
    partial class RuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.t1 = new System.Windows.Forms.PictureBox();
            this.t2 = new System.Windows.Forms.PictureBox();
            this.t3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(885, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Người chơi dùng phím mũi tên để di chuyển";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(885, 68);
            this.label3.TabIndex = 4;
            this.label3.Text = "Người chơi dùng phím SPACE để bắn\r\n";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Lavender;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(885, 69);
            this.label5.TabIndex = 7;
            this.label5.Text = "Người chơi dùng phím ESC để tạm dừng game\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1241, 159);
            this.label2.TabIndex = 9;
            this.label2.Text = "Người chơi điều khiển Cupid tránh các cây cột và các chướng ngại vật đi tới. Nếu " +
    "đụng phải trò chơi sẽ kết thúc ngay lập tức.\r\nDùng đạn để bắn các chướng ngại vậ" +
    "t để ghi điểm.\r\n\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(597, 739);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 77);
            this.button1.TabIndex = 10;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Game_cupid.Properties.Resources.dowload;
            this.pictureBox4.Location = new System.Drawing.Point(1024, 392);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 109);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Game_cupid.Properties.Resources.skill;
            this.pictureBox3.Location = new System.Drawing.Point(1024, 257);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(274, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Game_cupid.Properties.Resources.key1;
            this.pictureBox2.Location = new System.Drawing.Point(1024, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // t1
            // 
            this.t1.Image = global::Game_cupid.Properties.Resources.Cloud_Transparent_Vector_Art_PNG__Cloud_Vector_Png_Transparent_Background__Cloud__Cloud_Vector__Png_PNG_Image_For_Free_Download_removebg_preview;
            this.t1.Location = new System.Drawing.Point(12, 96);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(247, 204);
            this.t1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t1.TabIndex = 11;
            this.t1.TabStop = false;
            // 
            // t2
            // 
            this.t2.Image = global::Game_cupid.Properties.Resources.clouds2;
            this.t2.Location = new System.Drawing.Point(474, 572);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(414, 280);
            this.t2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t2.TabIndex = 12;
            this.t2.TabStop = false;
            // 
            // t3
            // 
            this.t3.Image = global::Game_cupid.Properties.Resources.Cloud_Transparent_Vector_Art_PNG__Cloud_Vector_Png_Transparent_Background__Cloud__Cloud_Vector__Png_PNG_Image_For_Free_Download_removebg_preview;
            this.t3.Location = new System.Drawing.Point(1237, 283);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(192, 159);
            this.t3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t3.TabIndex = 13;
            this.t3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1441, 874);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rules";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox t1;
        private System.Windows.Forms.PictureBox t2;
        private System.Windows.Forms.PictureBox t3;
        private System.Windows.Forms.Timer timer1;
    }
}