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
    public partial class Form1 : Form
    {
        SoundPlayer s = new SoundPlayer(@"PATH TO INTRO AUDIO.wav");
        
        public Form1()
        {
            InitializeComponent();
            s.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s.Stop();
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            s.Stop();
            timer1.Stop();
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
