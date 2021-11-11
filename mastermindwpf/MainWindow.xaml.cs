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
        Random code = new Random();
        int een, twee, drie, vier, vijf, zes, zeven, acht;
        public MainWindow()
        {

            InitializeComponent();
            Is_Code_Berekening();
            CodePlaatsen(een, codeeen);
            CodePlaatsen(twee, codetwee);
            CodePlaatsen(drie, codedrie);
            CodePlaatsen(vier, codevier);
            CodePlaatsen(vijf, codevijf);
            CodePlaatsen(zes, codezes);
            CodePlaatsen(zeven, codezeven);
            CodePlaatsen(acht, codeacht);


        }




        private void CodePlaatsen(int input, Ellipse fill)
        {
            switch (input)

            {

                case 0:
                    fill.Fill = Brushes.Green;

                    break;
                case 1:
                    fill.Fill = Brushes.Red;
                    break;
                case 2:
                    fill.Fill = Brushes.Yellow;
                    break;
                case 3:
                    fill.Fill = Brushes.BlueViolet;
                    break;
                case 4:
                    fill.Fill = Brushes.Blue;
                    break;
                case 5:
                    fill.Fill = Brushes.Purple;
                    break;
                case 6:
                    fill.Fill = Brushes.Pink;
                    break;
                case 7:
                    fill.Fill = Brushes.Aqua;
                    break;
                default:
                    break;
            }
        }

        private void Groen1(object sender, RoutedEventArgs e)
        {
            groen.Background = Brushes.White;

        }


        private void Rood2(object sender, RoutedEventArgs e)
        {
            rood.Background = Brushes.White;
        }

        private void Geel3(object sender, RoutedEventArgs e)
        {
            geel.Background = Brushes.White;
        }

        private void Lichtblauw4(object sender, RoutedEventArgs e)
        {
            lichtblauw.Background = Brushes.White;
        }

        private void Blauw5(object sender, RoutedEventArgs e)
        {
            blauw.Background = Brushes.White;
        }

        private void Paars6(object sender, RoutedEventArgs e)
        {
            paars.Background = Brushes.White;
        }

        private void Roze7(object sender, RoutedEventArgs e)
        {
            roze.Background = Brushes.White;
        }

        private void Aqua8(object sender, RoutedEventArgs e)
        {
            aqua.Background = Brushes.White;
        }


        private void Is_Code_Berekening()
        {

            Random code = new Random();

            een = code.Next(8);

            do
            {
                twee = code.Next(8);
            } while (twee == een);

            do
            {
                drie = code.Next(8);
            } while (drie == twee || drie == een);

            do
            {
                vier = code.Next(8);
            } while (vier == drie || vier == twee || vier == een);

            do
            {
                vijf = code.Next(8);
            } while (vijf == vier || vijf == drie || vijf == twee || vijf == een);

            do
            {
                zes = code.Next(8);
            } while (zes == vijf || zes == vier || zes == drie || zes == twee || zes == een);

            do
            {
                zeven = code.Next(8);
            } while (zeven == zes || zeven == vijf || zeven == vier || zeven == drie || zeven == twee || zeven == een);

            do
            {
                acht = code.Next(8);
            } while (acht == zeven || acht == zes || acht == vijf || acht == vier || acht == drie || acht == twee || acht == een);




        }

        private void Rijeenceleen_Button_click(object sender, MouseButtonEventArgs e)
        {
            
            if (groen.Background == Brushes.White)
            {
                eeneen.Fill = Brushes.Green;
                groen.Background = Brushes.Green;
               
            }
            else if (rood.Background == Brushes.White)
            {
                eeneen.Fill = Brushes.Red;
                rood.Background = Brushes.Red;
            }
            else if (geel.Background == Brushes.White)
            {
                eeneen.Fill = Brushes.Yellow;
                geel.Background = Brushes.Yellow;
            }
            else if (lichtblauw.Background == Brushes.White)
            {
                eeneen.Fill = Brushes.BlueViolet;
                lichtblauw.Background = Brushes.BlueViolet;
            }
            else if (blauw.Background == Brushes.White)
            {
                eeneen.Fill = Brushes.Blue;
                blauw.Background = Brushes.Blue;
            }
            else if (paars.Background == Brushes.White)
            {
                eeneen.Fill = Brushes.Purple;
                paars.Background = Brushes.Purple;
            }
            else if (roze.Background == Brushes.White)
            {
                eeneen.Fill = Brushes.Pink;
                roze.Background = Brushes.Pink;
            }
            else if (aqua.Background == Brushes.White)
            {
                eeneen.Fill = Brushes.Aqua;
                aqua.Background = Brushes.Aqua;
            }
            if (eeneen.Fill == codeeen.Fill)

            {
                codeeen.Visibility = Visibility.Visible;
            }

        }

       

        private void RijeenCelTwee(object sender, MouseButtonEventArgs e)
        {
            if (groen.Background == Brushes.White)
            {
                eentwee.Fill = Brushes.Green;
                groen.Background = Brushes.Green;
            }
            else if (rood.Background == Brushes.White)
            {
                eentwee.Fill = Brushes.Red;
                rood.Background = Brushes.Red;
            }
            else if (geel.Background == Brushes.White)
            {
                eentwee.Fill = Brushes.Yellow;
                geel.Background = Brushes.Yellow;
            }
            else if (lichtblauw.Background == Brushes.White)
            {
                eentwee.Fill = Brushes.BlueViolet;
                lichtblauw.Background = Brushes.BlueViolet;
            }
            else if (blauw.Background == Brushes.White)
            {
                eentwee.Fill = Brushes.Blue;
                blauw.Background = Brushes.Blue;
            }
            else if (paars.Background == Brushes.White)
            {
                eentwee.Fill = Brushes.Purple;
                paars.Background = Brushes.Purple;
            }
            else if (roze.Background == Brushes.White)
            {
                eentwee.Fill = Brushes.Pink;
                roze.Background = Brushes.Pink;
            }
            else if (aqua.Background == Brushes.White)
            {
                eentwee.Fill = Brushes.Aqua;
                aqua.Background = Brushes.Aqua;
            }
            if (eentwee.Fill == codetwee.Fill)
            {
                codetwee.Visibility = Visibility.Visible;
            }
        }

        private void RijEenCelDrie(object sender, MouseButtonEventArgs e)
        {
            if (groen.Background == Brushes.White)
            {
                eendrie.Fill = Brushes.Green;
                groen.Background = Brushes.Green;
            }
            else if (rood.Background == Brushes.White)
            {
                eendrie.Fill = Brushes.Red;
                rood.Background = Brushes.Red;
            }
            else if (geel.Background == Brushes.White)
            {
                eendrie.Fill = Brushes.Yellow;
                geel.Background = Brushes.Yellow;
            }
            else if (lichtblauw.Background == Brushes.White)
            {
                eendrie.Fill = Brushes.BlueViolet;
                lichtblauw.Background = Brushes.BlueViolet;
            }
            else if (blauw.Background == Brushes.White)
            {
                eendrie.Fill = Brushes.Blue;
                blauw.Background = Brushes.Blue;
            }
            else if (paars.Background == Brushes.White)
            {
                eendrie.Fill = Brushes.Purple;
                paars.Background = Brushes.Purple;
            }
            else if (roze.Background == Brushes.White)
            {
                eendrie.Fill = Brushes.Pink;
                roze.Background = Brushes.Pink;
            }
            else if (aqua.Background == Brushes.White)
            {
                eendrie.Fill = Brushes.Aqua;
                aqua.Background = Brushes.Aqua;
            }

            if (eendrie.Fill == codedrie.Fill)
            {
                codedrie.Visibility = Visibility.Visible;
            }
        }

        private void RijEenCelVier(object sender, MouseButtonEventArgs e)
        {
            if (groen.Background == Brushes.White)
            {
                eenvier.Fill = Brushes.Green;
                groen.Background = Brushes.Green;
            }
            else if (rood.Background == Brushes.White)
            {
                eenvier.Fill = Brushes.Red;
                rood.Background = Brushes.Red;
            }
            else if (geel.Background == Brushes.White)
            {
                eenvier.Fill = Brushes.Yellow;
                geel.Background = Brushes.Yellow;
            }
            else if (lichtblauw.Background == Brushes.White)
            {
                eenvier.Fill = Brushes.BlueViolet;
                lichtblauw.Background = Brushes.BlueViolet;
            }
            else if (blauw.Background == Brushes.White)
            {
                eenvier.Fill = Brushes.Blue;
                blauw.Background = Brushes.Blue;
            }
            else if (paars.Background == Brushes.White)
            {
                
                eenvier.Fill = Brushes.Purple;
                paars.Background = Brushes.Purple;
            }
            else if (roze.Background == Brushes.White)
            {
                eenvier.Fill = Brushes.Pink;
                roze.Background = Brushes.Pink;
            }
            else if (aqua.Background == Brushes.White)
            {
                eenvier.Fill = Brushes.Aqua;
                aqua.Background = Brushes.Aqua;
            }
            if (eenvier.Fill == codevier.Fill)
            {
                codevier.Visibility = Visibility.Visible;
            }
        }

        private void RijEenCelVijf(object sender, MouseButtonEventArgs e)
        {
            if (groen.Background == Brushes.White)
            {
                eenvijf.Fill = Brushes.Green;
                groen.Background = Brushes.Green;
            }
            else if (rood.Background == Brushes.White)
            {
                eenvijf.Fill = Brushes.Red;
                rood.Background = Brushes.Red;
            }
            else if (geel.Background == Brushes.White)
            {
                eenvijf.Fill = Brushes.Yellow;
                geel.Background = Brushes.Yellow;
            }
            else if (lichtblauw.Background == Brushes.White)
            {
                eenvijf.Fill = Brushes.BlueViolet;
                lichtblauw.Background = Brushes.BlueViolet;
            }
            else if (blauw.Background == Brushes.White)
            {
                eenvijf.Fill = Brushes.Blue;
                blauw.Background = Brushes.Blue;
            }
            else if (paars.Background == Brushes.White)
            {

                eenvijf.Fill = Brushes.Purple;
                paars.Background = Brushes.Purple;
            }
            else if (roze.Background == Brushes.White)
            {
                eenvijf.Fill = Brushes.Pink;
                roze.Background = Brushes.Pink;
            }
            else if (aqua.Background == Brushes.White)
            {
                eenvijf.Fill = Brushes.Aqua;
                aqua.Background = Brushes.Aqua;
            }
            if (eenvijf.Fill == codevijf.Fill)
            {
                codevijf.Visibility = Visibility.Visible;
            }
        }

        private void RijEenCelZes(object sender, MouseButtonEventArgs e)
        {
            if (groen.Background == Brushes.White)
            {
                eenzes.Fill = Brushes.Green;
                groen.Background = Brushes.Green;
            }
            else if (rood.Background == Brushes.White)
            {
                eenzes.Fill = Brushes.Red;
                rood.Background = Brushes.Red;
            }
            else if (geel.Background == Brushes.White)
            {
                eenzes.Fill = Brushes.Yellow;
                geel.Background = Brushes.Yellow;
            }
            else if (lichtblauw.Background == Brushes.White)
            {
                eenzes.Fill = Brushes.BlueViolet;
                lichtblauw.Background = Brushes.BlueViolet;
            }
            else if (blauw.Background == Brushes.White)
            {
                eenzes.Fill = Brushes.Blue;
                blauw.Background = Brushes.Blue;
            }
            else if (paars.Background == Brushes.White)
            {

                eenzes.Fill = Brushes.Purple;
                paars.Background = Brushes.Purple;
            }
            else if (roze.Background == Brushes.White)
            {
                eenzes.Fill = Brushes.Pink;
                roze.Background = Brushes.Pink;
            }
            else if (aqua.Background == Brushes.White)
            {
                eenzes.Fill = Brushes.Aqua;
                aqua.Background = Brushes.Aqua;
            }
            if (eenzes.Fill == codezes.Fill)
            {
                codezes.Visibility = Visibility.Visible;
            }
        }

        private void RijEenCelZeven(object sender, MouseButtonEventArgs e)
        {
            if (groen.Background == Brushes.White)
            {
                eenzeven.Fill = Brushes.Green;
                groen.Background = Brushes.Green;
            }
            else if (rood.Background == Brushes.White)
            {
                eenzeven.Fill = Brushes.Red;
                rood.Background = Brushes.Red;
            }
            else if (geel.Background == Brushes.White)
            {
                eenzeven.Fill = Brushes.Yellow;
                geel.Background = Brushes.Yellow;
            }
            else if (lichtblauw.Background == Brushes.White)
            {
                eenzeven.Fill = Brushes.BlueViolet;
                lichtblauw.Background = Brushes.BlueViolet;
            }
            else if (blauw.Background == Brushes.White)
            {
                eenzeven.Fill = Brushes.Blue;
                blauw.Background = Brushes.Blue;
            }
            else if (paars.Background == Brushes.White)
            {

                eenzeven.Fill = Brushes.Purple;
                paars.Background = Brushes.Purple;
            }
            else if (roze.Background == Brushes.White)
            {
                eenzeven.Fill = Brushes.Pink;
                roze.Background = Brushes.Pink;
            }
            else if (aqua.Background == Brushes.White)
            {
                eenzeven.Fill = Brushes.Aqua;
                aqua.Background = Brushes.Aqua;
            }
            if (eenzeven.Fill == codezeven.Fill)
            {
                codezeven.Visibility = Visibility.Visible;
            }
        }

        private void RijEenCelAcht(object sender, MouseButtonEventArgs e)
        {
            if (groen.Background == Brushes.White)
            {
                eenacht.Fill = Brushes.Green;
                groen.Background = Brushes.Green;
            }
            else if (rood.Background == Brushes.White)
            {
                eenacht.Fill = Brushes.Red;
                rood.Background = Brushes.Red;
            }
            else if (geel.Background == Brushes.White)
            {
                eenacht.Fill = Brushes.Yellow;
                geel.Background = Brushes.Yellow;
            }
            else if (lichtblauw.Background == Brushes.White)
            {
                eenacht.Fill = Brushes.BlueViolet;
                lichtblauw.Background = Brushes.BlueViolet;
            }
            else if (blauw.Background == Brushes.White)
            {
                eenacht.Fill = Brushes.Blue;
                blauw.Background = Brushes.Blue;
            }
            else if (paars.Background == Brushes.White)
            {

                eenacht.Fill = Brushes.Purple;
                paars.Background = Brushes.Purple;
            }
            else if (roze.Background == Brushes.White)
            {
                eenacht.Fill = Brushes.Pink;
                roze.Background = Brushes.Pink;
            }
            else if (aqua.Background == Brushes.White)
            {
                eenacht.Fill = Brushes.Aqua;
                aqua.Background = Brushes.Aqua;
            }
            if (eenacht.Fill == codeacht.Fill)

            {
                codeacht.Visibility = Visibility.Visible;
            }
        }
    }
}
