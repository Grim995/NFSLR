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

namespace NFSLR
{
    public partial class Form1 : Form
    {
        private GameDef def;

        private List<GameDef> defs;

        public GameDef Selected
        {
            get
            {
                return def;
            }
        }

        public Form1()
        {
            InitializeComponent();
            defs = new List<GameDef>();
            DirectoryInfo di = new DirectoryInfo("defs");
            foreach(FileInfo inf in di.GetFiles("*.def"))
            {
                GameDef gameDef = new GameDef();
                gameDef.Parse(File.ReadAllLines(inf.FullName));
                defs.Add(gameDef);
            }
            comboBox1.Items.AddRange(defs.ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            def = defs[comboBox1.SelectedIndex];
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult != DialogResult.OK)
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
