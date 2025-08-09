using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] symptoms = new string[5];

            Console.WriteLine("Please enter symptoms for 5 patients");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Patient {i + 1} symptoms: ");
                symptoms[i] = Console.ReadLine().ToLower();
            }

            Console.WriteLine("\nDepartment Assignment Results:");

            for (int i = 0; i < 5; i++)
            {
                string assignedDepartment = DetermineDepartment(symptoms[i]);
                Console.WriteLine($"Patient {i + 1} with symptoms '{symptoms[i]}' → {assignedDepartment}");
            }
        }

        static string DetermineDepartment(string symptoms)
        {
            if (symptoms.Contains("fever") || symptoms.Contains("cough"))
            {
                return "General Medicine";
            }
            else if (symptoms.Contains("injury") || symptoms.Contains("burn"))
            {
                return "Emergency";
            }
            else
            {
                return "Refer to Specialist";
            }
        }
    }
}
       

           