using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Level_2___Challenge_1___Full_Stack_Website.Services
{
    public class HelloServices : IHelloServices
    {
        public string SayHello(string name)
        {
          string yourName = name; 
          return yourName;
        }
        
    }
}