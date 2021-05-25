namespace PhotoViewer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_minimizeWindow = new System.Windows.Forms.Button();
            this.btn_maximizeWindow = new System.Windows.Forms.Button();
            this.btn_closeWindow = new System.Windows.Forms.Button();
            this.pnl_topBorder = new System.Windows.Forms.Panel();
            this.lbl_appName = new System.Windows.Forms.Label();
            this.timer_closing = new System.Windows.Forms.Timer(this.components);
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_backFromSetting = new System.Windows.Forms.Button();
            this.pnl_colorForPhotoAlbum = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_photoViewTools = new System.Windows.Forms.Panel();
            this.btn_rightButton = new System.Windows.Forms.Button();
            this.btn_leftButton = new System.Windows.Forms.Button();
            this.btn_cropImage = new System.Windows.Forms.Button();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.btn_zoomImage = new System.Windows.Forms.Button();
            this.btn_options = new System.Windows.Forms.Button();
            this.btn_folders = new System.Windows.Forms.Button();
            this.btn_photos = new System.Windows.Forms.Button();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.lbl_mainBGText = new System.Windows.Forms.Label();
            this.tb_zoomImage = new System.Windows.Forms.TrackBar();
            this.pnl_add = new System.Windows.Forms.Panel();
            this.btn_addFolder = new System.Windows.Forms.Button();
            this.btn_addPhoto = new System.Windows.Forms.Button();
            this.pnl_options = new System.Windows.Forms.Panel();
            this.btn_saveCropedImage = new System.Windows.Forms.Button();
            this.btn_changeSizeImage = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.timer_colorForPhotoAlbum = new System.Windows.Forms.Timer(this.components);
            this.pnl_topBorder.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.pnl_photoViewTools.SuspendLayout();
            this.pnl_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_zoomImage)).BeginInit();
            this.pnl_add.SuspendLayout();
            this.pnl_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_minimizeWindow
            // 
            this.btn_minimizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizeWindow.BackColor = System.Drawing.Color.Black;
            this.btn_minimizeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimizeWindow.FlatAppearance.BorderSize = 0;
            this.btn_minimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizeWindow.Image")));
            this.btn_minimizeWindow.Location = new System.Drawing.Point(814, 0);
            this.btn_minimizeWindow.Name = "btn_minimizeWindow";
            this.btn_minimizeWindow.Size = new System.Drawing.Size(34, 34);
            this.btn_minimizeWindow.TabIndex = 3;
            this.btn_minimizeWindow.UseVisualStyleBackColor = false;
            this.btn_minimizeWindow.Click += new System.EventHandler(this.btn_minimizeWindow_Click);
            this.btn_minimizeWindow.MouseEnter += new System.EventHandler(this.btn_minimizeWindow_MouseEnter);
            this.btn_minimizeWindow.MouseLeave += new System.EventHandler(this.btn_minimizeWindow_MouseLeave);
            this.btn_minimizeWindow.MouseHover += new System.EventHandler(this.btn_minimizeWindow_MouseHover);
            // 
            // btn_maximizeWindow
            // 
            this.btn_maximizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_maximizeWindow.FlatAppearance.BorderSize = 0;
            this.btn_maximizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximizeWindow.Image")));
            this.btn_maximizeWindow.Location = new System.Drawing.Point(848, 0);
            this.btn_maximizeWindow.Name = "btn_maximizeWindow";
            this.btn_maximizeWindow.Size = new System.Drawing.Size(34, 34);
            this.btn_maximizeWindow.TabIndex = 2;
            this.btn_maximizeWindow.UseVisualStyleBackColor = true;
            this.btn_maximizeWindow.Click += new System.EventHandler(this.btn_maximizeWindow_Click);
            this.btn_maximizeWindow.MouseEnter += new System.EventHandler(this.btn_maximizeWindow_MouseEnter);
            this.btn_maximizeWindow.MouseLeave += new System.EventHandler(this.btn_maximizeWindow_MouseLeave);
            this.btn_maximizeWindow.MouseHover += new System.EventHandler(this.btn_maximizeWindow_MouseHover);
            // 
            // btn_closeWindow
            // 
            this.btn_closeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_closeWindow.BackColor = System.Drawing.Color.Black;
            this.btn_closeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_closeWindow.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_closeWindow.FlatAppearance.BorderSize = 0;
            this.btn_closeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_closeWindow.Image")));
            this.btn_closeWindow.Location = new System.Drawing.Point(882, 0);
            this.btn_closeWindow.Name = "btn_closeWindow";
            this.btn_closeWindow.Size = new System.Drawing.Size(34, 34);
            this.btn_closeWindow.TabIndex = 1;
            this.btn_closeWindow.UseVisualStyleBackColor = false;
            this.btn_closeWindow.Click += new System.EventHandler(this.btn_closeWindow_Click);
            this.btn_closeWindow.MouseEnter += new System.EventHandler(this.btn_closeWindow_MouseEnter);
            this.btn_closeWindow.MouseLeave += new System.EventHandler(this.btn_closeWindow_MouseLeave);
            this.btn_closeWindow.MouseHover += new System.EventHandler(this.btn_closeWindow_MouseHover);
            // 
            // pnl_topBorder
            // 
            this.pnl_topBorder.BackColor = System.Drawing.Color.Black;
            this.pnl_topBorder.Controls.Add(this.lbl_appName);
            this.pnl_topBorder.Controls.Add(this.btn_minimizeWindow);
            this.pnl_topBorder.Controls.Add(this.btn_closeWindow);
            this.pnl_topBorder.Controls.Add(this.btn_maximizeWindow);
            this.pnl_topBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topBorder.Location = new System.Drawing.Point(0, 0);
            this.pnl_topBorder.Name = "pnl_topBorder";
            this.pnl_topBorder.Size = new System.Drawing.Size(916, 34);
            this.pnl_topBorder.TabIndex = 0;
            this.pnl_topBorder.DoubleClick += new System.EventHandler(this.pnl_topBorder_DoubleClick);
            this.pnl_topBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_topBorder_MouseDown);
            this.pnl_topBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_topBorder_MouseMove);
            this.pnl_topBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_topBorder_MouseUp);
            // 
            // lbl_appName
            // 
            this.lbl_appName.AutoSize = true;
            this.lbl_appName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_appName.ForeColor = System.Drawing.Color.White;
            this.lbl_appName.Location = new System.Drawing.Point(12, 5);
            this.lbl_appName.Name = "lbl_appName";
            this.lbl_appName.Size = new System.Drawing.Size(106, 21);
            this.lbl_appName.TabIndex = 1;
            this.lbl_appName.Text = "Photo Home";
            // 
            // timer_closing
            // 
            this.timer_closing.Interval = 1;
            this.timer_closing.Tick += new System.EventHandler(this.timer_closing_Tick);
            // 
            // pnl_top
            // 
            this.pnl_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pnl_top.Controls.Add(this.btn_backFromSetting);
            this.pnl_top.Controls.Add(this.pnl_colorForPhotoAlbum);
            this.pnl_top.Controls.Add(this.btn_back);
            this.pnl_top.Controls.Add(this.pnl_photoViewTools);
            this.pnl_top.Controls.Add(this.btn_options);
            this.pnl_top.Controls.Add(this.btn_folders);
            this.pnl_top.Controls.Add(this.btn_photos);
            this.pnl_top.Location = new System.Drawing.Point(0, 32);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(916, 38);
            this.pnl_top.TabIndex = 1;
            this.pnl_top.Click += new System.EventHandler(this.pnl_top_Click);
            // 
            // btn_backFromSetting
            // 
            this.btn_backFromSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_backFromSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_backFromSetting.FlatAppearance.BorderSize = 0;
            this.btn_backFromSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backFromSetting.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_backFromSetting.ForeColor = System.Drawing.Color.White;
            this.btn_backFromSetting.Image = ((System.Drawing.Image)(resources.GetObject("btn_backFromSetting.Image")));
            this.btn_backFromSetting.Location = new System.Drawing.Point(0, 0);
            this.btn_backFromSetting.Name = "btn_backFromSetting";
            this.btn_backFromSetting.Size = new System.Drawing.Size(90, 38);
            this.btn_backFromSetting.TabIndex = 10;
            this.btn_backFromSetting.UseVisualStyleBackColor = false;
            this.btn_backFromSetting.Visible = false;
            this.btn_backFromSetting.Click += new System.EventHandler(this.btn_backFromSetting_Click);
            // 
            // pnl_colorForPhotoAlbum
            // 
            this.pnl_colorForPhotoAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnl_colorForPhotoAlbum.Location = new System.Drawing.Point(0, 0);
            this.pnl_colorForPhotoAlbum.Name = "pnl_colorForPhotoAlbum";
            this.pnl_colorForPhotoAlbum.Size = new System.Drawing.Size(90, 5);
            this.pnl_colorForPhotoAlbum.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Olive;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 38);
            this.btn_back.TabIndex = 9;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pnl_photoViewTools
            // 
            this.pnl_photoViewTools.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_photoViewTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pnl_photoViewTools.Controls.Add(this.btn_rightButton);
            this.pnl_photoViewTools.Controls.Add(this.btn_leftButton);
            this.pnl_photoViewTools.Controls.Add(this.btn_cropImage);
            this.pnl_photoViewTools.Controls.Add(this.btn_rotate);
            this.pnl_photoViewTools.Controls.Add(this.btn_zoomImage);
            this.pnl_photoViewTools.Location = new System.Drawing.Point(356, 0);
            this.pnl_photoViewTools.Name = "pnl_photoViewTools";
            this.pnl_photoViewTools.Size = new System.Drawing.Size(204, 38);
            this.pnl_photoViewTools.TabIndex = 8;
            this.pnl_photoViewTools.Visible = false;
            this.pnl_photoViewTools.Click += new System.EventHandler(this.pnl_photoViewTools_Click);
            // 
            // btn_rightButton
            // 
            this.btn_rightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_rightButton.FlatAppearance.BorderSize = 0;
            this.btn_rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rightButton.Image = ((System.Drawing.Image)(resources.GetObject("btn_rightButton.Image")));
            this.btn_rightButton.Location = new System.Drawing.Point(159, 0);
            this.btn_rightButton.Name = "btn_rightButton";
            this.btn_rightButton.Size = new System.Drawing.Size(38, 38);
            this.btn_rightButton.TabIndex = 4;
            this.btn_rightButton.UseVisualStyleBackColor = false;
            this.btn_rightButton.Click += new System.EventHandler(this.btn_rightButton_Click);
            // 
            // btn_leftButton
            // 
            this.btn_leftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_leftButton.FlatAppearance.BorderSize = 0;
            this.btn_leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leftButton.Image = ((System.Drawing.Image)(resources.GetObject("btn_leftButton.Image")));
            this.btn_leftButton.Location = new System.Drawing.Point(7, 0);
            this.btn_leftButton.Name = "btn_leftButton";
            this.btn_leftButton.Size = new System.Drawing.Size(38, 38);
            this.btn_leftButton.TabIndex = 3;
            this.btn_leftButton.UseVisualStyleBackColor = false;
            this.btn_leftButton.Click += new System.EventHandler(this.btn_leftButton_Click);
            // 
            // btn_cropImage
            // 
            this.btn_cropImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cropImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_cropImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cropImage.FlatAppearance.BorderSize = 0;
            this.btn_cropImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cropImage.Image = ((System.Drawing.Image)(resources.GetObject("btn_cropImage.Image")));
            this.btn_cropImage.Location = new System.Drawing.Point(121, 0);
            this.btn_cropImage.Name = "btn_cropImage";
            this.btn_cropImage.Size = new System.Drawing.Size(38, 38);
            this.btn_cropImage.TabIndex = 9;
            this.btn_cropImage.UseVisualStyleBackColor = false;
            this.btn_cropImage.Click += new System.EventHandler(this.btn_cropImage_Click);
            // 
            // btn_rotate
            // 
            this.btn_rotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_rotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rotate.FlatAppearance.BorderSize = 0;
            this.btn_rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rotate.Image = ((System.Drawing.Image)(resources.GetObject("btn_rotate.Image")));
            this.btn_rotate.Location = new System.Drawing.Point(83, 0);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(38, 38);
            this.btn_rotate.TabIndex = 8;
            this.btn_rotate.UseVisualStyleBackColor = false;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // btn_zoomImage
            // 
            this.btn_zoomImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_zoomImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_zoomImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_zoomImage.FlatAppearance.BorderSize = 0;
            this.btn_zoomImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zoomImage.Image = ((System.Drawing.Image)(resources.GetObject("btn_zoomImage.Image")));
            this.btn_zoomImage.Location = new System.Drawing.Point(45, 0);
            this.btn_zoomImage.Name = "btn_zoomImage";
            this.btn_zoomImage.Size = new System.Drawing.Size(38, 38);
            this.btn_zoomImage.TabIndex = 7;
            this.btn_zoomImage.UseVisualStyleBackColor = false;
            this.btn_zoomImage.Click += new System.EventHandler(this.btn_zoomImage_Click);
            // 
            // btn_options
            // 
            this.btn_options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_options.FlatAppearance.BorderSize = 0;
            this.btn_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_options.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_options.ForeColor = System.Drawing.Color.White;
            this.btn_options.Location = new System.Drawing.Point(846, 0);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(70, 38);
            this.btn_options.TabIndex = 6;
            this.btn_options.Text = ". . .";
            this.btn_options.UseVisualStyleBackColor = true;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // btn_folders
            // 
            this.btn_folders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_folders.FlatAppearance.BorderSize = 0;
            this.btn_folders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_folders.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_folders.ForeColor = System.Drawing.Color.White;
            this.btn_folders.Location = new System.Drawing.Point(90, 0);
            this.btn_folders.Name = "btn_folders";
            this.btn_folders.Size = new System.Drawing.Size(90, 38);
            this.btn_folders.TabIndex = 5;
            this.btn_folders.Text = "Albums";
            this.btn_folders.UseVisualStyleBackColor = true;
            this.btn_folders.Click += new System.EventHandler(this.btn_folders_Click);
            // 
            // btn_photos
            // 
            this.btn_photos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_photos.FlatAppearance.BorderSize = 0;
            this.btn_photos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_photos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_photos.ForeColor = System.Drawing.Color.White;
            this.btn_photos.Location = new System.Drawing.Point(0, 0);
            this.btn_photos.Name = "btn_photos";
            this.btn_photos.Size = new System.Drawing.Size(90, 38);
            this.btn_photos.TabIndex = 3;
            this.btn_photos.Text = "Photos";
            this.btn_photos.UseVisualStyleBackColor = true;
            this.btn_photos.Click += new System.EventHandler(this.btn_photos_Click);
            // 
            // pnl_body
            // 
            this.pnl_body.AllowDrop = true;
            this.pnl_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_body.AutoScroll = true;
            this.pnl_body.Controls.Add(this.lbl_mainBGText);
            this.pnl_body.Controls.Add(this.tb_zoomImage);
            this.pnl_body.Controls.Add(this.pnl_add);
            this.pnl_body.Controls.Add(this.pnl_options);
            this.pnl_body.Location = new System.Drawing.Point(0, 68);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(916, 398);
            this.pnl_body.TabIndex = 2;
            this.pnl_body.Click += new System.EventHandler(this.pnl_body_Click);
            this.pnl_body.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_body_DragDrop);
            this.pnl_body.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_body_DragEnter);
            this.pnl_body.DragLeave += new System.EventHandler(this.pnl_body_DragLeave);
            // 
            // lbl_mainBGText
            // 
            this.lbl_mainBGText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_mainBGText.AutoSize = true;
            this.lbl_mainBGText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mainBGText.ForeColor = System.Drawing.Color.Silver;
            this.lbl_mainBGText.Location = new System.Drawing.Point(346, 201);
            this.lbl_mainBGText.Name = "lbl_mainBGText";
            this.lbl_mainBGText.Size = new System.Drawing.Size(223, 25);
            this.lbl_mainBGText.TabIndex = 4;
            this.lbl_mainBGText.Text = "Drag or add image file";
            this.lbl_mainBGText.SizeChanged += new System.EventHandler(this.lbl_mainBGText_SizeChanged);
            // 
            // tb_zoomImage
            // 
            this.tb_zoomImage.LargeChange = 10;
            this.tb_zoomImage.Location = new System.Drawing.Point(355, 0);
            this.tb_zoomImage.Maximum = 100;
            this.tb_zoomImage.Name = "tb_zoomImage";
            this.tb_zoomImage.Size = new System.Drawing.Size(124, 45);
            this.tb_zoomImage.TabIndex = 2;
            this.tb_zoomImage.Visible = false;
            this.tb_zoomImage.Scroll += new System.EventHandler(this.tb_zoomImage_Scroll);
            // 
            // pnl_add
            // 
            this.pnl_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnl_add.Controls.Add(this.btn_addFolder);
            this.pnl_add.Controls.Add(this.btn_addPhoto);
            this.pnl_add.Location = new System.Drawing.Point(590, 0);
            this.pnl_add.Name = "pnl_add";
            this.pnl_add.Size = new System.Drawing.Size(160, 71);
            this.pnl_add.TabIndex = 1;
            this.pnl_add.Visible = false;
            // 
            // btn_addFolder
            // 
            this.btn_addFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addFolder.FlatAppearance.BorderSize = 0;
            this.btn_addFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFolder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addFolder.ForeColor = System.Drawing.Color.White;
            this.btn_addFolder.Location = new System.Drawing.Point(0, 31);
            this.btn_addFolder.Name = "btn_addFolder";
            this.btn_addFolder.Size = new System.Drawing.Size(160, 31);
            this.btn_addFolder.TabIndex = 8;
            this.btn_addFolder.Text = "Add folder";
            this.btn_addFolder.UseVisualStyleBackColor = true;
            this.btn_addFolder.Click += new System.EventHandler(this.btn_addFolder_Click);
            // 
            // btn_addPhoto
            // 
            this.btn_addPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addPhoto.FlatAppearance.BorderSize = 0;
            this.btn_addPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPhoto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addPhoto.ForeColor = System.Drawing.Color.White;
            this.btn_addPhoto.Location = new System.Drawing.Point(0, 0);
            this.btn_addPhoto.Name = "btn_addPhoto";
            this.btn_addPhoto.Size = new System.Drawing.Size(160, 31);
            this.btn_addPhoto.TabIndex = 7;
            this.btn_addPhoto.Text = "Add photo";
            this.btn_addPhoto.UseVisualStyleBackColor = true;
            this.btn_addPhoto.Click += new System.EventHandler(this.btn_addPhoto_Click);
            // 
            // pnl_options
            // 
            this.pnl_options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnl_options.Controls.Add(this.btn_saveCropedImage);
            this.pnl_options.Controls.Add(this.btn_changeSizeImage);
            this.pnl_options.Controls.Add(this.btn_settings);
            this.pnl_options.Controls.Add(this.btn_add);
            this.pnl_options.Location = new System.Drawing.Point(747, 0);
            this.pnl_options.Name = "pnl_options";
            this.pnl_options.Size = new System.Drawing.Size(169, 138);
            this.pnl_options.TabIndex = 3;
            this.pnl_options.Visible = false;
            // 
            // btn_saveCropedImage
            // 
            this.btn_saveCropedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveCropedImage.FlatAppearance.BorderSize = 0;
            this.btn_saveCropedImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveCropedImage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_saveCropedImage.ForeColor = System.Drawing.Color.White;
            this.btn_saveCropedImage.Location = new System.Drawing.Point(0, 100);
            this.btn_saveCropedImage.Name = "btn_saveCropedImage";
            this.btn_saveCropedImage.Size = new System.Drawing.Size(169, 31);
            this.btn_saveCropedImage.TabIndex = 10;
            this.btn_saveCropedImage.Text = "Save cropped image as";
            this.btn_saveCropedImage.UseVisualStyleBackColor = true;
            this.btn_saveCropedImage.Click += new System.EventHandler(this.btn_saveCropedImage_Click);
            // 
            // btn_changeSizeImage
            // 
            this.btn_changeSizeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_changeSizeImage.FlatAppearance.BorderSize = 0;
            this.btn_changeSizeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changeSizeImage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_changeSizeImage.ForeColor = System.Drawing.Color.White;
            this.btn_changeSizeImage.Location = new System.Drawing.Point(0, 69);
            this.btn_changeSizeImage.Name = "btn_changeSizeImage";
            this.btn_changeSizeImage.Size = new System.Drawing.Size(169, 31);
            this.btn_changeSizeImage.TabIndex = 9;
            this.btn_changeSizeImage.Text = "See in original size";
            this.btn_changeSizeImage.UseVisualStyleBackColor = true;
            this.btn_changeSizeImage.Click += new System.EventHandler(this.btn_changeSizeImage_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Location = new System.Drawing.Point(0, 31);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(169, 31);
            this.btn_settings.TabIndex = 7;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(169, 31);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // timer_colorForPhotoAlbum
            // 
            this.timer_colorForPhotoAlbum.Interval = 1;
            this.timer_colorForPhotoAlbum.Tick += new System.EventHandler(this.timer_colorForPhotoAlbum_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(916, 466);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_topBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Home";
            this.pnl_topBorder.ResumeLayout(false);
            this.pnl_topBorder.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_photoViewTools.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            this.pnl_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_zoomImage)).EndInit();
            this.pnl_add.ResumeLayout(false);
            this.pnl_options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_maximizeWindow;
        private System.Windows.Forms.Button btn_minimizeWindow;
        private System.Windows.Forms.Button btn_closeWindow;
        private System.Windows.Forms.Panel pnl_topBorder;
        private System.Windows.Forms.Label lbl_appName;
        private System.Windows.Forms.Timer timer_closing;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_photos;
        private System.Windows.Forms.Button btn_folders;
        private System.Windows.Forms.Button btn_options;
        private System.Windows.Forms.Panel pnl_add;
        private System.Windows.Forms.Button btn_addFolder;
        private System.Windows.Forms.Button btn_addPhoto;
        private System.Windows.Forms.Button btn_zoomImage;
        private System.Windows.Forms.Panel pnl_photoViewTools;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.Panel pnl_colorForPhotoAlbum;
        public System.Windows.Forms.Timer timer_colorForPhotoAlbum;
        private System.Windows.Forms.Panel pnl_options;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_backFromSetting;
        public System.Windows.Forms.Button btn_cropImage;
        private System.Windows.Forms.Button btn_saveCropedImage;
        private System.Windows.Forms.Button btn_changeSizeImage;
        public System.Windows.Forms.TrackBar tb_zoomImage;
        private System.Windows.Forms.Label lbl_mainBGText;
        public System.Windows.Forms.Button btn_rightButton;
        public System.Windows.Forms.Button btn_leftButton;
    }
}

