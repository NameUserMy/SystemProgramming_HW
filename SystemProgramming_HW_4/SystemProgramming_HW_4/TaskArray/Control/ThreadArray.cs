using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace SystemProgramming_HW_4.TaskArray.Control
{
    internal class ThreadArray
    {
        public List<int> _randomNum { get;  private set; }
        private object _lock = new object();
        private int _findNum;
        private Random _random;
        public List<int> GenArray(int countGener)
        {
            _random = new Random();
            _randomNum = new List<int>();
            for (int i = 0; i < countGener; i++)
            {

                _randomNum.Add(_random.Next(0, countGener));

            }
            return _randomNum;
        }
        public  void SortArray()
        {
            lock (_lock)
            {
                _randomNum.Sort();
            }
        }
        public  void IsNumberArray(object obj)
        {
            lock (_lock)
            {
                _findNum = _randomNum.BinarySearch((int)obj);
            }
            if (_findNum>=0)
            {
                MessageBox.Show($"{_randomNum.ElementAt(_findNum)}");
            }
            else { MessageBox.Show($"No find"); }
           
        }


       
    }
}
