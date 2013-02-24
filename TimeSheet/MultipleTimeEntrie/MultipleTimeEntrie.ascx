<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MultipleTimeEntrie.ascx.cs" Inherits="TimeSheet.MultipleTimeEntrie.MultipleTimeEntrie" %>

<link href="../_layouts/15/TimeSheet/Stylesheet1.css" rel="stylesheet" />
<script src="../_layouts/15/TimeSheet/jquery1.8.3.js"></script>

<style type="text/css">
    .alignment {
        height: 40px;
        width: 100px;
        text-align: center;
    }

    .header {
        height: 24px;
        width: 100px;
        text-align: center;
        font-weight: bold;
        background-color: #c3de9f;
    }
</style>

<script type="text/javascript">
    $(document).ready(function () {
        var clonefirst = $('#first').clone();
        $('#copybtn').click(function () {

            clonefirst.clone(false).insertAfter("#first");


        });
    });
</script>

<div class="Container">
    <table>
        <tr>
            <td class="header">
                <label>
                    Resource</label>
            </td>
            <td class="header">
                <label>
                    Client</label>
            </td>
            <td class="header">
                <label>
                    Project</label>
            </td>
            <td class="header">
                <label>
                    Task Title</label>
            </td>
            <td class="header">
                <label>
                    Work Type</label>
            </td>
            <td class="header">
                <label>
                    Time</label>
            </td>
            <td class="header">
                <label>
                    Date</label>
            </td>
            <td class="header"></td>
        </tr>
        <tr id="first">
            
            <td class="alignment">
                <asp:Label ID="lblResource" runat="server"></asp:Label>
            </td>

            <td class="alignment">
                <asp:DropDownList ID="ddlClientname" runat="server" OnSelectedIndexChanged="Ddlclientname" AutoPostBack="False"></asp:DropDownList>
            </td>


            <td class="alignment">
                <select id="ddlProjectName" name="ddlProjectName">
                    <% foreach (string value in (ArrayList)ViewState["ProjectValues"])
                       { %>
                    <option><%= value %></option>
                    <% } %>
                </select>
            </td>

            <td class="alignment">
                <asp:DropDownList ID="ddlTasktitle" runat="server"></asp:DropDownList></td>

            <td class="alignment">
                <asp:DropDownList ID="ddlWorktype" runat="server"></asp:DropDownList>
            </td>

            <td class="alignment">
                <input type="text" id="txttime" name="txttime" />
            </td>

            <td class="alignment">

                <%-- <SharePoint:DateTimeControl runat="server" ID="Date" IsRequiredField="False" DateOnly="True"/>--%>
            </td>
            <td colspan="2" style="width: 200px">&nbsp;&nbsp;
                <img id="copybtn" src="../_layouts/15/TimeSheet/copy.gif" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="../_layouts/15/TimeSheet/delete.gif" alt="copy" />
            </td>
        </tr>

    </table>
    <div>

        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="BtnSaveClick" />
    </div>
    <asp:HiddenField ID="hdncurrentuser" runat="server" />
    <asp:Label ID="lblError" runat="server"></asp:Label>
</div>
