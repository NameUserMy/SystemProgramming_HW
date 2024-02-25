using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using SystemProgramming_HW_4.DecreasingValue.View;

namespace SystemProgramming_HW_4.DecreasingValue.Control
{
    internal class DecreasingThread
    {

        private  List<int>  _decreasing;
        private  Random _random;
        public void GetListBox(object obj)
        {
            Param param = (Param)obj;
            param.List.Items.Add(param.value);

        }
        public List<int> RandomCollection()
        {
            _decreasing = new List<int>();
            _random = new Random();
            for (int i = 0; i < 15; i++)
            {
                _decreasing.Add(_random.Next(i, 500));
            }

            return _decreasing;
        }
       

    }
}
