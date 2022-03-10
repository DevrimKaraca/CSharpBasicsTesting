using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraFps0ErrorShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        Thread thread;
        private void Form1_Load(object sender, EventArgs e)
        {
            thread = new Thread(SetPictureBoxesColorRepeatly);
            thread.IsBackground = true;
            thread.Start();
        }
        
        public void SetPictureBoxesColorRepeatly() 
        {

            // This thread will work always you see.
            // And use a 3th party tool ThrottleStop , And Below a 1Ghz Per Second Of CPU Speed And
            // You can see the methods is not working truely.

            string[] colorList = new string[4];
            colorList[0] = "LightSeaGreen";
            colorList[1] = "LightSkyBlue";
            colorList[2] = "LightYellow";
            colorList[3] = "LightPink";

            int counterForPictureBox1 = 0;
            int counterForPictureBox2 = 1;
            int counterForPictureBox3 = 2;
            int counterForPictureBox4 = 3;
            int delayForFps = 0;
            int fps = 100;
            int milliSecond = 1000;
            int fpsRateFor1Second = milliSecond / fps;
            this.Text = String.Format("Fps : {0}",fps);
            Stopwatch sw = new Stopwatch();
            while (true)
            {
                sw.Start();
                pictureBox1.BackColor = Color.FromName(colorList[counterForPictureBox1]);
                pictureBox2.BackColor = Color.FromName(colorList[counterForPictureBox2]);
                pictureBox3.BackColor = Color.FromName(colorList[counterForPictureBox3]);
                pictureBox4.BackColor = Color.FromName(colorList[counterForPictureBox4]);
                counterForPictureBox1++; if (counterForPictureBox1 % 4 == 0) counterForPictureBox1 = 0;
                counterForPictureBox2++; if (counterForPictureBox2 % 4 == 0) counterForPictureBox2 = 0;
                counterForPictureBox3++; if (counterForPictureBox3 % 4 == 0) counterForPictureBox3 = 0;
                counterForPictureBox4++; if (counterForPictureBox4 % 4 == 0) counterForPictureBox4 = 0;
                sw.Stop();
                sw.Reset();
                //Example of delay for FPS. 66 = 1000ms/15frame = 66,66 ms delay for 15fps.And we must exclude code process time - from result.
                delayForFps = fpsRateFor1Second - Convert.ToInt32(sw.ElapsedTicks); 
                Thread.Sleep(delayForFps);
            }
        }
    }
}
