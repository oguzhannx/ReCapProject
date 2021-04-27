using System;
using DataAccess.Concrete.InMemory;

namespace Console
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
