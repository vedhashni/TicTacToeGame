using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGameProblem
{
    public class TicToeTacGame
    {
        static char[] arr = { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' };

        public static void Performance()
        {
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    for (int i = 1; i < arr.Length; i++)
                    {
                        Console.WriteLine("{0}", arr[i]);
                    }
                    break;

                default:
                    break;

            }
        }
    }
}
