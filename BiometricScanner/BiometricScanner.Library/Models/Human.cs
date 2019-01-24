using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricScanner.Library.Models
{
    public class Human : Animal
    {
        public override string Eat()
        {
            return "Eating pizza...";
        }

        public override string Walk()
        {
            return "Taking step by step...";
        }
    }
}
