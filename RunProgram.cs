using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DBZ
{
    public class RunProgram
    {
        public RunProgram()
        {
            Console.WriteLine("You created Goku!");
            Thread.Sleep(1000); // Delay of 1 seconds. 
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            // Normal random instance of Goku
            Saiyan goku = new Goku();
            Thread.Sleep(1000);
            goku.Attack();
            Thread.Sleep(2000);
            Console.WriteLine($"Goku is {goku.height} feet tall.");
            Thread.Sleep(2000);
            Console.WriteLine($"Goku's powerlevel is: {string.Format("{0:n0}", goku.powerLevel)}");
            Thread.Sleep(2000);
            goku.tail = false;
            if (goku.tail == false)
            {
                Console.WriteLine("Goku lost his tail when he was younger");
            }
            Thread.Sleep(2000);
            goku.SuperSaiyan = true;
            if (goku.SuperSaiyan == true)
            {
                Console.WriteLine("Goku is able to turn into a Super Saiyan");
                Thread.Sleep(2000);
                Console.WriteLine("Press any key to transform him into a Super Saiyan");
                Console.ReadKey();
                Console.Clear();
                // Yelling sequence
                Thread.Sleep(1000);
                Console.WriteLine("Goku is powering up!");
                Thread.Sleep(1500);
                string yell = "AGHHHHHHHHHHHHHH";
                for (int i = 0; i < 5; i++)
                {
                    yell += "HHHHHHHHHH";
                    Console.WriteLine(yell);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            // New characteristics of Goku when he goes super Saiyan.
            SuperSaiyan Goku = new SuperSaiyan();
            Console.WriteLine($"SSJ Goku's new powerlevel is: {string.Format("{0:n0}", Goku.SuperPowerLevel())}");
            Thread.Sleep(3000);
            Console.WriteLine("Press any key to create another Saiyan");
            Console.ReadKey();
            Console.Clear();

            // New Saiyan Created is Vegeta
            Console.WriteLine("You have created Vegeta");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            // Normal random instance of Vegeta
            Saiyan vegeta = new Vegeta();
            vegeta.Attack();
            Console.WriteLine($"Vegeta is {vegeta.height} feet tall.");
            Console.WriteLine($"Vegeta's powerlevel is: {string.Format("{0:n0}", vegeta.powerLevel)}");
            vegeta.tail = true;
            if (vegeta.tail == true)
            {
                Console.WriteLine("Vegeta still has his tail");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Vegeta turns into a Great Ape!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            GreatApe greatApeVegeta = new GreatApe();
            Console.WriteLine($"Great Ape Vegeta's new powerlevel is: {string.Format("{0:n0}", greatApeVegeta.GreatApePL())}");
            Thread.Sleep(3000);
            Console.WriteLine("Press any key to create a new Human");
            Console.ReadKey();
            Console.Clear();
            vegeta.SuperSaiyan = false; //Since vegeta can't turn super saiyan we won't interate through the SSJ loop. 

            Console.WriteLine("You created Yamcha!");
            Thread.Sleep(1000); // Delay of 1 seconds. 
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Human Yamcha = new Yamcha();
            Console.WriteLine($"Yamcha is: {Yamcha.height} feet tall.");
            Thread.Sleep(2000);
            Console.WriteLine($"Yamcha's powerlevel is: {string.Format("{0:n0}", Yamcha.powerLevel)}");
            Thread.Sleep(1500);
            Console.WriteLine("Press any key to interact with Yamcha");
            Thread.Sleep(1000);
            Console.ReadKey();
            Console.Clear();
            Yamcha.Interact();
        }
    }
}
