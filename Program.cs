
using System;

namespace TIC_TAC_TOE
{
    class Program
    {
        static void Main(string[] args)
        {


            string a1 = " ", a2 = " ", a3 = " ", a4 = " ", a5 = " ", a6 = " ", a7 = " ", a8 = " ", a9 = " ";
            string T = "X";
            string input;
            int inputNumber = 0;
            int Tnumber = 0;
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("=======================");
            Console.WriteLine();

            int i = 0;

            while (i < 9)
            {
                Console.WriteLine($" {a1} | {a2} | {a3}");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" {a4} | {a5} | {a6}");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" {a7} | {a8} | {a9}");
                if (Tnumber % 2 == 0) T = "X";
                else T = "O";

                while (Tnumber < 9)

                {
                    Console.Write($"{T}'s move > ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out inputNumber)) continue;
                    switch (inputNumber)
                    {
                        case 1:
                            if (a1 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAIN");
                                continue;
                            }
                            a1 = T;
                            break;
                        case 2:
                            if (a2 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAIN");
                                continue;
                            }
                            a2 = T;
                            break;
                        case 3:
                            if (a3 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAIN");
                                continue;
                            }
                            a3 = T;
                            break;
                        case 4:
                            if (a4 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAIN");
                                continue;
                            }
                            a4 = T;
                            break;
                        case 5:
                            if (a5 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAIN");
                                continue;
                            }
                            a5 = T;
                            break;
                        case 6:
                            if (a6 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAIN");
                                continue;
                            }
                            a6 = T;
                            break;
                        case 7:
                            if (a7 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAIN");
                                continue;
                            }
                            a7 = T;
                            break;
                        case 8:
                            if (a8 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAIN");
                                continue;
                            }
                            a8 = T;
                            break;
                        case 9:
                            if (a9 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAIN");
                                continue;
                            }
                            a9 = T;
                            break;
                        default:
                            Console.WriteLine("ILLEGAL MOVE! TRY AGAIN");
                            continue;
                    }
                    i++;
                    Tnumber++;
                    break;
                }

            }
            Console.WriteLine("GAME OVER...");
        }
    }
}