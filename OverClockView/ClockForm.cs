using Timer = System.Windows.Forms.Timer;

namespace OverClockView
{
    public partial class ClockForm : Form
    {
        public ClockForm()
        {
            InitializeComponent();
            this.TopMost = true;
            this.TopLevel = true;
            Setting setting = new Setting();
            TimeLabel.Font = new Font(TimeLabel.Font.OriginalFontName!, setting.FontSize);
            TimeLabel.ForeColor = setting.FontColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Tick += new EventHandler((s, e) => { TimeLabel.Text = DateTime.Now.ToShortTimeString(); });
            timer.Interval = 100;
            timer.Start();
        }
    }
}