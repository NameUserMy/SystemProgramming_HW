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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SystemProgramming_HW_7.CountFile.Control;

namespace SystemProgramming_HW_7.CountFile.View
{
    /// <summary>
    /// Interaction logic for CountFileView.xaml
    /// </summary>
    public partial class CountFileView : UserControl
    {
        CountFileControl countFileControl;
        public CountFileView()
        {
            countFileControl = new CountFileControl();
            this.DataContext = countFileControl;
            InitializeComponent();
        }

        private void countFileButton_Click(object sender, RoutedEventArgs e)
        {
           
            countFileControl.GetFileInfo();
        }

        private void countFileButton1_Click(object sender, RoutedEventArgs e)
        {
            countFileControl.startDirDir();
        }
    }
}
