using System;

namespace HW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGarland Lamp = new SimpleGarland();
            Lamp.GetCurrentState();
            ColoredGarland ColoredLamp = new ColoredGarland();
            ColoredLamp.GetCurrentState();
            Console.ReadKey();
        }
    }
}