using NPF.BusinessLogic;
using System;
using System.Collections.Generic;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start testing.");

            //List<long> numbers = new List<long>() { 1, 11, 22, 33, 99, 76 };

            //foreach (var number in numbers)
            //{
            //    string response = Multiplicity.By11(number) ? "is" : "isn't";
            //    Console.WriteLine($"The number {number} {response} multiple of 11.");
            //}

            List<string> collection = new List<string>() {
                "286",
                "1331",
                "14641",
                "24350",

                "94186565",
                "56568143",

                "4611686018427387901307445734561825860123058430092136939501844674407370955160",
                "4611686018427387903307445734561825860223058430092136939511844674407370955161",

                "112233",
                "30800",
                "2937",
                "323455693",
                "5038297",
                "112234"
            };

            foreach (var item in collection)
            {
                if (long.TryParse(item, out long number))
                {
                    string response = Divisibility.By11(number) ? "is" : "isn't";
                    Console.WriteLine($"The number {number} {response} divisible by 11.");
                }
                else
                {
                    string response = Divisibility.By11(item) ? "is" : "isn't";
                    Console.WriteLine($"The number {item} {response} divisible by 11.");
                }
            }

            Console.WriteLine("The end!");
            Console.ReadKey();
        }
    }
}
