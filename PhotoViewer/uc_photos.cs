using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class uc_photos : UserControl
    {
        public uc_photos()
        {
            InitializeComponent();
        }

        public static void createImage(String path)
        {
            PictureBox pb = new PictureBox();
            pb.Size = new Size(100, 100);
            pb.ImageLocation = path;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
