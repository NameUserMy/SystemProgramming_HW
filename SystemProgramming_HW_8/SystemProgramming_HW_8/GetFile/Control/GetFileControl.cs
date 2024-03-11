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

namespace SystemProgramming_HW_8.GetFile.Control
{
    internal class GetFileControl : INotifyPropertyChanged
    {
        private OpenFolderDialog? _openFolder;
        private DirectoryInfo? _directory;
        private ObservableCollection<string> _infoFole;
        private string _path;
        public string Path
        {
            get => _path;
            set { _path = value; NotifyPropertyChanged(nameof(Path)); }
        }

        public ObservableCollection<string> FileInfo
        {
            get => _infoFole;
            set { _infoFole = value; NotifyPropertyChanged(nameof(FileInfo)); }
        }


        public void SearchFile()
        {
            _openFolder = new OpenFolderDialog();
            _openFolder.ShowDialog();
            _directory = new DirectoryInfo(_openFolder.FolderName);
            Path = _directory.FullName;
            TestAsync(_directory.FullName);
        }
        public async Task TestAsync(string directory)
        {
            try
            {
                var directories = await Task.Run(() => Directory.GetDirectories(directory));
                foreach (var d in directories)
                {
                    await TestAsync(d);
                }
                var files = await Task.Run(() => Directory.GetFiles(directory));
                var DC = File.GetCreationTime(directory);

                foreach (var f in files)
                {
                    if(DC.Year == DateTime.Now.Year)
                    {
                        Application.Current.Dispatcher.Invoke(()=>_infoFole.Add($"Info {f}  Date {DC}"));
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public GetFileControl()
        {
            _infoFole = new ObservableCollection<string>();
        }
    }
}
