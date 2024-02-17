using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming_LaboratoryWork.Model
{
    internal class ThreadMinMax
    {

        private List<int>? _random;
        private int _min;
        private int _max;
        private Thread _threadMin;
        private Thread _threadMax;
        private Thread _saveData;
        public void MinMax(Label min,Label max)
        {
     
            Random rand = new Random();
            for (int i = 0; i < 10000; i++)
            {
                _random.Add(rand.Next(i + 1, 10000));
            }
            _threadMin = new Thread(GetMin);
            _threadMax = new Thread(GetMax);
            _saveData = new Thread(SaveData);
            _threadMin.Start(_random);
            _threadMax.Start(_random);
            _saveData.Start();

            min.Text = _min.ToString();
            max.Text = _max.ToString();
            
        }
        private void GetMin(object min)
        {
            List<int> number = (List<int>)min;
            _min = number.Min();
           
        }
        private void GetMax(object max)
        {
            List<int> number = (List<int>)max;
            _max = number.Max();
           
        }
        private void SaveData()
        {
            StreamWriter data = new StreamWriter("Data.txt");
            data.Write($"MIN RESULT  {_min}  MAN RESULT  {_max} \n");
            for (int i = 0; i < _random.Count(); i++)
            {
                if (i == 100)
                {
                    data.Write("\n");
                }
                data.Write($"{_random[i]} ");
            }
            data.Close();
            MessageBox.Show("Result save in file");
        }
        public ThreadMinMax()
        {

            _random = new List<int>();
        }
    }
}
