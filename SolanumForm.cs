using System;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Solanum
{
    public partial class SolanumForm : Form
    {
        private Timer _timer;
        private TimeSpan _duration;
        private int _n;

        public SolanumForm()
        {
            InitializeComponent();
        }

        private void SolanumForm_Load(object sender, EventArgs e)
        {
            _n = 0;
            pomodoroLengthComboBox.Items.AddRange(MakePomodoroLengthComboBoxItems());
            pomodoroLengthComboBox.SelectedIndex = 3;
            KeyPreview = true;
            _timer = MakeTimer();
        }

        private void newPomodoroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_n > 0)
                return;
            MakeTomato();
        }

        private void shortBreakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_n > 0)
                return;
            MakeTomato(5);
        }

        private void longBreakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_n > 0)
                return;
            MakeTomato(15);
        }

        private void ToggleMenuItems(bool enabled)
        {
            foreach (var item in fileToolStripMenuItem.DropDown.Items)
            {
                try
                {
                    var i = (ToolStripMenuItem)item;
                    if (i.Name == "exitToolStripMenuItem1") continue;
                    i.Enabled = enabled;

                }
                catch (InvalidCastException)
                {
                    continue;
                }
            }
        }

        private void CompleteBox()
        {
            Activate();
            MessageBox.Show(@"Your timer is complete.", @"Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static object[] MakePomodoroLengthComboBoxItems()
        {
            return new object[]
            {
                new ComboBoxItem{Text = @"5 minutes", Value = 5},
                new ComboBoxItem{Text = @"10 minutes", Value = 10},
                new ComboBoxItem{Text = @"15 minutes", Value = 15},
                new ComboBoxItem{Text = @"25 minutes", Value = 25}
            };
        }

        private Timer MakeTimer()
        {
            var t = new Timer
            {
                Interval = 1000,
                SynchronizingObject = this
            };

            t.Elapsed += (s, a) =>
            {
                _n++;
                var ts = new TimeSpan(0, 0, _n);
                timerTextBox.Text = ts.ToString(@"mm\:ss");
                Text = ts.ToString(@"mm\:ss");

                if (_n != Convert.ToInt32(Math.Round(_duration.TotalSeconds))) return;
                t.Stop();
                _n = 0;
                Text = @"Complete";
                ToggleMenuItems(true);
                CompleteBox();
            };

            return t;
        }

        private void MakeTomato(int minutes = 0)
        {
            ToggleMenuItems(false);
            timerTextBox.Text = @"00:00";
            Text = @"00:00";
            var i = (ComboBoxItem)pomodoroLengthComboBox.SelectedItem;
            _duration = minutes <= 0 ? new TimeSpan(0, Convert.ToInt32(i.Value), 0) : 
                new TimeSpan(0, minutes, 0);
            _timer.Start();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Shift | Keys.P))
            {
                newPomodoroToolStripMenuItem_Click(this, EventArgs.Empty);
                return true;
            }
            if (keyData == (Keys.Shift | Keys.S))
            {
                shortBreakToolStripMenuItem_Click(this, EventArgs.Empty);
                return true;
            }
            if (keyData == (Keys.Shift | Keys.L))
            {
                longBreakToolStripMenuItem_Click(this, EventArgs.Empty);
                return true;
            }
            if (keyData == (Keys.Shift | Keys.Space))
            {
                if (_timer.Enabled)
                {
                    _timer.Stop();
                    return true;
                }
                if (!_timer.Enabled && _n > 0)
                {
                    _timer.Start();
                    return true;
                }
                newPomodoroToolStripMenuItem_Click(this, EventArgs.Empty);
                return true;
            }
            if (keyData == (Keys.Shift | Keys.D))
            {
                _timer.Stop();
                _timer.Dispose();
                _n = 0;
                _timer = MakeTimer();
                Text = @"00:00";
                timerTextBox.Text = @"00:00";
                ToggleMenuItems(true);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    public class ComboBoxItem {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
    
}
