using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static SystemProgramming_HW_3.Form1;

namespace SystemProgramming_HW_3
{
    internal class Bank
    {
        public string Name { get; set; }
        public int Procent { get; set; }
        public decimal Money { get; set; }
        private  void SaveData(object obj)
        {
               Param bank = (Param)obj;
               StreamWriter aF = new StreamWriter("Bank.txt");
               aF.WriteLine($"Name : {bank.Name}\nProcent : {bank.Procent}\nMoney : {bank.Money}\n");
               aF.Close();
        }
        public void ThreadSaveData(Param param)
        {
            Thread thread = new Thread(SaveData);
            thread.Start(param);
        }
    }
}
