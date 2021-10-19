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

        public void doSomething()//void means no return type
        {
            User me = new User();
            me.Name = "Raj Kumar";
            me.LastName = "Tiwari";
            string userMessage = me.Output(5);
            Console.WriteLine(userMessage);
            me.Output(5);//prints the output 5 times from the function inside User classs
            //me.Output();//prints the output from the function inside User classs
            //Console.WriteLine(me.Name);
            //Console.WriteLine(me.LastName);

        }
    }
}
