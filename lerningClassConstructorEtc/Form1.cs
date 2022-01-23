using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lerningClassConstructorEtc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        PERSON Nurgul;
        PERSON Devrim;
        private void Form1_Load(object sender, EventArgs e)
        {
            Nurgul = new PERSON();

            //Scopetan scope a gelindiği anda Dispose() çalışır.
            using (PERSON person1 = new PERSON())
            {
                person1.hairColor = "Blue";
                if (Nurgul.hairColor == person1.hairColor) throw new Exception();
            }

            Devrim = new PERSON();

            if (Nurgul.hairColor != Devrim.hairColor)
            {
                Console.WriteLine("EşitDeğil");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Nurgul.Dispose();
            Devrim.Dispose();
        }
    }
}
