using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommerce_aspnet
{
    public partial class _Default : Page
    {
        // Al page load, la lista di articoli viene svuotata e riempita con nuovi articoli altrimenti ad ogni postback la lista verrebbe riempita nuovamente
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Svuoto la lista di articoli
                Articolo.GetListaArticoli().Clear();
                // Genero gli articoli attraverso il metodo GeneraArticoli
                GeneraArticoli();
                // Associo la lista di articoli al Repeater che mi fa una sorta di "map" lato html
                Repeater1.DataSource = Articolo.GetListaArticoli();
                Repeater1.DataBind();
            }


        }

        // Metodo che mi genera gli articoli tramite il costruttore della classe Articolo e attraverso il metodo AggiungiArticolo li aggiunge alla lista.
        protected void GeneraArticoli()
        {
            Articolo articolo1 = new Articolo(1, "Apple Iphone 11 128GB Nero", "Un bell'Iphone 11, molto bello", 303.99, "https://m.media-amazon.com/images/I/71B62qVvfML._AC_SX569_.jpg");
            Articolo.AggiungiArticolo(articolo1);
            Articolo articolo2 = new Articolo(2, "Samsung Galaxy S20 128GB Nero", "Un bell'Samsung S20, molto bello", 202.89, "https://m.media-amazon.com/images/I/71yeSJUjKfL._AC_SX569_.jpg");
            Articolo.AggiungiArticolo(articolo2);
            Articolo articolo3 = new Articolo(3, "Huawei P40 128GB Nero", "Un bell'Huawei P40, molto bello", 384.22, "https://m.media-amazon.com/images/I/61cToSsznRL._AC_SX679_.jpg");
            Articolo.AggiungiArticolo(articolo3);
            Articolo articolo4 = new Articolo(4, "Xiaomi Mi 10 128GB Nero", "Un bell'Xiaomi Mi 10, molto bello", 299.99, "https://m.media-amazon.com/images/I/61I-7uCTjEL._AC_SX679_.jpg");
            Articolo.AggiungiArticolo(articolo4);
            Articolo articolo5 = new Articolo(5, "OnePlus 8 128GB Nero", "Un bell'OnePlus 8, molto bello", 399.99, "https://m.media-amazon.com/images/I/51FZY2EihLL._AC_SX569_.jpg");
            Articolo.AggiungiArticolo(articolo5);
            Articolo articolo6 = new Articolo(6, "Oppo Find X2 128GB Nero", "Un bell'Oppo Find X2, molto bello", 499.99, "https://m.media-amazon.com/images/I/715qO4LZoGL._AC_SY879_.jpg");
            Articolo.AggiungiArticolo(articolo6);
            Articolo articolo7 = new Articolo(7, "Realme X50 128GB Nero", "Un bell'Realme X50, molto bello", 299.99, "https://m.media-amazon.com/images/I/61a37-bGsXL._AC_SX679_.jpg");
            Articolo.AggiungiArticolo(articolo7);
            Articolo articolo8 = new Articolo(8, "Vivo X50 128GB Nero", "Un bell'Vivo X50, molto bello", 399.99, "https://m.media-amazon.com/images/I/71-THgQ-SsL._AC_SX679_.jpg");
            Articolo.AggiungiArticolo(articolo8);
        }

        // Metodo che mi permette di aggiungere un articolo al carrello. Mi prendo l'id dell'articolo tramite il CommandArgument del bottone e lo passo al metodo AggiungiCarrello della classe Articolo.
        protected void aggiungiCarrello_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            int id = Convert.ToInt32(btn.CommandArgument);
            Articolo questoArticolo = Articolo.TrovaArticolo(id);
            Articolo.AggiungiCarrello(questoArticolo);




        }
    }
}