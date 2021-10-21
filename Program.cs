using System;
using System.Xml.Serialization;
using System.Collections.Generic;

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
            //me.FirstName = "Raj Kumar";
            me.LastName = "Tiwari";
            string userMessage = me.Output(5);
            Console.WriteLine(userMessage);
            Console.WriteLine(me.FirstName);
            me.Output(5);//prints the output 5 times from the function inside User classs
            //me.Output();//prints the output from the function inside User classs
            //Console.WriteLine(me.Name);
            //Console.WriteLine(me.LastName);


            User you = new User();
            you.FirstName = "Agrima";
            you.LastName = "KC";

            List<User> users = new List<User>();
            users.Add(me); users.Add(you);

            foreach(User currentUser in users)
            {
                Console.WriteLine(currentUser.FullName);
            }

            //clsPerson

            clsPerson dataClsPerson = new clsPerson
            {
                FirstName = "Poshan",
                LastName = "Bahadur",
                MI = "A"
            };

            System.Xml.Serialization.XmlSerializer mySerializeFile = new System.Xml.Serialization.XmlSerializer(dataClsPerson.GetType());
            mySerializeFile.Serialize(Console.Out, dataClsPerson);
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
