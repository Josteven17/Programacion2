<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Form2.aspx.cs" Inherits="Examen2JosephOvares.Form2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>

        <div>
            <label>Numero de factura</label>
        </div>
        <div>
            <asp:TextBox ID="TFactura" runat="server"></asp:TextBox>

        </div>
        <div>
            <label>Codigo de servicio</label>
        </div>
        <div>
            <asp:TextBox ID="TCodigo" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Mes</label>
        </div>
        <div>
            <asp:TextBox ID="TMes" runat="server"></asp:TextBox>

        </div>
        <div>
            <label>Monto</label>
        </div>
        <div>
            <asp:TextBox ID="TMonto" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Descuento</label>
        </div>
        <div>
            <asp:TextBox ID="TDescuento" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="BAgregar" runat="server" Text="Agregar" />
            <asp:Button ID="BSalvar" runat="server" Text="Salvar" />
            <asp:Button ID="BVolver" runat="server" Text="Volver" OnClick="BVolver_Click" />
        </div>
    </div>

    <div>

        <div>
        <label>Nombre</label>
    </div>

    <div>
        <asp:TextBox ID="TNombre2" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Cedula</label>
    </div>
    <div>
        <asp:TextBox ID="TCedula2" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Telefono</label>

    </div>
    <div>
        <asp:TextBox ID="TTelefono2" runat="server"></asp:TextBox>

    </div>
    <div>
        <label>Direccion</label>
    </div>
    <div>
        <asp:TextBox ID="TDireccion2" runat="server"></asp:TextBox>

    </div>
    </div>

    <div>

        <div>
        <label>Monto</label>
    </div>

    <div>
        <asp:TextBox ID="TMonto2" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Descuento</label>
    </div>
    <div>
        <asp:TextBox ID="TDescuento2" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Subtotal</label>

    </div>
    <div>
        <asp:TextBox ID="TSubtotal" runat="server"></asp:TextBox>

    </div>
    <div>
        <label>Iva</label>
    </div>
    <div>
        <asp:TextBox ID="TIva" runat="server"></asp:TextBox>

    </div>
        <div>
        <label>Total</label>
    </div>
    <div>
        <asp:TextBox ID="TTotal" runat="server"></asp:TextBox>

    </div>
    </div>
</asp:Content>
