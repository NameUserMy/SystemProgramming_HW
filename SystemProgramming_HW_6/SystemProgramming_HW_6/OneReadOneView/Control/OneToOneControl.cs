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

namespace SystemProgramming_HW_6.OneReadOneView.Control
{
    internal class OneToOneControl: INotifyPropertyChanged
    {
        private Stream? _stream;
        private byte[]? _data;
        private Random _random;
        private string _message;
        private bool _isEnable;
        private ObservableCollection<string> _firstThread;
        private ObservableCollection<string> _secondtThread;
        private Mutex _mutex;
        private bool _IsCreated;
        public int CountNumber { get; set; }

        #region Binding
        public ObservableCollection<string> FirstThread
        {
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
            GetMessage = "Start generation number";
            GenRandom();
            GetMessage = "Start save file";
            _stream = new FileStream("Mutex.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            _stream.BeginWrite(_data, 0, _data.Length, new AsyncCallback(StreamCallBack), _stream);
        }
        private void StreamCallBack(IAsyncResult asyncResult)
        {
            Stream _stream = asyncResult.AsyncState as Stream;
            if (_stream != null)
                _stream.Close();
            GetMessage = "End save file";
            IsEnable = true;
        }
        private byte[] ReadFile()
        {
            _mutex.WaitOne();
            _stream = new FileStream("Mutex.txt", FileMode.Open, FileAccess.Read);
            _stream.BeginRead(_data, 0, _data.Length, null, null);
            _mutex.ReleaseMutex();
            return _data;

        }

        public void StartRead()
        {
            Task<byte[]>.Run(() => ReadFile()).ContinueWith(CallBackRead);
        }
        private void CallBackRead(Task<byte[]> task)
        {
            var result = task.Result;
            for (int i = 0; i < result.Length; i++)
            {
                if (i % 10000 == 0)
                    Application.Current.Dispatcher.Invoke(() => FirstThread.Add($"Read file...  iteration {i}"));

            }
            Application.Current.Dispatcher.Invoke(() => FirstThread.Add("End read file."));
        }
        private void GenRandom()
        {
            _data = new byte[CountNumber];
            for (int i = 0; i < CountNumber; i++)
            {
                _data[i] = (Convert.ToByte(_random.Next(0, 255)));
            }
        }
        public OneToOneControl()
        {

             _mutex = new Mutex(false,"5B67F18A-6E0E-461F-9813-1A40B7D8FB47",out _IsCreated);
            _firstThread = new ObservableCollection<string>();
            _secondtThread = new ObservableCollection<string>();
            CountNumber = 500000000;
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





