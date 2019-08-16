using System;
using System.Collections.Generic;
using System.Text;

namespace DBZ
{
    public class SuperSaiyan : Saiyan
    {
        Random rPowerLevel = new Random();
        public int SSJPowerLevel { get; set; }
        public int SuperPowerLevel()
        {
            this.SSJPowerLevel = rPowerLevel.Next(10000) * 500;
            SSJPowerLevel.ToString();
            return SSJPowerLevel;
        }
    }
    public class GreatApe : Saiyan
    {
        Random rPowerLevel = new Random();
        public int GreatApePowerLevel { get; set; }
        public int GreatApePL()
        {
            this.GreatApePowerLevel = rPowerLevel.Next(5000) * 500;
            GreatApePowerLevel.ToString();
            return GreatApePowerLevel;
        }
    }
}
