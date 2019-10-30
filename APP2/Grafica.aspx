<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Grafica.aspx.cs" Inherits="APP2.Grafica" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid" id="contenedor">

    <div id="g1">
        <asp:Chart ID="Ventas" runat="server">
            <series>
                <asp:Series Name="Series1" Legend="Legend1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
            <Legends>
                <asp:Legend Name="Legend1">
                </asp:Legend>
            </Legends>
        </asp:Chart>
    </div>

    <div id="g2">
        <asp:Chart ID="Alumnos" runat="server">
            <series>
                <asp:Series Name="Series1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
    </div>
        <div>
                    <asp:FileUpload ID="archivo" accept=".pdf,.jpg" runat="server" class="btn btn-info"/><br />
            </div>
        <div>
            <asp:Button ID="BtnSavePDF" runat="server" Text="Guardar PDF" OnClick="BtnSavePDF_Click" />
        </div>
        <div>
            <asp:Button ID="BtnSaveImg" runat="server" Text="Guardar Imagen" OnClick="BtnSaveImg_Click" />
        </div>
        <div>
            <asp:Button ID="BtnEnviar" runat="server" Text="Enviar Correo" OnClick="BtnEnviar_Click" />
        </div>
</div>

</asp:Content>
