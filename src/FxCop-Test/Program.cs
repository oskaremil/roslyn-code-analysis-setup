using System;
using FxCop_Test_Dependency;

namespace FxCopTest
{
    class Program
    {
        // Triggers [CA1801: Review unused parameters] when not supressed
        static void Main(string[] args)
        {
            const string helloWorld = "Hello World!";

            var dependentClass = new Class1();
            dependentClass.Foo("123");

            // Triggers [CA1303: Do not pass literals as localized parameters] when not supressed
            Console.WriteLine(helloWorld);
        }
    }
}
