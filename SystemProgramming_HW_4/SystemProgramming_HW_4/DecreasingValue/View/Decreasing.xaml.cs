using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SystemProgramming_HW_4.DecreasingValue.Control;

namespace SystemProgramming_HW_4.DecreasingValue.View
{
    /// <summary>
    /// Interaction logic for Decreasing.xaml
    /// </summary>
    public partial class Decreasing : Window
    {
        private List<int> _decreasing;
        private int _index;
        public SynchronizationContext uiContext;
        private DecreasingThread decreasing;
        private Param param;
        private int _countThread;
        private int _countThread5;
        List<Thread> thread;
        List<Thread> thread5;
        public Decreasing()
        {
            InitializeComponent();
            this.Loaded += Decreasing_Loaded;
           
        }
        private void Decreasing_Loaded(object sender, RoutedEventArgs e)
        {
            uiContext = SynchronizationContext.Current;
            param = new Param();
            decreasing = new DecreasingThread();
            thread = new List<Thread> { new Thread(DecrasintOne), new Thread(DecrasintOne), new Thread(DecrasintOne) };
            thread5 = new List<Thread> { new Thread(DecrasintFive), new Thread(DecrasintFive), new Thread(DecrasintFive) };
            _countThread = 0;
            _countThread5 = 0;
        }
        private void DecrasintOne(object obj)
        {
            Param param = (Param)obj;
            for (int i = 0; i < _decreasing.Count(); i++)
            {
                _index = _decreasing[i];
                _decreasing[i] = Interlocked.Decrement(ref _index);
                param.value = _decreasing[i];
                uiContext.Send(decreasing.GetListBox, param);
            }
        }

        private void DecrasintFive(object obj)
        {
            Param param = (Param)obj;
            for (int i = 0; i < _decreasing.Count(); i++)
            {
                _index = _decreasing[i];
                _decreasing[i] = Interlocked.Add(ref _index,5);
                param.value = _decreasing[i];
                uiContext.Send(decreasing.GetListBox, param);
            }
        }



        private void startButton5_Click(object sender, RoutedEventArgs e)
        {
            _decreasing = decreasing.RandomCollection();
            if (_countThread5 <= 2)
            {
                var listboxB = before5StackPanel.Children.Cast<ListBox>().ToList();
                var listboxA = After5StackPanel.Children.Cast<ListBox>().ToList();
                listboxB[_countThread5].ItemsSource = _decreasing;
                param.List = listboxA[_countThread5];
                thread5.ElementAt(_countThread5).Start(param);
                _countThread5++;
            }
            else { startButton5.IsEnabled = false; }
        }

        private void startButton1_Click(object sender, RoutedEventArgs e)
        {
            _decreasing = decreasing.RandomCollection();
            if (_countThread != 3)
            {
                var listboxB = before1StackPanel.Children.Cast<ListBox>().ToList();
                var listboxA = After1StackPanel.Children.Cast<ListBox>().ToList();
                listboxB[_countThread].ItemsSource = _decreasing;
                param.List = listboxA[_countThread];
                thread.ElementAt(_countThread).Start(param);
                _countThread++;
            }
            else { startButton1.IsEnabled = false;}
        }
    }
}
