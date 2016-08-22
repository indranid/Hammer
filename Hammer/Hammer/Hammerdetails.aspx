<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Hammerdetails.aspx.cs" Inherits="Hammer._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   


    <asp:GridView ID="GridViewHammer" runat="server" AutoGenerateColumns="False" DataKeyNames="id" OnRowCancelingEdit="GridViewHammer_RowCancelingEdit" OnRowEditing="GridViewHammer_RowEditing" OnPageIndexChanging="GridViewHammer_PageIndexChanging" OnRowDeleting="GridViewHammer_RowDeleting" OnRowUpdating="GridViewHammer_RowUpdating">

        <Columns>
        <asp:BoundField DataField="HammerName" HeaderText="Name" />
        <asp:BoundField DataField="Hammertype" HeaderText="Type" />
         <asp:CommandField ShowEditButton="true" />
        <asp:CommandField ShowDeleteButton="true" />
        </Columns>
    </asp:GridView>

   


</asp:Content>
