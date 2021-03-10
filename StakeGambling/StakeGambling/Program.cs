using System;

namespace StakeGambling
{
    class Program
    {
        public const int STAKE = 100;
        public const int BET = 1;
        public const int IS_WIN = 1;
        public const int IS_lost = 0;        

        public void Play()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
                        
                if (check == IS_WIN)

                {
                    Console.WriteLine("You Win");
                }
                else
                {
                    Console.WriteLine("You Lose");
                    
                }
            }
            static void Main(string[] args)
        {
            Program program  = new Program();
            program.Play();
        }
    }
}
