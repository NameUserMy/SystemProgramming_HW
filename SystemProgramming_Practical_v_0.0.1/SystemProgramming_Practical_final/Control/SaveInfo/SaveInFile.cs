using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming_Practical_final.Control.SaveInfo
{
    internal class SaveInFile : Keeper
    {
        private string _path;
        
        public void SaveInfo()
        {
            AsyncSave(new int[] {3,2,3,2,22});
        }
        private async void AsyncSave(IEnumerable  objects)
        {
            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(_path, "Info.txt")))
            //{
            //    foreach (var obj in objects)
            //    {
            //        await outputFile.WriteAsync(obj.ToString());
            //    }
            //}
        }
    }
}
