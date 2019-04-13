using System;
using System.Text;


namespace TicTacToe
{
    class Program
    {
        // Creat default PlayField (characters are in ' ', string in "" and int = 4)
        static char[,] playField =
        {
             {'1','2','3'},
             {'4','5','6'},
             {'7','8','9'}
        };



        static void Main(string[] args)
        {

            int player = 2; //Player 2 starts
            int input = 0;
            bool inputCorrect = true;


            //Run code as long as program runs
            do
            {
                if(player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);

                } else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }


                //Get player input
                do
                {
                    Console.WriteLine(" Player {0} : Choose your feild? :  ", player);
                    input = int.Parse(Console.ReadLine());
                    



                } while (!inputCorrect);




            } while (true);


            

           
        }



             
        public static void SetFields()
        {
            Console.WriteLine("      |      |     ");
            Console.WriteLine("   {0}  |   {1}  |  {2} ", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("______|______|_____");
            Console.WriteLine("      |      |     ");
            Console.WriteLine("   {0}  |   {1}  |  {2} ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("______|______|_____");
            Console.WriteLine("      |      |     ");
            Console.WriteLine("   {0}  |   {1}  |  {2} ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("______|______|_____");
            Console.WriteLine("      |      |     ");
            Console.WriteLine("      |      |     ");
        }
           

        public static void EnterXorO ( int player, int input)
        {
            char playersign = ' ';

            if (player == 1)
                playersign = 'X';
            else if (player == 2)
                playersign = 'O';

            switch (input)
            {
                case 1: playField[0, 0] = playersign ; break;
                case 2: playField[0, 1] =  playersign; break;
                case 3: playField[0, 2] =  playersign; break;
                case 4: playField[1, 0] = playersign; break;
                case 5: playField[1, 1] =  playersign; break;
                case 6: playField[1, 2] =  playersign; break;
                case 7: playField[2, 0] =  playersign; break;
                case 8: playField[2, 1] =  playersign; break;
                case 9: playField[2, 2] =  playersign; break;

            }
        }














    }
}
