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
            if (IsNotFinished())
            {
                return -1;
            }

            if (IsPlayerWonTheGame("x"))
            {
                return 1;
            }

            if (IsPlayerWonTheGame("o"))
            {
                return 2;
            }

            return 0;
        }

        private bool IsPlayerWonTheGame(string mark)
        {
            var isWinInColumn = IsWinnerInColumn(0, mark) || IsWinnerInColumn(1, mark) ||
                                IsWinnerInColumn(2, mark);
            var isWinInRow = IsWinnerInRow(0, mark) || IsWinnerInRow(1, mark) || IsWinnerInRow(2, mark);
            var isWinInDiagonal = IsWinnerInDiagonal(mark);

            return isWinInColumn || isWinInRow || isWinInDiagonal;
        }

        private bool IsWinnerInDiagonal(String mark)
        {
            var leftDiagonal = board.ElementAt(0).ElementAt(0).Equals(mark) &&
                               board.ElementAt(1).ElementAt(1).Equals(mark) &&
                               board.ElementAt(2).ElementAt(2).Equals(mark);
            var rightDiagonal = board.ElementAt(0).ElementAt(2).Equals(mark) &&
                                board.ElementAt(1).ElementAt(1).Equals(mark) &&
                                board.ElementAt(2).ElementAt(0).Equals(mark);

            return leftDiagonal || rightDiagonal;
        }

        private bool IsNotFinished()
        {
            var flattenBoard = board.SelectMany(row => row).ToList();
            return flattenBoard.Any(x => x.Equals(""));
        }

        private bool IsWinnerInColumn(int columnNumber, String mark)
        {
            return board.ElementAt(0).ElementAt(columnNumber).Equals(mark) &&
                   board.ElementAt(1).ElementAt(columnNumber).Equals(mark) &&
                   board.ElementAt(2).ElementAt(columnNumber).Equals(mark);
        }

        private bool IsWinnerInRow(int rowNumber, string mark)
        {
            return board.ElementAt(rowNumber).ElementAt(0).Equals(mark) &&
                   board.ElementAt(rowNumber).ElementAt(1).Equals(mark) &&
                   board.ElementAt(rowNumber).ElementAt(2).Equals(mark);
        }

        public void Set(List<List<string>> finishedBoard)
        {
            board = finishedBoard;
        }
    }
}