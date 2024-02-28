
using System.Windows;
using SystemProgramming_HW_5.Control;


namespace SystemProgramming_HW_5.View
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        StartControl startControl;
      
        public Start()
        {
            startControl=new StartControl(this);
            startControl.Max3();
            InitializeComponent();
           
        }

        private void secondBooton_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new StopwatchTest();
        }
        private void firstBooton_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new EventTask();
        }
        private void Fourth_Click(object sender, RoutedEventArgs e)
        {
           CC.Content = new MutexView();
        }
        private void newApp_Click(object sender, RoutedEventArgs e)
        {
            new  Start().Show();
        }

        private void semafor_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new SemaforView();
        }
    }
}
