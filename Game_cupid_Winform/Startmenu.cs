using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_cupid
{
    public partial class Startmenu : Form
    {
        public Startmenu()
        {
            InitializeComponent();
        }

        private void Startmenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_batdau_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play play = new Play();
            play.ShowDialog();
            this.Show();
        }

        private void Startmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_luatchoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            RuleForm rule = new RuleForm();
            rule.ShowDialog();
            this.Show();
        }
    }
}
