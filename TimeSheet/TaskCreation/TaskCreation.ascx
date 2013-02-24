<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaskCreation.ascx.cs" Inherits="TimeSheet.TaskCreation.TaskCreation" %>

<link href="../_layouts/15/TimeSheet/Stylesheet1.css" rel="stylesheet" />


<div class="Container">
    <table>
        <tr class="header">
            <th colspan="2">
                <h3>
                    Task Creation.</h3>
            </th>
        </tr>
        <tr class="data">
            <td>
                <label>
                   Task Title</label>
                <asp:Label runat="server" ID="lbltitle" Text="*" ForeColor="RED"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txttitle"></asp:TextBox>
            </td>
        </tr>
        <tr class="data">
            <td>
                <label>
                    Client Name</label>
                <asp:Label runat="server" ID="lblclientname" Text="*" ForeColor="RED"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DDlClientname" AutoPostBack="False" />
            </td>
        </tr>
        <tr class="data">
            <td>
                <label>
                    Project Name</label>
                <asp:Label runat="server" ID="lblprojectname" Text="*" ForeColor="RED"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DdlProjectname" AutoPostBack="False">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="data">
            <td>
                <label>
                    Priority</label>
                <asp:Label runat="server" ID="lblpriority" Text="*" ForeColor="RED"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DDlPriority" AutoPostBack="False">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>High</asp:ListItem>
                    <asp:ListItem>Low</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="data">
            <td>
                <label>
                    Status</label>
                <asp:Label runat="server" ID="lblstatus" Text="*" ForeColor="RED"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlstatus" AutoPostBack="False">
                     <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Not Started</asp:ListItem>
                    <asp:ListItem>In Progress</asp:ListItem>
                     <asp:ListItem>Complete</asp:ListItem> 
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="data">
            <td>
                <label>
                    Assigned To</label>
                <asp:Label runat="server" ID="lblassignedto" Text="*" ForeColor="RED"></asp:Label>
            </td>
            <td>
                 <SharePoint:PeopleEditor ID="peoplepickeremp" Width="355px" Visible="true" AllowEmpty="false"
                    ValidatorEnabled="true" SelectionSet="User" MultiSelect="True" runat="server"
                    CssClass="pickerStyle"></SharePoint:PeopleEditor>
            </td>
        </tr>
        <tr class="data">
            <td colspan="2">
                <label>
                    Description of Task</label>
                <asp:Label runat="server" ID="lbldescription" Text="*" ForeColor="RED"></asp:Label>
             <p>(Limit 255 characters. 255 remaining.)</p>
                <asp:TextBox runat="server" ID="txtDescription" TextMode="MultiLine" Width="500px" Height="40px"></asp:TextBox>
            </td>
        </tr><br/>
        <tr>
            <td>
                <asp:Button ID="btnsubmit" CssClass="btnStyle" Text="Submit" runat="server" 
                    onclick="BtnsubmitClick" />
            </td>
        </tr>
        <tr>
            <td>
               <asp:Label runat="server" ID="lblerror" ForeColor="Red"></asp:Label>
                <asp:HiddenField ID="hdnCurrentUsername" runat="server"  />
            </td>
        </tr>
    </table>
</div>
