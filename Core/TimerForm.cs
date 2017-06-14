﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFSLR.Core
{
    public partial class TimerForm : Form
    {
        Stopwatch sw;
        long time = 0;
        GameTime timer;
        IGame game;
        GameProcess proc;
        public TimerForm(string filepath, string classpath, string process)
        {
            MessageBox.Show("Loading " + filepath + "\nClasspath " + classpath, "Alert!");
            InitializeComponent();
            KeyHook.SharedInstance.OnKeyPressed += OnGlobalKey;
            proc = GameProcess.OpenGameProcess(process);
            LoadGame(filepath, classpath);
            sw = new Stopwatch();
            timer = new GameTime(game);
            timer1.Start();
        }

        private void OnGlobalKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
                Start();
            if (e.KeyCode == Keys.Decimal)
                Stop();
            if (e.KeyCode == Keys.NumPad3)
                Reset();
        }

        private void Start()
        {
            sw.Start();
        }

        private void Stop()
        {
            sw.Stop();
        }

        private void Reset()
        {
            Stop();
            sw.Reset();
            timer.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = TimeSpan.FromMilliseconds(timer.Time).ToString(@"hh\:mm\:ss\.fff");
            if (sw.IsRunning)
                timer.Update(sw.ElapsedMilliseconds - time);
            panel1.BackColor =  proc.IsOpen ? Color.Green : Color.Red;
            time = sw.ElapsedMilliseconds;
        }

        private void LoadGame(string path, string classname)
        {
            Assembly asm = Assembly.LoadFile(path);
            Type t = asm.GetType(classname);
            IGame game = Activator.CreateInstance(t) as IGame;
            game.Init(proc);
            this.game = game;
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {

        }
    }
}