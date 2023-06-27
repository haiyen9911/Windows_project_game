using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Game_cupid
{
    public partial class Play : Form
    {
        bool goUp, goDown, shot, gameOver; //lưu trạng thái di chuyển của người chơi, việc bắn đạn và trạng thái kết thúc trò chơi.

        int score = 0;
        int speed = 5;
        int UFOspeed = 7;
        int UFO1speed = 9;

        Random rand = new Random(); //sử dụng để tạo số ngẫu nhiên

        int playerSpeed = 7;
        int index = 0;
        bool pause = false;
        public Play()
        {
            InitializeComponent();
        }

       

       
        private void GameTimer_Tick(object sender, EventArgs e)
        {

            lbl_score.Text = "Score: " + score; 
            if (goUp == true && player.Top > 0)
            {
                player.Top -= playerSpeed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += playerSpeed;
            }

            ufo.Left -= UFOspeed; //di chuyển chướng ngại vật sang trái với tốc độ

            if (ufo.Left <= 0) //kiểm tra xem chướng ngại vật đã đi qua giới hạn bên trái chưa
            {
                ChangeUFO(); // gọi hàm để đặt lại vị trí mới cho chướng ngại vật
            }
            ufo1.Left -= UFO1speed;

            if (ufo1.Left + ufo1.Width <= 0)
            {
                ChangeUFO1();
            }

            Random r = new Random();

            foreach (Control x in this.Controls) //kiểm tra va chạm giữa ng chơi và các chướng ngại vật
            {
                if (x is PictureBox && (string)x.Tag == "pillar")
                {
                    x.Left -= speed;


                    if (x.Left < -200)
                    {
                        x.Left = 1000;
                        x.Height = r.Next(80, 200); //thay đổi chiều cao của các cột khi xuất hiện bằng một số ngẫu nhiên trong khoảng
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameOver();
                    }

                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Left += 25;

                    if (x.Left > 900)
                    {
                        RemoveBullet(((PictureBox)x)); //gọi hàm để xóa đối tượng đạn
                    }


                    if (ufo.Bounds.IntersectsWith(x.Bounds)) //kiểm tra va chạm giữa đạn với chướng ngại vật
                    {
                        RemoveBullet(((PictureBox)x));
                        score += 1;  //tăng điểm
                        ChangeUFO(); //gọi lại chướng ngại vật mới
                    }

                    if (ufo1.Bounds.IntersectsWith(x.Bounds))
                    {
                        RemoveBullet(((PictureBox)x));
                        score += 1;
                        ChangeUFO1();
                    }

                }

            }

            //nếu có va chạm giữa ng chơi và chướng ngại vật thì kết thúc trò chơi
            if (player.Bounds.IntersectsWith(ufo.Bounds) || player.Bounds.IntersectsWith(ufo1.Bounds))
            {
                GameOver();
                
            }
            //nếu điểm của ng chơi hơn 10 thì tăng tốc độ ng chơi và chướng ngại vật lên
            if (score > 10)
            {
                speed = 10;
                UFOspeed = 12;
            }
            
        }
        private void KeyIsDown(object sender, KeyEventArgs e) //sự kiện khi một phím đc nhấn xuống
        {
            if (e.KeyCode == Keys.Up) //khi ng chơi nhấn phím lên thì gán gtri true cho biến goUp
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.Space && shot == false) //Điều kiện đảm bảo người chơi chỉ có thể bắn khi đã hoàn thành lần bắn trước đó.
            {
                MakeBullet(); //gọi hàm tạo đạn
                shot = true;
            }
            if (e.KeyCode == Keys.Escape)
            {

                if (pause == true)
                {
                    pause = false;
                }
                else
                {
                    pause = true;
                }
                if (pause == true)
                {
                    GameTimer.Stop();
                    timer1.Stop();
                    DialogResult r = MessageBox.Show("Đã tạm dừng! Bạn có muốn TIẾP TỤC [YES] hoặc THOÁT [NO]", "Tạm dừng", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        GameTimer.Start();
                        timer1.Start();
                    }
                    else if (r == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e) //sự kiện khi một phím được nhả
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (shot == true)
            {
                shot = false;
            }

            

        }

        

        private void GameOver()
        {
            GameTimer.Stop();
            lbl_score.Text = "Score: " + score ;
            DialogResult r = MessageBox.Show("Game over\nScore:" + score);
            if (r == DialogResult.OK)
            {
                this.Close();
            }
            gameOver = true;
            
            
        }

        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }

        private void MakeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Maroon;
            bullet.Height = 5;
            bullet.Width = 10;

            bullet.Left = player.Left + player.Width; //Đặt vị trí bên trái của viên đạn bằng vị trí bên phải của người chơi (player) để đặt viên đạn bên phải người chơi.
            bullet.Top = player.Top + player.Height / 2; //Đặt vị trí đỉnh của viên đạn ở giữa chiều cao của người chơi.

            bullet.Tag = "bullet"; //đặt tag của viên đạn là Bullet

            this.Controls.Add(bullet);

        }

        private void ChangeUFO()
        {


            if (index > 3)
            {
                index = 1;
            }
            else
            {
                index += 1;
            }


            switch (index) //sử dụng switch để xác đinh hình ảnh của chướng ngại vật dựa trên gtri của index
            {
                case 1:
                    ufo.Image = Properties.Resources.alien2;
                    break;
                case 2:
                    ufo.Image = Properties.Resources.alien6;
                    break;
                case 3:
                    ufo.Image = Properties.Resources.a1;
                    break;
                case 4:
                    ufo.Image = Properties.Resources.a2;
                    break;
            }

            

            ufo.Left = 1000;

            ufo.Top = rand.Next(20, this.ClientSize.Height - ufo.Height);

           

        }

        private void ChangeUFO1()
        {


            if (index > 3)
            {
                index = 1;
            }
            else
            {
                index += 1;
            }

           

            switch (index)
            {


                case 1:
                    ufo1.Image = Properties.Resources.alien6;
                    break;
                case 2:
                    ufo1.Image = Properties.Resources.a1;
                    break;
                case 3:
                    ufo1.Image = Properties.Resources.a2;
                    break;
            }

          

            ufo1.Left = 1000;

            ufo1.Top = rand.Next(20, this.ClientSize.Height - ufo1.Height);

        }

       

       

        private void pillar1_Click(object sender, EventArgs e)
        {
            
        }

        private void player_Click(object sender, EventArgs e)
        {
            

        }

        private void lbl_score_Click(object sender, EventArgs e)
        {

        }

        private int countdown = 6; 
        private void Play_Load(object sender, EventArgs e)
        {
            
            Timer countdownTimer = new Timer(); //khởi tạo đối tương Timer với tên countdownTimer
            countdownTimer.Interval = 1000; //đặt khoảng tgian là 1000ms(1s)
            countdownTimer.Tick += new EventHandler(CountdownTimer_Tick);
            countdownTimer.Start();

           

        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            countdown--; 
            if (countdown == 0)
            {
                ((Timer)sender).Stop(); 
                CountdownLabel.Visible = false; //ẩn label đếm ngược đi
                GameTimer.Enabled = true; //kích hoạt GameTimer
                timer1.Enabled = true;
                return;
            }
            CountdownLabel.Text = countdown.ToString(); //cập nhật hiển thị là gtri hiện tại của biến countdown dưới dang chuoi
        }

        private void pillar2_Click(object sender, EventArgs e)
        {
            

        }

        private Timer startLabelTimer;


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            movetime(7);

        }
        void movetime(int speed) 
        {
            if (t1.Left >= 0)
            { t1.Left += -speed; }
            else { t1.Left = 1020; }

            if (t2.Left >= 0)
            { t2.Left += -speed; }
            else { t2.Left = 1020; } 

            if (t3.Left >= 0)
            { t3.Left += -speed; }
            else { t3.Left = 1020; }
        }


    }
}
