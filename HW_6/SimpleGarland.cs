using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    public class SimpleGarland : Garland
    {
        public SimpleGarland()
            : base()
        {
        }
        public override void GetCurrentState()
        {
            Console.WriteLine("Введите количество лампочек простой гирлянды");
            InputHelper LampNumber = new InputHelper ();
            int Number = LampNumber.Input;
            int[] Array1 = new int[Number - 1]; 
            int CurrentMinute = Convert.ToInt32(DateTime.Now.Minute);
            for (int i = 0; i < Number; i++)
            {
                int Order = i + 1;
                if (((CurrentMinute % 2) != 0) & ((Order % 2) != 0))
                {
                    currentState = " горит";
                }
                else if (((CurrentMinute % 2) != 0) & ((Order % 2) == 0))
                {
                    currentState = " не горит";
                }
                else if (((CurrentMinute % 2) == 0) & ((Order % 2) != 0))
                {
                    currentState = " не горит";
                }
                else if (((CurrentMinute % 2) == 0) & ((Order % 2) == 0))
                {
                    currentState = " горит";
                }
                Console.WriteLine("Лампочка № " + (i + 1) + currentState);
            }
        }
    }
}