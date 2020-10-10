<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MusicDetails.aspx.cs" Inherits="Music.MusicDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="musicDetail" runat="server"
                        ItemType="Music.Models.AppMusic" SelectMethod ="GetMusic"
                        RenderOuterTable="false">
            <ItemTemplate>
                <div>
                    <h1><%#:Item.MusicName %></h1>
                </div>
                <br />
                <table>
                    <tr>
                            <td>
                                <img src="/Catalog/Images/<%#:Item.ImagePath %>"
                                    style="border:solid; height:300px" alt="<%#:Item.MusicName %>"/>
                            </td>
                            <td>&nbsp;</td>
                            <td style="vertical-align: top; text-align:left;">
                                <b>Description:</b><br /><%#:Item.Description %>
                                <br />
                                <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}",
                                    Item.UnitPrice) %>
                                </span>
                                <br />
                                <span><b>Music Number:</b>&nbsp;<%#:Item.MusicID%></span>
                                <br />
                            </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:FormView>
</asp:Content>
