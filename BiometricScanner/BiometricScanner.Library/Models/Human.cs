using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricScanner.Library.Models
{
    public class Human : Animal
    {
        #region Constructors
        public Human()
        {

        }

        public Human(int id, string name) : base (id,name)
        {

        }
        #endregion

        #region Methods
        public override string Eat()
        {
            return "Eating pizza...";
        }

        public override string Walk()
        {
            return "Taking step by step...";
        }
        #endregion
    }
}
