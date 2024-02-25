using System.Threading;
using System.Windows;
using SystemProgramming_HW_4.Control;

namespace SystemProgramming_HW_4.View
{
    /// <summary>
    /// Interaction logic for CriticalSection.xaml
    /// </summary>
    public partial class CriticalSection : Window
    {
        private  FileThread fileThread;
        private ControlButton controlButton;
        private static string _pathFile;
        private Thread countWords;
        private Thread replase;
        public CriticalSection()
        {
            InitializeComponent();
            this.Loaded += CriticalSection_Loaded;
        }

        private void CriticalSection_Loaded(object sender, RoutedEventArgs e)
        {
           
            fileThread = new FileThread(viewFile);
            controlButton = new ControlButton();
            _pathFile = pathFile.Text;
           
        }
        private void loadFile_Click(object sender, RoutedEventArgs e)
        {
           
            viewFile.Text=controlButton.OpenFile();
            pathFile.Text = controlButton.FilePath;
            
           
        }
        private void saveFileButton_Click(object sender, RoutedEventArgs e)
        {
            controlButton.SaveFile(viewFile.Text);
          
        }
        private void startProgramBuuton_Click(object sender, RoutedEventArgs e)
        {
            countWords = new Thread(fileThread.CountWords);
            replase = new Thread(fileThread.ReplaceSimbol);
            MessageBox.Show($"Count Thread  {countWords.ThreadState}  Replace {replase.ThreadState}");
            countWords.Start(pathFile.Text);
            replase.Start(pathFile.Text);
            MessageBox.Show($"Count Thread  {countWords.ThreadState}  Replace {replase.ThreadState}");
            replase.Join();
            viewFile.Text = fileThread.ReplaceS;
        }
    }
}
