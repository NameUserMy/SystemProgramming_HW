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
using System.Windows.Documents;
using System.Windows.Media;

namespace SystemProgramming_HW_7.CountFile.Control
{
    class CountFileControl : INotifyPropertyChanged
    {
        private int _countFile;
        private long _sizeFile;
        private string _messageCount;
        private string _messageSize;
        private string _adressFolder;
        private OpenFolderDialog _openFolder;
        private DirectoryInfo directory;
        #region Binding
        public string CountFile
        {
            get => _messageCount;
            set { _messageCount = value; NotifyPropertyChanged(nameof(CountFile)); }
        }
        public string SizeFiles
        {
            get => _messageSize;
            set { _messageSize = value; NotifyPropertyChanged(nameof(SizeFiles)); }
        }
        public string AdressFolder
        {
            get => _adressFolder;
            set { _adressFolder = value; NotifyPropertyChanged(nameof(AdressFolder)); }
        }





        public string CountFile1
        {
            get => _messageCount;
            set { _messageCount = value; NotifyPropertyChanged(nameof(CountFile1)); }
        }
        public string SizeFiles1
        {
            get => _messageSize;
            set { _messageSize = value; NotifyPropertyChanged(nameof(SizeFiles1)); }
        }
        public string AdressFolder1
        {
            get => _adressFolder;
            set { _adressFolder = value; NotifyPropertyChanged(nameof(AdressFolder1)); }
        }

        #endregion


        #region Get file in deryctory;
        private DirectoryInfo GetDirectory()
        {

            _openFolder = new OpenFolderDialog();
            _openFolder.ShowDialog();
            directory = new DirectoryInfo(_openFolder.FolderName);
            AdressFolder = _openFolder.FolderName;
            return directory;

        }
        private void CallBackDirectoryInfo(Task<DirectoryInfo> task)
        {

            for (_countFile = 0; _countFile < task.Result.GetFiles().Length; _countFile++)
            {

                _sizeFile += task.Result.GetFiles()[_countFile].Length;
            }
            CountFile = $"Count file in directory : {_countFile}";
            SizeFiles = $"Overall size file in directory : {_sizeFile} bytes";
        }
        public void GetFileInfo()
        {

            Task.Run(GetDirectory).ContinueWith(CallBackDirectoryInfo);


        }
        #endregion

        #region Get file in deryctory deryctory;
        private int CallBackDirectoryDirInfo(int n, DirectoryInfo directory)
        {
            
            if (directory.GetDirectories().Length == n)
                return n;
            else
            {
                _countFile+=directory.GetDirectories()[n].GetFiles().Length;
                for (int i = 0; i < directory.GetDirectories()[n].GetFiles().Length; i++)
                {
                    _sizeFile+=directory.GetDirectories()[n].GetFiles()[i].Length;
                   
                }
                CountFile1 = $"Count file in directories : {_countFile}";
                SizeFiles1 = $"Overall size file in directories : {_sizeFile} bytes";
            }
           
            return CallBackDirectoryDirInfo(n += 1, directory);

        }
        private void GetAllFiles()
        {
            _openFolder = new OpenFolderDialog();
            _openFolder.ShowDialog();
            directory = new DirectoryInfo(_openFolder.FolderName);
            AdressFolder1 = _openFolder.FolderName;
            Task.Run(()=>CallBackDirectoryDirInfo(0, directory));
        }

       public void startDirDir()
        {

          Task.Run(GetAllFiles);
        }
        #endregion

        public CountFileControl()
        {
            CountFile = $"Count file in directory : {_countFile}";
            SizeFiles = $"Overall size file in directory : {_sizeFile} bytes";
           
            CountFile1 = $"Count file in directories : {_countFile}";
            SizeFiles1 = $"Overall size file in directories : {_sizeFile} bytes";
            
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}





