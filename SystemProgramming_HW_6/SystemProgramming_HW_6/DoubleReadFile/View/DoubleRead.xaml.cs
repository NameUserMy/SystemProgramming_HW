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
using SystemProgramming_HW_6.DoubleReadFile.Control;

namespace SystemProgramming_HW_6.DoubleReadFile.View
{
    /// <summary>
    /// Interaction logic for DoubleRead.xaml
    /// </summary>
    public partial class DoubleRead : UserControl
    {
        DoubleReadFileControl doubleReadFileControl;
        public DoubleRead()
        {
            doubleReadFileControl = new DoubleReadFileControl();
            this.DataContext = doubleReadFileControl;
            InitializeComponent();
        }

        private void CountNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex;
            regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void startSaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (CountNumber.Text!="")
            {
                doubleReadFileControl.CountNumber = Convert.ToInt32(CountNumber.Text);
            }
            doubleReadFileControl.SaveFile();
        }

        private void startReadButton_Click(object sender, RoutedEventArgs e)
        {

            doubleReadFileControl.StartRead();
        }
    }
}
