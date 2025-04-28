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
    public partial class Form2 : Form
    {
        SoundPlayer s = new SoundPlayer(@"PATH TO CAMERA SHUTTER AUDIO.wav");

        public Form2()
        {
            InitializeComponent();
            s.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s.Stop();
            MainMenuForm m = new MainMenuForm();
            m.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void Form4_Click(object sender, EventArgs e)
        {
            s.Stop();
            MainMenuForm m = new MainMenuForm();
            m.Show();
            this.Hide();
            timer1.Stop();
        }
    }
}
