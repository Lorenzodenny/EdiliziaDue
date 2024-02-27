using System.Collections.Specialized;

namespace EdiliziaDue.Models
{
    public static class Db
    {
        private static int _maxId = 3;

        private static List<Dipendente> _dipendenti { get; set; } = [
            new Dipendente() { DipendenteId = 1, Nome = "Francesco", Cognome = "MIssorini", Indirizzo = "via del campo", CodiceFiscale = "12345655455254525425232", Coniugato = true, Figli = 3, Mansione = "Pulizia Pubblica" },
            new Dipendente() { DipendenteId = 2, Nome = "Abel", Cognome = "Sossu", Indirizzo = "via del campo", CodiceFiscale = "12345655455254525425232", Coniugato = true, Figli = 7, Mansione = "Presenta le cugine della moglie" },
            new Dipendente() { DipendenteId = 3, Nome = "Domenico", Cognome = "Villani", Indirizzo = "via del campo", CodiceFiscale = "12345655455254525425232", Coniugato = true, Figli = 1, Mansione = "Scassa il.." }
        ];

        public static List<Dipendente> getAll()
        {
            return _dipendenti;
        }

        public static Dipendente? getById(int? id)
        {
            if (id == null) return null;

            for(int i = 0; i < _dipendenti.Count; i++)
            {
                Dipendente dipendente = _dipendenti[i];
                if (_dipendenti[i].DipendenteId == id)
                {
                    return dipendente;
                }
            }

            return null;
        }

        public static Dipendente AggiungiDipendente(string nome, string cognome, string indirizzo, string codicefiscale, bool coniugato, int figli, string mansione)
        {
            _maxId++;
            var dipendente = new Dipendente() { DipendenteId = _maxId, Nome = nome, Cognome = cognome, Indirizzo = indirizzo, CodiceFiscale = codicefiscale, Coniugato = coniugato, Figli = figli, Mansione = mansione };
            _dipendenti.Add(dipendente);
            return dipendente;
        }
    }
}
