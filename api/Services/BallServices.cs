using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Level_2___Challenge_1___Full_Stack_Website.Services
{
    public class BallServices : IBallServices
    {
        private readonly Random _random = new Random();

        private readonly string[] _ballresponses =
        {
            "no lol.",
            "Can't talk right now, I'm busy doing stuff...",
            "Uh, sure.",
            "Maybe...",
            "I could tell you, but I won't :)",
            "My always accurate sources say 'Yes'.",
            "My always accurate sources say 'No'.",
            "Don't count on it",
            "Rely on it, maybe...",
            "Can't speak right now, I am sleeping."
        };

        public string userQuestion(string question)
        {
            int responseList = Random.Shared.Next(_ballresponses.Length);
            return _ballresponses[responseList];
        }
    }
}