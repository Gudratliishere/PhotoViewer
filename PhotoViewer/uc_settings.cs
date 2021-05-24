using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhotoViewer
{
    public partial class uc_settings : UserControl
    {
        Main main;

        bool allowChanging = true;

        public uc_settings(Main main)
        {
            InitializeComponent();

            allowChanging = false;

            this.main = main;

            try
            {
                StreamReader sr = new StreamReader(@"config\setting.cfg");

                string mode = sr.ReadLine();
                string language = sr.ReadLine();

                sr.Close();

                if (mode.Equals("dark")) rb_darkModeDark.Checked = true;
                else if (mode.Equals("light")) rb_darkModeLight.Checked = true;
                else throw new Exception();

                if (language.Equals("english")) cb_language.Text = "English";
                else if (language.Equals("azerbaijani")) cb_language.Text = "Azerbaijani";
                else if (language.Equals("turkish")) cb_language.Text = "Turkish";
                else if (language.Equals("russian")) cb_language.Text = "Russian";
                else throw new Exception();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is problem in config files.\nPlease download application again.\n\n*" + ex.Message +
                    "*", "Error");
            }

            allowChanging = true;
        }

        private void rb_darkModeDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_darkModeDark.Checked && allowChanging)
            {
                main.changeToDarkMode();

                writeSettingsFile("dark", 1);
            }
            else if (rb_darkModeLight.Checked && allowChanging)
            {
                main.changeToLightMode();

                writeSettingsFile("light", 1);
            }
        }

        private void cb_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_language.SelectedItem.ToString() == "English" && allowChanging)
            {
                main.changeLanguageToEnglish();

                writeSettingsFile("english", 2);
            }
            else if (cb_language.SelectedItem.ToString() == "Azerbaijani" && allowChanging)
            {
                main.changeLanguageToAzerbaijani();

                writeSettingsFile("azerbaijani", 2);
            }
            else if (cb_language.SelectedItem.ToString() == "Russian" && allowChanging)
            {
                main.changeLanguageToRussian();

                writeSettingsFile("russian", 2);
            }
            else if (cb_language.SelectedItem.ToString() == "Turkish" && allowChanging)
            {
                main.changeLanguageToTurkish();

                writeSettingsFile("turkish", 2);
            }
        }

        private void writeSettingsFile(string data, int line)
        {
            try
            {
                StreamReader sr = new StreamReader(@"config\setting.cfg");

                string mode = sr.ReadLine();
                string language = sr.ReadLine();

                sr.Close();

                if (line == 1) mode = data;
                else if (line == 2) language = data;

                StreamWriter sw = new StreamWriter(@"config\setting.cfg");

                sw.Write(mode + "\n" + language);

                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is problem in config files.\nPlease download application again.\n\n*" + ex.Message +
                    "*", "Error");
            }
        }
    }
}