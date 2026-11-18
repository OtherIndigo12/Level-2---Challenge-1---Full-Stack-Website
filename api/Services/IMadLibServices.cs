using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Level_2___Challenge_1___Full_Stack_Website.Services
{
    public interface IMadLibServices
    {
        string madlib(
        string name, 
        string location, 
        string color,
        string event1,
        string number,
        string letter,
        string friend,
        string eat,
        string food,
        string dessert);
    }
}