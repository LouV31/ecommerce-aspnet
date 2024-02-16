using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace ecommerce_aspnet
{
    public partial class Carrello : System.Web.UI.Page
    {
        /* Al caricamento della pagina faccio un semplice controllo ossia, se la lista del carrello ha 0 elementi mi spunta un alert che mi dice che il carrello è vuoto
         * Altrimenti mi nasconde l'alert e mi popola la pagina con gli elementi della lista del carrello tramite il repeater 
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Articolo.GetCarrello().Count == 0)
            {
                alert.InnerHtml = "Il carrello è vuoto";
            }
            else
            {
                alert.Style.Add("display", "none");
                Repeater2.DataSource = Articolo.GetCarrello();
                Repeater2.DataBind();
                Totale(Articolo.GetCarrello());
            }
        }

        // Metodo che mi permette di rimuovere un articolo dal carrello. Mi prendo l'id dell'articolo tramite il CommandArgument del bottone e lo passo al metodo RimuoviCarrello della classe Articolo.
        protected void rimuoviCarrello_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int prodottoId = Convert.ToInt32(btn.CommandArgument);

            List<Articolo> carrello = Articolo.GetCarrello();
            Articolo articoloDaRimuovere = carrello.Find(a => a.Id == prodottoId);
            if (articoloDaRimuovere != null)
            {
                carrello.Remove(articoloDaRimuovere);


            }
            Response.Redirect(Request.RawUrl);
        }

        // Metodo che mi fa calcolare il totale del carrello sommando la proprietà prezzo di ogni articolo
        protected void Totale(List<Articolo> listaCarrello)
        {
            double totale = 0;
            foreach (Articolo articolo in listaCarrello)
            {
                totale += articolo.Prezzo;
            }
            contoTotale.InnerHtml = "Totale: " + totale.ToString() + "€";
        }
    }
}