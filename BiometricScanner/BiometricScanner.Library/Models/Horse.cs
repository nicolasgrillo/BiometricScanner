using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricScanner.Library.Models
{
    public class Horse : Animal
    {
        #region Constructor
        public Horse() : base ()
        { }

        public Horse(int id, string name) : base(id, name)
        { }
        #endregion

        #region Method
        public override string Eat()
        {
            return "Eating grass...";
        }

        public override string Walk()
        {
            return "Galloping...";
        }
        #endregion
    }
}
