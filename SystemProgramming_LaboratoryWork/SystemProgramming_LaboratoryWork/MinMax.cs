using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemProgramming_LaboratoryWork.Model;
namespace SystemProgramming_LaboratoryWork
{
    public partial class MinMax : Form
    {

        ThreadMinMax minMax = new ThreadMinMax();
        public MinMax()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            minMax.MinMax(resultMinLabel, resultMaxLabel);
        }

       
    }
}
