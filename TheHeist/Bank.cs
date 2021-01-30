using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class Bank
    {
        public int Difficulty { get; set; }
        public int LuckValue { get; set; }

        public Bank(int difficulty)
        {
            Difficulty = difficulty;
        }

        public void AssignLuck()
        {
            var rand = new Random();
            LuckValue = rand.Next(-10, 10);
        }
    }
}
