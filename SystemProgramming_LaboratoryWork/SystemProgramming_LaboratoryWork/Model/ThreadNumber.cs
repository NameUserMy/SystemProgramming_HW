using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming_LaboratoryWork.Model
{
    internal class ThreadNumber
    {
        public void ViewNumber50(Label result1)
        {
            Thread thread = new Thread(
                () => {
                for (int i =0; i <50; i++)
                {
                        result1.Text = i.ToString();
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
        public void ViewNumberRange(int start, int end,Label result2)
        {
            Param param = new Param {A=start,B=end};
           
            Thread thread = new Thread((object a) =>
            {
                Param paramp = (Param)a;
                for (int i = paramp.A; i < paramp.B; i++)
                {
                    result2.Text = i.ToString();
                }
            });
            thread.Name = "new thread";
            thread.Start(param);
        }
        public void ViewNumberRangeAndThreadCountint(int start, int end,int countThread,Label result,Label info)
        {

            Param param = new Param {A=start,B=end};    
            for (int i = 0; i < countThread; i++)
            {
                Thread thread = new Thread((object a) =>
                {
                    Param paramp = (Param)a;
                    for (int i = paramp.A; i < paramp.B; i++)
                    {

                        result.Text=i.ToString();
                    }
                });
               info.Text= thread.Name = $"New thread {i} {thread.IsAlive}";
               thread.Start(param);
            }   
            

        } 

       
    }
}
