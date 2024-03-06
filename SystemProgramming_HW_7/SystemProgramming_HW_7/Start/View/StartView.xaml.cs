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
using SystemProgramming_HW_7.CountFile;
using SystemProgramming_HW_7.CountFile.View;
using SystemProgramming_HW_7.SearchFileAndFolder.Control;
using SystemProgramming_HW_7.SearchFileAndFolder.View;

namespace SystemProgramming_HW_7.Start.View
{
    /// <summary>
    /// Interaction logic for StartView.xaml
    /// </summary>
    public partial class StartView : Window
    {
        SearchFileControl searchFileControl;
        public StartView()
        {
            searchFileControl = new SearchFileControl();
            InitializeComponent();
        }

        private void firstBooton_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new CountFileView();
        }

        private void secondBooton_Click(object sender, RoutedEventArgs e)
        {

            //CC.Content = new ResultSearch();
            searchFileControl.blah();
        }
    }
}
