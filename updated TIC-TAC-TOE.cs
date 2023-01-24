using System;
namespace value_parameter
{
    class Program
    {


        //Here is the Class For Mechanice of the Game
        class TicTacToeMechanics
        {

            




            public void function(char[] tic_array, char[] final_array, char[] final_array_)
            {
                Console.WriteLine("Player A ::Which Index you wanna mark");
                int mark = Convert.ToInt32(Console.ReadLine());

                while (true)
                {
                    if (tic_array[mark-1]=='O'|| tic_array[mark - 1] == 'X')
                    {
                        Console.WriteLine("Invalid Option Choosen Turn Failed");
                        break;
                    }

                    if (mark == 1)
                    {
                        var temp = tic_array[0];
                        tic_array[0] = final_array[0];
                        final_array[0] = temp;
                    }

                    if (mark == 2)
                    {
                        var temp = tic_array[1];
                        tic_array[1] = final_array[1];
                        final_array[1] = temp;
                    }

                    if (mark == 3)
                    {
                        var temp = tic_array[2];
                        tic_array[2] = final_array[2];
                        final_array[2] = temp;
                    }

                    if (mark == 4)
                    {
                        var temp = tic_array[3];
                        tic_array[3] = final_array[3];
                        final_array[3] = temp;
                    }
                    if (mark == 5)
                    {
                        var temp = tic_array[4];
                        tic_array[4] = final_array[4];
                        final_array[4] = temp;
                    }

                    if (mark == 6)
                    {
                        var temp = tic_array[5];
                        tic_array[5] = final_array[5];
                        final_array[5] = temp;
                    }

                    if (mark == 7)
                    {
                        var temp = tic_array[6];
                        tic_array[6] = final_array[6];
                        final_array[6] = temp;
                    }
                    if (mark == 8)
                    {
                        var temp = tic_array[7];
                        tic_array[7] = final_array[7];
                        final_array[7] = temp;
                    }

                    if (mark == 9)
                    {
                        var temp = tic_array[8];
                        tic_array[8] = final_array[8];
                        final_array[8] = temp;
                    }
                }


            }



            public void function_(char[] tic_array, char[] final_array, char[] final_array_)
            {
                Console.WriteLine("Player B :: Which Index you wanna mark");
                int mark = Convert.ToInt32(Console.ReadLine());

                while (true)
                {
                    if (tic_array[mark - 1] == 'O' || tic_array[mark - 1] == 'X')
                    {
                        Console.WriteLine("Invalid Option Choosen Turn Failed");
                        break;
                    }

                    if (mark == 1)
                    {
                        var temp = tic_array[0];
                        tic_array[0] = final_array_[0];
                        final_array_[0] = temp;
                    }

                    if (mark == 2)
                    {
                        var temp = tic_array[1];
                        tic_array[1] = final_array_[1];
                        final_array_[1] = temp;
                    }

                    if (mark == 3)
                    {
                        var temp = tic_array[2];
                        tic_array[2] = final_array_[2];
                        final_array_[2] = temp;
                    }

                    if (mark == 4)
                    {
                        var temp = tic_array[3];
                        tic_array[3] = final_array_[3];
                        final_array_[3] = temp;
                    }
                    if (mark == 5)
                    {
                        var temp = tic_array[4];
                        tic_array[4] = final_array_[4];
                        final_array_[4] = temp;
                    }

                    if (mark == 6)
                    {
                        var temp = tic_array[5];
                        tic_array[5] = final_array_[5];
                        final_array_[5] = temp;
                    }

                    if (mark == 7)
                    {
                        var temp = tic_array[6];
                        tic_array[6] = final_array_[6];
                        final_array_[6] = temp;
                    }
                    if (mark == 8)
                    {
                        var temp = tic_array[7];
                        tic_array[7] = final_array_[7];
                        final_array_[7] = temp;
                    }

                    if (mark == 9)
                    {
                        var temp = tic_array[8];
                        tic_array[8] = final_array_[8];
                        final_array_[8] = temp;
                    }
                }


            }

            public void check_1(char[] tic_array, ref bool player_1_win)
            {

                if (tic_array[0] == 'O' && tic_array[1] == 'O' && tic_array[3] == 'O')
                {
                    player_1_win = true;
                }
                else if (tic_array[0] == 'O' && tic_array[3] == 'O' && tic_array[6] == 'O')
                {
                    player_1_win = true;
                }
                else if (tic_array[0] == 'O' && tic_array[4] == 'O' && tic_array[8] == 'O')
                {
                    player_1_win = true;
                }
                else if (tic_array[0] == 'O' && tic_array[4] == 'O' && tic_array[8] == 'O')
                {
                    player_1_win = true;
                }
                else if (tic_array[2] == 'O' && tic_array[5] == 'O' && tic_array[8] == 'O')
                {
                    player_1_win = true;
                }
                else if (tic_array[2] == 'O' && tic_array[4] == 'O' && tic_array[6] == 'O')
                {
                    player_1_win = true;
                }
                else if (tic_array[1] == 'O' && tic_array[4] == 'O' && tic_array[7] == 'O')
                {
                    player_1_win = true;
                }
                else if (tic_array[3] == 'O' && tic_array[4] == 'O' && tic_array[5] == 'O')
                {
                    player_1_win = true;
                }
                else if (tic_array[6] == 'O' && tic_array[7] == 'O' && tic_array[8] == 'O')
                {
                    player_1_win = true;
                }
                else if (tic_array[0] == 'O' && tic_array[1] == 'O' && tic_array[2] == 'O')
                {
                    player_1_win = true;
                }

            }

            public void check_2(char[] tic_array, ref bool player_1_win)
            {

                if (tic_array[0] == 'X' && tic_array[1] == 'X' && tic_array[3] == 'X')
                {
                    player_1_win = true;
                }
                else if (tic_array[0] == 'X' && tic_array[3] == 'X' && tic_array[6] == 'X')
                {
                    player_1_win = true;
                }
                else if (tic_array[0] == 'X' && tic_array[4] == 'X' && tic_array[8] == 'X')
                {
                    player_1_win = true;
                }
                else if (tic_array[0] == 'X' && tic_array[4] == 'X' && tic_array[8] == 'X')
                {
                    player_1_win = true;
                }
                else if (tic_array[2] == 'X' && tic_array[5] == 'X' && tic_array[8] == 'X')
                {
                    player_1_win = true;
                }
                else if (tic_array[2] == 'X' && tic_array[4] == 'X' && tic_array[6] == 'X')
                {
                    player_1_win = true;
                }
                else if (tic_array[1] == 'X' && tic_array[4] == 'X' && tic_array[7] == 'X')
                {
                    player_1_win = true;
                }
                else if (tic_array[3] == 'X' && tic_array[4] == 'X' && tic_array[5] == 'X')
                {
                    player_1_win = true;
                }
                else if (tic_array[6] == 'X' && tic_array[7] == 'X' && tic_array[8] == 'X')
                {
                    player_1_win = true;
                }
                else if (tic_array[0] == 'X' && tic_array[1] == 'X' && tic_array[2] == 'X')
                {
                    player_1_win = true;
                }

            }

        }



        //Here is the Class For Displaying
        class TicTacToeDisplay
        {

            public void board(char[] tic_array, char[] final_array, char[] final_array_)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("TIC_TAC_TOE");
                Console.WriteLine("\n\n");


                Console.Write("\t|");
                Console.Write(tic_array[0]);
                Console.Write("		|");
                Console.Write(tic_array[1]);
                Console.Write("		|");
                Console.Write(tic_array[2]);
                Console.WriteLine("		|");

                Console.Write("\t|		|		");
                Console.WriteLine("|		|");
                Console.WriteLine("\t-------------------------------------------------");


                Console.Write("\t|");
                Console.Write(tic_array[3]);
                Console.Write("		|");
                Console.Write(tic_array[4]);
                Console.Write("		|");
                Console.Write(tic_array[5]);
                Console.WriteLine("		|");

                Console.Write("\t|		|		");
                Console.WriteLine("|		|");
                Console.WriteLine("\t-------------------------------------------------");

                Console.Write("\t|");
                Console.Write(tic_array[6]);
                Console.Write("		|");
                Console.Write(tic_array[7]);
                Console.Write("		|");
                Console.Write(tic_array[8]);
                Console.WriteLine("		|");

                Console.Write("\t|		|		");
                Console.WriteLine("|		|");
                Console.WriteLine("\t-------------------------------------------------");

            }
        }



        static void Main(string[] args)
        {

            TicTacToeMechanics obj = new TicTacToeMechanics();
            TicTacToeDisplay obj_01= new TicTacToeDisplay();



            char[] tic_array = new char[9];
            char[] final_array = new char[9];
            char[] final_array_ = new char[9];


            bool player_1_win = false;
            bool player_2_win = false;


            for (int i = 0; i < 9; i++)
            {
                tic_array[i] = ' ';
                final_array[i] = 'O';
                final_array_[i] = 'X';
            }


            for (int i = 0; i < 9; i++)
            {
                Console.Clear();
                obj_01.board(tic_array, final_array, final_array_);
                obj.function(tic_array, final_array, final_array_);
                obj.check_1(tic_array, ref player_1_win);
                if (player_1_win == true)
                {
                    Console.Clear();
                    obj_01.board(tic_array, final_array, final_array_);
                    Console.WriteLine("PLAYER A WINS!!!");
                    break;
                }

                Console.Clear();
                obj_01.board(tic_array, final_array, final_array_);
                obj.function_(tic_array, final_array, final_array_);
                obj.check_2(tic_array, ref player_2_win);
                if (player_2_win == true)
                {
                    Console.Clear();
                    obj_01.board(tic_array, final_array, final_array_);
                    Console.WriteLine("PLAYER A WINS!!!");
                    break;
                }

            }



            Console.ReadLine();
        }
    }
}