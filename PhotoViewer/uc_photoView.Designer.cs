namespace PhotoViewer
{
    partial class uc_photoView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_photoView));
            this.pnl_photoView = new System.Windows.Forms.Panel();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.pnl_photoView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_photoView
            // 
            resources.ApplyResources(this.pnl_photoView, "pnl_photoView");
            this.pnl_photoView.BackColor = System.Drawing.Color.White;
            this.pnl_photoView.Controls.Add(this.pb_photo);
            this.pnl_photoView.Name = "pnl_photoView";
            // 
            // pb_photo
            // 
            this.pb_photo.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pb_photo, "pb_photo");
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.TabStop = false;
            this.pb_photo.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_photo_Paint);
            this.pb_photo.DoubleClick += new System.EventHandler(this.pb_photo_DoubleClick);
            this.pb_photo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_photo_MouseDown);
            this.pb_photo.MouseEnter += new System.EventHandler(this.pb_photo_MouseEnter);
            this.pb_photo.MouseLeave += new System.EventHandler(this.pb_photo_MouseLeave);
            this.pb_photo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_photo_MouseMove);
            this.pb_photo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_photo_MouseUp);
            // 
            // uc_photoView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pnl_photoView);
            this.Name = "uc_photoView";
            this.pnl_photoView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pb_photo;
        public System.Windows.Forms.Panel pnl_photoView;
    }
}
