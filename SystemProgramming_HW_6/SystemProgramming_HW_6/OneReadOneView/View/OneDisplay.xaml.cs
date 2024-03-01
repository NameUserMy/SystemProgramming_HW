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
using SystemProgramming_HW_6.OneReadOneView.Control;

namespace SystemProgramming_HW_6.OneReadOneView.View
{
    /// <summary>
    /// Interaction logic for OneDisplay.xaml
    /// </summary>
    public partial class OneDisplay : Window
    {
        OneDisplayControl oneDisplayControl;
        public OneDisplay()
        {
            oneDisplayControl = new OneDisplayControl();
            this.DataContext = oneDisplayControl;
            InitializeComponent();
        }

        private void ReadButtom_Click(object sender, RoutedEventArgs e)
        {
            oneDisplayControl.StartDisplay();
        }
    }
}
