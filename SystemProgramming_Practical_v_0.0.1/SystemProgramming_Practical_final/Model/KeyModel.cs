using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SystemProgramming_Practical_final.Model
{
    internal class KeyModel:ViewModel
    {
        private ObservableCollection<string> _Key;
        public ObservableCollection<string> KeyInfo
        {
            get => _Key;
            set { _Key = value; NotifyPropertyChanged(nameof(KeyInfo)); }
        }
        public KeyModel() => _Key = new ObservableCollection<string>();
    }
}
