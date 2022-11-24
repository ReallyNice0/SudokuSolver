using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    internal class Sudoku
    {
        public int[,] Board { get; set; }

        public Sudoku()
        {
            Board = new int[9, 9];
        }
    }
}
