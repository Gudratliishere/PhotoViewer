namespace PhotoViewer
{
    partial class uc_photos
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
            this.flp_photos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_photos
            // 
            this.flp_photos.AutoScroll = true;
            this.flp_photos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_photos.Location = new System.Drawing.Point(0, 0);
            this.flp_photos.Name = "flp_photos";
            this.flp_photos.Size = new System.Drawing.Size(916, 398);
            this.flp_photos.TabIndex = 0;
            // 
            // uc_photos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.flp_photos);
            this.Name = "uc_photos";
            this.Size = new System.Drawing.Size(916, 398);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel flp_photos;
    }
}
