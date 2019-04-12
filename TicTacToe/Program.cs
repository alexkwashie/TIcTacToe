using System;
using System.Text;


namespace TicTacToe
{
    class Program
    {
        // the PlayField
        static char[,] playField =
        {
             {'1','2','3'},
             {'4','5','6'},
             {'7','8','9'}
        };


        static void Main(string[] args)
        {



            SetFields();
            Console.Read();
             



        }



             
        public static void SetFields()
        {
            Console.WriteLine("      |      |     ");
            //TODO replace numbers with variables
            Console.WriteLine("   {0}  |   {1}  |  {2} ", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("______|______|_____");
            Console.WriteLine("      |      |     ");
            //TODO replace numbers with variables
            Console.WriteLine("   {0}  |   {1}  |  {2} ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("______|______|_____");
            Console.WriteLine("      |      |     ");
            //TODO replace numbers with variables
            Console.WriteLine("   {0}  |   {1}  |  {2} ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("______|______|_____");
            Console.WriteLine("      |      |     ");
            Console.WriteLine("      |      |     ");
        }
            
    }
}
