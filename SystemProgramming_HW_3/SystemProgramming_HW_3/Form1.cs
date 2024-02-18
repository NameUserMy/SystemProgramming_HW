using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemProgramming_HW_3
{
    public partial class Form1 : Form
    {
        Bank bank;
        public Form1()
        {
            InitializeComponent();
            this.Load += formLoad;
            bank = new Bank();
        }

        private void formLoad(object sender, EventArgs e)
        {
            bank.Name = "Name";
            bank.Procent = 20;
            bank.Money = 60;
           
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            bank.Name = nameTextBox.Text;
            infoList.Items.Add(bank.Name);
            bank.ThreadSaveData(new Param { Name = bank.Name, Procent = bank.Procent, Money = bank.Money });
        }

        private void procentUpDown_ValueChanged(object sender, EventArgs e)
        {
            bank.Procent = Convert.ToInt32(procentUpDown.Value);
            infoList.Items.Add(bank.Procent);
            bank.ThreadSaveData(new Param { Name = bank.Name, Procent = bank.Procent, Money = bank.Money });
        }

        private void moneyUpDown2_ValueChanged(object sender, EventArgs e)
        {
            bank.Money = moneyUpDown2.Value;
            infoList.Items.Add(bank.Money);
            bank.ThreadSaveData(new Param { Name = bank.Name, Procent = bank.Procent, Money = bank.Money });
        }
    }
}
