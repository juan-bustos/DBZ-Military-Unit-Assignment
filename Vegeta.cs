using System;
using System.Collections.Generic;
using System.Text;

namespace DBZ
{
    class Vegeta : Saiyan
    {
        public override void Attack()
        {
            Console.WriteLine($"Vegeta's signature attack is: Final Flash");
        }
    }
}
