using System.Collections.Generic;
using NUnit.Framework;
using TicTacToeChecker;

namespace TicTacToeCheckerTests
{
    public class TicTacToeEvaluatorTests
    {
        [Test]
        public void NoWinner()
        {
            var checker = new TicTacToeEvaluator();
            var board = new List<List<string>>
                {new List<string> {"x", "", "o"}, new List<string> {"", "o", ""}, new List<string> {"", "", "x"}};
            checker.Set(board);

            Assert.AreEqual(-1, checker.GetStatus());
        }

        [Test]
        public void xWins_column()
        {
            var checker = new TicTacToeEvaluator();

            var board = new List<List<string>>
                {new List<string> {"x", "x", "o"}, new List<string> {"x", "o", "x"}, new List<string> {"x", "o", "x"}};
            checker.Set(board);

            Assert.AreEqual(1, checker.GetStatus());
        }

        [Test]
        public void xWins_row()
        {
            var checker = new TicTacToeEvaluator();

            var board = new List<List<string>>
                {new List<string> {"x", "x", "x"}, new List<string> {"x", "o", "o"}, new List<string> {"o", "o", "x"}};
            checker.Set(board);

            Assert.AreEqual(1, checker.GetStatus());
        }

        [Test]
        public void xWins_diagonal()
        {
            var checker = new TicTacToeEvaluator();

            var board = new List<List<string>>
                {new List<string> {"o", "o", "x"}, new List<string> {"o", "x", "o"}, new List<string> {"x", "x", "o"}};
            checker.Set(board);

            Assert.AreEqual(1, checker.GetStatus());
        }

        [Test]
        public void oWins_column()
        {
            var checker = new TicTacToeEvaluator();

            var board = new List<List<string>>
                {new List<string> {"o", "x", "o"}, new List<string> {"o", "o", "x"}, new List<string> {"o", "o", "x"}};
            checker.Set(board);

            Assert.AreEqual(2, checker.GetStatus());
        }

        [Test]
        public void oWins_row()
        {
            var checker = new TicTacToeEvaluator();

            var board = new List<List<string>>
                {new List<string> {"o", "o", "o"}, new List<string> {"o", "x", "x"}, new List<string> {"x", "x", "o"}};
            checker.Set(board);

            Assert.AreEqual(2, checker.GetStatus());
        }

        [Test]
        public void oWins_diagonal()
        {
            var checker = new TicTacToeEvaluator();

            var board = new List<List<string>>
                {new List<string> {"o", "x", "x"}, new List<string> {"x", "o", "x"}, new List<string> {"o", "x", "o"}};
            checker.Set(board);

            Assert.AreEqual(2, checker.GetStatus());
        }
    }
}