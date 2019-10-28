<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Video.aspx.cs" Inherits="APP2.Video" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="multimedia">
        <h2> Video </h2>
        <video controls width="560" height="315" autoplay>
            <source src="VID/IMG_6920.MOV"/>
        </video>

        <h2> Youtube </h2>
        <iframe width="560" height="315" src="https://www.youtube.com/embed/-e_3Cg9GZFU" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
    </div>

</asp:Content>
