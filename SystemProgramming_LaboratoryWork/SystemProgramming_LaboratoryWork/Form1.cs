using SystemProgramming_LaboratoryWork.Model;

namespace SystemProgramming_LaboratoryWork
{
    public partial class Form1 : Form
    {
        ThreadNumber threadNumber = new ThreadNumber();
        public Form1()
        {
            InitializeComponent();
            this.Load += Tes;


        }
        private void Tes(object? sender, EventArgs e)
        {
            //

            //threadNumber.ViewNumberRangeAndThreadCountint(0,10,2);
            //ThreadMinMax threadMinMax = new ThreadMinMax();
            //threadMinMax.MinMax();
            //secondThreadGB.l

        }

        private void startSecondButt_Click(object sender, EventArgs e)
        {
            threadNumber.ViewNumberRange(Convert.ToInt32(startRangeSecondNumeric.Value), Convert.ToInt32(endRangeSecondNumeric.Value), secondResult);
        }

        private void firstThread_Click(object sender, EventArgs e)
        {
            threadNumber.ViewNumber50(firstThreadResult);
        }

        private void manyThreadButton_Click(object sender, EventArgs e)
        {
            threadNumber.ViewNumberRangeAndThreadCountint(Convert.ToInt32(startRangeManyNumeric.Value),
                Convert.ToInt32(endRangeManyNumeric.Value), Convert.ToInt32(countThreadNum.Value), manyThreadResult, manyThreadName);
        }
    }
}
