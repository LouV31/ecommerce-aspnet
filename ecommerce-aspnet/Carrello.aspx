<%@ Page Language="C#"  MasterPageFile="~/Site.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="ecommerce_aspnet.Carrello" %>

<asp:Content ID="BodyContent2" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    </head>
    <body>
        <div class="container">
        <p class="alert alert-primary text-success" runat="server" id="alert"></p>
    <div class="row row-cols-1">

        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <div class="col gy-3 border-bottom border-2 pb-2">
                    <div class="d-flex align-items-center justify-content-between">
                        <div>
                            <img src='<%# Eval("Immagine") %>' class="card-img-top img-fluid" style="max-height: 250px; object-fit: contain" alt='<%# Eval("Nome") %>'>
                        </div>
                      
                        <div class="d-flex flex-column">
                            <h5 class="card-title fw-semibold mb-2">Prodotto: <%# Eval("Nome") %></h5>
                            <p class="fw-normal fs-5 mb-0"  >Descrizione: <%# Eval("Descrizione") %></p>

                        </div>
                        <p class="fw-semibold fs-6 mb-0"  >Prezzo: <%# Eval("Prezzo", "{0:c2}") %></p>
                        <asp:Button ID="rimuoviCarrello" runat="server" OnClick="rimuoviCarrello_Click" Text="Rimuovi" CssClass="btn btn-sm btn-success" CommandArgument='<%# Eval("Id") %>'/>
                    </div>
                    
                           
                                   
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <hr />
        <p runat="server" id="contoTotale" class="text-end mb-0">Totale: 0€</p>
    </div>
</div>
    </body>
    </html>
</asp:Content>

