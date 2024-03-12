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
using SystemProgramming_HW_9.Control;
using SystemProgramming_HW_9.Model;

namespace SystemProgramming_HW_9.View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private SuperProjectControl control;
        private PluginInfoModel pluginInfoModel;
        public Window1()
        {
            pluginInfoModel = new PluginInfoModel();
            control = new SuperProjectControl(pluginInfoModel);
            this.DataContext = pluginInfoModel;
            InitializeComponent();
        }
        private void getInfoPlugin_Click(object sender, RoutedEventArgs e)
        {
            control.GetPluginInfo();
        }

        private void getStaticMethod_Click(object sender, RoutedEventArgs e)
        {
            control.GetStaticMethodsSquareArea();
        }

        private void getMethod_Click(object sender, RoutedEventArgs e)
        {
            control.GetMethodsRectangleArea();
        }
    }
}
