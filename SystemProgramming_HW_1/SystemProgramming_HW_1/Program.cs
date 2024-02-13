using SystemProgramming_HW_1.GuessTheNumber;
using SystemProgramming_HW_1.Resume;

namespace SystemProgramming_HW_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuessNumber guessNumber = new GuessNumber();
            //guessNumber.Start();

            MyResume myResume= new MyResume();
            myResume.ViewResume();

        }
    }
}
