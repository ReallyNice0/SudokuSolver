using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SudokuSolver
{
    public class SudokuBoard
    {
        public int[] content;

        public SudokuBoard()
        {
            content = new int[81];
        }

        public int[] Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}
