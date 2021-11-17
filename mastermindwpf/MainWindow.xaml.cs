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

namespace mastermindwpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //int een, twee, drie, vier, vijf, zes, zeven, acht;

        int[] rij = new int[8];

        int geselecteerdeKleur = -1;

        Brush[] kleuren = new Brush[] { Brushes.Green, Brushes.Red, Brushes.Yellow, Brushes.BlueViolet, Brushes.Blue, Brushes.Purple, Brushes.Pink, Brushes.Aqua, };

        Button[] knoppen;

        Ellipse[] resultaatCirkels;
        Ellipse[] invoerCirkels;

        Ellipse[,] allEllipses;

        public MainWindow()
        {
            InitializeComponent();
            //Is_Code_Berekening();
            GenereerRandomArray();

            allEllipses = GetAllEllipses();

            resultaatCirkels = new Ellipse[]
            {
                codeeen,
                codetwee,
                codedrie,
                codevier,
                codevijf,
                codezes,
                codezeven,
                codeacht,
            };

            invoerCirkels = new Ellipse[]
            {
                allEllipses[0,0],
                allEllipses[0,1],
                allEllipses[0,2],
                allEllipses[0,3],
                allEllipses[0,4],
                allEllipses[0,5],
                allEllipses[0,6],
                allEllipses[0,7],
            };

            knoppen = new Button[]
            {
                groen,
                rood,
                geel,
                lichtblauw,
                blauw,
                paars,
                roze,
                aqua,
            };

            GetAllEllipses();
        }

        private Ellipse[,] GetAllEllipses()
        {
            const int columnCount = 8;
            const int rowCount = 10;
            var ellipses = new Ellipse[rowCount, columnCount];
            foreach (var child in MainGrid.Children)
            {
                var ellipse = child as Ellipse;
                if (ellipse == null)
                    continue;

                //column 4 à 11
                // row 15 à 6
                const int firstColumn = 4;
                const int lastColumn = 11;
                const int firstRow = 6;
                const int lastRow = 15;

                var col = Grid.GetColumn(ellipse);
                var row = Grid.GetRow(ellipse);

                if (row >= firstRow && row <= lastRow && col >= firstColumn && col <= lastColumn)
                {
                    var r = row - firstRow;
                    var c = col - firstColumn;

                    var inverted = rowCount - 1 - r;

                    ellipses[inverted, c] = ellipse;
                }
            }

            return ellipses;
        }

        private void GenereerRandomArray()
        {
            Random random = new Random();

            for (int i = 0; i < rij.Length; ++i)
            {
                bool alreadyExists = true;
                int number = 0;
                while (alreadyExists)
                {
                    number = random.Next(rij.Length);
                    alreadyExists = false;
                    for (int j = 0; j < i; ++j)
                    {
                        if (rij[j] == number)
                        {
                            alreadyExists = true;
                        }
                    }
                }

                rij[i] = number;
            }
        }

        private void SelectButton(int number)
        {
            if (geselecteerdeKleur == -1)
            {
                knoppen[number].Background = Brushes.White;
                geselecteerdeKleur = number;
            }
            else if (geselecteerdeKleur == number)
            {
                knoppen[number].Background = kleuren[number];
                geselecteerdeKleur = -1;
            }
            else
            {
                knoppen[geselecteerdeKleur].Background = kleuren[geselecteerdeKleur];
                knoppen[number].Background = Brushes.White;
                geselecteerdeKleur = number;
            }
        }

        private void Groen1(object sender, RoutedEventArgs e)
        {
            SelectButton(0);
        }


        private void Rood2(object sender, RoutedEventArgs e)
        {
            SelectButton(1);
        }

        private void Geel3(object sender, RoutedEventArgs e)
        {
            SelectButton(2);
        }

        private void Lichtblauw4(object sender, RoutedEventArgs e)
        {
            SelectButton(3);
        }

        private void Blauw5(object sender, RoutedEventArgs e)
        {
            SelectButton(4);
        }

        private void Paars6(object sender, RoutedEventArgs e)
        {
            SelectButton(5);
        }

        private void Roze7(object sender, RoutedEventArgs e)
        {
            SelectButton(6);
        }

        private void Aqua8(object sender, RoutedEventArgs e)
        {
            SelectButton(7);
        }


        private void SelectEllipse(int number)
        {
            if (geselecteerdeKleur != -1)
            {
                if (invoerCirkels[number].Fill == Brushes.White)
                {
                    invoerCirkels[number].Fill = kleuren[geselecteerdeKleur];
                    int correctValue = rij[number];

                    if (geselecteerdeKleur == correctValue)
                    {
                        resultaatCirkels[number].Fill = kleuren[correctValue];
                        resultaatCirkels[number].Visibility = Visibility.Visible;
                    }

                    knoppen[geselecteerdeKleur].IsEnabled = false;
                    geselecteerdeKleur = -1;
                }
            }
        }


        private void Rijeenceleen_Button_click(object sender, MouseButtonEventArgs e)
        {
            SelectEllipse(0);
        }

        private void RijeenCelTwee(object sender, MouseButtonEventArgs e)
        {
            SelectEllipse(1);
        }

        private void RijEenCelDrie(object sender, MouseButtonEventArgs e)
        {
            SelectEllipse(2);
        }

        private void RijEenCelVier(object sender, MouseButtonEventArgs e)
        {
            SelectEllipse(3);
        }

        private void RijEenCelVijf(object sender, MouseButtonEventArgs e)
        {
            SelectEllipse(4);
        }

        private void RijEenCelZes(object sender, MouseButtonEventArgs e)
        {
            SelectEllipse(5);
        }

        private void RijEenCelZeven(object sender, MouseButtonEventArgs e)
        {
            SelectEllipse(6);
        }

        private void RijEenCelAcht(object sender, MouseButtonEventArgs e)
        {
            SelectEllipse(7);
        }
    }
}
