using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudokuSolver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SudokuBoard Board { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Board = new SudokuBoard();

            Board.Content[1] = "1";
            Board.Content[12] = "9";
            Board.Content[70] = "4";

            this.DataContext = Board;
        }
    }
}
