using System;
using System.Collections.Generic;
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
using SystemProgramming_HW_6.Loader.Control;

namespace SystemProgramming_HW_6.Loader.View
{
    /// <summary>
    /// Interaction logic for LoaderView.xaml
    /// </summary>
    public partial class LoaderView : UserControl
    {
        private LoaderControl loaderControl;
        public LoaderView()
        {
            loaderControl = new LoaderControl();
            this.DataContext = loaderControl;
            InitializeComponent();

        }

        private void sourceButton_Click(object sender, RoutedEventArgs e)
        {
            loaderControl.GetSource();
            loaderControl.ReadFile();
            
        }

        private void destinationButton_Click(object sender, RoutedEventArgs e)
        {
            loaderControl.GetDestination();
        }

        private void startCopyButton_Click(object sender, RoutedEventArgs e)
        {
            loaderControl.Replicate();
        }
    }
}
