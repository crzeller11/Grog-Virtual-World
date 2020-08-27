using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Flashlight
    {
        public bool Bulb = false;
        public bool Handle = false;
        public bool Batteries = false;

        public bool IsFlashlightComplete()
        {
            if (Bulb && Handle && Batteries)
            {
                return true;
            }
            return false;
        }
    }


}
