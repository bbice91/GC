using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillenialConverter

{
    class Program

    {
        static void Main()

        {
            string InputType;
            double InputAmount;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Input Measurement type? (inch; foot; meme; fidget spinner)");
                InputType = Console.ReadLine();
                Console.WriteLine("Amount?");
                InputAmount = Convert.ToDouble(Console.ReadLine());

                switch (InputType)
                {
                    case "inch":
                        Console.WriteLine($"{InputAmount * 3.5} fidget spinners");
                        break;

                    case "fidget spinner":
                        Console.WriteLine($"{InputAmount / 3.5} inches");
                        break;

                    case "foot":
                        Console.WriteLine($"{InputAmount * 5} memes");
                        break;

                    case "meme":
                        Console.WriteLine($"{InputAmount / 5} feet");
                        break;
                }

                Console.WriteLine("Continue to Convert (YES to Continue)?");
                Console.ReadLine();
                if (Console.ReadLine() == "YES")
                {
                    continue;

                }
                else
                    return;
            }

        }

    }

}