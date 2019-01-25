using BiometricScanner.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricScanner.Library.Models
{
    public class Robot : IWalker
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }

        #endregion

        #region Constructor
        public Robot()
        { }

        public Robot(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        #region Methods
        public string Walk()
        {
            return "Taking mechanical steps...";
        }

        public override string ToString()
        {
            return "I am a Robot!. My way of moving is: " + Walk();
        }
        #endregion
    }
}
