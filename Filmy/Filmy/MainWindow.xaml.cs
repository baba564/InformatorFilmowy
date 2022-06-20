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
using Filmy;


namespace Filmy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Film> Listafilmow { get; set; }

        
        public MainWindow()
        {
            
            wywolajListe();
            if (Listafilmow != null)
            {

                InitializeComponent();
                items.DataContext = Listafilmow;
            }
            else
            {
                this.Close();
            }



        }


        private void wywolajListe()
        {
            Listafilmow = ListaFilmow.zwrocListe();
        }

        private void Szczegoly(object sender,RoutedEventArgs e)
        {

            var nazwaFilmu = ((Button)sender).Tag.ToString();

            Szczegoly szczegoly = new Szczegoly(nazwaFilmu, Listafilmow);
            szczegoly.Show();
            this.Close();
        }


    }
}
