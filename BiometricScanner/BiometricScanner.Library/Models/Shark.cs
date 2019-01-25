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
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructors
        public Shark()
        {}

        public Shark(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        #region Methods
        public string Eat()
        {
            return "Eating small fish...";
        }

        public override string ToString()
        {
            return "I am a Shark. My favourite meal is: " + Eat();
        }
        #endregion
    }
}
