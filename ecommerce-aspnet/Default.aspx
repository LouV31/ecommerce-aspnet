<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Default.aspx.cs" Inherits="ecommerce_aspnet._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="container">

            <div class="row row-cols-1 row-cols-md-2 row-cols-lg-3 row-cols-xl-4">

                <asp:Repeater ID="Repeater1" runat="server" >
                    <ItemTemplate>
                        <div class="col gy-3">

                            <div class="card mx-2 my-2 bg-white text-white border border-dark border-2 overflow-hidden">
                                <img src='<%# Eval("Immagine") %>' class="card-img-top img-fluid" style="max-height: 250px; object-fit: contain" alt='<%# Eval("Nome") %>'>
                                <div class="card-body bg-dark">
                                    <h5 class="card-title fw-semibold"><%# Eval("Nome") %></h5>
                                    <p class="card-text"><%# Eval("Prezzo", "{0:c2}") %></p>
                                    <a href='<%# "Dettagli.aspx?IdProdotto=" + Eval("Id") %>' class="btn btn-sm btn-secondary">Dettagli</a>
                                    <asp:Button ID="aggiungiCarrello" runat="server" OnClick="aggiungiCarrello_Click" Text="Acquista" CssClass="btn btn-sm btn-success" CommandArgument='<%# Eval("Id") %>' />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </main>

</asp:Content>
