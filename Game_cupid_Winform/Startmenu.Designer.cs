namespace Game_cupid
{
    partial class Startmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startmenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_luatchoi = new System.Windows.Forms.Button();
            this.btn_batdau = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_cupid.Properties.Resources.Coffee_Please;
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1414, 800);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_luatchoi
            // 
            this.btn_luatchoi.Font = new System.Drawing.Font("Showcard Gothic", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luatchoi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_luatchoi.Location = new System.Drawing.Point(157, 536);
            this.btn_luatchoi.Name = "btn_luatchoi";
            this.btn_luatchoi.Size = new System.Drawing.Size(274, 139);
            this.btn_luatchoi.TabIndex = 1;
            this.btn_luatchoi.Text = "RULES";
            this.btn_luatchoi.UseVisualStyleBackColor = true;
            this.btn_luatchoi.Click += new System.EventHandler(this.btn_luatchoi_Click);
            // 
            // btn_batdau
            // 
            this.btn_batdau.Font = new System.Drawing.Font("Showcard Gothic", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_batdau.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_batdau.Location = new System.Drawing.Point(566, 522);
            this.btn_batdau.Name = "btn_batdau";
            this.btn_batdau.Size = new System.Drawing.Size(295, 167);
            this.btn_batdau.TabIndex = 2;
            this.btn_batdau.Text = "START";
            this.btn_batdau.UseVisualStyleBackColor = true;
            this.btn_batdau.Click += new System.EventHandler(this.btn_batdau_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Showcard Gothic", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_thoat.Location = new System.Drawing.Point(1014, 536);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(232, 139);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "EXIT";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Startmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 795);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_batdau);
            this.Controls.Add(this.btn_luatchoi);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Startmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Startmenu_FormClosing);
            this.Load += new System.EventHandler(this.Startmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_luatchoi;
        private System.Windows.Forms.Button btn_batdau;
        private System.Windows.Forms.Button btn_thoat;
    }
}