using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6
{
    public abstract class Garland
    {
        public string currentState { get; set; }
        public string lampColor { get; set; }
        public abstract void GetCurrentState();
    }
}