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
        static char uservalue;
        static char computervalue;

        public static void Performance()
        {
            
                    for (int i = 1; i < arr.Length; i++)
                    {
                Console.WriteLine("{0} ", arr[i]);
            }
                 
            
        }
        public static void whoplay()
        {
            char player = Convert.ToChar(Console.ReadLine());
            if(player == 'O' || player =='o')
            {
                uservalue = 'X';
            }
            else
            {
                computervalue = 'O';
            }
        }
    }
}
