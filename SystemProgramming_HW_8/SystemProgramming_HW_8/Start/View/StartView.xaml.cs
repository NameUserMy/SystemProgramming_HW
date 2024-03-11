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
using SystemProgramming_HW_8.DifferentTask.View;
using SystemProgramming_HW_8.GetFile.View;

namespace SystemProgramming_HW_8.Start.View
{
    /// <summary>
    /// Interaction logic for StartView.xaml
    /// </summary>
    public partial class StartView : Window
    {
        public StartView()
        {
            InitializeComponent();
           
        }

        private void firstBooton_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new DifferentView();
        }

        private void secondBooton_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new GetFileView();
        }
    }
}
