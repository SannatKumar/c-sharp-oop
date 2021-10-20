using System;
using System.Collections.Generic;
using System.Text;

namespace ooping_csharp
{
    public class User
    {
        
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        
        public string Output(int times)//passing the arguments to reapeatedly writeline
        {
            string message = "";

            for (int i = 0; i < times; i++)
            {
                message += FirstName + " " + LastName + "\n";
            }
            return message;
        }
        
    }
}
