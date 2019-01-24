using BiometricScanner.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricScanner.Library.Models
{
    public abstract class Animal : IAnimal, IWalker
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract string MakeNoise();

        public abstract string Walk();
        
    }
    
}
