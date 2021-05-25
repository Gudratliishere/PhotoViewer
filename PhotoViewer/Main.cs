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
    public partial class Main : Form
    {
        int movX, movY;
        public int indexOfPhoto;

        bool move;
        public bool allOrSpecialPhotoL;
        public bool imageCropped = false;

        public uc_photoView photoView = new uc_photoView();
        uc_photos photos = new uc_photos();
        public uc_photos currentPhotos = new uc_photos();
        uc_folders folders = new uc_folders();
        public uc_settings setting;

        UserControl currentUC;

        FolderIcon allPhoto;

        List<uc_photos> photosList = new List<uc_photos>();

        public Image orgImg;

        public String filePath;

        HashSet<String> allPhotosList = new HashSet<string>();
        HashSet<string> specialPhotosList;

        ToolTip toolTip = new ToolTip();

        String messageMaximizeWindowError, messageError, messageErrorOccured, messageImageWasNotFound,
            messageImageWasNotFoundTitle, messageSaveImage, messageSaveImageTitle,
            messageSaved, messageDoneTitle, messageDragLeave, messageDragEnter, messageLoading;
        String buttonTextOrgSize, buttonTextZoomSize, nameOfAllPhoto;

        public Main()
        {
            InitializeComponent();

            setting = new uc_settings(this);

            try
            {
                StreamReader sr = new StreamReader(@"config\setting.cfg");

                string mode = sr.ReadLine();
                string language = sr.ReadLine();

                sr.Close();

                if (mode.Equals("dark")) changeToDarkMode();
                else if (mode.Equals("light")) changeToLightMode();
                else throw new Exception();

                if (language.Equals("english")) changeLanguageToEnglish();
                else if (language.Equals("azerbaijani")) changeLanguageToAzerbaijani();
                else if (language.Equals("turkish")) changeLanguageToTurkish();
                else if (language.Equals("russian")) changeLanguageToRussian();
                else throw new Exception();
            } catch (Exception ex)
            {
                MessageBox.Show("There is problem in config files.\nPlease download application again.\n\n*" + ex.Message +
                    "*", "Error");
            }

            photos.flp_photos.Click += Flp_photos_Click;
            folders.flp_folders.Click += Flp_folders_Click;
            photoView.pb_photo.Click += Pb_photo_Click;

            photoView.getMain = this;
        }

        private void Flp_folders_Click(object sender, EventArgs e)
        {
            closeOptionsPanel();
        }

        private void Flp_photos_Click(object sender, EventArgs e)
        {
            closeOptionsPanel();
        }

        private void pnl_topBorder_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            movX = e.X;
            movY = e.Y;
        }

        private void pnl_topBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;

                    pnl_photoViewTools.Location = new Point(pnl_top.Size.Width / 2 - 100, 0);

                    tb_zoomImage.Location = new Point(pnl_photoViewTools.Location.X - 1, 0);
                }

                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pnl_topBorder_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void btn_maximizeWindow_Click(object sender, EventArgs e)
        {
            try
            {
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Maximized;

                    btn_maximizeWindow.Image = Image.FromFile(@"img\Normalize.png");
                    btn_maximizeWindow.FlatStyle = FlatStyle.Flat;
                    btn_maximizeWindow.FlatAppearance.BorderSize = 0;
                    
                    pnl_photoViewTools.Location = new Point(pnl_top.Size.Width / 2 - 100, 0);

                    tb_zoomImage.Location = new Point(pnl_photoViewTools.Location.X - 1, 0);

                }
                else
                {
                    WindowState = FormWindowState.Normal;

                    StartPosition = FormStartPosition.CenterScreen;

                    btn_maximizeWindow.Image = Image.FromFile(@"img\Maximize.png");
                    btn_maximizeWindow.FlatStyle = FlatStyle.Flat;
                    btn_maximizeWindow.FlatAppearance.BorderSize = 0;

                    pnl_photoViewTools.Location = new Point(pnl_top.Size.Width / 2 - 100, 0);

                    tb_zoomImage.Location = new Point(pnl_photoViewTools.Location.X - 1, 0);
                }
            }
            catch
            {
                MessageBox.Show(messageMaximizeWindowError, messageError);
            }

        }

        private void timer_closing_Tick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;

            if (this.Size.Width > 20)
            {
                this.Size = new Size(this.Size.Width - 80, this.Size.Height - 40);
                this.Location = new Point(this.Location.X + 40, this.Location.Y + 20);
            }
            else
            {
                timer_closing.Stop();

                Application.Exit();
            }
        }

        private void btn_closeWindow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btn_closeWindow, "Close Application");
        }

        private void btn_closeWindow_MouseLeave(object sender, EventArgs e)
        {
            if (setting.rb_darkModeDark.Checked) btn_closeWindow.BackColor = Color.Black;
            else btn_closeWindow.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_maximizeWindow_MouseLeave(object sender, EventArgs e)
        {
            if (setting.rb_darkModeDark.Checked) btn_maximizeWindow.BackColor = Color.Black;
        }

        private void btn_maximizeWindow_MouseHover(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) toolTip.SetToolTip(btn_maximizeWindow, "Maximize window");
            else toolTip.SetToolTip(btn_maximizeWindow, "Normalize window");
        }

        private void btn_minimizeWindow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btn_minimizeWindow, "Minimize window");
        }

        private void btn_minimizeWindow_MouseLeave(object sender, EventArgs e)
        {
            if (setting.rb_darkModeDark.Checked) btn_minimizeWindow.BackColor = Color.Black;
        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            disableCropButton();

            tb_zoomImage.Visible = false;

            pnl_options.Visible = (pnl_options.Visible) ? false : true;

            if (setting.rb_darkModeDark.Checked) btn_options.BackColor = (pnl_options.Visible) ? Color.FromArgb(15, 15, 15) : Color.FromArgb(10, 10, 10);
            else btn_options.BackColor = (pnl_options.Visible) ? Color.FromArgb(210, 210, 210) : Color.FromArgb(220, 220, 220);

            if (pnl_add.Visible) pnl_add.Visible = false;

            if (pnl_body.Controls.Contains(photoView) && !imageCropped) pnl_options.Size = new Size(169, 100);
            else if (pnl_body.Controls.Contains(photoView) && imageCropped) pnl_options.Size = new Size(169, 138);
            else pnl_options.Size = new Size(169, 69);

            if (photoView.pb_photo.SizeMode == PictureBoxSizeMode.Zoom) btn_changeSizeImage.Text = buttonTextOrgSize;
            else btn_changeSizeImage.Text = buttonTextZoomSize;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            pnl_add.Visible = (pnl_add.Visible) ? false : true;
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            closeOptionsPanel();

            btn_backFromSetting.Visible = true;

            foreach (Control control in pnl_body.Controls) if (control is UserControl) currentUC = (UserControl)control;

            clearAllUserControls();

            pnl_body.Controls.Add(setting);

            setting.Dock = DockStyle.Fill;

            changeVisibilityPV(false);

            btn_photos.Visible = false;
            btn_folders.Visible = false;
            pnl_colorForPhotoAlbum.Visible = false;
        }

        private void pnl_top_Click(object sender, EventArgs e)
        {
            tb_zoomImage.Visible = false;

            closeOptionsPanel();
        }

        private void pnl_body_Click(object sender, EventArgs e)
        {
            closeOptionsPanel();
        }

        private void fillPhotos(HashSet<String> directoryList, uc_photos control, bool key)
        {
            control.flp_photos.Controls.Clear();

            List<PictureBox> pictureBoxList = new List<PictureBox>();

            pictureBoxList = Photos.getPictureBox(directoryList, this, key);

            foreach (PictureBox pictureBox in pictureBoxList) control.flp_photos.Controls.Add(pictureBox);
        }

        private void btn_photos_Click(object sender, EventArgs e)
        {
            if (pnl_colorForPhotoAlbum.Location.X == 90) timer_colorForPhotoAlbum.Start();

            tb_zoomImage.Visible = false;

            closeOptionsPanel();

            clearAllUserControls();

            pnl_body.Controls.Add(currentPhotos);

            if (allPhotosList.Count == 0) lbl_mainBGText.Visible = true;
        }

        public void clearAllUserControls()
        {
            foreach (Control control in pnl_body.Controls) if (control is UserControl) pnl_body.Controls.Remove(control);

            lbl_mainBGText.Visible = false;
        }

        private void btn_folders_Click(object sender, EventArgs e)
        {
            if (pnl_colorForPhotoAlbum.Location.X == 0) timer_colorForPhotoAlbum.Start();

            tb_zoomImage.Visible = false;

            closeOptionsPanel();

            clearAllUserControls();

            pnl_body.Controls.Add(folders);

            if (allPhotosList.Count == 0) lbl_mainBGText.Visible = true;

            folders.Dock = DockStyle.Fill;
        }

        private void btn_addPhoto_Click(object sender, EventArgs e)
        {
            closeOptionsPanel();

            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = "Image files (*.png, *.jpg, *.jpeg, *.jpe, *.jfif, *.JPG)|*.jpg; *.jpeg; *.png; *.jpe; *.jfif; *.JPG |All files (*.*)| *.*";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                photoView.pb_photo.Image = Image.FromFile(fd.FileName);

                clearAllUserControls();

                pnl_body.Controls.Add(photoView);

                if (pnl_colorForPhotoAlbum.Location.X == 90) timer_colorForPhotoAlbum.Start();

                photoView.Dock = DockStyle.Fill;

                orgImg = photoView.pb_photo.Image;

                changeVisibilityPV(true);

                allPhotosList.Add(fd.FileName);

                indexOfPhoto = allPhotosList.Count - 1;

                fillPhotos(allPhotosList, photos, true);

                if (allPhoto == null) allPhoto = new FolderIcon(nameOfAllPhoto, photos, this);

                allPhoto.imagesSize = allPhotosList.Count;

                if (!folders.flp_folders.Controls.Contains(allPhoto.getResult())) folders.flp_folders.Controls.Add(allPhoto.getResult());

                if (allPhotosList.Count < 5) fillFolderIcon(allPhoto, allPhotosList);

                filePath = fd.FileName;

                currentPhotos = photos;

                btn_leftButton.Enabled = true;
                btn_rightButton.Enabled = true;

                btn_leftButton.BackColor = (setting.rb_darkModeDark.Checked) ? Color.FromArgb(10, 10, 10) :
                    Color.FromArgb(220, 220, 220);
                btn_rightButton.BackColor = (setting.rb_darkModeDark.Checked) ? Color.FromArgb(10, 10, 10) :
                    Color.FromArgb(220, 220, 220);
            }
        }

        private void Pnl_photoView_Click(object sender, EventArgs e)
        {
            tb_zoomImage.Visible = false;

            closeOptionsPanel();

        }

        private void Pb_photo_Click(object sender, EventArgs e)
        {
            tb_zoomImage.Visible = false;

            closeOptionsPanel();
        }

        List<FolderIcon> folderPanelsList = new List<FolderIcon>();

        private void btn_addFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            lbl_mainBGText.Visible = true;
            lbl_mainBGText.Text = messageLoading;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string folderDirectory = fbd.SelectedPath;
                string folderName = folderDirectory.Substring(folderDirectory.LastIndexOf('\\') + 1);

                specialPhotosList = getImagesFromFolder(folderDirectory);

                if (specialPhotosList.Count == 0) MessageBox.Show(messageImageWasNotFound, messageImageWasNotFoundTitle);
                else
                {
                    FolderIcon tempicon;

                    int index = findFolder(folderName);

                    if (index == -1)
                    {
                        photosList.Add(new uc_photos());

                        folderPanelsList.Add(new FolderIcon(folderName, photosList.Last(), this));

                        tempicon = folderPanelsList.Last();
                    }
                    else tempicon = folderPanelsList[index];

                    if (setting.rb_darkModeLight.Checked) photosList.Last().flp_photos.BackColor = Color.FromArgb(220, 220, 220);
                    else photosList.Last().flp_photos.BackColor = Color.FromArgb(10, 10, 10);

                    closeOptionsPanel();

                    allPhotosList.UnionWith(specialPhotosList);

                    fillPhotos(specialPhotosList, photosList.Last(), false);
                    fillPhotos(allPhotosList, photos, true);

                    if (allPhoto == null) allPhoto = new FolderIcon(nameOfAllPhoto, photos, this);

                    allPhoto.imagesSize = allPhotosList.Count;

                    if (!folders.flp_folders.Controls.Contains(allPhoto.getResult())) folders.flp_folders.Controls.Add(allPhoto.getResult());

                    tempicon.imagesSize = specialPhotosList.Count;
                    tempicon.folderDir = folderDirectory;

                    fillFolderIcon(tempicon, specialPhotosList);
                    fillFolderIcon(allPhoto, allPhotosList);

                    folders.flp_folders.Controls.Add(tempicon.getResult());

                    if (setting.rb_darkModeDark.Checked) btn_options.BackColor = Color.FromArgb(10, 10, 10);
                    else btn_options.BackColor = Color.FromArgb(220, 220, 220);

                    clearAllUserControls();

                    pnl_body.Controls.Add(photosList.Last());

                    photosList.Last().Dock = DockStyle.Fill;

                    if (pnl_colorForPhotoAlbum.Location.X == 90) timer_colorForPhotoAlbum.Start();

                    currentPhotos = photosList.Last();

                    btn_leftButton.Enabled = true;
                    btn_rightButton.Enabled = true;

                    btn_leftButton.BackColor = (setting.rb_darkModeDark.Checked) ? Color.FromArgb(10, 10, 10) :
                        Color.FromArgb(220, 220, 220);
                    btn_rightButton.BackColor = (setting.rb_darkModeDark.Checked) ? Color.FromArgb(10, 10, 10) :
                        Color.FromArgb(220, 220, 220);
                }
            }

            lbl_mainBGText.Text = messageDragEnter;
            lbl_mainBGText.Visible = false;
        }

        private int findFolder(String folderName)
        {
            for (int i = 0; i < folderPanelsList.Count; i++)
                if (folderPanelsList[i].folderName.Equals(folderName)) return i;

            return -1;
        }

        private void fillFolderIcon(FolderIcon icon, HashSet<String> list)
        {
            if (icon != null)
            {
                switch (list.Count)
                {
                    case 1: icon.firstPB = Image.FromFile(list.ElementAt(0)); break;
                    case 2: icon.secondPB = Image.FromFile(list.ElementAt(1)); break;
                    case 3: icon.thirdPB = Image.FromFile(list.ElementAt(2)); break;
                    case 4: icon.fourthPB = Image.FromFile(list.ElementAt(3)); break;
                    default:
                        icon.firstPB = Image.FromFile(list.ElementAt(0));
                        icon.secondPB = Image.FromFile(list.ElementAt(1));
                        icon.thirdPB = Image.FromFile(list.ElementAt(2));
                        icon.fourthPB = Image.FromFile(list.ElementAt(3)); break;
                }
            }
        }

        private HashSet<String> getImagesFromFolder(String folderDirectory)
        {
            DirectoryInfo dir = new DirectoryInfo(folderDirectory);

            FileInfo[] files = dir.GetFiles();

            HashSet<String> images = new HashSet<string>();

            foreach (FileInfo file in files)
                if (file.Extension == ".jpg" || file.Extension == ".jpeg" || file.Extension == ".png" ||
                    file.Extension == "jfif" || file.Extension == "jpe" || file.Extension == ".JPG")
                    images.Add(file.DirectoryName + '\\' + file.ToString());

            return images;
        }

        private void btn_zoomImage_Click(object sender, EventArgs e)
        {
            tb_zoomImage.Visible = (tb_zoomImage.Visible) ? false : true;

            closeOptionsPanel();
        }

        public void tb_zoomImage_Scroll(object sender, EventArgs e)
        {
            if (tb_zoomImage.Value > 0)
            {
                photoView.pb_photo.SizeMode = PictureBoxSizeMode.AutoSize;
                photoView.pb_photo.Dock = DockStyle.None;
                photoView.pb_photo.Location = new Point(0, 0);
                photoView.pb_photo.Image = zoomPicture(orgImg, new Size(tb_zoomImage.Value, tb_zoomImage.Value));
            }
            else
            {
                photoView.pb_photo.SizeMode = PictureBoxSizeMode.Zoom;
                photoView.pb_photo.Dock = DockStyle.Fill;
            }
        }

        private Image zoomPicture(Image img, Size size)
        {
            try
            {
                Bitmap bm = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));

                Graphics.FromImage(bm).InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                return bm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(messageErrorOccured + "\n" + ex.Message, messageError);

                return null;
            }
        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            Bitmap bm = (Bitmap)photoView.pb_photo.Image;

            bm.RotateFlip(RotateFlipType.Rotate90FlipNone);

            photoView.pb_photo.Image = bm;

            orgImg = photoView.pb_photo.Image;

            tb_zoomImage.Visible = false;

            closeOptionsPanel();
        }

        private void btn_cropImage_Click(object sender, EventArgs e)
        {
            tb_zoomImage.Visible = false;

            closeOptionsPanel();

            if (photoView.crop)
                disableCropButton();
            else
            {
                photoView.crop = true;

                photoView.pb_photo.SizeMode = PictureBoxSizeMode.AutoSize;
                photoView.pb_photo.Dock = DockStyle.None;

                btn_cropImage.BackColor = Color.FromArgb(192, 192, 0);
            }
        }

        public void disableCropButton()
        {
            photoView.crop = false;

            photoView.pb_photo.SizeMode = PictureBoxSizeMode.Zoom;
            photoView.pb_photo.Dock = DockStyle.Fill;

            if (setting.rb_darkModeDark.Checked) btn_cropImage.BackColor = Color.FromArgb(10, 10, 10);
            else btn_cropImage.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void pnl_photoViewTools_Click(object sender, EventArgs e)
        {
            tb_zoomImage.Visible = false;

            closeOptionsPanel();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (imageCropped && MessageBox.Show(messageSaveImage, messageSaveImageTitle, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                saveCroppedImage();

            tb_zoomImage.Visible = false;

            imageCropped = false;

            closeOptionsPanel();

            changeVisibilityPV(false);

            clearAllUserControls();

            pnl_body.Controls.Add(currentPhotos);

            if (pnl_colorForPhotoAlbum.Location.X == 90) timer_colorForPhotoAlbum.Start();

            btn_leftButton.Enabled = true;
            btn_rightButton.Enabled = true;

            btn_leftButton.BackColor = (setting.rb_darkModeDark.Checked) ? Color.FromArgb(10, 10, 10) :
                Color.FromArgb(220, 220, 220);
            btn_rightButton.BackColor = (setting.rb_darkModeDark.Checked) ? Color.FromArgb(10, 10, 10) :
                Color.FromArgb(220, 220, 220);
        }

        private void btn_minimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        bool direction = true;

        int movePnl = 0;

        private void timer_colorForPhotoAlbum_Tick(object sender, EventArgs e)
        {
            if (direction)
            {
                movePnl += 10;

                pnl_colorForPhotoAlbum.Location = new Point(movePnl, 0);

                if (pnl_colorForPhotoAlbum.Location.X == 90)
                {
                    direction = false;

                    timer_colorForPhotoAlbum.Stop();
                }
            }
            else
            {
                movePnl -= 10;

                pnl_colorForPhotoAlbum.Location = new Point(movePnl, 0);

                if (pnl_colorForPhotoAlbum.Location.X == 0)
                {
                    direction = true;

                    timer_colorForPhotoAlbum.Stop();
                }
            }
        }

        public void btn_leftButton_Click(object sender, EventArgs e)
        {
            try
            {
                closeOptionsPanel();

                if (imageCropped && MessageBox.Show(messageSaveImage, messageSaveImageTitle, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    saveCroppedImage();

                filePath = (allOrSpecialPhotoL) ? allPhotosList.ElementAt(indexOfPhoto - 1) :
                    specialPhotosList.ElementAt(indexOfPhoto - 1);

                photoView.pb_photo.Image = Image.FromFile(filePath);

                orgImg = photoView.pb_photo.Image;

                indexOfPhoto--;

                btn_rightButton.Enabled = true;
                btn_rightButton.BackColor = (setting.rb_darkModeDark.Checked) ? Color.FromArgb(10, 10, 10) :
                    Color.FromArgb(220, 220, 220);

                tb_zoomImage.Value = 0;
                tb_zoomImage.Visible = false;
            }
            catch
            {
                btn_leftButton.Enabled = false;

                if (setting.rb_darkModeDark.Checked) btn_leftButton.BackColor = Color.FromArgb(64, 64, 64);
                else btn_leftButton.BackColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void btn_rightButton_Click(object sender, EventArgs e)
        {
            try
            {
                closeOptionsPanel();

                if (imageCropped && MessageBox.Show(messageSaveImage, messageSaveImageTitle, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    saveCroppedImage();

                filePath = (allOrSpecialPhotoL) ? allPhotosList.ElementAt(indexOfPhoto + 1) :
                    specialPhotosList.ElementAt(indexOfPhoto + 1);

                photoView.pb_photo.Image = Image.FromFile(filePath);

                orgImg = photoView.pb_photo.Image;

                indexOfPhoto++;

                btn_leftButton.Enabled = true;
                btn_leftButton.BackColor = Color.Transparent;

                tb_zoomImage.Value = 0;
                tb_zoomImage.Visible = false;
            }
            catch
            {
                btn_rightButton.Enabled = false;

                if (setting.rb_darkModeDark.Checked) btn_rightButton.BackColor = Color.FromArgb(64, 64, 64);
                else btn_rightButton.BackColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void btn_saveCropedImage_Click(object sender, EventArgs e)
        {
            closeOptionsPanel();

            saveCroppedImage();
        }

        private void btn_closeWindow_Click(object sender, EventArgs e)
        {
            timer_closing.Start();
        }

        private void btn_closeWindow_MouseEnter(object sender, EventArgs e)
        {
            btn_closeWindow.BackColor = Color.Red;
        }

        private void btn_maximizeWindow_MouseEnter(object sender, EventArgs e)
        {
            if (setting.rb_darkModeDark.Checked) btn_maximizeWindow.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void btn_minimizeWindow_MouseEnter(object sender, EventArgs e)
        {
            if (setting.rb_darkModeDark.Checked) btn_minimizeWindow.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void pnl_body_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);

            if (data != null)
            {
                string[] filesPath = data as string[];

                if (filesPath.Length > 0)
                {
                    photoView.pb_photo.Image = Image.FromFile(filesPath[0]);

                    clearAllUserControls();

                    pnl_body.Controls.Add(photoView);

                    if (pnl_colorForPhotoAlbum.Location.X == 90) timer_colorForPhotoAlbum.Start();

                    photoView.Dock = DockStyle.Fill;

                    orgImg = photoView.pb_photo.Image;

                    changeVisibilityPV(true);

                    allPhotosList.Add(filesPath[0]);

                    indexOfPhoto = allPhotosList.Count - 1;

                    fillPhotos(allPhotosList, photos, true);

                    if (allPhoto == null) allPhoto = new FolderIcon(nameOfAllPhoto, photos, this);

                    allPhoto.imagesSize = allPhotosList.Count;

                    if (!folders.flp_folders.Controls.Contains(allPhoto.getResult())) folders.flp_folders.Controls.Add(allPhoto.getResult());

                    if (allPhotosList.Count < 5) fillFolderIcon(allPhoto, allPhotosList);

                    filePath = filesPath[0];

                    currentPhotos = photos;

                    if (filesPath.Length > 1)
                    {
                        for (int i = 1; i < filesPath.Length; i++)
                        {
                            allPhotosList.Add(filesPath[i]);

                            fillFolderIcon(allPhoto, allPhotosList);
                        }

                        fillPhotos(allPhotosList, photos, true);

                        allPhoto.imagesSize = allPhotosList.Count;
                    }

                    btn_leftButton.Enabled = true;
                    btn_rightButton.Enabled = true;

                    btn_leftButton.BackColor = (setting.rb_darkModeDark.Checked) ? Color.FromArgb(10, 10, 10) :
                        Color.FromArgb(220, 220, 220);
                    btn_rightButton.BackColor = (setting.rb_darkModeDark.Checked) ? Color.FromArgb(10, 10, 10) :
                        Color.FromArgb(220, 220, 220);
                }
            }
            lbl_mainBGText.Text = messageDragEnter;
        }

        private void pnl_topBorder_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

                pnl_photoViewTools.Location = new Point(pnl_top.Size.Width / 2 - 100, 0);

                tb_zoomImage.Location = new Point(pnl_photoViewTools.Location.X - 1, 0);

            }
            else
            {
                WindowState = FormWindowState.Normal;

                pnl_photoViewTools.Location = new Point(pnl_top.Size.Width / 2 - 100, 0);

                tb_zoomImage.Location = new Point(pnl_photoViewTools.Location.X - 1, 0);
            }
        }

        private void lbl_mainBGText_SizeChanged(object sender, EventArgs e)
        {
            lbl_mainBGText.Left = (pnl_body.ClientSize.Width - lbl_mainBGText.Size.Width) / 2;
        }

        private void pnl_body_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            if (e.KeyState == 1) lbl_mainBGText.Text = messageDragEnter;

        }

        private void pnl_body_DragLeave(object sender, EventArgs e)
        {
            lbl_mainBGText.Text = messageDragLeave;
        }

        private void btn_changeSizeImage_Click(object sender, EventArgs e)
        {
            if (photoView.pb_photo.SizeMode == PictureBoxSizeMode.Zoom)
            {
                photoView.pb_photo.SizeMode = PictureBoxSizeMode.AutoSize;
                photoView.pb_photo.Dock = DockStyle.None;

                btn_changeSizeImage.Text = buttonTextZoomSize;
            }
            else
            {
                photoView.pb_photo.SizeMode = PictureBoxSizeMode.Zoom;
                photoView.pb_photo.Dock = DockStyle.Fill;

                btn_changeSizeImage.Text = buttonTextOrgSize;
            }
        }

        public void saveCroppedImage()
        {
            int index = 0;

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                String savePath = fbd.SelectedPath + "\\Image" + index + ".jpg";

                while (File.Exists(savePath))
                {
                    index++;

                    savePath = fbd.SelectedPath + "\\Image" + index + ".jpg";
                }

                Image img = photoView.pb_photo.Image;

                img.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                MessageBox.Show(messageSaved, messageDoneTitle);

                imageCropped = false;
            }
        }

        public void changeVisibilityPV(bool key)
        {
            pnl_photoViewTools.Visible = key;
            btn_back.Visible = key;

            btn_photos.Visible = !key;
            btn_folders.Visible = !key;
            pnl_colorForPhotoAlbum.Visible = !key;
        }

        private void btn_backFromSetting_Click(object sender, EventArgs e)
        {
            closeOptionsPanel();

            btn_backFromSetting.Visible = false;

            clearAllUserControls();

            if (currentUC != null) pnl_body.Controls.Add(currentUC);

            if (currentUC != null && currentUC is uc_photoView) changeVisibilityPV(true);
            else changeVisibilityPV(false);

            if (allPhotosList.Count == 0) lbl_mainBGText.Visible = true;
        }

        public void changeToLightMode()
        {
            Color topBorderColor = Color.FromArgb(240, 240, 240);
            Color bodyColor = Color.FromArgb(220, 220, 220);

            pnl_topBorder.BackColor = topBorderColor;

            lbl_appName.ForeColor = Color.Black;

            foreach (Control control in pnl_topBorder.Controls) control.BackColor = Color.FromArgb(80, 80, 80);

            lbl_appName.BackColor = topBorderColor;

            btn_options.ForeColor = Color.Black;

            pnl_top.BackColor = bodyColor;

            foreach (Control control in pnl_top.Controls) if (!(control is Panel)) control.BackColor = bodyColor;

            foreach (Control control in pnl_top.Controls) if (!(control is Panel)) control.ForeColor = Color.Black;

            pnl_body.BackColor = bodyColor;

            foreach (Control control in pnl_body.Controls) control.BackColor = bodyColor;

            foreach (Control control in pnl_options.Controls) control.ForeColor = Color.Black;

            foreach (Control control in pnl_add.Controls) control.ForeColor = Color.Black;

            photos.flp_photos.BackColor = bodyColor;
            currentPhotos.flp_photos.BackColor = bodyColor;

            folders.flp_folders.BackColor = bodyColor;

            pnl_photoViewTools.BackColor = bodyColor;

            foreach (Control control in pnl_photoViewTools.Controls) control.BackColor = bodyColor;

            foreach (Control control in setting.Controls) control.ForeColor = Color.Black;

            setting.cb_language.BackColor = Color.White;

            setting.BackColor = bodyColor;

            lbl_mainBGText.ForeColor = Color.FromArgb(64, 64, 64);
        }

        public void changeToDarkMode()
        {
            Color topBorderColor = Color.Black;
            Color bodyColor = Color.FromArgb(10, 10, 10);

            pnl_topBorder.BackColor = topBorderColor;

            lbl_appName.ForeColor = Color.White;

            foreach (Control control in pnl_topBorder.Controls) control.BackColor = topBorderColor;

            lbl_appName.BackColor = topBorderColor;

            btn_options.ForeColor = Color.White;

            pnl_top.BackColor = bodyColor;

            foreach (Control control in pnl_top.Controls) if (!(control is Panel)) control.BackColor = bodyColor;

            foreach (Control control in pnl_top.Controls) if (!(control is Panel)) control.ForeColor = Color.White;

            btn_backFromSetting.BackColor = Color.FromArgb(150, 150, 150);

            pnl_body.BackColor = bodyColor;

            foreach (Control control in pnl_body.Controls) control.BackColor = bodyColor;

            foreach (Control control in pnl_options.Controls) control.ForeColor = Color.White;

            foreach (Control control in pnl_add.Controls) control.ForeColor = Color.White;

            photos.flp_photos.BackColor = bodyColor;
            currentPhotos.flp_photos.BackColor = bodyColor;

            folders.flp_folders.BackColor = bodyColor;

            pnl_photoViewTools.BackColor = bodyColor;

            foreach (Control control in pnl_photoViewTools.Controls) control.BackColor = bodyColor;

            foreach (Control control in setting.Controls) control.ForeColor = Color.White;

            setting.cb_language.BackColor = Color.Black;

            setting.BackColor = bodyColor;

            lbl_mainBGText.ForeColor = Color.Silver;
        }

        public void changeLanguageToEnglish()
        {
            try
            {
                btn_photos.Text = "Photos";
                btn_folders.Text = "Albums";

                btn_add.Text = "Add";
                btn_settings.Text = "Settings";
                btn_addPhoto.Text = "Add photo";
                btn_addFolder.Text = "Add folder";

                buttonTextOrgSize = "See in original size";
                buttonTextZoomSize = "Fill image to window";

                btn_saveCropedImage.Text = "Save cropped image as";

                nameOfAllPhoto = "All photos";
                if (allPhoto != null) allPhoto.nameOfFolder = "All photos";

                setting.lbl_settings.Text = "Settings";
                setting.lbl_darkMode.Text = "Dark mode:";
                setting.rb_darkModeDark.Text = "Dark";
                setting.rb_darkModeLight.Text = "Light";
                setting.lbl_descriptionDarkmode.Text = "Change theme of application as follows your choice.";
                setting.lbl_language.Text = "Language:";
                setting.lbl_descriptionLanguage.Text = "Change language of application for your native language.";

                messageMaximizeWindowError = "There is problem with images files!\nPlease delete application and download again!";
                messageError = "Error";
                messageErrorOccured = "Error occured!";
                messageImageWasNotFound = "There is not any image file here!";
                messageImageWasNotFoundTitle = "Image was not found!";
                messageSaveImage = "Do you want to save cropped image?";
                messageSaveImageTitle = "Save image";
                messageSaved = "Image was saved successfully!";
                messageDoneTitle = "Done!";
                messageDragLeave = "Drag or add image file";
                messageDragEnter = "Leave here";
                messageLoading = "Loading...";
                Photos.messageFileNotFound = "Error was happened!\nFile was not found in that directory: \n";
                Photos.messageError = "Error";
                photoView.messageCrop = "Are you sure to crop this image?";
                photoView.messageCropTitle = "Crop image";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void changeLanguageToAzerbaijani()
        {
            try
            {
                btn_photos.Text = "Şəkillər";
                btn_folders.Text = "Albomlar";

                btn_add.Text = "Əlavə et";
                btn_settings.Text = "Parametrlər";
                btn_addPhoto.Text = "Şəkil əlavə et";
                btn_addFolder.Text = "Qovluq əlavə et";

                buttonTextOrgSize = "Şəkilə orjinal ölçüdə bax";
                buttonTextZoomSize = "Şəkili ekrana sığdır";

                btn_saveCropedImage.Text = "Şəkili yadda saxla";

                nameOfAllPhoto = "Bütün şəkillər";
                if (allPhoto != null) allPhoto.nameOfFolder = "Bütün şəkillər";

                setting.lbl_settings.Text = "Parametrlər";
                setting.lbl_darkMode.Text = "Tünd mod:";
                setting.rb_darkModeDark.Text = "Tünd";
                setting.rb_darkModeLight.Text = "Açıq";
                setting.lbl_descriptionDarkmode.Text = "Tətbiqin rəngini öz zövqünüzə uyğun dəyişin.";
                setting.lbl_language.Text = "Dil:";
                setting.lbl_descriptionLanguage.Text = "Tətbiqin dilini öz ana dilinizə uyğun dəyişin.";

                lbl_mainBGText.Text = "Şəkili bura sürüşdür və ya əlavə et";

                messageMaximizeWindowError = "Şəkil faylları ilə əlaqəli problem var!\nZəhmət olmasa tətbiqi silib yenidən yükləyin!";
                messageError = "Xəta";
                messageErrorOccured = "Xəta başverdi!";
                messageImageWasNotFound = "Burada heçbir şəkil faylı yoxdur!";
                messageImageWasNotFoundTitle = "Şəkil tapılmadı!";
                messageSaveImage = "Kəsilmiş şəkili yaddaşda saxlamaq istəyirsiniz mi?";
                messageSaveImageTitle = "Şəkili yadda saxla";
                messageSaved = "Şəkil uğurla yaddaşa yazıldı!";
                messageDoneTitle = "Hazır!";
                messageDragLeave = "Şəkili bura sürüşdür və ya əlavə et";
                messageDragEnter = "Buraya burax";
                messageLoading = "Yüklənir...";
                Photos.messageFileNotFound = "Xəta baş verdi!\nŞəkil bu istiqamətdə tapılmadı: \n";
                Photos.messageError = "Xəta";
                photoView.messageCrop = "Şəkili kəsmək istədiyinizə əminsiniz mi?";
                photoView.messageCropTitle = "Şəkili kəs";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void changeLanguageToTurkish()
        {
            try
            {
                btn_photos.Text = "Fotoğraflar";
                btn_folders.Text = "Albümler";

                btn_add.Text = "Ekle";
                btn_settings.Text = "Ayarlar";
                btn_addPhoto.Text = "Resim ekle";
                btn_addFolder.Text = "Klasör ekle";

                buttonTextOrgSize = "Orijinal boyutta görün";
                buttonTextZoomSize = "Resmi pencereye sığdırın";

                btn_saveCropedImage.Text = "Resmi kaydet";

                nameOfAllPhoto = "Tüm fotoğraflar";
                if (allPhoto != null) allPhoto.nameOfFolder = "Tüm fotoğraflar";

                setting.lbl_settings.Text = "Ayarlar";
                setting.lbl_darkMode.Text = "Karanlık mod:";
                setting.rb_darkModeDark.Text = "Karanlık";
                setting.rb_darkModeLight.Text = "Işık";
                setting.lbl_descriptionDarkmode.Text = "Uygulamanın temasını kendi isteğinize uygun değişin.";
                setting.lbl_language.Text = "Dil:";
                setting.lbl_descriptionLanguage.Text = "Uygulamanın dilini kendi ana dilinize uygun değişin.";

                lbl_mainBGText.Text = "Resim dosyasını buraya sürükleyin ve ya ekleyin";

                messageMaximizeWindowError = "Resim dosyalarıyla ilgili hata var!\nLütfen uygulamayı silin ve tekrardan indirin!";
                messageError = "Hata";
                messageErrorOccured = "Hata oluştu!";
                messageImageWasNotFound = "Klasörde hiç bir resim dosyası bulunamadı!";
                messageImageWasNotFoundTitle = "Resim bulunamadı!";
                messageSaveImage = "Kırpılmış resim kaydedilsin mi?";
                messageSaveImageTitle = "Resmi kaydet";
                messageSaved = "Resim başarıyla kaydedildi!";
                messageDoneTitle = "Bitdi!";
                messageDragLeave = "Resim dosyasını buraya sürükleyin ve ya ekleyin";
                messageDragEnter = "Buraya bırak";
                messageLoading = "Yükleniyor...";
                Photos.messageFileNotFound = "Hata oluştu!\nDosya bu dizinde bulunamadı: \n";
                Photos.messageError = "Hata";
                photoView.messageCrop = "Resmi kırpmak istediğinize eminsiniz mi?";
                photoView.messageCropTitle = "Resmi kırp";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void changeLanguageToRussian()
        {
            try
            {
                btn_photos.Text = "Фотографии";
                btn_folders.Text = "Альбомы";

                btn_add.Text = "Добавлять";
                btn_settings.Text = "Настройки";
                btn_addPhoto.Text = "Добавить фото";
                btn_addFolder.Text = "Добавить папку";

                buttonTextOrgSize = "Посмотреть в исходном размере";
                buttonTextZoomSize = "Залить изображение в окно";

                btn_saveCropedImage.Text = "Сохранить изображение как";

                nameOfAllPhoto = "Все фотографии";
                if (allPhoto != null) allPhoto.nameOfFolder = "Все фотографии";

                setting.lbl_settings.Text = "Настройки";
                setting.lbl_darkMode.Text = "Темный режим:";
                setting.rb_darkModeDark.Text = "Темный";
                setting.rb_darkModeLight.Text = "Свет";
                setting.lbl_descriptionDarkmode.Text = "Измените тему приложения по вашему выбору.";
                setting.lbl_language.Text = "Язык:";
                setting.lbl_descriptionLanguage.Text = "Измените язык приложения на свой родной язык.";

                lbl_mainBGText.Text = "Перетащите или добавьте файл изображения";

                messageMaximizeWindowError = "Проблема с файлами изображений!\nПожалуйста, удалите приложение и скачайте снова!";
                messageError = "Ошибка";
                messageErrorOccured = "Произошла ошибка!";
                messageImageWasNotFound = "Здесь нет файла изображения!";
                messageImageWasNotFoundTitle = "Изображение не найдено!";
                messageSaveImage = "Вы хотите сохранить обрезанное изображение?";
                messageSaveImageTitle = "Сохранить изображение";
                messageSaved = "Изображение успешно сохранено!";
                messageDoneTitle = "Сделанный!";
                messageDragLeave = "Перетащите или добавьте файл изображения";
                messageDragEnter = "Оставить здесь";
                messageLoading = "Загрузка...";
                Photos.messageFileNotFound = "Произошла ошибка!\nФайл не найден в этом каталоге: \n";
                Photos.messageError = "Ошибка";
                photoView.messageCrop = "Вы уверены, что обрежете это изображение?";
                photoView.messageCropTitle = "Обрезать изображение";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void closeOptionsPanel()
        {
            pnl_options.Visible = false;
            pnl_add.Visible = false;

            if (setting.rb_darkModeDark.Checked) btn_options.BackColor = Color.FromArgb(10, 10, 10);
            else btn_options.BackColor = Color.FromArgb(220, 220, 220);
        }
    }
}
