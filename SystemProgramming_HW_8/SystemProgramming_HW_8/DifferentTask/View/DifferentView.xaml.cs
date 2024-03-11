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
using SystemProgramming_HW_8.DifferentTask.Control;

namespace SystemProgramming_HW_8.DifferentTask.View
{
    /// <summary>
    /// Interaction logic for DifferentView.xaml
    /// </summary>
    public partial class DifferentView : UserControl
    {

        private DifferentControl different;
        public DifferentView()
        {
            different = new DifferentControl();
            InitializeComponent();
            this.DataContext = different;
            
        }

        private void startTask_Click(object sender, RoutedEventArgs e)
        {
            different.StartTaskTime();
        }

        private void factoryTask_Click(object sender, RoutedEventArgs e)
        {
            different.FactoryTaskTime();
        }

        private void runTask_Click(object sender, RoutedEventArgs e)
        {
            different.RunTaskTime();
        }

        private void runAsyncTask_Click(object sender, RoutedEventArgs e)
        {
            different.StartAsyncTaskTime();
        }
    }
}
