using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Level_2___Challenge_1___Full_Stack_Website.Services
{
    public class CompareServices : ICompareServices
    {
        public string compare(int numOne, int numTwo)
        {
            string result = "";

            if (numOne > numTwo) {
                result = $"{numOne} is Greater Than {numTwo} and {numTwo} is Lesser Than {numOne}";
            
            }
            else if (numTwo > numOne) {
                result = $"{numTwo} is Greater Than {numOne} and {numOne} is Lesser Than {numTwo}";
            }
            else
            {
                result = "Both Numbers are Equal!";
            }
            
            return result;
        }
    }
}