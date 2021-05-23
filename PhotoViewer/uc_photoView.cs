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
    public partial class uc_photoView : UserControl
    {
        Point mousePosition;
        Point oldMouseLocation, newMouseLocation;

        public bool crop = false;
        bool isMouseDown = false;

        Rectangle cropRectangle;

        Image orgImg;

        Main main;

        public String messageCrop, messageCropTitle;

        public uc_photoView()
        {
            InitializeComponent();
        }

        private void pb_photo_MouseDown(object sender, MouseEventArgs e)
        {
            if (pb_photo.SizeMode == PictureBoxSizeMode.AutoSize && e.Button == MouseButtons.Left && !crop)
                mousePosition = new Point(e.X, e.Y);

            if (crop && e.Button == MouseButtons.Left)
            {
                isMouseDown = true;

                oldMouseLocation = e.Location;

                orgImg = pb_photo.Image;
            }
        }

        private void pb_photo_MouseEnter(object sender, EventArgs e)
        {
            if (pb_photo.SizeMode == PictureBoxSizeMode.AutoSize && !crop)
                pb_photo.Cursor = Cursors.Hand;
        }

        private void pb_photo_MouseMove(object sender, MouseEventArgs e)
        {
            if (pb_photo.SizeMode == PictureBoxSizeMode.AutoSize && e.Button == MouseButtons.Left && !crop)
            {
                int X = mousePosition.X - e.X, Y = mousePosition.Y - e.Y;

                pnl_photoView.AutoScrollPosition = new Point(X - pnl_photoView.AutoScrollPosition.X, Y - pnl_photoView.AutoScrollPosition.Y);
            }

            if (isMouseDown)
            {
                newMouseLocation = e.Location;

                Refresh();
            }
        }

        private void pb_photo_Paint(object sender, PaintEventArgs e)
        {
            if (crop && cropRectangle != null && isMouseDown)
                e.Graphics.DrawRectangle(Pens.Blue, getRectangle());
        }

        private void pb_photo_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                newMouseLocation = e.Location;

                isMouseDown = false;

                DialogResult dr = MessageBox.Show(messageCrop, messageCropTitle,
                    MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    if (cropRectangle != null)
                    {
                        Bitmap cropImg = new Bitmap(cropRectangle.Width, cropRectangle.Height);

                        Graphics.FromImage(cropImg).DrawImage(pb_photo.Image, 0, 0, cropRectangle, GraphicsUnit.Pixel);

                        pb_photo.Image = cropImg;

                        main.disableCropButton();

                        main.imageCropped = true;
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    main.disableCropButton();

                    pb_photo.Image = orgImg;
                }
                else
                    pb_photo.Image = orgImg;
            }
        }

        public Main getMain
        {
            set { main = value; }
        }

        private void pb_photo_DoubleClick(object sender, EventArgs e)
        {
            if (main.tb_zoomImage.Value == 0) main.tb_zoomImage.Value += 20;
            else main.tb_zoomImage.Value = 0;
            main.tb_zoomImage_Scroll(sender, e);
        }

        private Rectangle getRectangle()
        {
            cropRectangle = new Rectangle();

            cropRectangle.X = Math.Min(oldMouseLocation.X, newMouseLocation.X);
            cropRectangle.Y = Math.Min(oldMouseLocation.Y, newMouseLocation.Y);

            cropRectangle.Width = Math.Abs(oldMouseLocation.X - newMouseLocation.X);
            cropRectangle.Height = Math.Abs(oldMouseLocation.Y - newMouseLocation.Y);

            return cropRectangle;
        }

        private void pb_photo_MouseLeave(object sender, EventArgs e)
        {
            pb_photo.Cursor = Cursors.Default;
        }
    }
}
