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
        private struct Coordinates
        {
            public int Column;
            public int Row;
        }

        private const int NumberOfRows = 9;
        private const int NumberOfColumns = 9;
        public MainWindow()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }

        private void InitializeTextBoxes()
        {
            for (int ColumnsCounter = 0; ColumnsCounter < NumberOfColumns; ColumnsCounter++)
            {
                for (int RowCounter = 0; RowCounter < NumberOfRows; RowCounter++)
                {
                    Coordinates DisplayCoordinates = new Coordinates();
                    Coordinates LogicalCoordinates = new Coordinates();

                    LogicalCoordinates.Column = ColumnsCounter;
                    LogicalCoordinates.Row = RowCounter;

                    DisplayCoordinates = GetDisplayCoordinatesFromLogicalLCoordinates(LogicalCoordinates);

                    string TextBoxName = "TextBox_" + "R" + RowCounter.ToString() + "C" + ColumnsCounter.ToString();
                    TextBox textBox = new TextBox
                    {
                        Name = TextBoxName,
                        Background = Brushes.Black,
                        Foreground = Brushes.White,
                        FontSize = 24,
                        HorizontalContentAlignment = HorizontalAlignment.Center,
                        VerticalContentAlignment = VerticalAlignment.Center,
                        Text = "R" + RowCounter.ToString() + "C" + ColumnsCounter.ToString() /* For verification */
                    };

                    Grid.SetRow(textBox, DisplayCoordinates.Row);
                    Grid.SetColumn(textBox, DisplayCoordinates.Column);

                    DisplayGrid.Children.Add(textBox);
                }
            }
        }

        private Coordinates GetDisplayCoordinatesFromLogicalLCoordinates(Coordinates LogicalCoordinates)
        {
            Coordinates DisplayCoordinates = new Coordinates();


            if (LogicalCoordinates.Column < 3)
            {
                DisplayCoordinates.Column = LogicalCoordinates.Column;
            }
            else if (LogicalCoordinates.Column < 6)
            {
                DisplayCoordinates.Column = LogicalCoordinates.Column + 1;
            }
            else if (LogicalCoordinates.Column < 9)
            {
                DisplayCoordinates.Column = LogicalCoordinates.Column + 2;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Logical Column coordinate is out of range.");
            }

            if (LogicalCoordinates.Row < 3)
            {
                DisplayCoordinates.Row = LogicalCoordinates.Row;
            }
            else if (LogicalCoordinates.Row < 6)
            {
                DisplayCoordinates.Row = LogicalCoordinates.Row + 1;
            }
            else if (LogicalCoordinates.Row < 9)
            {
                DisplayCoordinates.Row = LogicalCoordinates.Row + 2;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Logical Row coordinate is out of range.");
            }

            return DisplayCoordinates;
        }
    }
}
