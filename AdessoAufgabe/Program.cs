using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AdessoAufgabe
{
    internal class Program
    {
        //static Fields
        static int[,] pitch = new int[5, 5]
        {
            {1,124,2,124,3},
            {45,43,45,43,45},
            {4,124,5,124,6},
            {45,43,45,43,45},
            {7,124,8,124,9}
        };
        static int[,] defaultpitch = new int[5, 5]
        {
            {1,124,2,124,3},
            {45,43,45,43,45},
            {4,124,5,124,6},
            {45,43,45,43,45},
            {7,124,8,124,9}
        };
        static int checkwin = 0;
        static int maxrounds;
        static int input;
        static int player;
        static bool until=true;
        static bool breakgame = true;

        static void Main(string[] args)
        {
            //Fields
            char playagain;
            Console.WriteLine("Name\t Vorname\t Adresse\t");
            do //Loop For Continue 
            {
                try //Catch Failure Inputs
                {
                    do //Loop For Game
                    {
                        Console.Clear();                        
                        maxrounds = 0; // Reset Counter
                        player = 1; // Reset Counter                     
                        ShowDefaultPitch(); // Creating New Pitch
                        Console.WriteLine();

                        do //Loop for ingame
                        {
                            until = true; // Reset Boolean For Catching Any Failure Inputs
                            if (player == 1) // Check Players Turn
                            {
                                Player1Turn();
                                checkwin = CheckWin();
                            }
                            else
                            {
                                Player2Turn();
                                checkwin = CheckWin();
                            }
                        } while (checkwin != 1 && maxrounds < 9);
                    
                        if (checkwin == 1) //Win Situation
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            Console.WriteLine($"Player {player} has won the game!");
                        }
                        else //Draw Situation
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine();
                            Console.WriteLine("Draw!");
                        }
                        Console.WriteLine();
                        //Asking To Continue The Game
                        Console.WriteLine("Press Y to play again.");
                        Console.Write("Press any key to leave the game. - ");
                        playagain = Convert.ToChar(Console.ReadLine().ToUpper());
                        if (playagain == 'N')
                        {
                            breakgame = false;
                        }
                    } while (playagain == 'Y');

                    Console.WriteLine();
                    Console.WriteLine("Game Over.");                   
                }
                catch (Exception)
                {
                    Console.WriteLine("Your input was wrong! Please try again.");                  
                }
            } while (breakgame);
        }

        ////Static Methods
        static void ShowDefaultPitch()
        //Creating default pitch
        {
            for (int i = 0; i < pitch.GetLength(0); i++)
            {
                for (int j = 0; j < defaultpitch.GetLength(1); j++)
                {
                    pitch[i, j] = defaultpitch[i, j];
                }
            }
            ShowPitch();
        }
        static void ShowPitch()
        //Creating the pitch field
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int f = 0; f < 5; f++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (pitch[f, i] > 40)
                    {
                        Console.Write(Convert.ToChar(pitch[f, i]));
                    }
                    else
                    {
                        Console.Write(pitch[f, i]);
                    }
                }
                Console.WriteLine();
            }
        }
        static void Player1Turn()
        //Player 1 decisions - switch case 
        {
            Console.WriteLine();
            Console.WriteLine("Player 1 Turn.");
            do
            {              
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Choose a number between 1 till 9. - ");
                string s = Console.ReadLine();
                input = Convert.ToInt32(s);

                if (input > 0 && input <= 9)
                {
                    switch (input)
                    {
                        case 1:
                            if (pitch[0, 0] == input)
                            {
                                pitch[0, 0] = 88;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 2:
                            if (pitch[0, 2] == input)
                            {
                                pitch[0, 2] = 88;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked(); ;
                            }
                            break;
                        case 3:
                            if (pitch[0, 4] == input)
                            {
                                pitch[0, 4] = 88;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 4:
                            if (pitch[2, 0] == input)
                            {
                                pitch[2, 0] = 88;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 5:
                            if (pitch[2, 2] == input)
                            {
                                pitch[2, 2] = 88;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 6:
                            if (pitch[2, 4] == input)
                            {
                                pitch[2, 4] = 88;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 7:
                            if (pitch[4, 0] == input)
                            {
                                pitch[4, 0] = 88;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 8:
                            if (pitch[4, 2] == input)
                            {
                                pitch[4, 2] = 88;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 9:
                            if (pitch[4, 4] == input)
                            {
                                pitch[4, 4] = 88;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Your input was too big or wrong. Please try again.");
                    until = true;
                }
            } while (until);
        }
        static void Player2Turn()
        //Player 2 decisions - switch case
        {
            Console.WriteLine();
            Console.WriteLine("Player 2 Turn.");
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Choose a number between 1 till 9. - ");
                string s = Console.ReadLine();
                input = Convert.ToInt32(s);

                if (input > 0 && input <= 9)
                {
                    switch (input)
                    {
                        case 1:
                            if (pitch[0, 0] == input)
                            {
                                pitch[0, 0] = 79;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 2:
                            if (pitch[0, 2] == input)
                            {
                                pitch[0, 2] = 79;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked(); ;
                            }
                            break;
                        case 3:
                            if (pitch[0, 4] == input)
                            {
                                pitch[0, 4] = 79;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 4:
                            if (pitch[2, 0] == input)
                            {
                                pitch[2, 0] = 79;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 5:
                            if (pitch[2, 2] == input)
                            {
                                pitch[2, 2] = 79;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 6:
                            if (pitch[2, 4] == input)
                            {
                                pitch[2, 4] = 79;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 7:
                            if (pitch[4, 0] == input)
                            {
                                pitch[4, 0] = 79;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 8:
                            if (pitch[4, 2] == input)
                            {
                                pitch[4, 2] = 79;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        case 9:
                            if (pitch[4, 4] == input)
                            {
                                pitch[4, 4] = 79;
                                maxrounds++;
                                until = false;
                                Console.Clear();
                                ShowPitch();
                            }
                            else
                            {
                                AlreadyMarked();
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Your input was too big or wrong. Please try again.");
                    until = true;
                }
            } while (until);
        }
        static int CheckWin()
        //Creating win situations
        {
            //First Row
            if (pitch[0, 0] == pitch[0, 2] && pitch[0, 2] == pitch[0, 4])
            {
                return checkwin = 1;
            }

            //Second Row
            else if (pitch[0, 2] == pitch[2, 2] && pitch[2, 2] == pitch[4, 2])
            {
                return checkwin = 1;
            }

            //Third Row
            else if (pitch[4, 0] == pitch[4, 2] && pitch[4, 2] == pitch[4, 4])
            {
                return checkwin = 1;
            }

            //First Column
            else if (pitch[0, 0] == pitch[2, 0] && pitch[2, 0] == pitch[4, 0])
            {
                return checkwin = 1;
            }

            //Second Column
            else if (pitch[2, 0] == pitch[2, 2] && pitch[2, 2] == pitch[2, 4])
            {
                return checkwin = 1;
            }

            //Third Column
            else if (pitch[0, 4] == pitch[2, 4] && pitch[2, 4] == pitch[4, 4])
            {
                return checkwin = 1;
            }

            //Diagonal
            else if (pitch[0, 0] == pitch[2, 2] && pitch[2, 2] == pitch[4, 4])
            {
                return checkwin = 1;
            }
            else if (pitch[0, 4] == pitch[2, 2] && pitch[2, 2] == pitch[4, 0])
            {
                return checkwin = 1;
            }

            else
            {
                if (player == 1)
                {
                    player++;
                }
                else
                {
                    player--;
                }
                return checkwin = 0;
            }
        }
        static void AlreadyMarked()
        //Output for marked spots
        {
            Console.Clear();
            ShowPitch();
            Console.WriteLine("The row is already marked. Please try again.");
        }
    }
}