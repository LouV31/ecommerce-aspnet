<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="ecommerce_aspnet.Dettagli" %>

<asp:Content ID="BodyContent1" ContentPlaceHolderID="MainContent" runat="server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-8">
                <h2>Dettagli Prodotto</h2>
                <hr />
                <div class="row">
                    <div class="col-4">
                        <img id="Immagine" runat="server" src="" alt="" class="img-thumbnail" />
                    </div>
                    <div class="col-8">
                        <h4 id="Nome" runat="server"></h4>
                        <p class="fw-normal fs-5 mb-2" id="Descrizione" runat="server"></p>
                        <p class="fw-semibold fs-6 mb-0" id="Prezzo" runat="server"></p>
                        
                    </div>
                </div>

            </div>
</body>
</html>
</asp:Content>

