using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        int time = 0;

        private void timer_loading_Tick(object sender, EventArgs e)
        {
            pnl_loadingBar.Size = new Size(pnl_loadingBar.Size.Width + 3, pnl_loadingBar.Size.Height);
            
            if (pnl_loadingBar.Size.Width == 600)
            {
                timer_loading.Stop();

                Main main = new Main();

                main.Show();

                this.Hide();
            }

            if (time >= 30 && pnl_textWelcome.Size.Width < 210)
                pnl_textWelcome.Size = new Size(pnl_textWelcome.Size.Width + 5, 42);

            if (pnl_textWelcome.Size.Width == 210 && pnl_textTo.Size.Width < 56)
                pnl_textTo.Size = new Size(pnl_textTo.Size.Width + 4, 42);

            if (pnl_textTo.Size.Width == 56 && pnl_textPB.Size.Width < 230)
                pnl_textPB.Size = new Size(pnl_textPB.Size.Width + 5, 42);

            time++;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer_loading.Start();
        }
    }
}
