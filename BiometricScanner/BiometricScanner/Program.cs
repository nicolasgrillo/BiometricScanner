using BiometricScanner.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            BiometricScannerMenu.DisplayWelcome();
            bool SubjectEats = BiometricScannerMenu.AskForConsumption();
            Console.Clear();
            bool SubjectWalks = BiometricScannerMenu.AskForWalk();
            Scanner.Process(SubjectEats, SubjectWalks);
        }        
    }
}
