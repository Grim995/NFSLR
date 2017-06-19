namespace NFSLR.Core
{
    partial class SettingsForm
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
            this.visualsBox = new System.Windows.Forms.GroupBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.bkLabel = new System.Windows.Forms.Label();
            this.textPanel = new System.Windows.Forms.Panel();
            this.fgPanel = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.visualsBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // visualsBox
            // 
            this.visualsBox.Controls.Add(this.textLabel);
            this.visualsBox.Controls.Add(this.bkLabel);
            this.visualsBox.Controls.Add(this.textPanel);
            this.visualsBox.Controls.Add(this.fgPanel);
            this.visualsBox.Location = new System.Drawing.Point(12, 12);
            this.visualsBox.Name = "visualsBox";
            this.visualsBox.Size = new System.Drawing.Size(503, 209);
            this.visualsBox.TabIndex = 0;
            this.visualsBox.TabStop = false;
            this.visualsBox.Text = "Visuals";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(44, 66);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(54, 13);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Text color";
            // 
            // bkLabel
            // 
            this.bkLabel.AutoSize = true;
            this.bkLabel.Location = new System.Drawing.Point(44, 29);
            this.bkLabel.Name = "bkLabel";
            this.bkLabel.Size = new System.Drawing.Size(91, 13);
            this.bkLabel.TabIndex = 2;
            this.bkLabel.Text = "Background color";
            // 
            // textPanel
            // 
            this.textPanel.Location = new System.Drawing.Point(6, 57);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(32, 32);
            this.textPanel.TabIndex = 1;
            this.textPanel.Tag = "1";
            this.textPanel.Click += new System.EventHandler(this.ColorPanelClick);
            // 
            // fgPanel
            // 
            this.fgPanel.Location = new System.Drawing.Point(6, 19);
            this.fgPanel.Name = "fgPanel";
            this.fgPanel.Size = new System.Drawing.Size(32, 32);
            this.fgPanel.TabIndex = 0;
            this.fgPanel.Tag = "0";
            this.fgPanel.Click += new System.EventHandler(this.ColorPanelClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reset hotkey";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stop hotkey";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start hotkey";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Tag = "2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Tag = "1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "0";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HKBoxKeyDown);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.visualsBox);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.visualsBox.ResumeLayout(false);
            this.visualsBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox visualsBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label bkLabel;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.Panel fgPanel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}