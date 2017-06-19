using System;
using System.Drawing;
using System.Windows.Forms;

namespace NFSLR.Core
{
    public partial class SettingsForm : Form
    {
        Settings settings;
        public SettingsForm(Settings s)
        {
            InitializeComponent();
            settings = s;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            fgPanel.BackColor = Color.FromArgb(settings.BkColor);
            textPanel.BackColor = Color.FromArgb(settings.TColor);
        }

        private void ColorPanelClick(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                switch((string)p.Tag)
                {
                    case "0":
                        fgPanel.BackColor = colorDialog.Color;
                        settings.BkColor = colorDialog.Color.ToArgb();
                        return;
                    case "1":
                        textPanel.BackColor = colorDialog.Color;
                        settings.TColor = colorDialog.Color.ToArgb();
                        return;
                }
            }
        }

        private void HKBoxKeyDown(object sender, KeyEventArgs e)
        {
            switch((string)(sender as TextBox).Tag)
            {
                case "0":
                    settings.StarHKey = (int)e.KeyData;
                    break;
                case "1":
                    settings.StopHKey = (int)e.KeyData;
                    break;
                case "2":
                    settings.ResetHKey = (int)e.KeyData;
                    break;
            }
            (sender as TextBox).Text = KeyToText(e.KeyData);
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private string KeyToText(Keys key)
        {
            KeysConverter conv = new KeysConverter();
            return conv.ConvertToString(key);
        }
    }
}
