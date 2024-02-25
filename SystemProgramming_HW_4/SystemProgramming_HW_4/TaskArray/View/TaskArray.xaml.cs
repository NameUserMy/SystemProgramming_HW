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
using System.Windows.Shapes;
using SystemProgramming_HW_4.TaskArray.Control;

namespace SystemProgramming_HW_4.TaskArray.View
{
    /// <summary>
    /// Interaction logic for TaskArray.xaml
    /// </summary>
    public partial class TaskArray : Window
    {


        ThreadArray threadArray;
        public TaskArray()
        {
            InitializeComponent();
            threadArray = new ThreadArray();
        }
        private void findNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void findNumber_MouseEnter(object sender, MouseEventArgs e)
        {
            findNumber.Clear();
        }
      
        private void GenereteCount_MouseEnter(object sender, MouseEventArgs e)
        {
                genereteCount.Clear();
        }

        private void startProgramm_Click(object sender, RoutedEventArgs e)
        {
            Task taskSort = new Task(threadArray.SortArray);
            Task taskSearchNum = new Task(threadArray.IsNumberArray,Convert.ToInt32(findNumber.Text));
            taskSort.Start();
            taskSort.Wait();
            sortArrList.ItemsSource = threadArray._randomNum;
            taskSearchNum.Start();
            
        }

        private void startGenButton_Click(object sender, RoutedEventArgs e)
        {
            generateArrList.ItemsSource = threadArray.GenArray(Convert.ToInt32(genereteCount.Text));
        }
    }
}
