using System;

namespace StakeGambling
{
    class Program
    {
        public int STAKE = 100;
        public const int BET = 1;
        public const int IS_WIN = 1;
        public const int IS_lost = 0;

        public void Play()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            int countWin = 0;
            int countLose = 0;

            for (int day = 0; day <= 20; day++)
            {

                if (check == IS_WIN)

                {
                    Console.WriteLine("You Win");
                    countWin++;
                    STAKE++;
                }
                else
                {
                    Console.WriteLine("You Lose");
                    countLose++;
                    STAKE--;

                }
            }
             Console.WriteLine("Number of times win:"+countWin);
            Console.WriteLine("Number of times lost:" + countLose);           
        }
       

    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Play();
    }
}


