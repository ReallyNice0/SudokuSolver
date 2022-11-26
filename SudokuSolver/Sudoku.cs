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
        private string[] content;

        public SudokuBoard()
        {
            content = new string[81];
        }

        public string[] Content
        {
            get
            {
                int arrayCounter = 0;
                foreach (string element in content)
                {
                    if (int.TryParse(element, out int parseOutput))
                    {
                        if (parseOutput > 0 && parseOutput < 10)
                        {
                            content[arrayCounter] = parseOutput.ToString();
                        }
                        else
                        {
                            content[arrayCounter] = "";
                        }
                    }
                    else
                    {
                        content[arrayCounter] = "";
                    }
                    arrayCounter++;
                }
                GC.Collect();
                return content;
            }
        }
    }
}
