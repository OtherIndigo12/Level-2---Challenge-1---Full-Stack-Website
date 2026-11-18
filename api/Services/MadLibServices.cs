using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Level_2___Challenge_1___Full_Stack_Website.Services
{
    public class MadLibServices : IMadLibServices
    {
        public string madlib(
        string name, 
        string location, 
        string color,
        string event1,
        string number,
        string letter,
        string friend,
        string eat,
        string food,
        string dessert)
        {
           string MadLib = $"{name}, who lived in {location}, one day found a brand new car which was in their favorite color, which was {color}. The car even had their favorite number which was {number} and their favorite letter which was {letter}. and so, they drove to the nearest {event1}, and while there, they saw their best friend, {friend}, and so after letting them into the car they both went to {eat}, where {name} ordered {food} and {dessert}.";

           return MadLib;
        }
    }
}