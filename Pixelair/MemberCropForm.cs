using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;

namespace Pixelair
{
    public partial class MemberCropForm : Form
    {
        SoundPlayer s;
        public MemberCropForm()
        {
            InitializeComponent();
            button10.Visible = false;
            s = new SoundPlayer(@"PATH TO AUDIO\Pixelair\Media\Beth Thornton - I Wish You World (320  kbps).wav");
            s.PlayLooping();
        }

        Image file;
        Boolean opened = false;
        Boolean opened1 = false;

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened1 = true;
                

            }
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            s.Stop();
            MemberEntry me = new MemberEntry();
            me.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s.Stop();
            MainMenuForm mf = new MainMenuForm();
            mf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            
            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            Controls.Add(pictureBox1);
            MessageBox.Show("Click on the Picture Box and Drag in order to Crop. Press OK to continue");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{
                if (opened1 == true)
                {
                    //label1.Text = "Dimensions :" + rectW + "," + rectH;
                    Cursor = Cursors.Default;
                    //Now we will draw the cropped image into pictureBox2
                    Bitmap bmp2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.DrawToBitmap(bmp2, pictureBox1.ClientRectangle);

                    Bitmap crpImg = new Bitmap(rectW, rectH);

                    for (int i = 0; i < rectW; i++)
                    {
                        for (int y = 0; y < rectH; y++)
                        {
                            Color pxlclr = bmp2.GetPixel(crpX + i, crpY + y);
                            crpImg.SetPixel(i, y, pxlclr);
                        }
                    }

                    pictureBox2.Image = (Image)crpImg;
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    opened = true;
                }

                else
                {
                    MessageBox.Show("Open Image to Crop. Press OK to continue");
                }
            }

            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        int crpX, crpY, rectW, rectH;
        Pen crpPen = new Pen(Color.Gray, 3);

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

        private void button8_Click(object sender, EventArgs e)
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
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            s.PlayLooping();
            button10.Visible = false;
            button9.Visible = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Refresh();
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = DashStyle.DashDotDot;
                
                crpX = e.X;
                crpY = e.Y;

            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
