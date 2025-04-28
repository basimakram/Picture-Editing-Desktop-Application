using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixelair
{
    public partial class Guest_Entry : Form
    {
        public Guest_Entry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuestFilterForm g = new GuestFilterForm();
            g.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuestCropForm g = new GuestCropForm();
            g.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GuestResizeForm g = new GuestResizeForm();
            g.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GuestModeForm g = new GuestModeForm();
            g.Show();
            this.Hide();
        }
    }
}
