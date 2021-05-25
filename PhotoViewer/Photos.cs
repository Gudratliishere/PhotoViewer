using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    class Photos
    {
        public PictureBox photo = new PictureBox();

        public static String messageFileNotFound, messageError;

        Main mainObject;

        HashSet<String> photoDirectoryList = new HashSet<string>();

        bool allOrSpecialPhoto;

        public String fileDir;

        public Photos(Main main, HashSet<String> photoDirectoryList, bool allOrSpecialPhoto)
        {
            this.allOrSpecialPhoto = allOrSpecialPhoto;

            this.photoDirectoryList = photoDirectoryList;

            mainObject = main;

            photo.Size = new Size(100, 100);
            photo.SizeMode = PictureBoxSizeMode.Zoom;

            photo.Click += photo_Click;
        }

        private void photo_Click(object sender, EventArgs e)
        {
            mainObject.filePath = fileDir;

            mainObject.changeVisibilityPV(true);

            mainObject.clearAllUserControls();

            mainObject.photoView.pb_photo.Image = photo.Image;

            mainObject.orgImg = photo.Image;

            mainObject.pnl_body.Controls.Add(mainObject.photoView);

            mainObject.timer_colorForPhotoAlbum.Start();

            mainObject.photoView.Dock = DockStyle.Fill;

            int index = findIndexOfPhoto(photoDirectoryList, fileDir);
            if (index != -1)
                mainObject.indexOfPhoto = index;

            mainObject.allOrSpecialPhotoL = allOrSpecialPhoto;

            mainObject.closeOptionsPanel();

            mainObject.btn_leftButton.Enabled = true;
            mainObject.btn_rightButton.Enabled = true;

            mainObject.btn_leftButton.BackColor = (mainObject.setting.rb_darkModeDark.Checked) ? Color.FromArgb(10, 10, 10) :
                Color.FromArgb(220, 220, 220);
            mainObject.btn_rightButton.BackColor = (mainObject.setting.rb_darkModeDark.Checked) ? Color.FromArgb(10, 10, 10) :
                Color.FromArgb(220, 220, 220);
        }

        private int findIndexOfPhoto(HashSet<String> photoDirectoryList, String fileDir)
        {
            for (int i = 0; i < photoDirectoryList.Count; i++)
                if (photoDirectoryList.ElementAt(i).Equals(fileDir)) return i;

            return -1;
        }

        public static List<PictureBox> getPictureBox(HashSet<String> photoDirectoryList, Main main, bool allOrSpecialPhoto)
        {
            List<PictureBox> pictureBoxList = new List<PictureBox>();
            List<Photos> photosList = new List<Photos>();

            foreach (String dir in photoDirectoryList)
            {
                try
                {
                    photosList.Add(new Photos(main, photoDirectoryList, allOrSpecialPhoto));

                    photosList.Last().photo.Image = Image.FromFile(dir);
                    photosList.Last().fileDir = dir;

                    pictureBoxList.Add(photosList.Last().photo);
                }
                catch
                {
                    MessageBox.Show(messageFileNotFound + dir, messageError);
                }
            }

            return pictureBoxList;
        }
    }
}
