using BiometricScanner.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricScanner.Extensions
{
    public static class BiometricScannerMenu
    {
        #region Constants
        private static string[] affirmativeAnswers = { "Y","YES", "IT DOES" };
        private static string[] negativeAnswers = { "N", "NO", "IT DOES NOT" };
        private static string[] validAnswers = affirmativeAnswers.Concat(negativeAnswers).ToArray();        
        #endregion

        internal static bool AskForConsumption()
        {
            string question = "Does your subject eat?";
            var answer = GetValidAnswer(question);
            return isAffirmativeAnswer(answer);
        }

        internal static bool AskForWalk()
        {
            string question = "Does your subject walk?";
            var answer = GetValidAnswer(question);
            return isAffirmativeAnswer(answer);
        }

        internal static void DisplayWelcome()
        {
            Console.WriteLine("Hello Doctor. Welcome to the Biometric Scanner" + Environment.NewLine);
            Console.WriteLine("Press any key to start.");
            Console.ReadKey();
            Console.Clear();
        }

        internal static void DisplaySubjectExpression(string output)
        {
            Console.Clear();
            Console.WriteLine("Analysis complete. Here is what the subject expressed: ");
            Console.WriteLine(output);
            Console.ReadKey();
        }

        internal static void DisplayErrorOutput()
        {
            Console.Clear();
            Console.WriteLine("Analysis complete. We could not determine the subject type with the current scanner");
            Console.ReadKey();
        }

        internal static string GetValidAnswer(string question)
        {
            Console.WriteLine(question);
            var input = Console.ReadLine();
            if (!isValidAnswer(input))
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, we could not process your input. Please try again." + Environment.NewLine);
                    Console.WriteLine(question);
                    input = Console.ReadLine();
                } while (!isValidAnswer(input));
            }
            return input;
        }

        internal static bool isValidAnswer(string input)
        {
            return validAnswers.Contains(input.ToUpper());
        }

        internal static bool isAffirmativeAnswer(string input)
        {
            return affirmativeAnswers.Contains(input.ToUpper());
        }

        //private static bool isNegativeAnswer(string input)
        //{
        //    return negativeAnswers.Contains(input.ToUpper());
        //}               
     }
}
