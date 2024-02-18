using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemProgramming_HW_2.Model
{
    internal class SimpleNumber
    {

        
        public void SimpleNumberGenerator(object obj) {

            Param param = (Param)obj;

            bool isSimple;
            if (param.Start < 2)
                param.Start = 2;

            for (int i = param.Start; i <= param.End; i++)
            {
                isSimple = true;
                for (int j = 2; j <i; j++)
                {
                    if (i%j == 0)
                    {
                        isSimple= false;
                        break;
                    }
                   
                }
                if (isSimple) { param.AddListBox.Items.Add(i);};
            }
            
        }

        public void FibonachyGenerator(object obj) {
            Param param = (Param)obj;
            int first = 1,second=1,sum=0;
            while (sum<= param.End)
            {
                sum = first + second;
                param.AddListBox.Items.Add(sum);
                first = second; second=sum;
            }
        }
    }
}

















