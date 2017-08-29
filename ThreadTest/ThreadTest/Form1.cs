using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadTest
{
    public partial class Form1 : Form
    {
        Thread oThread;
        Alpha test; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test = new Alpha();
            oThread = new Thread(new ThreadStart(test.beta));
            oThread.Start();
            oThread.Interrupt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(test.currentNumber);
        }
    }
    public class Alpha
    {
        public int currentNumber = 0;
        public Alpha()
        {
            
        }
        public void beta()
        {
            
            while (true)
            {
                
                
               currentNumber = currentNumber + 1;
                
            }
        }
    }
}
