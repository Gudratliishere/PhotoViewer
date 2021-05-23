using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PhotoViewer
{
    class FolderIcon
    {
        String folderDirectory;
        public String folderName;

        Main mainObject;

        Panel panel = new Panel();

        public Label label = new Label();

        FlowLayoutPanel flp = new FlowLayoutPanel();

        int size;

        PictureBox pb1 = new PictureBox();
        PictureBox pb2 = new PictureBox();
        PictureBox pb3 = new PictureBox();
        PictureBox pb4 = new PictureBox();

        uc_photos photos;

        public FolderIcon(String label, uc_photos photos, Main mainObject)
        {
            panel.BackColor = Color.FromArgb(45, 45, 45);

            this.mainObject = mainObject;

            folderName = label;

            this.photos = photos;

            flp.Size = new Size(100, 100);
            flp.BackColor = Color.Transparent;

            panel.Size = new Size(100, 125);

            this.label.Font = new Font("Tahoma", 9.75f, FontStyle.Regular);
            this.label.ForeColor = Color.White;
            this.label.Location = new Point(0, 103);
            this.label.BackColor = Color.Transparent;
            this.label.AutoEllipsis = true;

            pb1.SizeMode = PictureBoxSizeMode.Zoom;
            pb2.SizeMode = PictureBoxSizeMode.Zoom;
            pb3.SizeMode = PictureBoxSizeMode.Zoom;
            pb4.SizeMode = PictureBoxSizeMode.Zoom;

            pb1.Size = new Size(44, 44);
            pb2.Size = new Size(44, 44);
            pb3.Size = new Size(44, 44);
            pb4.Size = new Size(44, 44);

            panel.Click += panel_click;
            this.label.Click += label_click;
            flp.Click += Flp_Click;
            pb1.Click += Pb1_Click;
            pb2.Click += Pb2_Click;
            pb3.Click += Pb3_Click;
            pb4.Click += Pb4_Click;
        }

        private void Pb4_Click(object sender, EventArgs e)
        {
            mainObject.clearAllUserControls();

            mainObject.pnl_body.Controls.Add(photos);

            mainObject.timer_colorForPhotoAlbum.Start();

            mainObject.currentPhotos = photos;

            photos.Dock = DockStyle.Fill;

            mainObject.closeOptionsPanel();
        }

        private void Pb3_Click(object sender, EventArgs e)
        {
            mainObject.clearAllUserControls();

            mainObject.pnl_body.Controls.Add(photos);

            mainObject.timer_colorForPhotoAlbum.Start();

            mainObject.currentPhotos = photos;

            photos.Dock = DockStyle.Fill;

            mainObject.closeOptionsPanel();
        }

        private void Pb2_Click(object sender, EventArgs e)
        {
            mainObject.clearAllUserControls();

            mainObject.pnl_body.Controls.Add(photos);

            mainObject.timer_colorForPhotoAlbum.Start();

            mainObject.currentPhotos = photos;

            photos.Dock = DockStyle.Fill;

            mainObject.closeOptionsPanel();
        }

        private void Pb1_Click(object sender, EventArgs e)
        {
            mainObject.clearAllUserControls();

            mainObject.pnl_body.Controls.Add(photos);

            mainObject.timer_colorForPhotoAlbum.Start();

            mainObject.currentPhotos = photos;

            photos.Dock = DockStyle.Fill;

            mainObject.closeOptionsPanel();
        }

        private void Flp_Click(object sender, EventArgs e)
        {
            mainObject.clearAllUserControls();

            mainObject.pnl_body.Controls.Add(photos);

            mainObject.timer_colorForPhotoAlbum.Start();

            mainObject.currentPhotos = photos;

            photos.Dock = DockStyle.Fill;

            mainObject.closeOptionsPanel();
        }

        private void label_click(object sender, EventArgs e)
        {
            mainObject.clearAllUserControls();

            mainObject.pnl_body.Controls.Add(photos);

            mainObject.timer_colorForPhotoAlbum.Start();

            mainObject.currentPhotos = photos;

            photos.Dock = DockStyle.Fill;

            mainObject.closeOptionsPanel();
        }

        private void panel_click(object sender, EventArgs e)
        {
            mainObject.clearAllUserControls();

            mainObject.pnl_body.Controls.Add(photos);

            mainObject.timer_colorForPhotoAlbum.Start();

            mainObject.currentPhotos = photos;

            photos.Dock = DockStyle.Fill;

            mainObject.closeOptionsPanel();
        }

        public String nameOfFolder
        {
            set { folderName = value; label.Text = size + " " + folderName; }
        }

        public int imagesSize
        {
            set { size = value; label.Text = size + " " + folderName; }
        }

        public String folderDir
        {
            set { folderDirectory = value; }
        }

        public Image firstPB
        {
            set { pb1.Image = value; }
        }

        public Image secondPB
        {
            set { pb2.Image = value; }
        }

        public Image thirdPB
        {
            set { pb3.Image = value; }
        }

        public Image fourthPB
        {
            set { pb4.Image = value; }
        }

        public Panel getResult()
        {
            flp.Controls.Add(pb1);
            flp.Controls.Add(pb2);
            flp.Controls.Add(pb3);
            flp.Controls.Add(pb4);

            label.Text = size + " " + folderName;

            panel.Controls.Add(flp);
            panel.Controls.Add(label);

            return panel;
        }

    }
}
