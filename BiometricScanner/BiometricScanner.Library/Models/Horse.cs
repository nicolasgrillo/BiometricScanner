using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricScanner.Library.Models
{
    public class Horse : Animal
    {
        public override string Eat()
        {
            return "Eating grass...";
        }

        public override string Walk()
        {
            return "Galloping...";
        }
    }
}
