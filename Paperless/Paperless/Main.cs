using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paperless
{
    public partial class Main : Form
    {

        Splash splash;

        public Main()
        {
            this.splash = new Splash();
            this.splash.Show();

            InitializeComponent();

        }

        private void MainShown(object sender, EventArgs e)
        {
            this.splash.Hide();
        }

        private void exitPaperlessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
