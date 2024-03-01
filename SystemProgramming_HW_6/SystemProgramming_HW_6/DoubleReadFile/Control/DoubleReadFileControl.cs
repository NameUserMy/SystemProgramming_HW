using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SystemProgramming_HW_6.DoubleReadFile.Control
{

    public delegate byte[] supperDelegate();
    internal class DoubleReadFileControl : INotifyPropertyChanged
    {
        private Stream? _stream;
        private byte[]? _data;
        private Random _random;
        private string _message;
        private bool _isEnable;
        private ObservableCollection<string> _firstThread;
        private ObservableCollection<string> _secondtThread;
        public int CountNumber { get; set; }

        #region Binding
        public ObservableCollection<string> FirstThread {
            get { return _firstThread; }
            set { _firstThread = value; NotifyPropertyChanged(nameof(FirstThread)); }
        }
        public ObservableCollection<string> SecondThread
        {
            get { return _secondtThread; }
            set { _secondtThread = value; NotifyPropertyChanged(nameof(SecondThread)); }
        }
        public string GetMessage
        {
            get { return _message; }
            set { _message = value; NotifyPropertyChanged(nameof(GetMessage)); }
        }
        public bool IsEnable
        {
            get { return _isEnable; }
            set { _isEnable = value; NotifyPropertyChanged(nameof(IsEnable)); }
        }
        #endregion
        public void SaveFile()
        {
            GenRandom();
            GetMessage = "Start save file";
            _stream = new FileStream("Number.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite);
            _stream.BeginWrite(_data, 0, _data.Length,new AsyncCallback(StreamCallBack), _stream);
        }
        private byte[] ReadFile()
        {
            _stream = new FileStream("Number.txt", FileMode.Open, FileAccess.Read);
            _stream.BeginRead(_data, 0, _data.Length, StreamCallBack, _stream);
            return _data;

        }
        private void StreamCallBack(IAsyncResult asyncResult)
        {
            Stream _stream = asyncResult.AsyncState as Stream;
            if (_stream != null)
                _stream.Close();
            GetMessage = "End save file";
            IsEnable = true;
        }
       
       
        public void StartRead()
        {
            Task<byte[]>.Run(()=> ReadFile()).ContinueWith(CallBackRead);
            Task<byte[]>.Run(()=> ReadFile()).ContinueWith(CallBackRead1);
        //***** No support this  platform********///
            //supperDelegate test =ReadFile;
            //supperDelegate test1 = ReadFile;
            //AsyncCallback ac = CallBackRead;
            //MessageBox.Show($"{test.BeginInvoke(null, null)}");
            // MessageBox.Show($"{test1.BeginInvoke(null, null)}");
            //test.DynamicInvoke(new AsyncCallback(CallBackRead), test);
            //test1.BeginInvoke(ac, test1);
            //**********************************************************////

        }
        private void CallBackRead(Task <byte[]>task)
        {
            var result = task.Result;
            for (int i = 0; i < result.Length; i++)
            {
                if (i % 10000 == 0)
                    Application.Current.Dispatcher.Invoke(() => FirstThread.Add($"{result[i]}  iteration {i}"));
               
            }
        }
        private void CallBackRead1(Task<byte[]> task)
        {
            var result = task.Result;
            for (int i = 0; i < result.Length; i++)
            {
                if(i%10000==0)
                Application.Current.Dispatcher.Invoke(() => SecondThread.Add($"{result[i]}  iteration {i}"));
     
            }
        }
        private void GenRandom()
        {
            _data = new byte[CountNumber];
            for (int i = 0; i < CountNumber; i++)
            {
                _data[i]=(Convert.ToByte(_random.Next(0,255)));
            }
        }

        public DoubleReadFileControl()
        {
            _firstThread = new ObservableCollection<string>();
            _secondtThread = new ObservableCollection<string>();
            CountNumber =1000000;
           _random = new Random();
            _message = "Status";
            _isEnable = false;

        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
