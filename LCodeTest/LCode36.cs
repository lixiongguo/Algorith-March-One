using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCode
{
    class LCode36
    {
        HashSet<char> char_sets = new HashSet<char>();
        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!CheckRow(board, i))
                {
                    return false;
                }
            }
            for (int j = 0; j < 9; j++)
            {
                if (!CheckColumn(board, j))
                {
                    return false;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (!CheckBlock(board, i, j))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        bool CheckRow(char[][] board, int rowIdx)
        {
            char_sets.Clear();
            for (int i = 0; i < board.Length; i++)
            {
                char thisChar = board[rowIdx][i];
                if (thisChar != '.')
                {
                    if (char_sets.Contains(thisChar))
                    {
                        Console.WriteLine(rowIdx + " Row Duplication!!");
                        return false;
                    }
                    else
                    {
                        char_sets.Add(thisChar);
                    }
                }
            }
            return true;
        }
        bool CheckColumn(char[][] board, int colIdx)
        {
            char_sets.Clear();
            for (int i = 0; i < board.Length; i++)
            {
                char thisChar = board[i][colIdx];
                if (thisChar != '.')
                {
                    if (char_sets.Contains(thisChar))
                    {
                        Console.WriteLine(colIdx + " Col Duplication!!");
                        return false;
                    }
                    else
                    {
                        char_sets.Add(thisChar);
                    }
                }
            }
            return true;
        }
        bool CheckBlock(char[][] board, int block_i, int block_j)
        {
            char_sets.Clear();
            int start_i = block_i * 3;
            int start_j = block_j * 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int idx_i = start_i + i;
                    int idx_j = start_j + j;
                    char thisChar = board[idx_i][idx_j];
                    if (thisChar != '.')
                    {
                        if (char_sets.Contains(thisChar))
                        {
                            Console.WriteLine(string.Format("({0},{1}) Duplication", block_i, block_j));
                            return false;
                        }
                        else
                        {
                            char_sets.Add(thisChar);
                        }
                    }

                }
            }
            return true;
        }
    }
}
