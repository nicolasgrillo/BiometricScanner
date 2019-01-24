using BiometricScanner.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricScanner.Library.Models
{
    public class Shark : IAnimal
    {
        public string Eat()
        {
            return "Eating small fish...";
        }
    }
}
