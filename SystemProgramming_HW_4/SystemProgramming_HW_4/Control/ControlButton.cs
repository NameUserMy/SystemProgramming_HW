using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming_HW_4.Control
{
    internal class ControlButton
    {
        private string _info;
        public string FilePath { get; set; }
        public string OpenFile()
        {
            
            var dialog = new OpenFileDialog();
            dialog.FileName = "Document";
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text documents (.txt)|*.txt"; 

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                FilePath= dialog.FileName;
                StreamReader file = new StreamReader(FilePath);
                _info = file.ReadToEnd();
                file.Close();
            }
            return _info;
        }
        public void SaveFile(string fileForSave)
        {
            var dialog = new SaveFileDialog();
            dialog.FileName = "Document";
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text documents (.txt)|*.txt";

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                FilePath = dialog.FileName;
                StreamWriter si = new StreamWriter(FilePath);
                si.WriteLine(fileForSave);
                si.Close();
            }
        }
    }
}
