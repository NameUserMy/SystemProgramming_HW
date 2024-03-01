using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using SystemProgramming_HW_6.OneReadOneView.Control;

namespace SystemProgramming_HW_6.OneReadOneView.View
{
    /// <summary>
    /// Interaction logic for OneRead.xaml
    /// </summary>
    public partial class OneRead : UserControl
    {
        OneToOneControl oneToOne;
        public OneRead()
        {
            InitializeComponent();
            oneToOne= new OneToOneControl();
            this.DataContext = oneToOne;
        }
        private void startSaveButton_Click(object sender, RoutedEventArgs e)
        {
            oneToOne.SaveFile();
        }

        private void startReadButton_Click(object sender, RoutedEventArgs e)
        {
            oneToOne.StartRead();
            new OneDisplay().Show();
        }
    }
}
