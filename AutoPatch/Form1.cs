
using CefSharp.WinForms;
using System.Runtime.InteropServices;

namespace AutoPatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChromiumWebBrowser browserKayanK = new ChromiumWebBrowser();
            browserKayanK.Load("https://conquer.online/Media/Screenshots");
            browserKayanK.Dock = DockStyle.Fill;
            this.BrowserLocation.Controls.Add(browserKayanK);

            t.Interval = 1; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            this.SizeChanged += new EventHandler(this_SizeChanged);
            t1.Interval = 1;
            t1.Tick += new EventHandler(timer1_Tick);
            t1.Start();
            btnJogar.Location = new Point(411, 03);

            checkUpdate.Interval = 500;
            checkUpdate.Tick += new EventHandler(CheckUpdate_Tick);
            checkUpdate.Start();
        }
        string UpdateTxt = "Buscando Atualização..";
        private void CheckUpdate_Tick(object sender, EventArgs e)
        {
            if(lblCheckUpdate.Text.Length > UpdateTxt.Length + 3)
            {
                lblCheckUpdate.Text = UpdateTxt;
            }
            else
            {
                lblCheckUpdate.Text += ".";
            }
        }

        private void this_SizeChanged(object source, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Minimized = false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        private const int AW_VER_POSITIVE = 0x00000004;
        private const int AW_VER_NEGATIVE = 0x00000008;
        private const int AW_SLIDE = 0x00040000;
        private const int AW_HIDE = 0x00010000;



        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer checkUpdate = new System.Windows.Forms.Timer();
        bool Minimized;
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            t.Start();

        }

        private void timer_Tick(object source, EventArgs e)
        {
            this.Height = this.Height - 40;
            if (this.Height < 50)
            {
                t.Stop();
                t.Enabled = false;
                this.WindowState = FormWindowState.Minimized;
                Minimized = true;
            }
        }

        private void timer1_Tick(object source, EventArgs e)
        {
            if (Minimized == false && t.Enabled == false)
            {
                this.Height = 658;
            }
        }
    }
}
