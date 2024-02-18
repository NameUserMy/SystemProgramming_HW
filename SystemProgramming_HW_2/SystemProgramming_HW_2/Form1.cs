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
using SystemProgramming_HW_2.Model;

namespace SystemProgramming_HW_2
{
    public partial class Form1 : Form
    {
        SimpleNumber simpleNumber;
        Thread simpleThread;
        Thread fibonacciThread;
        Param param;
        public Form1()
        {
            InitializeComponent();
            this.Load += LoadApp;
            simpleNumber= new SimpleNumber();
        }

        private void LoadApp(object sender, EventArgs e)
        {
           
        }
        private void startSimpleButton_Click(object sender, EventArgs e)
        {
            simpleThread = new Thread(simpleNumber.SimpleNumberGenerator);
            param = new Param();
            param.Start = Convert.ToInt32(startRangeSimpleNumeric.Value);
            param.End = Convert.ToInt32(endRangeSimpleNumeric.Value);
            param.AddListBox = simpleNumberListB;
            startSimpleButton.Enabled = false;
            simpleThread.Start(param);
           
        }
        private void endSimpleButton_Click(object sender, EventArgs e)
        {
            if (simpleThread.IsAlive == true)
            {
                if (simpleThread.ThreadState == ThreadState.Suspended)
                {
                    simpleThread.Resume();
                }
                
                simpleThread.Abort();
                simpleNumberListB.Items.Clear();
                if (pauseSimpleButton.Text == "Resume")
                {
                    pauseSimpleButton.Text = "Pause";
                }
                startSimpleButton.Enabled = true;
            }
            else {
                simpleThread.Abort();
                simpleNumberListB.Items.Clear();
                if (pauseSimpleButton.Text == "Resume")
                {
                    pauseSimpleButton.Text = "Pause";
                }
                startSimpleButton.Enabled = true;
            }
        }
        private void pauseSimpleButton_Click(object sender, EventArgs e)
        {



            try
            {
                if (simpleThread.ThreadState == ThreadState.Suspended)
                {
                    simpleThread.Resume();
                    pauseSimpleButton.Text = "Pause";

                }
                else
                {
                    simpleThread.Suspend();
                    pauseSimpleButton.Text = "Resume";
                }
            }
            catch (Exception)
            {

                MessageBox.Show($"Thread not start");
            }   

           
            
        }

        private void startFibonacci_Click(object sender, EventArgs e)
        {
            fibonacciThread = new Thread(simpleNumber.FibonachyGenerator);
            param = new Param();
            param.Start = Convert.ToInt32(startFibonacciNum.Value);
            param.End = Convert.ToInt32(endFibonacciNum.Value);
            param.AddListBox = numberFibonacci;
            startFibonacci.Enabled = false;
            fibonacciThread.Start(param);
        }

        private void pauseFibonacci_Click(object sender, EventArgs e)
        {
            try
            {
                if (fibonacciThread.ThreadState == ThreadState.Suspended)
                {
                    fibonacciThread.Resume();
                    pauseFibonacci.Text = "Pause";

                }
                else
                {
                    fibonacciThread.Suspend();
                    pauseFibonacci.Text = "Resume";
                }
            }
            catch (Exception)
            {

                MessageBox.Show($"Thread not start");
            }
        }

        private void endFibonacci_Click(object sender, EventArgs e)
        {
            if (fibonacciThread.IsAlive == true)
            {
                if (simpleThread.ThreadState == ThreadState.Suspended)
                {
                    fibonacciThread.Resume();
                }
                fibonacciThread.Abort();
                numberFibonacci.Items.Clear();
                if (pauseFibonacci.Text == "Resume")
                {
                    pauseFibonacci.Text = "Pause";
                }
                startFibonacci.Enabled = true;
            }
            else
            {
                fibonacciThread.Abort();
                numberFibonacci.Items.Clear();
                if (pauseFibonacci.Text == "Resume")
                {
                    pauseFibonacci.Text = "Pause";
                }
                startFibonacci.Enabled = true;
            }

        }
    }
}
