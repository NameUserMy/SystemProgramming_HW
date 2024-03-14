using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SystemProgramming_Practical_final.Control.SaveInfo;
using SystemProgramming_Practical_final.Control.Settings;


namespace SystemProgramming_Practical_final.View
{
    /// <summary>
    /// Interaction logic for Sniffer.xaml
    /// </summary>
    public partial class Sniffer : Window
    {
        private SaveInFile _saveInFile;
        private Settings _settings;
        public Sniffer()
        {
            _settings = new Settings();
            _saveInFile = new SaveInFile();
            _saveInFile.SaveInfo();
            InitializeComponent();
          
        }
        private void startProgramm_Click(object sender, RoutedEventArgs e)
        {
            if (getAllKey.IsChecked == true) {infoKey.DataContext= _settings.StartKey();};
            if (allProcess.IsChecked == true) {info.DataContext= _settings.StartProcess();};
        }

        private void pickFolderButton_Click(object sender, RoutedEventArgs e)
        {

           

        }
    }
}
