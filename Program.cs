namespace Mario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mario m1 = new Mario();
            Random rnd = new Random();
            Console.WriteLine(m1);
            while(m1.ReturnGameOver() == false)
            {
                switch(rnd.Next(0,5))
                {
                    case 0:
                        m1.GotFireflower();
                        Console.WriteLine(m1);
                        break;
                    case 1:
                        m1.GotFeather();
                        Console.WriteLine(m1);
                        break;
                    case 2:
                        m1.GotMushroom();
                        Console.WriteLine(m1);
                        break;
                    default:
                        m1.MetMonster();
                        Console.WriteLine(m1);
                        break;

                }
            }

        }
    }
}
