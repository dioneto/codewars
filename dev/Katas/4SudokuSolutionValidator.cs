using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars.dev.Katas
{
    public static class SudokuSolutionValidator
    {
        public static bool ValidateSolution(int[][] board)
        {
            //Validações iniciais
            if (board.Length != 9) return false;

            //Validar Linhas
            foreach (int[] item in board)
            {
                if (item.Length != 9) return false;
                
                if ("123456789" != string.Concat(item.OrderBy(x => x).Select(x => Convert.ToString(x)))) return false;
            }

            //Validar Colunas
            for (int y = 0; y < board.Length; y++)
            {
                int[] coluna = new int[9];
                for (int x = 0; x < board.Length; x++)
                {
                    coluna[x] = board[x][y];
                }
                if ("123456789" != string.Concat(coluna.OrderBy(x => x).Select(x => Convert.ToString(x)))) return false;
            }

            //Quebrar em sub quadros
            int[] q1 = new int[9];
            int q = 0;
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    q1[q] = board[x][y];
                    q++;
                }
            }
            if ("123456789" != string.Concat(q1.OrderBy(x => x).Select(x => Convert.ToString(x)))) return false;
            q = 0;
            int[] q2 = new int[9];
            for (int y = 3; y < 6; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    q2[q] = board[x][y];
                    q++;
                }
            }
            if ("123456789" != string.Concat(q2.OrderBy(x => x).Select(x => Convert.ToString(x)))) return false;
            q = 0;
            int[] q3 = new int[9];
            for (int y = 6; y < 9; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    q3[q] = board[x][y];
                    q++;
                }
            }
            if ("123456789" != string.Concat(q3.OrderBy(x => x).Select(x => Convert.ToString(x)))) return false;

            return true;
        }
    }
}
