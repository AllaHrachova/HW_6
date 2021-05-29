using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    class InputHelper
    {
        public int input;
        public int Input
        {
            get
            {
                return input;
            }
            set
            {
                input = value;
            }
        }
        public InputHelper()
        {
            do
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод. Введите натуральное число");
                    input = -1;
                }
            }
            while (input <= 0);
        }
    }
}