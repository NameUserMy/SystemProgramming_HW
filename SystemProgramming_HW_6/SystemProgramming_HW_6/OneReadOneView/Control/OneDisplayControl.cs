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
    internal class OneDisplayControl : INotifyPropertyChanged
    {
        private Mutex _mutex;
        private bool _IsCreated;
        private Stream? _stream;
        private byte[]? _data;
        private string _message;
        private ObservableCollection<int> _display;

        public ObservableCollection<int> DisplayChange
        {
            get { return _display; }

            set { _display = value; NotifyPropertyChanged(nameof(DisplayChange)); }
        }
        public string GetMessage
        {
            get { return _message;}
            set { _message = value; NotifyPropertyChanged(nameof(GetMessage));}
        }
        private void ReadFile()
        {
            try
            {
                if (_IsCreated==true)
                {
                    GetMessage = "hhh!!";
                }
                else {
                   
                    _stream = new FileStream("Mutex.txt", FileMode.Open, FileAccess.Read);
                    _stream.BeginRead(_data, 0, _data.Length, null, null);
                    GetMessage = "weit";
                    _mutex.WaitOne();
                    GetMessage = "Read end, starting to display";
                    for (int i = 0; i < _data.Length; i++)
                    {
                        Application.Current.Dispatcher.Invoke(() => DisplayChange.Add(_data[i]));
                    }
                    _mutex.ReleaseMutex();
                    _stream.Close();
                }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void StartDisplay()
        {
            Task.Run(() => ReadFile());
        }

        public OneDisplayControl()
        {
            _display = new ObservableCollection<int>();
            _mutex = new Mutex(false, "5B67F18A-6E0E-461F-9813-1A40B7D8FB47", out _IsCreated);
            GetMessage = "Waiting...";
            _data = new byte[500000000];

        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
