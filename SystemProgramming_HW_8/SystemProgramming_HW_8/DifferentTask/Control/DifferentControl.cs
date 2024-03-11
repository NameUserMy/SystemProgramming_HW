using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace SystemProgramming_HW_8.DifferentTask.Control
{
    internal class DifferentControl : INotifyPropertyChanged
    {
       
        private string? _startTime;
        private string? _factoryTime;
        private string? _runTime;
        private string? _asyncTime;


        public string StartTime{
            get => _startTime;
            set { _startTime = value; NotifyPropertyChanged(nameof(StartTime)); }
    
        }
        public string FactoryTime
        {
            get => _factoryTime;
            set { _factoryTime = value; NotifyPropertyChanged(nameof(FactoryTime)); }

        }
        public string RunTime
        {
            get => _runTime;
            set { _runTime = value; NotifyPropertyChanged(nameof(RunTime)); }

        }
        public string RunAsuncTime
        {
            get => _asyncTime;
            set { _asyncTime = value; NotifyPropertyChanged(nameof(RunAsuncTime)); }

        }
        private void UpdateStartTime()
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedStartEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void OnTimedStartEvent(object? sender, ElapsedEventArgs e)
        {
            DateTime startTime = DateTime.Now;
            StartTime = $"{startTime.Hour} : {startTime.Minute} : {startTime.Second}";
        }
        public void StartTaskTime()
        {
            new Task(UpdateStartTime).Start();
        }

       


        private void UpdateFactoryTime()
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedFactoryEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void OnTimedFactoryEvent(object? sender, ElapsedEventArgs e)
        {
            DateTime startTime = DateTime.Now;
            FactoryTime = $"{startTime.Hour} : {startTime.Minute} : {startTime.Second}";
        }
        public void FactoryTaskTime()
        {
            Task.Factory.StartNew(UpdateFactoryTime);
        }



        private void UpdateRunTime()
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedRunEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void OnTimedRunEvent(object? sender, ElapsedEventArgs e)
        {
            DateTime startTime = DateTime.Now;
            RunTime = $"{startTime.Hour} : {startTime.Minute} : {startTime.Second}";
        }
        public void RunTaskTime()
        {
             Task.Run(UpdateRunTime);
        }



        private void UpdateAsyncRunTime()
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedAsyncRunEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void OnTimedAsyncRunEvent(object? sender, ElapsedEventArgs e)
        {
            DateTime startTime = DateTime.Now;
            RunAsuncTime = $"{startTime.Hour} : {startTime.Minute} : {startTime.Second}";
        }
        public async void StartAsyncTaskTime()
        {
             Task.Run(UpdateAsyncRunTime);
        }




        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public DifferentControl() {
            DateTime now = DateTime.Now;
            StartTime = $"{now.Hour} : {now.Minute} : {now.Second}";
            FactoryTime = $"{now.Hour} : {now.Minute} : {now.Second}";
            RunTime = $"{now.Hour} : {now.Minute} : {now.Second}";
            RunAsuncTime = $"{now.Hour} : {now.Minute} : {now.Second}";
        }
    }
}
