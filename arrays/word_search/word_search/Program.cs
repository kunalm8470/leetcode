using System;

namespace word_search
{
    class Program
    {
        public static bool Exist(char[][] board, string word)
        {
            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[r].Length; c++)
                {
                    if (
                        board[r][c] == word[0]
                        && Dfs(board, r, c, word, 0)
                    )
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool Dfs(char[][] board, int r, int c, string word, int index)
        {
            // If index matches word length then exit recursion
            if (index == word.Length) return true;

            // If out of bounds in row/column or character not equal then exit recursion
            if (
                r < 0 
                || r >= board.Length 
                || c < 0 
                || c >= board[r].Length
                || board[r][c] != word[index]
            )
            {
                return false;
            }

            char current = word[index];
            board[r][c] = '\0';

            // Traverse in all 4 valid directions
            bool result = Dfs(board, r + 1, c, word, index + 1)
                          || Dfs(board, r, c + 1, word, index + 1)
                          || Dfs(board, r - 1, c, word, index + 1)
                          || Dfs(board, r, c - 1, word, index + 1);

            board[r][c] = current;
            return result;
        }

        static void Main(string[] args)
        {
            char[][] board1 = new char[][] 
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S','F','C','S' },
                new char[] { 'A','D','E','E' }
            };
            string word1 = "ABCCED";
            bool res1 = Exist(board1, word1);
        }
    }
}
