using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToeChecker
{
    public class TicTacToeEvaluator
    {
        private List<List<string>> board = new List<List<string>>
            {new List<string> {"", "", ""}, new List<string> {"", "", ""}, new List<string> {"", "", ""}};

        public void Set(int i, int j, string mark)
        {
            if (mark.ToLower().Equals("x") || mark.ToLower().Equals("o"))
            {
                board[i][j] = mark;
            }
        }

        public int GetStatus()
        {
            //YOU HAVE TO IMPLEMENT THIS FUNCTION AT THE DOJO!
            return -10000;
        }

        public void Set(List<List<string>> finishedBoard)
        {
            board = finishedBoard;
        }
    }
}
