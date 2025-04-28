using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Media;

namespace Pixelair
{
    public partial class MemberFilterForm : Form
    {
        SoundPlayer s;
        public MemberFilterForm()
        {
            InitializeComponent();
            button17.Visible = false;
            s = new SoundPlayer(@"C:\PATH TO AUDIO\Pixelair\Media\maroon_5_memories.wav");
            s.PlayLooping();
        }

        Image file;
        Boolean opened = false;

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened = true;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (opened == true)
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "JPG(*.JPG)|*.jpg";
                if (s.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(s.FileName);
                }
            }

            else
            {
                MessageBox.Show("Please Open The Image First");
            }
        }

        void Moon()
        {
            if (opened == true)
            {
                Image i = pictureBox1.Image;
                Bitmap bi = new Bitmap(i.Width, i.Height);

                ImageAttributes ia = new ImageAttributes();

                float[][] colorMatrixElements = {
                new float[] { 0.299f, 0.299f, 0.299f, 0, 0 },
                new float[] { 0.587f, 0.587f, 0.587f, 0, 0 },
                new float[] { 0.114f, 0.114f, 0.114f, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 0, 0, 0, 0, 0 }
                };

                ColorMatrix cm = new ColorMatrix(colorMatrixElements);

                ia.SetColorMatrix(cm);

                Graphics g = Graphics.FromImage(bi);
                g.DrawImage(i, new Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bi;

            }

            else
            {
                MessageBox.Show("Please Open The Image First");
            }
        }

        void Forest()
        {
            if (opened == true)
            {
                Image i = pictureBox1.Image;
                Bitmap bi = new Bitmap(i.Width, i.Height);

                ImageAttributes ia = new ImageAttributes();

                float[][] colorMatrixElements = {
                new float[] { 0.299f, 0.114f, 0.299f, 0, 0 },
                new float[] { 0.487f, 0.587f, 0.478f, 0, 0 },
                new float[] { 0.114f, 0.299f, 0.114f, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 0, 0, 0, 0, 0 }
                };

                ColorMatrix cm = new ColorMatrix(colorMatrixElements);

                ia.SetColorMatrix(cm);

                Graphics g = Graphics.FromImage(bi);
                g.DrawImage(i, new Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bi;

            }

            else
            {
                MessageBox.Show("Please Open The Image First");
            }
        }

        void Microsoft()
        {
            if (opened == true)
            {
                Image i = pictureBox1.Image;
                Bitmap bi = new Bitmap(i.Width, i.Height);

                ImageAttributes ia = new ImageAttributes();

                float[][] colorMatrixElements = {
                new float[] {2,  0,  0,  0, 0},        // red scaling factor of 2
                new float[] {0,  1,  0,  0, 0},        // green scaling factor of 1
                new float[] {0,  0,  1,  0, 0},        // blue scaling factor of 1
                new float[] {0,  0,  0,  1, 0},        // alpha scaling factor of 1
                new float[] {.2f, .2f, .2f, 0, 1}};

                ColorMatrix cm = new ColorMatrix(colorMatrixElements);

                ia.SetColorMatrix(cm);

                Graphics g = Graphics.FromImage(bi);
                g.DrawImage(i, new Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bi;

            }

            else
            {
                MessageBox.Show("Please Open The Image First");
            }
        }

        void Rust()
        {
            if (opened == true)
            {
                Image i = pictureBox1.Image;
                Bitmap bi = new Bitmap(i.Width, i.Height);

                ImageAttributes ia = new ImageAttributes();
                float[][] colorMatrixElements =  {
                    new float[] { .393f, .349f, .272f, 0, 0 },
                    new float[] { .769f, .686f, .534f, 0, 0 },
                    new float[] { .189f, .168f, .131f, 0, 0 },
                    new float[] { 0, 0, 0, 1, 0 },
                    new float[] { 0, 0, 0, 0, 1 }
                };

                ColorMatrix cm = new ColorMatrix(colorMatrixElements);

                ia.SetColorMatrix(cm);

                Graphics g = Graphics.FromImage(bi);
                g.DrawImage(i, new Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bi;

            }

            else
            {
                MessageBox.Show("Please Open The Image First");
            }
        }

        void Blue()
        {
            if (opened == true)
            {
                Image i = pictureBox1.Image;
                Bitmap bi = new Bitmap(i.Width, i.Height);

                ImageAttributes ia = new ImageAttributes();
                float[][] colorMatrixElements =  {
                    new float[]{1,0,0,0,0},
                    new float[]{0,1,0,0,0},
                    new float[]{0,0,1,0,0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 1, 0, 1}
                };

                ColorMatrix cm = new ColorMatrix(colorMatrixElements);

                ia.SetColorMatrix(cm);

                Graphics g = Graphics.FromImage(bi);
                g.DrawImage(i, new Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bi;

            }

            else
            {
                MessageBox.Show("Please Open The Image First");
            }
        }

        void Lahore()
        {
            if (opened == true)
            {
                Image i = pictureBox1.Image;
                Bitmap bi = new Bitmap(i.Width, i.Height);

                ImageAttributes ia = new ImageAttributes();
                float[][] colorMatrixElements = {
                new float[] {1.438f, -0.062f, -0.062f, 0, 0},        // red scaling factor of 2
                new float[] {-0.122f, 1.378f, -0.122f, 0, 0},        // green scaling factor of 1
                new float[] {-0.016f, -0.016f, 1.483f, 0, 0},        // blue scaling factor of 1
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 0, 0, 0, 0, 0 }};

                ColorMatrix cm = new ColorMatrix(colorMatrixElements);

                ia.SetColorMatrix(cm);

                Graphics g = Graphics.FromImage(bi);
                g.DrawImage(i, new Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bi;

            }

            else
            {
                MessageBox.Show("Please Open The Image First");
            }
        }

        void Invert()
        {
            if (opened == true)
            {
                Image i = pictureBox1.Image;
                Bitmap bi = new Bitmap(i.Width, i.Height);

                ImageAttributes ia = new ImageAttributes();
                
                float[][] colorMatrixElements = {
                new float[] {-1, 0, 0, 0, 0},        // red scaling factor of 2
                new float[] {0, -1, 0, 0, 0},        // green scaling factor of 1
                new float[] {0, 0, -1, 0, 0},        // blue scaling factor of 1
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 1, 1, 1, 0, 1 }};

                ColorMatrix cm = new ColorMatrix(colorMatrixElements);

                ia.SetColorMatrix(cm);

                Graphics g = Graphics.FromImage(bi);
                g.DrawImage(i, new Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bi;

            }

            else
            {
                MessageBox.Show("Please Open The Image First");
            }
        }

        void Mystique()
        {
            if (opened == true)
            {
                Image i = pictureBox1.Image;
                Bitmap bi = new Bitmap(i.Width, i.Height);

                ImageAttributes ia = new ImageAttributes();

                float[][] colorMatrixElements = {
                new float[] {0, 0, 1, 0, 0},        // red scaling factor of 2
                new float[] {0, 1, 0, 0, 0},        // green scaling factor of 1
                new float[] {1, 0, 0, 0, 0},        // blue scaling factor of 1
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 0, 0, 0, 0, 0 }};

                ColorMatrix cm = new ColorMatrix(colorMatrixElements);

                ia.SetColorMatrix(cm);

                Graphics g = Graphics.FromImage(bi);
                g.DrawImage(i, new Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bi;

            }

            else
            {
                MessageBox.Show("Please Open The Image First");
            }
        }

        void OldSchool()
        {
            if (opened == true)
            {
                Image i = pictureBox1.Image;
                Bitmap bi = new Bitmap(i.Width, i.Height);

                ImageAttributes ia = new ImageAttributes();

                float[][] colorMatrixElements = {
                new float[] { 0.5f, 0.5f, 0.5f, 0, 0 },
                new float[] { 0.5f, 0.5f, 0.5f, 0, 0 },
                new float[] { 0.5f, 0.5f, 0.5f, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { -0.1f, -0.1f, -0.1f, 0, 1 }
                };

                ColorMatrix cm = new ColorMatrix(colorMatrixElements);

                ia.SetColorMatrix(cm);

                Graphics g = Graphics.FromImage(bi);
                g.DrawImage(i, new Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bi;

            }

            else
            {
                MessageBox.Show("Please Open The Image First");
            }
        }

        void Brightness()
        {
            try
            {

                if (opened == true)
                {
                    Image i = pictureBox1.Image;

                    float fb = trackBar1.Value * 0.01f;

                    Bitmap bi = new Bitmap(i.Width, i.Height);

                    ImageAttributes ia = new ImageAttributes();

                    float[][] colorMatrixElements = {
                new float[] { 1, 0, 0, 0, 0 },
                new float[] { 0, 1, 0, 0, 0 },
                new float[] { 0, 0, 1, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { fb, fb, fb, 0, 1 }
                };

                    ColorMatrix cm = new ColorMatrix(colorMatrixElements);

                    ia.SetColorMatrix(cm);

                    Graphics g = Graphics.FromImage(bi);
                    g.DrawImage(i, new Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, ia);

                    g.Dispose();
                    pictureBox1.Image = bi;

                }

                else
                {
                    MessageBox.Show("Please Open The Image First");
                }
            }

            catch(Exception x)
            {
                s.Stop();
                MessageBox.Show(x.Message + " Application will Restart");
                MemberFilterForm mf = new MemberFilterForm();
                mf.Show();
                this.Hide();
            }
           
        }

        void Saturation()
        {
            try
            {
                if (opened == true)
                {
                    Image i = pictureBox1.Image;


                    Bitmap bi = new Bitmap(i.Width, i.Height);

                    ImageAttributes ia = new ImageAttributes();


                    float[][] colorMatrixElements = {
                new float[] { 1,0,(trackBar2.Value), 0, 0, 0, 0 },
                new float[] { 0, 1, 0, 0, 0 },
                new float[] { 0, 0, 1, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 0, 0, 0, 0, 1 }
                };

                    ColorMatrix cm = new ColorMatrix(colorMatrixElements);

                    ia.SetColorMatrix(cm);

                    Graphics g = Graphics.FromImage(bi);
                    g.DrawImage(i, new Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, ia);

                    g.Dispose();
                    pictureBox1.Image = bi;

                }

                else
                {
                    MessageBox.Show("Please Open The Image First");
                }
            }

            catch (Exception x)
            {
                s.Stop();
                MessageBox.Show(x.Message + " Application will Restart");
                MemberFilterForm mf = new MemberFilterForm();
                mf.Show();
                this.Hide();
            }
        }

        void Contrast()
        {
            try
            {
                if (opened == true)
                {
                    Image i = pictureBox1.Image;


                    Bitmap bi = new Bitmap(i.Width, i.Height);

                    ImageAttributes ia = new ImageAttributes();

                    float c = 1.2f * trackBar3.Value;
                    double tt = (1.0 - c) / 2.0;
                    float t = Convert.ToSingle(tt);
                    float[][] colorMatrixElements = {
                new float[] { c,0, 0, 0, 0 },
                new float[] { 0, c, 0, 0, 0 },
                new float[] { 0, 0, c, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { t, t, t, 0, 1 }
                };

                    ColorMatrix cm = new ColorMatrix(colorMatrixElements);

                    ia.SetColorMatrix(cm);

                    Graphics g = Graphics.FromImage(bi);
                    g.DrawImage(i, new Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, ia);

                    g.Dispose();
                    pictureBox1.Image = bi;

                }

                else
                {
                    MessageBox.Show("Please Open The Image First");
                }
            }

            catch (Exception x)
            {
                s.Stop();
                MessageBox.Show(x.Message + " Application will Restart");
                MemberFilterForm mf = new MemberFilterForm();
                mf.Show();
                this.Hide();
            }
        }



        void reload()
        {
            file = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = file;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MemberEntry me = new MemberEntry();
            me.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MainMenuForm mf = new MainMenuForm();
            mf.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (opened == true)
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = img;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (opened == true)
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Image = img;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reload();
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reload();
            Moon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reload();
            OldSchool();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reload();
            Rust();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reload();
            Mystique();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reload();
            Microsoft();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reload();
            Invert();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reload();
            Moon();
            Forest();
            Forest();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reload();
            Microsoft();
            Moon();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reload();
            Lahore();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if(trackBar1.Value < 0)
            {
                Brightness();
            }
            
            else if(trackBar1.Value > 0)
            {
                Brightness();
            }
            
            else
            {
                if (opened == true)
                {
                    reload();
                }
            }
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar2.Value < 0)
            {
                Saturation();
            }

            else if (trackBar2.Value > 0)
            {
                Saturation();
            }

            else
            {
                if (opened == true)
                {
                    reload();
                }
            }
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar3.Value < 0)
            {
                Contrast();
            }

            else if (trackBar3.Value > 0)
            {
                Contrast();
            }

            else
            {
                if (opened == true)
                {
                    reload();
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            s.Stop();
            button18.Visible = false;
            button17.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            s.Play();
            button17.Visible = false;
            button18.Visible = true;
        }
    }
}
