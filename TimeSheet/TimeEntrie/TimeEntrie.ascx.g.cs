﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeSheet.TimeEntrie {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    
    
    public partial class TimeEntrie {
        
        protected global::System.Web.UI.WebControls.Label Label1;
        
        protected global::System.Web.UI.WebControls.Label lblusername;
        
        protected global::System.Web.UI.WebControls.Label lbltitle;
        
        protected global::System.Web.UI.WebControls.DropDownList DDLtitle;
        
        protected global::System.Web.UI.WebControls.Label lblDate;
        
        protected global::Microsoft.SharePoint.WebControls.DateTimeControl Date;
        
        protected global::System.Web.UI.WebControls.Label lbltime;
        
        protected global::System.Web.UI.WebControls.TextBox txttime;
        
        protected global::System.Web.UI.WebControls.Label lblclient;
        
        protected global::System.Web.UI.WebControls.Label txtclient;
        
        protected global::System.Web.UI.WebControls.Label lblproject;
        
        protected global::System.Web.UI.WebControls.Label txtproject;
        
        protected global::System.Web.UI.WebControls.Label lblworktype;
        
        protected global::System.Web.UI.WebControls.DropDownList ddlworktype;
        
        protected global::System.Web.UI.WebControls.CheckBox cbbilliable;
        
        protected global::System.Web.UI.WebControls.Label lbldescription;
        
        protected global::System.Web.UI.WebControls.TextBox txtDescription;
        
        protected global::System.Web.UI.WebControls.Button btnsubmit;
        
        protected global::System.Web.UI.WebControls.Label lblerror;
        
        protected global::System.Web.UI.WebControls.HiddenField hdnCurrentUsername;
        
        protected global::System.Web.UI.WebControls.HiddenField hdnCreatedBy;
        
        public static implicit operator global::System.Web.UI.TemplateControl(TimeEntrie target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabel1() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.Label1 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "Label1";
            @__ctrl.Text = "*";
            @__ctrl.ForeColor = global::System.Drawing.Color.Red;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblusername() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblusername = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblusername";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllbltitle() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lbltitle = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lbltitle";
            @__ctrl.Text = "*";
            @__ctrl.ForeColor = global::System.Drawing.Color.Red;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.DropDownList @__BuildControlDDLtitle() {
            global::System.Web.UI.WebControls.DropDownList @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.DropDownList();
            this.DDLtitle = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "DDLtitle";
            @__ctrl.AutoPostBack = true;
            @__ctrl.SelectedIndexChanged -= new System.EventHandler(this.DdLtitleSelectedIndexChanged);
            @__ctrl.SelectedIndexChanged += new System.EventHandler(this.DdLtitleSelectedIndexChanged);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblDate() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblDate = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblDate";
            @__ctrl.Text = "*";
            @__ctrl.ForeColor = global::System.Drawing.Color.Red;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::Microsoft.SharePoint.WebControls.DateTimeControl @__BuildControlDate() {
            global::Microsoft.SharePoint.WebControls.DateTimeControl @__ctrl;
            @__ctrl = new global::Microsoft.SharePoint.WebControls.DateTimeControl();
            this.Date = @__ctrl;
            @__ctrl.ID = "Date";
            @__ctrl.IsRequiredField = true;
            @__ctrl.DateOnly = true;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllbltime() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lbltime = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lbltime";
            @__ctrl.Text = "*";
            @__ctrl.ForeColor = global::System.Drawing.Color.Red;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.TextBox @__BuildControltxttime() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.txttime = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txttime";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblclient() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblclient = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblclient";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControltxtclient() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.txtclient = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txtclient";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblproject() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblproject = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblproject";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControltxtproject() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.txtproject = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txtproject";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblworktype() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblworktype = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblworktype";
            @__ctrl.Text = "*";
            @__ctrl.ForeColor = global::System.Drawing.Color.Red;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.DropDownList @__BuildControlddlworktype() {
            global::System.Web.UI.WebControls.DropDownList @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.DropDownList();
            this.ddlworktype = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "ddlworktype";
            @__ctrl.AutoPostBack = false;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.CheckBox @__BuildControlcbbilliable() {
            global::System.Web.UI.WebControls.CheckBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.CheckBox();
            this.cbbilliable = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "cbbilliable";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllbldescription() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lbldescription = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lbldescription";
            @__ctrl.Text = "*";
            @__ctrl.ForeColor = global::System.Drawing.Color.Red;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.TextBox @__BuildControltxtDescription() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.txtDescription = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txtDescription";
            @__ctrl.TextMode = global::System.Web.UI.WebControls.TextBoxMode.MultiLine;
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(400D, global::System.Web.UI.WebControls.UnitType.Pixel);
            @__ctrl.Height = new System.Web.UI.WebControls.Unit(50D, global::System.Web.UI.WebControls.UnitType.Pixel);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControlbtnsubmit() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.btnsubmit = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.CssClass = "btnStyle";
            @__ctrl.ID = "btnsubmit";
            @__ctrl.Text = "Save";
            @__ctrl.Click -= new System.EventHandler(this.BtnsubmitClick);
            @__ctrl.Click += new System.EventHandler(this.BtnsubmitClick);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblerror() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblerror = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblerror";
            @__ctrl.Visible = false;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.HiddenField @__BuildControlhdnCurrentUsername() {
            global::System.Web.UI.WebControls.HiddenField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.HiddenField();
            this.hdnCurrentUsername = @__ctrl;
            @__ctrl.ID = "hdnCurrentUsername";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.HiddenField @__BuildControlhdnCreatedBy() {
            global::System.Web.UI.WebControls.HiddenField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.HiddenField();
            this.hdnCreatedBy = @__ctrl;
            @__ctrl.ID = "hdnCreatedBy";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::TimeSheet.TimeEntrie.TimeEntrie @__ctrl) {
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControlLabel1();
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(@__ctrl1);
            global::System.Web.UI.WebControls.Label @__ctrl2;
            @__ctrl2 = this.@__BuildControllblusername();
            @__parser.AddParsedSubObject(@__ctrl2);
            global::System.Web.UI.WebControls.Label @__ctrl3;
            @__ctrl3 = this.@__BuildControllbltitle();
            @__parser.AddParsedSubObject(@__ctrl3);
            global::System.Web.UI.WebControls.DropDownList @__ctrl4;
            @__ctrl4 = this.@__BuildControlDDLtitle();
            @__parser.AddParsedSubObject(@__ctrl4);
            global::System.Web.UI.WebControls.Label @__ctrl5;
            @__ctrl5 = this.@__BuildControllblDate();
            @__parser.AddParsedSubObject(@__ctrl5);
            global::Microsoft.SharePoint.WebControls.DateTimeControl @__ctrl6;
            @__ctrl6 = this.@__BuildControlDate();
            @__parser.AddParsedSubObject(@__ctrl6);
            global::System.Web.UI.WebControls.Label @__ctrl7;
            @__ctrl7 = this.@__BuildControllbltime();
            @__parser.AddParsedSubObject(@__ctrl7);
            global::System.Web.UI.WebControls.TextBox @__ctrl8;
            @__ctrl8 = this.@__BuildControltxttime();
            @__parser.AddParsedSubObject(@__ctrl8);
            global::System.Web.UI.WebControls.Label @__ctrl9;
            @__ctrl9 = this.@__BuildControllblclient();
            @__parser.AddParsedSubObject(@__ctrl9);
            global::System.Web.UI.WebControls.Label @__ctrl10;
            @__ctrl10 = this.@__BuildControltxtclient();
            @__parser.AddParsedSubObject(@__ctrl10);
            global::System.Web.UI.WebControls.Label @__ctrl11;
            @__ctrl11 = this.@__BuildControllblproject();
            @__parser.AddParsedSubObject(@__ctrl11);
            global::System.Web.UI.WebControls.Label @__ctrl12;
            @__ctrl12 = this.@__BuildControltxtproject();
            @__parser.AddParsedSubObject(@__ctrl12);
            global::System.Web.UI.WebControls.Label @__ctrl13;
            @__ctrl13 = this.@__BuildControllblworktype();
            @__parser.AddParsedSubObject(@__ctrl13);
            global::System.Web.UI.WebControls.DropDownList @__ctrl14;
            @__ctrl14 = this.@__BuildControlddlworktype();
            @__parser.AddParsedSubObject(@__ctrl14);
            global::System.Web.UI.WebControls.CheckBox @__ctrl15;
            @__ctrl15 = this.@__BuildControlcbbilliable();
            @__parser.AddParsedSubObject(@__ctrl15);
            global::System.Web.UI.WebControls.Label @__ctrl16;
            @__ctrl16 = this.@__BuildControllbldescription();
            @__parser.AddParsedSubObject(@__ctrl16);
            global::System.Web.UI.WebControls.TextBox @__ctrl17;
            @__ctrl17 = this.@__BuildControltxtDescription();
            @__parser.AddParsedSubObject(@__ctrl17);
            global::System.Web.UI.WebControls.Button @__ctrl18;
            @__ctrl18 = this.@__BuildControlbtnsubmit();
            @__parser.AddParsedSubObject(@__ctrl18);
            global::System.Web.UI.WebControls.Label @__ctrl19;
            @__ctrl19 = this.@__BuildControllblerror();
            @__parser.AddParsedSubObject(@__ctrl19);
            global::System.Web.UI.WebControls.HiddenField @__ctrl20;
            @__ctrl20 = this.@__BuildControlhdnCurrentUsername();
            @__parser.AddParsedSubObject(@__ctrl20);
            global::System.Web.UI.WebControls.HiddenField @__ctrl21;
            @__ctrl21 = this.@__BuildControlhdnCreatedBy();
            @__parser.AddParsedSubObject(@__ctrl21);
            @__ctrl.SetRenderMethodDelegate(new System.Web.UI.RenderMethod(this.@__Render__control1));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__Render__control1(System.Web.UI.HtmlTextWriter @__w, System.Web.UI.Control parameterContainer) {
            @__w.Write(@"

<link href=""../_layouts/15/TimeSheet/Stylesheet1.css"" rel=""stylesheet"" />

<script src=""../_layouts/15/TimeSheet/SPOpenDialog.js""></script>

<div class=""Container"">
    <table style=""width:500px"">
        <tr class=""header"">
            <th colspan=""2"">
                <h3>
                    Time Entrie</h3>
            </th>
        </tr>
        <tr class=""data"">
            <td>
                <label>
                    Resource</label>
                ");
            parameterContainer.Controls[0].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n            <td>\r\n               \r\n                    ");
            parameterContainer.Controls[1].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n        </tr>\r\n        <tr class=\"data\">\r\n            <td>\r\n" +
                    "                <label>\r\n                  Task Title</label>\r\n                ");
            parameterContainer.Controls[2].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n            <td>\r\n                ");
            parameterContainer.Controls[3].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n        </tr>\r\n        <tr class=\"data\">\r\n            <td>\r\n" +
                    "                <label>\r\n                    Date</label>\r\n                ");
            parameterContainer.Controls[4].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n            <td>\r\n                ");
            parameterContainer.Controls[5].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n        </tr>\r\n        <tr class=\"data\">\r\n            <td>\r\n" +
                    "                <label>\r\n                    Time</label>\r\n                ");
            parameterContainer.Controls[6].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n            <td>\r\n                ");
            parameterContainer.Controls[7].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n        </tr>\r\n        \r\n        <tr class=\"data\">\r\n        " +
                    "    <td>\r\n                <label>\r\n                    Client</label>\r\n         " +
                    "       ");
            parameterContainer.Controls[8].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n            <td>\r\n                \r\n                ");
            parameterContainer.Controls[9].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n        </tr>\r\n         <tr class=\"data\">\r\n            <td>\r" +
                    "\n                <label>\r\n                    Project</label>\r\n                ");
            parameterContainer.Controls[10].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n            <td>\r\n              \r\n                ");
            parameterContainer.Controls[11].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n        </tr>\r\n        <tr class=\"data\">\r\n            <td>\r\n" +
                    "                <label>\r\n                    Worktype</label>\r\n                ");
            parameterContainer.Controls[12].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n            <td>\r\n                ");
            parameterContainer.Controls[13].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n        </tr>\r\n        <tr class=\"data\">\r\n            <td>\r\n" +
                    "                <label>\r\n                    Billable</label></td>\r\n            " +
                    "    <td>\r\n                ");
            parameterContainer.Controls[14].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n        </tr>\r\n         <tr class=\"data\" >\r\n            <td " +
                    "colspan=\"2\">\r\n                <label>\r\n                    Description of Work <" +
                    "/label>\r\n                ");
            parameterContainer.Controls[15].RenderControl(@__w);
            @__w.Write("<br/>\r\n                <p>(Limit 255 characters. 255 remaining.)</p>\r\n           " +
                    "     ");
            parameterContainer.Controls[16].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n        </tr>\r\n        \r\n        <tr>\r\n            <td style" +
                    "=\"height:45px;\">\r\n                ");
            parameterContainer.Controls[17].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n        </tr>\r\n       \r\n        <tr>\r\n            <td>\r\n    " +
                    "           ");
            parameterContainer.Controls[18].RenderControl(@__w);
            @__w.Write("\r\n                ");
            parameterContainer.Controls[19].RenderControl(@__w);
            @__w.Write("\r\n                ");
            parameterContainer.Controls[20].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n        </tr>\r\n        <tr class=\"newOption\">\r\n            <" +
                    "td>\r\n                <a href=\"JavaScript:openDialog(\'");
                                        @__w.Write( SPContext.Current.Site.Url );

            @__w.Write("/Timesheet/SitePages/MultiTimeEntrie.aspx\');\">\r\n                    Add multi tim" +
                    "e entries</a>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n");
        }
        
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}