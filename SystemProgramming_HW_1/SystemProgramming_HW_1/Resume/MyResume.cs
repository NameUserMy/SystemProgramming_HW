using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SystemProgramming_HW_1.Resume
{
    internal class MyResume
    {
       
        
        public string[]? Resume { get; set; }
        private int _sumSimbols;
        private int i;
        public MyResume() {
            string[] test = { "Vasya", "Somthing", "Something wrong" };
            Resume = test;
        }
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
        public  void ViewResume()
        {
            for (i = 0; i < Resume?.Length; ++i)
            {
                MessageBox(new IntPtr(0), Resume[i], "Resume", 0);
                _sumSimbols+= Resume[i].Count();
            }

            MessageBox(new IntPtr(0), $"AVG simbols in resume {_sumSimbols/i}", "Resume", 0);
        }
       
    }
}
