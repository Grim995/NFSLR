using NFSLR.Core;
using System;
using System.Reflection;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace NFSLR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f1 = new Form1();
            if (f1.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
                return;
            }
            GameDef def = f1.Selected;
            AppDomain domain = AppDomain.CreateDomain("Timer");
            ObjectHandle h = domain.CreateInstanceFrom(AppDomain.CurrentDomain.BaseDirectory + "Core.dll", "NFSLR.Core.TimerForm", true, BindingFlags.CreateInstance, null, new string[] { AppDomain.CurrentDomain.BaseDirectory + "plugins\\" + def.Dll, def.Classpath, def.Module }, null, null, null);
            TimerForm t = h.Unwrap() as TimerForm;
            t.ShowDialog();
            AppDomain.Unload(domain);
            Application.Exit();
        }
    }
}
