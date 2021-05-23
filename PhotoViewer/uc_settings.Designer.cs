namespace PhotoViewer
{
    partial class uc_settings
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
            this.lbl_darkMode = new System.Windows.Forms.Label();
            this.rb_darkModeDark = new System.Windows.Forms.RadioButton();
            this.rb_darkModeLight = new System.Windows.Forms.RadioButton();
            this.lbl_settings = new System.Windows.Forms.Label();
            this.lbl_language = new System.Windows.Forms.Label();
            this.lbl_descriptionDarkmode = new System.Windows.Forms.Label();
            this.cb_language = new System.Windows.Forms.ComboBox();
            this.lbl_descriptionLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_darkMode
            // 
            this.lbl_darkMode.AutoSize = true;
            this.lbl_darkMode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_darkMode.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_darkMode.ForeColor = System.Drawing.Color.White;
            this.lbl_darkMode.Location = new System.Drawing.Point(68, 80);
            this.lbl_darkMode.Name = "lbl_darkMode";
            this.lbl_darkMode.Size = new System.Drawing.Size(121, 25);
            this.lbl_darkMode.TabIndex = 0;
            this.lbl_darkMode.Text = "Dark mode:";
            // 
            // rb_darkModeDark
            // 
            this.rb_darkModeDark.AutoSize = true;
            this.rb_darkModeDark.BackColor = System.Drawing.Color.Transparent;
            this.rb_darkModeDark.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_darkModeDark.ForeColor = System.Drawing.Color.White;
            this.rb_darkModeDark.Location = new System.Drawing.Point(73, 121);
            this.rb_darkModeDark.Name = "rb_darkModeDark";
            this.rb_darkModeDark.Size = new System.Drawing.Size(60, 23);
            this.rb_darkModeDark.TabIndex = 2;
            this.rb_darkModeDark.Text = "Dark";
            this.rb_darkModeDark.UseVisualStyleBackColor = false;
            this.rb_darkModeDark.CheckedChanged += new System.EventHandler(this.rb_darkModeDark_CheckedChanged);
            // 
            // rb_darkModeLight
            // 
            this.rb_darkModeLight.AutoSize = true;
            this.rb_darkModeLight.BackColor = System.Drawing.Color.Transparent;
            this.rb_darkModeLight.Checked = true;
            this.rb_darkModeLight.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_darkModeLight.ForeColor = System.Drawing.Color.White;
            this.rb_darkModeLight.Location = new System.Drawing.Point(155, 121);
            this.rb_darkModeLight.Name = "rb_darkModeLight";
            this.rb_darkModeLight.Size = new System.Drawing.Size(62, 23);
            this.rb_darkModeLight.TabIndex = 3;
            this.rb_darkModeLight.TabStop = true;
            this.rb_darkModeLight.Text = "Light";
            this.rb_darkModeLight.UseVisualStyleBackColor = false;
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.BackColor = System.Drawing.Color.Transparent;
            this.lbl_settings.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_settings.ForeColor = System.Drawing.Color.White;
            this.lbl_settings.Location = new System.Drawing.Point(34, 20);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(131, 39);
            this.lbl_settings.TabIndex = 4;
            this.lbl_settings.Text = "Settings";
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.BackColor = System.Drawing.Color.Transparent;
            this.lbl_language.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_language.ForeColor = System.Drawing.Color.White;
            this.lbl_language.Location = new System.Drawing.Point(68, 196);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(110, 25);
            this.lbl_language.TabIndex = 5;
            this.lbl_language.Text = "Language:";
            // 
            // lbl_descriptionDarkmode
            // 
            this.lbl_descriptionDarkmode.AutoSize = true;
            this.lbl_descriptionDarkmode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descriptionDarkmode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_descriptionDarkmode.ForeColor = System.Drawing.Color.White;
            this.lbl_descriptionDarkmode.Location = new System.Drawing.Point(68, 160);
            this.lbl_descriptionDarkmode.Name = "lbl_descriptionDarkmode";
            this.lbl_descriptionDarkmode.Size = new System.Drawing.Size(291, 14);
            this.lbl_descriptionDarkmode.TabIndex = 6;
            this.lbl_descriptionDarkmode.Text = "Change theme of application as follows your choice.";
            // 
            // cb_language
            // 
            this.cb_language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cb_language.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_language.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_language.ForeColor = System.Drawing.Color.White;
            this.cb_language.FormattingEnabled = true;
            this.cb_language.Items.AddRange(new object[] {
            "Azerbaijani",
            "English",
            "Russian",
            "Turkish"});
            this.cb_language.Location = new System.Drawing.Point(73, 245);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(150, 27);
            this.cb_language.TabIndex = 7;
            this.cb_language.Text = "English";
            this.cb_language.SelectedIndexChanged += new System.EventHandler(this.cb_language_SelectedIndexChanged);
            // 
            // lbl_descriptionLanguage
            // 
            this.lbl_descriptionLanguage.AutoSize = true;
            this.lbl_descriptionLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descriptionLanguage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_descriptionLanguage.ForeColor = System.Drawing.Color.White;
            this.lbl_descriptionLanguage.Location = new System.Drawing.Point(70, 293);
            this.lbl_descriptionLanguage.Name = "lbl_descriptionLanguage";
            this.lbl_descriptionLanguage.Size = new System.Drawing.Size(318, 14);
            this.lbl_descriptionLanguage.TabIndex = 8;
            this.lbl_descriptionLanguage.Text = "Change language of application for your native language.";
            // 
            // uc_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.lbl_descriptionLanguage);
            this.Controls.Add(this.cb_language);
            this.Controls.Add(this.lbl_descriptionDarkmode);
            this.Controls.Add(this.lbl_language);
            this.Controls.Add(this.lbl_settings);
            this.Controls.Add(this.rb_darkModeLight);
            this.Controls.Add(this.rb_darkModeDark);
            this.Controls.Add(this.lbl_darkMode);
            this.Name = "uc_settings";
            this.Size = new System.Drawing.Size(916, 398);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RadioButton rb_darkModeDark;
        public System.Windows.Forms.RadioButton rb_darkModeLight;
        public System.Windows.Forms.Label lbl_darkMode;
        public System.Windows.Forms.Label lbl_settings;
        public System.Windows.Forms.Label lbl_language;
        public System.Windows.Forms.Label lbl_descriptionDarkmode;
        public System.Windows.Forms.Label lbl_descriptionLanguage;
        public System.Windows.Forms.ComboBox cb_language;
    }
}
