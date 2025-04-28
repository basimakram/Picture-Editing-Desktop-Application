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
    public partial class GuestModeForm : Form
    {
        public GuestModeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guest_Entry g = new Guest_Entry();
            g.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenuForm mf = new MainMenuForm();
            mf.Show();
            this.Hide();
        }
    }
}
