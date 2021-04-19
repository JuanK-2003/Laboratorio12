<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio12._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>LABORATORIO# 12</h1>
        <p class="lead">Control de alumno</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Universidades</h2>
            <p>Ingrese la Universidad
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="btn-primary active" Height="16px" Width="181px">
                    <asp:ListItem>USAC</asp:ListItem>
                    <asp:ListItem>UMES</asp:ListItem>
                    <asp:ListItem>URL</asp:ListItem>
                    <asp:ListItem>UMG</asp:ListItem>
                    <asp:ListItem>Del Valle</asp:ListItem>
                    <asp:ListItem>Francisco Marroquín</asp:ListItem>
                    <asp:ListItem>Da Vinci</asp:ListItem>
                    <asp:ListItem>Rural</asp:ListItem>
                </asp:DropDownList>
            </p>
            <h2>Estudiantes</h2>
            <p>
                Ingrese el nombre de los estudiantes
                <asp:TextBox ID="TextAlumno" runat="server" Width="291px" CssClass="btn-primary active"></asp:TextBox>
&nbsp;
                <asp:Button ID="ButtonAlumno" runat="server" CssClass="btn-danger active" Text="Ingresar Alumno" Width="151px" OnClick="ButtonAlumno_Click" Height="30px" />
            </p>
            <p>
                Total de alumnos ingresados:
                <asp:Label ID="LabelTotalAlumnos" runat="server"></asp:Label>
            </p>
            <p>
                <asp:Button ID="ButtonIngreso" runat="server" CssClass="btn-success disabled" Text="Ingresar datos de la Universidad" OnClick="Button1_Click" Font-Bold="True" Font-Size="X-Large" Height="50px" Width="677px" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>