namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int time,
            setTime = -1,
            setMultiplier = -1;

        public Form1()
        {
            InitializeComponent();
            Stop.Enabled = false;
            comboBox.SelectedIndex = 0;
            timer.Interval = 1000;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex                  != setMultiplier ||
                Convert.ToInt32(numericUpDown1.Value)   != setTime          ) {
                    selectTime();
            }
            SwitchButtons();
            timer.Start();
        }

        private void selectTime()
        {
            setMultiplier = comboBox.SelectedIndex;
            setTime = Convert.ToInt32(numericUpDown1.Value);

            int multiplier = 0;
            switch (setMultiplier)
            {
                case 0:
                    multiplier = 1;
                    break;
                case 1:
                    multiplier = 60;
                    break;
                case 2:
                    multiplier = 3600;
                    break;
            }
            time = multiplier * setTime;
            Timer_Progress.Value = 0;
            Timer_Progress.Maximum = time;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time -= 1;
            Timer_Progress.Value = time;
            if (time <= 0)
            {
                Application.Exit();
            }
            int hour   = (time / 3600),
                minute = (time % 3600 / 60),
                second = (time % 60);

            string shour    = hour   < 10 ? $"0{hour}"   : $"{hour}",
                   sminute  = minute < 10 ? $"0{minute}" : $"{minute}",
                   ssecond  = second < 10 ? $"0{second}" : $"{second}";

            TimerPanel.Text = $"{shour} : {sminute} : {ssecond}";
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SwitchButtons();
        }

        private void SwitchButtons()
        {
            Start.Enabled = !Start.Enabled;
            Stop.Enabled = !Stop.Enabled;
            comboBox.Enabled = !comboBox.Enabled;
            numericUpDown1.Enabled = !numericUpDown1.Enabled;
        }
    }
}