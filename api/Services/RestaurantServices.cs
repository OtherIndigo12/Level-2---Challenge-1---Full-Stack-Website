using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Level_2___Challenge_1___Full_Stack_Website.Services
{
    public class RestaurantServices : IRestaurantServices
    {
        private readonly string[] _pizzaResponse =
        {
            "Mountain Mike's",
            "Little Ceasar's",
            "Domino's",
            "Round Table",
            "Papa John's",
            "Eric's Pizza",
            "Micheal's New York Style Pizza",
            "AP's Pizza",
            "Eddie's Pizza Cafe",
            "Freddy Fazbear's Pizza"
        };

        private readonly string[] _burgerResponse =
        {
            "Five Guys",
            "Moo Moo's Burger Farm",
            "Habbit Burger and Grill",
            "Bob's at the Marina",
            "Chilli's",
            "AppleBee's",
            "Lumberjack's Resturant",
            "Garlic Brothers",
            "Carl's Jr.",
            "Red Robin"
        };

        private readonly string[] _chineseFoodResponse =
        {
            "China Village",
            "China Palace",
            "Luu's Chicken Bowl",
            "Sherman's Chinese Buffet",
            "Panda Express",
            "Sam's Cafe",
            "Prosperity Szechuan Cuisine",
            "East Garden Chinese Express",
            "GK Mongolian BBQ",
            "Yen Du Resturant"
        };

        public string randomSelect(string response)
        {
            string response1 = response.Trim().ToLower();

            switch (response1)
            {
                case "pizza":
                    return _pizzaResponse[Random.Shared.Next(_pizzaResponse.Length)];
                case "burgers":
                    return _burgerResponse[Random.Shared.Next(_burgerResponse.Length)];
                case "chinese food":
                    return _chineseFoodResponse[Random.Shared.Next(_chineseFoodResponse.Length)];
                default:
                    return "Please Select one of the 3 Options...";
            }
        }
    }
}