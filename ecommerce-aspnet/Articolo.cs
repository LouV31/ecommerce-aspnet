using System.Collections.Generic;

namespace ecommerce_aspnet
{
    public class Articolo
    {
        // Definizione delle proprietà della classe Articolo e dei metodi per la gestione della lista di articoli e del carrello
        private int id { get; set; }
        public int Id { get => id; set => id = value; }
        private string nome { get; set; }
        public string Nome { get => nome; set => nome = value; }
        private string descrizione { get; set; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        private double prezzo { get; set; }
        public double Prezzo { get => prezzo; set => prezzo = value; }
        private string immagine { get; set; }
        public string Immagine { get => immagine; set => immagine = value; }

        private static List<Articolo> ListaArticoli = new List<Articolo>();
        public static List<Articolo> GetListaArticoli()
        {
            return ListaArticoli;
        }
        private static List<Articolo> Carrello = new List<Articolo>();
        public static List<Articolo> GetCarrello()
        {
            return Carrello;
        }

        // Costruttore della classe Articolo
        public Articolo(int id, string nome, string descrizione, double prezzo, string immagine)
        {
            this.id = id;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.immagine = immagine;
        }

        // Metodo per aggiungere un articolo alla lista di articoli
        public static void AggiungiArticolo(Articolo articolo)
        {
            ListaArticoli.Add(articolo);
        }

        // Metodo per aggiungere un articolo al carrello
        public static void AggiungiCarrello(Articolo articolo)
        {
            Carrello.Add(articolo);
        }

        // Metodo che accetta un id come parametro e restituisce l'articolo corrispondente
        public static Articolo TrovaArticolo(int id)
        {
            foreach (Articolo articolo in ListaArticoli)
            {
                if (articolo.Id == id)
                {
                    return articolo;
                }
            }
            return null;
        }
    }
}