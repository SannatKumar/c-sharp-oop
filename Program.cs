using System;

namespace ooping_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program myProgram = new Program();
            myProgram.doSomething();
        }

        public void doSomething()
        {
            User me = new User();
            me.Name = "Raj Kumar";
            Console.WriteLine(me.Name);
            
        }
    }
}
