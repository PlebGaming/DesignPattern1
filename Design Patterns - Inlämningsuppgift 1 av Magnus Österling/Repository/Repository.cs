using Design_Patterns_Assignment;

using System;

namespace Design_Patterns_Assignment
{
    internal class Repository
    {
        internal static void Run()
        {
            IDataRepository dataRepository = new DataRepository();
            Console.WriteLine("Repository");

            var data = dataRepository.Load("Dataset A");
            var customer = dataRepository.Load("From Table Customer Where Name==Steve");
            var animal = dataRepository.Load("From Table Animal Where Owner==Steve");
            dataRepository.Save(data);
            dataRepository.Save(customer);
            dataRepository.Save(animal);
            Console.WriteLine();
        }
    }
}