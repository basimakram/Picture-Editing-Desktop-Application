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
    public partial class MemberEntry : Form
    {
        public MemberEntry()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberFilterForm mf = new MemberFilterForm();
            mf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemberCropForm mc = new MemberCropForm();
            mc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberResizeForm mr = new MemberResizeForm();
            mr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
