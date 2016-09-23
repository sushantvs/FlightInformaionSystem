<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FlightInfoClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
    </div>
    <div class="showFlightButtondiv">
        <asp:Button ID="btnShowAllFlights" runat="server" Text="Show All Flights" OnClick="btnShowAllFlights_Click" />
    </div>
    <div class="showFlightsGriddiv">
        <asp:GridView ID="FlightListGrid" runat="server" AutoGenerateColumns="False" OnRowCommand="FlightListGrid_OnRowCommand">
            <Columns>
                <asp:BoundField HeaderText="Flight Number" DataField="FlightNumber"></asp:BoundField>
                <asp:ButtonField CommandName="Show Details" ButtonType="Button" Text="Show Details" runat="server"></asp:ButtonField>
            </Columns>
        </asp:GridView>
    </div>
    <div class="showFlightsDetialdiv">
        <asp:GridView ID="FlightDetailsGrid" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField HeaderText="Flight Number" DataField="FlightNumber"></asp:BoundField>
                <asp:BoundField HeaderText="Destination" DataField="Destination"></asp:BoundField>
                <asp:BoundField HeaderText="Flight Time" DataField="FlightTime"></asp:BoundField>
                <asp:BoundField HeaderText="Airline" DataField="Airline"></asp:BoundField>
                <asp:BoundField HeaderText="Model" DataField="Model"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
