using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Level_2___Challenge_1___Full_Stack_Website.Services
{
    public class AddServices : IAddServices
    {
        public int Addition(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
    }
}