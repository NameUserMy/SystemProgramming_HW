using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Threading;
using SystemProgramming_Practical_final.Model;

namespace SystemProgramming_Practical_final.Control.ProcessL
{
    internal class ProcessListener    
    {
        private ProcessModel _processModel;
        public void Updateprocess()
        {
            System.Timers.Timer timer = new System.Timers.Timer(5000);
            timer.Elapsed += (sender, e) => GetAllProcess();
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private  void GetAllProcess()
        {
            foreach (var item in Process.GetProcesses())
            {
                Application.Current.Dispatcher.Invoke(() => _processModel.ProcessStartInfo.Add($"Name : {item.ProcessName}"));
            }
        }
        public ProcessListener(ProcessModel processModel)
        {
           _processModel = processModel;
        }

    }
    
}
