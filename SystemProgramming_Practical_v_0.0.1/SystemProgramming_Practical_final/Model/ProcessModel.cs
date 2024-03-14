using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming_Practical_final.Model
{
    internal class ProcessModel : ViewModel
    {
        private ObservableCollection<string> _processes;
        public ObservableCollection<string> ProcessStartInfo
        {
            get => _processes;
            set { _processes = value; NotifyPropertyChanged(nameof(ProcessStartInfo)); } 
        }
        public ProcessModel()=>_processes = new ObservableCollection<string>();
    }
}
