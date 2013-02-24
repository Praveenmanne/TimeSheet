<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TimeEntrie.ascx.cs" Inherits="TimeSheet.TimeEntrie.TimeEntrie" %>

<link href="../_layouts/15/TimeSheet/Stylesheet1.css" rel="stylesheet" />

<script src="../_layouts/15/TimeSheet/SPOpenDialog.js"></script>

<div class="Container">
    <table style="width:500px">
        <tr class="header">
            <th colspan="2">
                <h3>
                    Time Entrie</h3>
            </th>
        </tr>
        <tr class="data">
            <td>
                <label>
                    Resource</label>
                <asp:Label runat="server" ID="Label1" Text="*" ForeColor="RED"></asp:Label>
            </td>
            <td>
               <%--<SharePoint:PeopleEditor ID="peoplepickeremp" Width="355px" Visible="true"  AllowEmpty="false"
                    ValidatorEnabled="true" SelectionSet="User" MultiSelect="True" runat="server"
                    CssClass="NoBorder"></SharePoint:PeopleEditor>--%>
                    <asp:Label runat="server" ID="lblusername"></asp:Label>
            </td>
        </tr>
        <tr class="data">
            <td>
                <label>
                  Task Title</label>
                <asp:Label runat="server" ID="lbltitle" Text="*" ForeColor="RED"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DDLtitle" AutoPostBack="True" 
                    onselectedindexchanged="DdLtitleSelectedIndexChanged"/>
            </td>
        </tr>
        <tr class="data">
            <td>
                <label>
                    Date</label>
                <asp:Label runat="server" ID="lblDate" Text="*" ForeColor="RED"></asp:Label>
            </td>
            <td>
                <SharePoint:DateTimeControl runat="server" ID="Date" IsRequiredField="True" DateOnly="True"/>
            </td>
        </tr>
        <tr class="data">
            <td>
                <label>
                    Time</label>
                <asp:Label runat="server" ID="lbltime" Text="*" ForeColor="RED"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txttime"></asp:TextBox>
            </td>
        </tr>
        
        <tr class="data">
            <td>
                <label>
                    Client</label>
                <asp:Label runat="server" ID="lblclient"></asp:Label>
            </td>
            <td>
                
                <asp:Label runat="server" ID="txtclient"></asp:Label>
            </td>
        </tr>
         <tr class="data">
            <td>
                <label>
                    Project</label>
                <asp:Label runat="server" ID="lblproject"></asp:Label>
            </td>
            <td>
              
                <asp:Label runat="server" ID="txtproject"></asp:Label>
            </td>
        </tr>
        <tr class="data">
            <td>
                <label>
                    Worktype</label>
                <asp:Label runat="server" ID="lblworktype" Text="*" ForeColor="RED"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="ddlworktype" AutoPostBack="False"/>
            </td>
        </tr>
        <tr class="data">
            <td>
                <label>
                    Billable</label></td>
                <td>
                <asp:CheckBox ID="cbbilliable" runat="server"   />
            </td>
        </tr>
         <tr class="data" >
            <td colspan="2">
                <label>
                    Description of Work </label>
                <asp:Label runat="server" ID="lbldescription" Text="*" ForeColor="RED"></asp:Label><br/>
                <p>(Limit 255 characters. 255 remaining.)</p>
                <asp:TextBox runat="server" ID="txtDescription" TextMode="MultiLine" 
                    Width="400px" Height="50px"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td style="height:45px;">
                <asp:Button CssClass="btnStyle" runat="server" ID="btnsubmit" Text="Save" 
                    onclick="BtnsubmitClick"/>
            </td>
        </tr>
       
        <tr>
            <td>
               <asp:Label runat="server" ID="lblerror" Visible="False"></asp:Label>
                <asp:HiddenField ID="hdnCurrentUsername" runat="server"  />
                <asp:HiddenField ID="hdnCreatedBy" runat="server"  />
            </td>
        </tr>
        <tr class="newOption">
            <td>
                <a href="JavaScript:openDialog('<%= SPContext.Current.Site.Url %>/Timesheet/SitePages/MultiTimeEntrie.aspx');">
                    Add multi time entries</a>
            </td>
        </tr>
    </table>
</div>
