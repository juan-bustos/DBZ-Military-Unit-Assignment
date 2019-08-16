using System;
using System.Collections.Generic;
using System.Text;

namespace DBZ
{
    class Human
    {
        Random randomHeight = new Random();
        Random rPowerLevel = new Random();
        public string name { get; set; }
        public int height { get; }
        public int powerLevel { get; }
        public Human()
        {
            this.name = "Type a name for your human";
            this.height = randomHeight.Next(5, 7);
            this.powerLevel = rPowerLevel.Next(1, 5000);
            powerLevel.ToString();
        }
        public virtual void Interact()
        {
            Console.WriteLine($"You interact with: {name}");
        }
    }
}
