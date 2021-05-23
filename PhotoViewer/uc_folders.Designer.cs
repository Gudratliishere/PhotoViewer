namespace PhotoViewer
{
    partial class uc_folders
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
            this.flp_folders = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_folders
            // 
            this.flp_folders.AutoScroll = true;
            this.flp_folders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_folders.Location = new System.Drawing.Point(0, 0);
            this.flp_folders.Name = "flp_folders";
            this.flp_folders.Size = new System.Drawing.Size(916, 398);
            this.flp_folders.TabIndex = 0;
            // 
            // uc_folders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.flp_folders);
            this.Name = "uc_folders";
            this.Size = new System.Drawing.Size(916, 398);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel flp_folders;
    }
}
