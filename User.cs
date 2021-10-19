using System;
using System.Collections.Generic;
using System.Text;

namespace ooping_csharp
{
    public class User
    {
        string _firstName = "hei There";
        public string FirstName
        {
            get
            {
                return _firstName.ToLower();
            }
        }
        public string LastName;
        
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
