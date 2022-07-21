<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="MedidoresWeb.Listado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row mt-5">
        <div class="col-lg-6-mx-auto">
            <asp:DropDownList ID="estadoDDL" runat="server">
                <asp:ListItem Text="Pagada" Selected="True" Value="Pagada"></asp:ListItem>
                <asp:ListItem Text="Con Deuda" Value="Con Deuda"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="row mt-5">
        <asp:GridView ID="grillaUsuarios"
            CssClass="table table-hover table-bordered"
            AutoGenerateColumns="false"
            ShowHeaderWhenEmpty ="true"
            EmptyDataText="No hay registros"
            runat ="server"></asp:GridView>
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="Rut" DataField="Rut" />
            <asp:BoundField HeaderText="Mail" DataField="Mail" />
            <asp:BoundField HeaderText="Contraseña" DataField="Contraseña" />

        </Columns>
    </div>
</asp:Content>
