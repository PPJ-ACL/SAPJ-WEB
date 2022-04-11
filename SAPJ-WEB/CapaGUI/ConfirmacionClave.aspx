<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmacionClave.aspx.cs" Inherits="CapaGUI.ConfirmacionClave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/> 
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    <link href="CSS/estilo.css" rel="stylesheet"/>
    <title></title>
</head>
<body id="PanchitoOdiame">
    <form id="form1" runat="server">
       <div id="BarraSuperior" class="col-md-12">
            <img src="/Imagenes/ACL.png" alt="Logo ACL" class="col-md-1" />
            <div class="col-md-11"></div>
        </div>
        <div id="Contenedor">
            <h4>    
                <asp:Label id="lblCorreo" Text="Correo:" runat="server" />
                <asp:TextBox id="tbCorreo" runat="server" CssClass="form-control" PlaceHolder ="Ingrese su Correo"/>         
            </h4>
             <asp:Label id="lblError" Text="" runat="server" /> <br/>   
            <div id="CentraTexto">
                <asp:Button id="BtnEnviarCorreo" Text="Enviar Correo" CssClass="btn btn-primary btn-lg btn-block" runat="server" OnClick="BtnEnviarCorreo_Click"/>
                <br/>
                <div class="col-sm-12">
                  <asp:Label id="lblCodVerificacion" Text="Código de Verificación:" runat="server" /><br/>
                  <asp:TextBox id="tbCodigoVerif" runat="server" CssClass="form-control-sm" PlaceHolder ="Ingrese su Código de Verificación"/>
                  <asp:Button id="BtnConfirmar" Text="Confirmar" CssClass="btn btn-primary btn-lg btn-block" runat="server" OnClick="BtnConfirmar_Click"/>
                    <asp:Label id="lblValida" Text="" runat="server" Visible="false"/>
                </div>
                
            </div>    
        </div>
    </form>
</body>
</html>
