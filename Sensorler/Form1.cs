using FileOperations;
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

namespace Sensorler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileOperation fileOperation = new FileOperation();

        private void buttonSensor1_Click(object sender, EventArgs e)
        {
            Thread fdfd = new Thread(() => {
                while (true)
                {
                    fileOperation.WriteToFile(FilePath(), ContentSensor1());
                    Thread.Sleep(1000);
                }
            });
            fdfd.Start();
        }
        private void buttonSensor2_Click(object sender, EventArgs e)
        {
            Thread asdf = new Thread(()=>{

                while (true)
                {
                    fileOperation.WriteToFile(FilePath(), ContentSensor2());
                    Thread.Sleep(1000);
                }
            });
            asdf.Start();
        }

        public string FilePath() 
        {
            string path = "C:\\Nurgul.txt";
            return path;
        }

        public string ContentSensor1() 
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1000, 10000);
            string content = "***" + sayi.ToString();
            return content;
        }

        public string ContentSensor2()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1000, 10000);
            string content = "###" + sayi.ToString();
            return content;
        }
    }
}
