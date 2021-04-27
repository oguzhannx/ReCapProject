using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            foreach (var a in inMemoryCarDal.GetAll())
            {
                System.Console.WriteLine(a.Description);
            }
        }
    }
}
