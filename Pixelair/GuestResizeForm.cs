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

namespace Pixelair
{
    public partial class GuestResizeForm : Form
    {
        SoundPlayer s;
        public GuestResizeForm()
        {
            InitializeComponent();
            button8.Visible = false;
            s = new SoundPlayer(@"PATH TO AUDIO\Pixelair\Media\beth_thornton_something_you_don_t_know.wav");
            s.PlayLooping();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s.Stop();
            Guest_Entry ge = new Guest_Entry();
            ge.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s.Stop();
            MainMenuForm mf = new MainMenuForm();
            mf.Show();
            this.Hide();
        }

        Image file;
        Boolean opened = false;
        Boolean opened1 = false;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened1 = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (opened == true)
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "JPG(*.JPG)|*.jpg";
                if (s.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image.Save(s.FileName);
                }
            }

            else
            {
                MessageBox.Show("Please Open The Image First");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (opened1 == true)
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Enter new dimensions in order to resize, Press OK to contnue");
                }

                else
                {
                    Bitmap bmp = new Bitmap(pictureBox1.Image, Int16.Parse(textBox1.Text), Int16.Parse(textBox2.Text));
                    pictureBox2.Image = bmp;
                    opened = true;
                }
            }

            else
            {
                MessageBox.Show("Open An Image First");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (opened1 == true)
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = img;
            }
            else
            {
                MessageBox.Show("Open An Image First");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (opened1 == true)
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Image = img;
            }
            else
            {
                MessageBox.Show("Open An Image First");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            s.Stop();
            button9.Visible = false;
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            s.PlayLooping();
            button8.Visible = false;
            button9.Visible = true;
        }
    }
}
