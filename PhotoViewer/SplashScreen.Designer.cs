namespace PhotoViewer
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pnl_loadingBarBG = new System.Windows.Forms.Panel();
            this.pnl_loadingBar = new System.Windows.Forms.Panel();
            this.timer_loading = new System.Windows.Forms.Timer(this.components);
            this.lbl_textWelcome = new System.Windows.Forms.Label();
            this.lbl_textTo = new System.Windows.Forms.Label();
            this.lbl_textPH = new System.Windows.Forms.Label();
            this.pnl_textWelcome = new System.Windows.Forms.Panel();
            this.pnl_textTo = new System.Windows.Forms.Panel();
            this.pnl_textPB = new System.Windows.Forms.Panel();
            this.pnl_loadingBarBG.SuspendLayout();
            this.pnl_textWelcome.SuspendLayout();
            this.pnl_textTo.SuspendLayout();
            this.pnl_textPB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_loadingBarBG
            // 
            this.pnl_loadingBarBG.BackColor = System.Drawing.Color.Transparent;
            this.pnl_loadingBarBG.Controls.Add(this.pnl_loadingBar);
            this.pnl_loadingBarBG.Location = new System.Drawing.Point(0, 325);
            this.pnl_loadingBarBG.Name = "pnl_loadingBarBG";
            this.pnl_loadingBarBG.Size = new System.Drawing.Size(600, 15);
            this.pnl_loadingBarBG.TabIndex = 0;
            // 
            // pnl_loadingBar
            // 
            this.pnl_loadingBar.BackColor = System.Drawing.Color.White;
            this.pnl_loadingBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_loadingBar.Name = "pnl_loadingBar";
            this.pnl_loadingBar.Size = new System.Drawing.Size(0, 15);
            this.pnl_loadingBar.TabIndex = 1;
            // 
            // timer_loading
            // 
            this.timer_loading.Interval = 1;
            this.timer_loading.Tick += new System.EventHandler(this.timer_loading_Tick);
            // 
            // lbl_textWelcome
            // 
            this.lbl_textWelcome.AutoSize = true;
            this.lbl_textWelcome.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_textWelcome.ForeColor = System.Drawing.Color.White;
            this.lbl_textWelcome.Location = new System.Drawing.Point(0, 0);
            this.lbl_textWelcome.Name = "lbl_textWelcome";
            this.lbl_textWelcome.Size = new System.Drawing.Size(180, 42);
            this.lbl_textWelcome.TabIndex = 1;
            this.lbl_textWelcome.Text = "Welcome";
            // 
            // lbl_textTo
            // 
            this.lbl_textTo.AutoSize = true;
            this.lbl_textTo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_textTo.ForeColor = System.Drawing.Color.White;
            this.lbl_textTo.Location = new System.Drawing.Point(0, 0);
            this.lbl_textTo.Name = "lbl_textTo";
            this.lbl_textTo.Size = new System.Drawing.Size(56, 42);
            this.lbl_textTo.TabIndex = 2;
            this.lbl_textTo.Text = "To";
            // 
            // lbl_textPH
            // 
            this.lbl_textPH.AutoSize = true;
            this.lbl_textPH.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_textPH.ForeColor = System.Drawing.Color.White;
            this.lbl_textPH.Location = new System.Drawing.Point(0, 0);
            this.lbl_textPH.Name = "lbl_textPH";
            this.lbl_textPH.Size = new System.Drawing.Size(230, 42);
            this.lbl_textPH.TabIndex = 3;
            this.lbl_textPH.Text = "Photo Home";
            // 
            // pnl_textWelcome
            // 
            this.pnl_textWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pnl_textWelcome.Controls.Add(this.lbl_textWelcome);
            this.pnl_textWelcome.ForeColor = System.Drawing.Color.Black;
            this.pnl_textWelcome.Location = new System.Drawing.Point(210, 83);
            this.pnl_textWelcome.Name = "pnl_textWelcome";
            this.pnl_textWelcome.Size = new System.Drawing.Size(0, 42);
            this.pnl_textWelcome.TabIndex = 4;
            // 
            // pnl_textTo
            // 
            this.pnl_textTo.BackColor = System.Drawing.Color.Transparent;
            this.pnl_textTo.Controls.Add(this.lbl_textTo);
            this.pnl_textTo.ForeColor = System.Drawing.Color.Black;
            this.pnl_textTo.Location = new System.Drawing.Point(272, 134);
            this.pnl_textTo.Name = "pnl_textTo";
            this.pnl_textTo.Size = new System.Drawing.Size(0, 42);
            this.pnl_textTo.TabIndex = 5;
            // 
            // pnl_textPB
            // 
            this.pnl_textPB.BackColor = System.Drawing.Color.Transparent;
            this.pnl_textPB.Controls.Add(this.lbl_textPH);
            this.pnl_textPB.ForeColor = System.Drawing.Color.Black;
            this.pnl_textPB.Location = new System.Drawing.Point(185, 188);
            this.pnl_textPB.Name = "pnl_textPB";
            this.pnl_textPB.Size = new System.Drawing.Size(0, 42);
            this.pnl_textPB.TabIndex = 6;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 340);
            this.Controls.Add(this.pnl_textPB);
            this.Controls.Add(this.pnl_textTo);
            this.Controls.Add(this.pnl_textWelcome);
            this.Controls.Add(this.pnl_loadingBarBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.pnl_loadingBarBG.ResumeLayout(false);
            this.pnl_textWelcome.ResumeLayout(false);
            this.pnl_textWelcome.PerformLayout();
            this.pnl_textTo.ResumeLayout(false);
            this.pnl_textTo.PerformLayout();
            this.pnl_textPB.ResumeLayout(false);
            this.pnl_textPB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_loadingBarBG;
        private System.Windows.Forms.Panel pnl_loadingBar;
        private System.Windows.Forms.Timer timer_loading;
        private System.Windows.Forms.Label lbl_textWelcome;
        private System.Windows.Forms.Label lbl_textTo;
        private System.Windows.Forms.Label lbl_textPH;
        private System.Windows.Forms.Panel pnl_textWelcome;
        private System.Windows.Forms.Panel pnl_textTo;
        private System.Windows.Forms.Panel pnl_textPB;
    }
}