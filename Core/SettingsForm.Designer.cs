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
            this.visualsBox.SuspendLayout();
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 446);
            this.Controls.Add(this.visualsBox);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.visualsBox.ResumeLayout(false);
            this.visualsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox visualsBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label bkLabel;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.Panel fgPanel;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}