using System;
using System.Collections.Generic;
using System.Threading;

namespace PatternGame
{
    class Program
    {
        static int points = 0;
        static void Main(string[] args)
        {
            int delay = 500;
            bool playAgain = false;
            do
            {
                Console.WriteLine("Be ready and repeat the pattern, in..");
                Thread.Sleep(1000);
                for(int i = 3; i > 0; i--)
                {
                    Console.WriteLine(i + "..");
                    Thread.Sleep(1000);
                }
                PlayGame(delay);
                Console.WriteLine("Points: " + points + "\n");
                
                Console.WriteLine("Press [SPACE] or [ENTER] to play again: ");
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Spacebar || key.Key == ConsoleKey.Enter)
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

                if(delay > 100)
                {
                    delay -= 50;
                }
            } while (playAgain);

            //avslutat
            Console.WriteLine("Goodbye..");
        }

        static void PlayGame(int delay)
        {
            List<int> amountOfPatterns = randomPatternGenerator();
            for (int i = 0; i < amountOfPatterns.Count; i++)
            {
                Console.Clear();
                Console.WriteLine(i + 1);
                string[] pattern = patterns(amountOfPatterns[i]);
                for (int s = 0; s < pattern.Length; s++)
                {
                    Console.Write(pattern[s]);
                }
                Thread.Sleep(delay);
            }

            Console.Clear();
            Console.WriteLine("Try to remember the pattern:\n");
            List<int> keyInput = getKeyInput(amountOfPatterns.Count); //lika många gissningar som mönster

            Console.Clear();
            Console.WriteLine("Stats: ");
            for (int i = 0; i < amountOfPatterns.Count; i++)
            {
                if (amountOfPatterns[i] == keyInput[i])
                {
                    points++;
                    Console.WriteLine(i + 1 + " Correct");
                }
                else
                {
                    points--;
                    Console.WriteLine(i + 1 + " False");
                }
            }
            Thread.Sleep(800);
        }

        static List<int> getKeyInput(int amountOfInputs)
        {
            List<int> KeyInput = new List<int>(); //keys pressed
            bool keyInputCorrect = false;
            for (int i = 0; i < amountOfInputs; i++)
            {
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    keyInputCorrect = true; //correct input type
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            KeyInput.Add(1); //up = 1
                            break;
                        case ConsoleKey.DownArrow:
                            KeyInput.Add(2); //down = 2
                            break;
                        case ConsoleKey.LeftArrow:
                            KeyInput.Add(3); //left = 3
                            break;
                        case ConsoleKey.RightArrow:
                            KeyInput.Add(4); //right = 4
                            break;
                        default:
                            Console.WriteLine("Not a correct input, please try with the keyboard arrows!");
                            keyInputCorrect = false;
                            break;
                    }
                } while (!keyInputCorrect);
            }

            return KeyInput;
        }

        static List<int> randomPatternGenerator()
        {
            List<int> patternIndexes = new List<int>();
            Random rnd = new Random();
            int randomAmount = rnd.Next(3, 6); // 3 - 6 patterns
            
            for(int i = 0; i < randomAmount; i++)
            {
                int randomPattern = rnd.Next(1, 5); //random amount patterns, index 1-4
                patternIndexes.Add(randomPattern);
            }
            return patternIndexes;
        }

        static string[] patterns(int index)
        {
            string[] pattern0 =
            {
                    "           ╔══════╗        " + '\n' +
                    "           ║      ║        " + '\n' +
                    "           ╚╗    ╔╝        " + '\n' +
                    "    ╔═══╗   ╚╗  ╔╝   ╔═══╗ " + '\n' +
                    "    ║   ╚═══╗╚══╝╔═══╝   ║ " + '\n' +
                    "    ║       ║    ║       ║ " + '\n' +
                    "    ║   ╔═══╝╔══╗╚═══╗   ║ " + '\n' +
                    "    ╚═══╝   ╔╝  ╚╗   ╚═══╝ " + '\n' +
                    "           ╔╝    ╚╗        " + '\n' +
                    "           ║      ║        " + '\n' +
                    "           ╚══════╝        "+ '\n'
            };

            string[] pattern1 =
            {
                    "           ╔══════╗        " + '\n' +
                    "           ║██████║        " + '\n' +
                    "           ╚╗████╔╝        " + '\n' +
                    "    ╔═══╗   ╚╗██╔╝   ╔═══╗ " + '\n' +
                    "    ║   ╚═══╗╚══╝╔═══╝   ║ " + '\n' +
                    "    ║       ║    ║       ║ " + '\n' +
                    "    ║   ╔═══╝╔══╗╚═══╗   ║ " + '\n' +
                    "    ╚═══╝   ╔╝  ╚╗   ╚═══╝ " + '\n' +
                    "           ╔╝    ╚╗        " + '\n' +
                    "           ║      ║        " + '\n' +
                    "           ╚══════╝        " + '\n'
            };

            string[] pattern2 =
            {
                    "           ╔══════╗        " + '\n' +
                    "           ║      ║        " + '\n' +
                    "           ╚╗     ╝        " + '\n' +
                    "    ╔═══╗   ╚╗  ╔╝   ╔═══╗ " + '\n' +
                    "    ║   ╚═══╗╚══╝╔═══╝   ║ " + '\n' +
                    "    ║       ║    ║       ║ " + '\n' +
                    "    ║   ╔═══╝╔══╗╚═══╗   ║ " + '\n' +
                    "    ╚═══╝   ╔╝██╚╗   ╚═══╝ " + '\n' +
                    "           ╔╝████╚╗        " + '\n' +
                    "           ║██████║        " + '\n' +
                    "           ╚══════╝        "+ '\n'
            };
            
            string[] pattern3 =
            {
                "           ╔══════╗        " + '\n' +
                "           ║      ║        " + '\n' +
                "           ╚╗    ╔╝        " + '\n' +
                "    ╔═══╗   ╚╗  ╔╝   ╔═══╗ " + '\n' +
                "    ║███╚═══╗╚══╝╔═══╝   ║ " + '\n' +
                "    ║███████║    ║       ║ " + '\n' +
                "    ║███╔═══╝╔══╗╚═══╗   ║ " + '\n' +
                "    ╚═══╝   ╔╝  ╚╗   ╚═══╝ " + '\n' +
                "           ╔╝    ╚╗        " + '\n' +
                "           ║      ║        " + '\n' +
                "           ╚══════╝        "+ '\n'
            };

            string[] pattern4 =
            {
                "           ╔══════╗        " + '\n' +
                "           ║      ║        " + '\n' +
                "           ╚╗    ╔╝        " + '\n' +
                "    ╔═══╗   ╚╗  ╔╝   ╔═══╗ " + '\n' +
                "    ║   ╚═══╗╚══╝╔═══╝███║ " + '\n' +
                "    ║       ║    ║███████║ " + '\n' +
                "    ║   ╔═══╝╔══╗╚═══╗███║ " + '\n' +
                "    ╚═══╝   ╔╝  ╚╗   ╚═══╝ " + '\n' +
                "           ╔╝    ╚╗        " + '\n' +
                "           ║      ║        " + '\n' +
                "           ╚══════╝        "+ '\n'
            };

            if(index == 0) // inget nedtryckt
            {
                return pattern0;
            } else if(index == 1) //upp knappen
            {
                return pattern1;
            } else if(index == 2) //ner knappen
            {
                return pattern2;
            }
            else if (index == 3) //vänster knappen
            {
                return pattern3;
            }
            else if (index == 4) //höger knappen
            {
                return pattern4;
            }
            //default
            return pattern0;
        }
    }
}
