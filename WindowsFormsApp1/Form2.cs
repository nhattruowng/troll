using System;
using System.Windows.Forms;
using WMPLib; // Nhớ thêm tham chiếu đến WMPLib

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private WindowsMediaPlayer mediaPlayer; 
        private Timer closeTimer; 

        public Form2()
        {
            InitializeComponent();
            closeTimer = new Timer();
            closeTimer.Interval = 5000; 
            closeTimer.Tick += CloseTimer_Tick; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string soundFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mp3", "mp3.wav");
            mediaPlayer = new WindowsMediaPlayer();
            mediaPlayer.URL = soundFilePath; 
            mediaPlayer.controls.play(); 

            closeTimer.Start(); 
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            mediaPlayer.controls.stop(); 
            closeTimer.Stop(); 
            this.Close(); 
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mediaPlayer != null)
            {
                mediaPlayer.controls.stop(); 
            }
        }
    }
}