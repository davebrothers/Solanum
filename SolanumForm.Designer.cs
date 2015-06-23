namespace Solanum
{
    partial class SolanumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolanumForm));
            this.timerTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPomodoroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomodoroLengthComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.shortBreakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longBreakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerTextBox
            // 
            this.timerTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.timerTextBox.Enabled = false;
            this.timerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerTextBox.Location = new System.Drawing.Point(16, 33);
            this.timerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.ReadOnly = true;
            this.timerTextBox.Size = new System.Drawing.Size(437, 68);
            this.timerTextBox.TabIndex = 0;
            this.timerTextBox.Text = "00:00";
            this.timerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(471, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPomodoroToolStripMenuItem,
            this.pomodoroLengthComboBox,
            this.shortBreakToolStripMenuItem,
            this.longBreakToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newPomodoroToolStripMenuItem
            // 
            this.newPomodoroToolStripMenuItem.Name = "newPomodoroToolStripMenuItem";
            this.newPomodoroToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.newPomodoroToolStripMenuItem.Text = "&Pomodoro";
            this.newPomodoroToolStripMenuItem.Click += new System.EventHandler(this.newPomodoroToolStripMenuItem_Click);
            // 
            // pomodoroLengthComboBox
            // 
            this.pomodoroLengthComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pomodoroLengthComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pomodoroLengthComboBox.Name = "pomodoroLengthComboBox";
            this.pomodoroLengthComboBox.Size = new System.Drawing.Size(121, 28);
            // 
            // shortBreakToolStripMenuItem
            // 
            this.shortBreakToolStripMenuItem.Name = "shortBreakToolStripMenuItem";
            this.shortBreakToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.shortBreakToolStripMenuItem.Text = "&Short Break";
            this.shortBreakToolStripMenuItem.Click += new System.EventHandler(this.shortBreakToolStripMenuItem_Click);
            // 
            // longBreakToolStripMenuItem
            // 
            this.longBreakToolStripMenuItem.Name = "longBreakToolStripMenuItem";
            this.longBreakToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.longBreakToolStripMenuItem.Text = "&Long Break";
            this.longBreakToolStripMenuItem.Click += new System.EventHandler(this.longBreakToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(181, 24);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SolanumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 113);
            this.Controls.Add(this.timerTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SolanumForm";
            this.Text = "Solanum";
            this.Load += new System.EventHandler(this.SolanumForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timerTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPomodoroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortBreakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longBreakToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox pomodoroLengthComboBox;
    }
}

