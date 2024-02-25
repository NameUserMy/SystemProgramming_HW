using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace SystemProgramming_HW_4.Control
{

    
    internal class FileThread
    {
        private string[] _split;
        private TextBox _textBox;
        public string ReplaceS { get; set;}
        private static object _loker = new object ();
        public void CountWords(object obj)
        {

            lock (_loker)
            {
                StreamReader file = new StreamReader((string)obj);
                string sr = file.ReadToEnd();
                _split = sr.Split(' ');
                file.Close();
                MessageBox.Show($"{_split.Length}");
            }
          
        }
        public  void ReplaceSimbol(object obj)
        {
            lock (_loker)
            {
                StreamReader file = new StreamReader((string)obj);
                string sr = file.ReadToEnd();
                ReplaceS = sr.Replace('!', '#');
                file.Close();
                MessageBox.Show($"{ReplaceS}");
             }
            //_textBox.Text = ReplaceS;
        }
        public FileThread(TextBox text) => _textBox = text;
        
    }
}
