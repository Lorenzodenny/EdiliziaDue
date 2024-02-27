namespace EdiliziaDue.Models
{
    public class DbLavoro
    {
        private static int _maxId = 3;

        private static List<Lavoro> _lavoro { get; set; } = [
            new Lavoro() { LavoroId = 1, Periodo = "3 mesi", Pagamento = 5000, Tipo = "Acconto"},
            new Lavoro() { LavoroId = 2, Periodo = "2 mesi", Pagamento = 7000, Tipo = "Stipendo" },
            new Lavoro() { LavoroId = 3, Periodo = "1 anno", Pagamento = 6000, Tipo = "Acconto" }
        ];

        public static List<Lavoro> getAll()
        {
            return _lavoro;
        }

        public static Lavoro? getById(int? id)
        {
            if (id == null) return null;

            for (int i = 0; i < _lavoro.Count; i++)
            {
                Lavoro lavoro = _lavoro[i];
                if (_lavoro[i].LavoroId == id)
                {
                    return lavoro;
                }
            }

            return null;
        }

        public static Lavoro AggiungiLavoro(string periodo, int pagamento, string tipo)
        {
            _maxId++;
            var lavoro = new Lavoro() { LavoroId = _maxId, Periodo = periodo, Pagamento = pagamento, Tipo = tipo};
            _lavoro.Add(lavoro);
            return lavoro;
        }
    }
}
