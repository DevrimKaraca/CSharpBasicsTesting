using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialPortReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Neredeyse tamamen hatalı bir işe yaramayan bu kodu gün gün düzelteceğiz :).
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        
        byte[] data = new byte[10];

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) 
            {
                serialPort1.Open();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            richTextBox1.Text += serialPort1.ReadExisting();
        }
    }
}
