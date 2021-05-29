using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    class ColoredGarland : Garland
    {
        public string LampColor { get; set; }
        public ColoredGarland()
            : base()
        {
        }
        public override void GetCurrentState()
        {
            Console.WriteLine("Введите количество лампочек цветной гирлянды");
            lampColor = LampColor;
            InputHelper ColoredLampNumber = new InputHelper();
            int Number = ColoredLampNumber.Input;

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
                int j = Order % 4;
                switch (j)
                {
                    case (int)Colors.red:
                        lampColor = "Красная";
                        break;
                    case (int)Colors.yellow:
                        lampColor = "Желтая";
                        break;
                    case (int)Colors.green:
                        lampColor = "Зеленая";
                        break;
                    case (int)Colors.blue:
                        lampColor = "Синяя";
                        break;
                }
                Console.WriteLine(lampColor + " лампочка № " + Order + currentState);
            }
        }
    }
}