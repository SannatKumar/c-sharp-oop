using System;
using System.Collections.Generic;
using System.Text;

namespace ooping_csharp
{
    public class User
    {
        public string Name;
        public string LastName;
        
        public void Output(int times)//passing the arguments to reapeatedly writeline
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(Name);
                Console.WriteLine(LastName);

            }
        }
        
    }
}
