<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="Examen2JosephOvares.Form1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <label>Nombre</label>
    </div>

    <div>
        <asp:TextBox ID="TNombre" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Cedula</label>
    </div>
    <div>
        <asp:TextBox ID="TCedula" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Telefono</label>

    </div>
    <div>
        <asp:TextBox ID="TTelefono" runat="server"></asp:TextBox>

    </div>
    <div>
        <label>Direccion</label>
    </div>
    <div>
        <asp:TextBox ID="TDireccion" runat="server"></asp:TextBox>

    </div>
    <div>
        <asp:Button ID="Agua" runat="server" Text="Agua" />
        <asp:Button ID="Electricidad" runat="server" Text="Electricidad" />
        <asp:Button ID="Telefono" runat="server" Text="Telefono" />
        <asp:Button ID="Internet" runat="server" Text="Internet" />
    </div>
</asp:Content>
