using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SystemProgramming_HW_6.Loader.Control
{
    class LoaderControl : INotifyPropertyChanged
    {
        private string? _source;
        private string? _destination;
        private Stream? _stream;
        private byte[]? _data;
        private long _maxValue;
        private long _proggresValue;
        private long _count;

        #region Binding
        public string GetSourceAdress {

            get { return _source; }
            set { _source = value; NotifyPropertyChanged(nameof(GetSourceAdress)); }
        }
        public string GetDestinationAdress
        {
            get { return _destination; }
            set { _destination = value; NotifyPropertyChanged(nameof(GetDestinationAdress)); }
        }
        public  long MaxValueProggres
        {
            get{ return _maxValue; }
            set { _maxValue = value;NotifyPropertyChanged(nameof(MaxValueProggres));}

        }
        public long ProggresValue
        {
            get { return _proggresValue; }
            set { _proggresValue = value; NotifyPropertyChanged(nameof(ProggresValue)); }

        }
        #endregion
        
        public void GetSource()
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Source document";
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text documents (.txt)|*.txt";

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                GetSourceAdress = dialog.FileName;
            }

        }
        public void GetDestination()
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Destination document";
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text documents (.txt)|*.txt";

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                GetDestinationAdress = dialog.FileName;
            }

        }
        public byte[] ReadFile()
        {
            _stream = new FileStream(GetSourceAdress, FileMode.Open, FileAccess.Read);
            MaxValueProggres = _stream.Length;
             _data =new byte[_stream.Length];
            _stream.BeginRead(_data,0, _data.Length, null,null);
           
            _stream.Close();
            return _data;
        }
      
        public void Replicate()
        {
            Task<byte[]>.Run(() => ReadFile()).ContinueWith(CallBackSave);
        }
        private void CallBackSave(Task<byte[]> task)
        {
            var result = task.Result;
            _stream = new FileStream(GetDestinationAdress, FileMode.OpenOrCreate, FileAccess.Write);
            _stream.BeginWrite(result,0, result.Length, null, null);
            for (int i = 0; i < result.Length; i++)
            {
                MessageBox.Show($"{result[i]}");
                ProggresValue+=4096;
            }
            _stream.Close();
        }
        public LoaderControl()
        {
            MaxValueProggres = 8000;
            
        } 
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
