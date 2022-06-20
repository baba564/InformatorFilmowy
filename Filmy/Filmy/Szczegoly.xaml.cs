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
using System.Windows.Shapes;

namespace Filmy
{
    /// <summary>
    /// Logika interakcji dla klasy Szczegoly.xaml
    /// </summary>
    public partial class Szczegoly : Window
    {
        
        public Szczegoly(string nazwaFilmu,List<Film> filmy)
        {
            InitializeComponent();
  
            myGrid.DataContext = znajdzFilm(nazwaFilmu,filmy);
        }


        private static Film znajdzFilm(string nazwaFilmu, List<Film> filmy)
        {
            Film film = filmy.Where(n => n.Tytul == nazwaFilmu).FirstOrDefault();
            return film;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();   
            mainWindow.Show();
            this.Close();
        }
    }
}
