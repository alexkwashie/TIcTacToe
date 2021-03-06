﻿using System;
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


        //Reset Fields after game is over
        static char[,] playFieldInitial =
        {
             {'1','2','3'},
             {'4','5','6'},
             {'7','8','9'}
        };

        //Set Turns
        static int turns = 0;


        static void Main(string[] args)
        {

            int player = 2; //Player 2 starts
            int input = 0;
            bool inputCorrect = true;


            


            //Run code as long as program runs
            do
            {
                if (player == 2) //this means player 1 will start
                {
                    player = 1;
                    EnterXorO(player, input);
                    
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }

                SetFields();


                #region
                //Check winings

                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (
                        ((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar))
                        || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                        || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                        || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))
                        )

                    { 

                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won");
                        }


                        Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();

                        //Reset field afterplay has won
                        ResetField();


                        break;
                    } 

                    else if(turns == 10)
                    {
                        Console.WriteLine("The Game is a Draw!");
                        Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }
                #endregion



                #region
                //Get player input and test if field is already taken
                do
                {
                    Console.WriteLine(" Player {0} : Choose your field? :  ", player);

                    try
                    {
                        input = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                    // i.e. if input is already taken 
                    if ((input == 1) && (playField[0, 0] == '1')) //if input is already taken this becomes (the input code doesnt match this) and jumps to the else block
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9 ) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input. Please enter another number");
                        inputCorrect = false;
                    }

                } while (!inputCorrect); //if input is false, run code again

                #endregion



            } while (true);


            
        }

        
        public static void ResetField()
        {
            playField = playFieldInitial; //set it to the playFieldInitial with the similar numbers
            SetFields();  //Reset the new playField(here in this method to the SetFields() method code below)

            turns = 0;
        }

             
        public static void SetFields()
        {
            Console.Clear();
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
            turns++; // Everytime a field is set, is adds 1 to the (turns) variable
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
                case 1: playField[0, 0] = playersign ; break;  //playField[0,0] = 1
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
