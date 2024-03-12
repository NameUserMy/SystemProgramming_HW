using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SystemProgramming_HW_9.Model
{
    internal class PluginInfoModel : INotifyPropertyChanged
    {
        private ObservableCollection<String>? _pluginInfo;

        public ObservableCollection<String> PluginInfoUpdate
        {
            get => _pluginInfo;
            set { _pluginInfo = value; NotifyPropertyChanged(nameof(PluginInfoUpdate)); }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public PluginInfoModel()
        {
            _pluginInfo = new ObservableCollection<string>();

        }
    }
}
