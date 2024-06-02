using System.ComponentModel;

namespace WinFormsControlLibrary2
{
    [ToolboxBitmap(typeof(Button))]
    public partial class LockableButton : UserControl
    {
        private Button button;
        private System.Windows.Forms.Timer unlockTimer;
        private int clickCount = 0;
        private int maxClicks = 5;  // Максимальна кількість натискань до блокування
        private int unlockTime = 5000;  // Час розблокування у мілісекундах

        [Category("Behavior")]
        [Description("Maximum number of clicks before the button is locked.")]
        public int MaxClicks
        {
            get { return maxClicks; }
            set { maxClicks = value; }
        }

        [Category("Behavior")]
        [Description("Time in milliseconds before the button is unlocked.")]
        public int UnlockTime
        {
            get { return unlockTime; }
            set { unlockTime = value; }
        }

        public LockableButton()
        {
            InitializeComponent();

            button = new Button();
            button.Dock = DockStyle.Fill;
            button.Click += Button_Click;
            this.Controls.Add(button);

            unlockTimer = new System.Windows.Forms.Timer();
            unlockTimer.Tick += UnlockTimer_Tick;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount >= maxClicks)
            {
                LockButton();
                unlockTimer.Interval = unlockTime;
                unlockTimer.Start();
            }
        }

        private void LockButton()
        {
            button.Enabled = false;
            // Можна додати логіку для візуального позначення заблокованої кнопки
        }

        private void UnlockButton()
        {
            button.Enabled = true;
            clickCount = 0;
            // Можна додати логіку для візуального позначення розблокованої кнопки
        }

        private void UnlockTimer_Tick(object sender, EventArgs e)
        {
            unlockTimer.Stop();
            UnlockButton();
        }
    }
}