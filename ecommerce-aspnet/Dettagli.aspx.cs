using System;

namespace ecommerce_aspnet
{
    public partial class Dettagli : System.Web.UI.Page
    {
        /* 
          Qui ci arrivo tramite il link "Dettagli" presente nel repaeater di Default.aspx il cui href è uguale a '<%# "Dettagli.aspx?IdProdotto=" + Eval("Id") %> dover eval mi prende l'id dell'articolo selezionato
          Tramite Request.QueryString mi vado a prendere il valore dell'id dalla sua url. Se la query string esiste allora mi popolo i campi dell'html con i valori dell'articolo selezionato
          altrimenti mi reindirizza alla pagina principale.
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["IdProdotto"]))
            {
                int id = Convert.ToInt32(Request.QueryString["IdProdotto"]);
                Response.Write(Request.QueryString["IdProdotto"]);
                Articolo articoloSelezionato = Articolo.TrovaArticolo(id);

                Immagine.Attributes.Add("src", articoloSelezionato.Immagine);
                Immagine.Attributes.Add("alt", articoloSelezionato.Nome);

                Nome.InnerHtml = articoloSelezionato.Nome;
                Descrizione.InnerHtml = "Descrizione: " + articoloSelezionato.Descrizione;
                Prezzo.InnerHtml = "Prezzo: " + articoloSelezionato.Prezzo.ToString();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}