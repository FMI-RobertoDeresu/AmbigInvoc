using System;
using System.Threading.Tasks;

namespace AmbigInvoc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SomeMethod(GetObject);
        }

        public static IInterface GetObject() => null;

        public static void SomeMethod(Func<IInterface> func) => Console.WriteLine("First");

        public static void SomeMethod(Func<Task<IInterface>> funcAsync) => Console.WriteLine("Second");
    }

    public interface IInterface { }
}