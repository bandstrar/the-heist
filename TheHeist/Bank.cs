using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class Bank
    {
        public int Difficulty { get; set; } = 100;
        public int LuckValue { get; set; }


        public void AssignLuck()
        {
            var rand = new Random();
            LuckValue = rand.Next(-10, 10);
        }
    }
}
