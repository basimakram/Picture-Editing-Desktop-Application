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
    public partial class MainMenuForm : Form
    {
        SoundPlayer s;
        public MainMenuForm()
        {
            InitializeComponent();
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 3);

            if (randomNumber == 1)
            {
                s = new SoundPlayer(@"PATH TO AUDIO\Pixelair\Media\Beth Thornton - I Wish You World.wav");
                s.PlayLooping();
            }

            else if (randomNumber == 2)
            {
                s = new SoundPlayer(@"PATH TO AUDI\Pixelair\Media\Katelyn-Tarver-You-Don-t-Know-.wav");
                s.PlayLooping();
            }

            else if (randomNumber == 3)
            {
                s = new SoundPlayer(@"PATH TO AUDIO\Pixelair\Media\maroon_5_memories.wav");
                s.PlayLooping();
            }

            else
            {
                s = new SoundPlayer(@"PATH TO AUDIO\Pixelair\Media\beth_thornton_something_you_don_t_know.wav");
                s.PlayLooping();
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
           panel3.Height = button1.Height;
           panel3.Top = button1.Top;
           myfirstusercontrol1.Visible = false;
           mysecondusercontrol1.Visible = false;
           mythirdusercontrol1.Visible = false;
        }  

        private void button1_Click(object sender, EventArgs e)
        {
           panel3.Height = button1.Height;
           panel3.Top = button1.Top;
           myfirstusercontrol1.Visible = false;
           mysecondusercontrol1.Visible = false;
           mythirdusercontrol1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           panel3.Height = button2.Height;
           panel3.Top = button2.Top;
           myfirstusercontrol1.Visible = true;
           mysecondusercontrol1.Visible = false;
           mythirdusercontrol1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           panel3.Height = button3.Height;
           panel3.Top = button3.Top;
           mysecondusercontrol1.Visible = true;
           myfirstusercontrol1.Visible = false;
           mythirdusercontrol1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           panel3.Height = button4.Height;
           panel3.Top = button4.Top;
           mythirdusercontrol1.Visible = true;
           myfirstusercontrol1.Visible = false;
           mysecondusercontrol1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pixelair is a picture editing app. Click on Main Menu button to proceed further","Help");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            s.Stop();
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            s.Stop();
            SignupForm sf = new SignupForm();
            sf.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            s.Stop();
            GuestModeForm g = new GuestModeForm();
            g.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            s.Stop();
            button8.Visible = false;
            button7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            s.PlayLooping();
            button7.Visible = false;
            button8.Visible = true;
        }
    }
}
