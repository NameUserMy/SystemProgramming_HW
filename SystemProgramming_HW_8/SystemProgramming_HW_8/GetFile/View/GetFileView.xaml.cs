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
using SystemProgramming_HW_8.GetFile.Control;

namespace SystemProgramming_HW_8.GetFile.View
{
    /// <summary>
    /// Interaction logic for GetFileView.xaml
    /// </summary>
    public partial class GetFileView : UserControl
    {
        private GetFileControl getFileControl;
        public GetFileView()
        {
            getFileControl = new GetFileControl();
            this.DataContext = getFileControl;
            InitializeComponent();
        }

        private void openDirectory_Click(object sender, RoutedEventArgs e)
        {
            getFileControl.SearchFile();
        }

        
    }
}
