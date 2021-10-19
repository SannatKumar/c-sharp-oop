using System;
using System.Collections.Generic;
using System.Text;

namespace ooping_csharp
{
    public class User
    {
        public string Name;
        public string LastName;
        
        public string Output(int times)//passing the arguments to reapeatedly writeline
        {
            string message = "";

            for (int i = 0; i < times; i++)
            {
                message += Name + " " + LastName + "\n";
            }
            return message;
        }
        
    }
}
