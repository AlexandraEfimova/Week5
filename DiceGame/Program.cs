using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //molemad mangijad viskavad taringuid
            //programm kontrollib, kumb mangija viskas rohkem
            //mangija, kes viskab rohkem, ongi mangu voistja
            //taringuid visatakse kolm korda
            //programm kuulutab voitjat

            Random rnd = new Random();

           
            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                
                int cpuNumber = rnd.Next(1, 7);
                int userNumber = rnd.Next(1, 7);
                Console.WriteLine($"Arvuti viskas {cpuNumber}. Kasutaja viskas {userNumber}");
                cpuScore = cpuScore + cpuNumber;
                userScore = userScore + userNumber;
            }

            Console.WriteLine($"Arvuti resultaat on {cpuScore}. Kasutaja resultaat on {userScore}");

            
            if (cpuScore < userScore)
            {
                Console.WriteLine("Kasutaja on mangu voitnud. Palju onne!");
                userScore = userScore + 1;
            }
            else if(cpuScore > userScore)
            {
                Console.WriteLine("Arvuti on mangu voitnud.");
                cpuScore = cpuScore + 1;
            }
            else
            {
                Console.WriteLine("Viik!");
            }
        }
    }
}
