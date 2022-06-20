using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace Filmy
{
    public class ListaFilmow
    {
        private static string sciezka = Directory.GetCurrentDirectory() + "\\ListaFilmow.xml";

        public static List<Film> zwrocListe()
        {


            
           
                List<Film> listaFilmow = new List<Film>();
                List<Film> listaFilmowPoprawiona = new List<Film>();

                 listaFilmow = wczytanieListyFilmow();

                foreach (var item in listaFilmow)
                {
                listaFilmowPoprawiona.Add(
                    new Film
                    {
                        Tytul=item.Tytul,
                        Rezyser="Reżyser: "+item.Rezyser,
                        OpisFilmu=item.OpisFilmu,
                        LinkDoPlakatu=item.LinkDoPlakatu,
                        RokProdukcji="Rok produkcji: "+item.RokProdukcji
                    }
                    );
                }
                return listaFilmowPoprawiona;
    
        }
        private static List<Film> wczytanieListyFilmow()
        {

            try
            {
                XmlSerializer reader =
                new XmlSerializer(typeof(List<Film>));

                StreamReader file = new StreamReader(
                    sciezka);


                var lista = (List<Film>)reader.Deserialize(file);
                file.Close();

                return lista;
            }
            catch
            {
                MessageBox.Show("Błąd wczytywania listy filmów proszę o kontakt z administratorem.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return null;
        }




        //public static List<Film> zwrocListe()
        //{


        //    var lista = wczytanieListyFilmow();
        //    if(lista != null)
        //    {
        //        List<Film> listaFilmow = new List<Film>();
        //        foreach (string lina in lista)
        //        {
        //            string[] model = lina.Split(';');
        //            listaFilmow.Add(new Film
        //            {
        //                Tytul = model[0].Trim(),
        //                Rezyser = "Reżyser: " + model[1].Trim(),
        //                RokProdukcji = "Rok produkcji: " + model[2].Trim(),
        //                LinkDoPlakatu = model[3].Trim(),
        //                OpisFilmu = model[4].Trim()
        //            });

        //        }
        //        return listaFilmow;
        //    }

        //    return null;
        //}

        //private static IEnumerable<string> wczytanieListyFilmow()
        //{

        //    try
        //    {
        //        var lista = File.ReadLines(sciezka);

        //        return lista;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Błąd wczytywania listy filmów proszę o kontakt z administratorem.","Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //    return null;
        //}




    }
}
