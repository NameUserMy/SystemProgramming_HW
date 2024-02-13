using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming_HW_1.GuessTheNumber
{
    internal class GuessNumber
    {
        private int _answer; 
        private int _count;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
        public void Start()
        {
            do
            {
                _answer = MessageBox(new IntPtr(0), new Random().Next(0, 100).ToString(), "Let's play", 1);

                if (_answer == 1)
                {
                    _answer = MessageBox(new IntPtr(0), new Random().Next(0, 100).ToString(),"количество попыток "+ _count.ToString(), 2);
                    _count = 0;
                };
                if (_answer == 2)
                {
                    _count++;
                }
            } while (_answer != 3);

        }
        public GuessNumber() => _count = 1;

    }
}
