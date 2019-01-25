using BiometricScanner.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricScanner.Extensions
{
    public static class Scanner
    {
        internal static void Process(bool eats, bool walks)
        {
            // Business rules to determine class. Abstract Factory should go here

            if (!eats && !walks)
            {
                BiometricScannerMenu.DisplayErrorOutput();
            }

            if (!eats)
            {
                BiometricScannerMenu.DisplaySubjectExpression(new Robot().ToString());
            }
            else
            {
                if (!walks)
                {
                    BiometricScannerMenu.DisplaySubjectExpression(new Shark().ToString());
                }
                else
                {
                    Console.Clear();
                    string question = "Does your subject stand in two legs?";
                    string answer = BiometricScannerMenu.GetValidAnswer(question);

                    if (BiometricScannerMenu.isAffirmativeAnswer(answer))
                    {
                        BiometricScannerMenu.DisplaySubjectExpression(new Human().ToString());
                    }
                    else
                    {
                        BiometricScannerMenu.DisplaySubjectExpression(new Horse().ToString());
                    }
                }
            }
        }
    }
}
