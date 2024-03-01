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
using System.Windows.Shapes;
using SystemProgramming_HW_6.DoubleReadFile.Control;
using SystemProgramming_HW_6.DoubleReadFile.View;
using SystemProgramming_HW_6.Loader.View;
using SystemProgramming_HW_6.OneReadOneView.View;

namespace SystemProgramming_HW_6.Start.View
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        
        public Start()
        {
            
            InitializeComponent();
        }

        private void firstBooton_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new DoubleRead();
        }

        private void secondBooton_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new OneRead();
        }

        private void third_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new LoaderView();
        }
    }
}
