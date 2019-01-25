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
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructor
        public Animal()
        { }

        public Animal(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        #region Method
        public abstract string Eat();

        public abstract string Walk();
        #endregion

    }

}
