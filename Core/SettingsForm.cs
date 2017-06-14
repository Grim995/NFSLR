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
    }
}
