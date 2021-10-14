using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_9
{
    public partial class Form1 : Form
    {
        Thread myThread1;
        Thread myThread2;

        bool thred1_life;
        int waitingtime1 = 1000;
        bool thred2_life;
        int waitingtime2 = 1000;


        public Form1()
        {
            InitializeComponent();
            progressBar1.MarqueeAnimationSpeed = 1;
            //progressBar1.Value += 50;
        }

        private void drawDonut()
        {
            Random random = new Random();
            int counter = 0;

            while (thred1_life)
            {
                chart1.Invoke(new Action(() => { chart1.Series[0].Points.AddXY(counter++, random.Next(counter, counter+100)); }));

                Thread.Sleep(waitingtime1);
            }
        }

        private void th1_start_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(" new thread ");

            th1_start.Enabled = false;

            thred1_life = true;

            myThread1 = new Thread(new ThreadStart(drawDonut));
            myThread1.Start();

            th1_stop.Enabled = true;
        }

        private void th1_pause_Click(object sender, EventArgs e)
        {
            if (myThread1.ThreadState == ThreadState.Suspended) { myThread1.Resume(); }
            else { myThread1.Suspend(); }
        }

        private void th1_stop_Click(object sender, EventArgs e)
        {
            th1_stop.Enabled = false;
            thred1_life = false;
            chart1.Series[0].Points.Clear();

            th1_start.Enabled = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            waitingtime1 = 1000 - trackBar1.Value;
        }



        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            waitingtime2 = 1000 - trackBar2.Value;
        }

        private void start_bt_Click(object sender, EventArgs e)
        {
            start_bt.Enabled = false;

            thred2_life = true;

            myThread2 = new Thread(new ThreadStart(drawProgressBar));
            myThread2.Start();

            stop_bt.Enabled = true;
        }

        private void pause_bt_Click(object sender, EventArgs e)
        {
            if (myThread2.ThreadState == ThreadState.Suspended) { myThread2.Resume(); }
            else { myThread2.Suspend(); }
        }

        private void stop_bt_Click(object sender, EventArgs e)
        {
            stop_bt.Enabled = false;
            thred2_life = false;
            chart1.Series[0].Points.Clear();

            start_bt.Enabled = true;
        }

        private void drawProgressBar()
        {

            while (thred2_life)
            {
                progressBar1.Invoke(new Action(() => {
                    if (progressBar1.Value == 100) { progressBar1.Value = 0; Thread.Sleep(waitingtime2); }
                    progressBar1.Value++;

                }));

                Thread.Sleep(waitingtime2);
            }
        }
    }
}
