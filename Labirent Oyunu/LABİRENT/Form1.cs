using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABİRENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hiz = 5;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                yildiz.Left -= hiz;
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                yildiz.Top -= hiz;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                yildiz.Left += hiz;
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                yildiz.Top += hiz;
            }
            if (yildiz.Top <= label4.Bottom)
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }
               
                   
                    
            }
            if (yildiz.Left <= label26.Right)
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }
            }
            if (yildiz.Bottom >= label27.Top)
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }
                
            }
            if (yildiz.Right >= label1.Left)
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }
            }
            if (yildiz.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
            if (yildiz.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
            if (yildiz.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }
            }
            if (yildiz.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
            if (yildiz.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
            if (yildiz.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
            if (yildiz.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
            if (yildiz.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
            if (yildiz.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
            if (yildiz.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
            if (yildiz.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
            if (yildiz.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
            if (yildiz.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                MessageBox.Show("KAYBETTİNİZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
            if (yildiz.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                MessageBox.Show("TEBRİKLER KAZANDINIZ");

                if (MessageBox.Show("Tekrar oynamak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                {
                    Application.Exit();
                }

            }
         }

     
    }
}
