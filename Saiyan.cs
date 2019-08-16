using System;
using System.Collections.Generic;
using System.Text;

namespace DBZ
{
    public abstract class Saiyan
    {
        Random randomHeight = new Random();
        Random rPowerLevel = new Random();
        public string name { get; set; }
        public int height { get; }
        public bool tail { get; set; }
        public int powerLevel { get; }
        public bool SuperSaiyan { get; set; }
        public Saiyan()
        {
            this.name = "Type a name for your saiyan";
            this.height = randomHeight.Next(5, 10);
            this.tail = true;
            this.powerLevel = rPowerLevel.Next(1, 10000);
            powerLevel.ToString();
            this.SuperSaiyan = false;
        }
        public virtual void Attack()
        {
            Console.WriteLine("Final Flash");
        }           
    }
}
