﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeSheet.MultipleTimeEntrie {
    using System.Web.UI.WebControls.Expressions;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebControls;
    using System.Collections.Specialized;
    using System.Web.SessionState;
    using Microsoft.SharePoint.WebPartPages;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Data;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Configuration;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    
    
    public partial class MultipleTimeEntrie {
        
        protected global::System.Web.UI.WebControls.Label lblResource;
        
        protected global::System.Web.UI.WebControls.DropDownList ddlClientname;
        
        protected global::System.Web.UI.WebControls.DropDownList ddlTasktitle;
        
        protected global::System.Web.UI.WebControls.DropDownList ddlWorktype;
        
        protected global::System.Web.UI.WebControls.Button btnSave;
        
        protected global::System.Web.UI.WebControls.HiddenField hdncurrentuser;
        
        protected global::System.Web.UI.WebControls.Label lblError;
        
        public static implicit operator global::System.Web.UI.TemplateControl(MultipleTimeEntrie target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblResource() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblResource = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblResource";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.DropDownList @__BuildControlddlClientname() {
            global::System.Web.UI.WebControls.DropDownList @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.DropDownList();
            this.ddlClientname = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "ddlClientname";
            @__ctrl.AutoPostBack = false;
            @__ctrl.SelectedIndexChanged -= new System.EventHandler(this.Ddlclientname);
            @__ctrl.SelectedIndexChanged += new System.EventHandler(this.Ddlclientname);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.DropDownList @__BuildControlddlTasktitle() {
            global::System.Web.UI.WebControls.DropDownList @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.DropDownList();
            this.ddlTasktitle = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "ddlTasktitle";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.DropDownList @__BuildControlddlWorktype() {
            global::System.Web.UI.WebControls.DropDownList @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.DropDownList();
            this.ddlWorktype = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "ddlWorktype";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControlbtnSave() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.btnSave = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "btnSave";
            @__ctrl.Text = "Save";
            @__ctrl.Click -= new System.EventHandler(this.BtnSaveClick);
            @__ctrl.Click += new System.EventHandler(this.BtnSaveClick);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.HiddenField @__BuildControlhdncurrentuser() {
            global::System.Web.UI.WebControls.HiddenField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.HiddenField();
            this.hdncurrentuser = @__ctrl;
            @__ctrl.ID = "hdncurrentuser";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblError() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblError = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblError";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::TimeSheet.MultipleTimeEntrie.MultipleTimeEntrie @__ctrl) {
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControllblResource();
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(@__ctrl1);
            global::System.Web.UI.WebControls.DropDownList @__ctrl2;
            @__ctrl2 = this.@__BuildControlddlClientname();
            @__parser.AddParsedSubObject(@__ctrl2);
            global::System.Web.UI.WebControls.DropDownList @__ctrl3;
            @__ctrl3 = this.@__BuildControlddlTasktitle();
            @__parser.AddParsedSubObject(@__ctrl3);
            global::System.Web.UI.WebControls.DropDownList @__ctrl4;
            @__ctrl4 = this.@__BuildControlddlWorktype();
            @__parser.AddParsedSubObject(@__ctrl4);
            global::System.Web.UI.WebControls.Button @__ctrl5;
            @__ctrl5 = this.@__BuildControlbtnSave();
            @__parser.AddParsedSubObject(@__ctrl5);
            global::System.Web.UI.WebControls.HiddenField @__ctrl6;
            @__ctrl6 = this.@__BuildControlhdncurrentuser();
            @__parser.AddParsedSubObject(@__ctrl6);
            global::System.Web.UI.WebControls.Label @__ctrl7;
            @__ctrl7 = this.@__BuildControllblError();
            @__parser.AddParsedSubObject(@__ctrl7);
            @__ctrl.SetRenderMethodDelegate(new System.Web.UI.RenderMethod(this.@__Render__control1));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__Render__control1(System.Web.UI.HtmlTextWriter @__w, System.Web.UI.Control parameterContainer) {
            @__w.Write("\r\n\r\n<link href=\"../_layouts/15/TimeSheet/Stylesheet1.css\" rel=\"stylesheet\" />\r\n<s" +
                    "cript src=\"../_layouts/15/TimeSheet/jquery1.8.3.js\"></script>\r\n\r\n<style type=\"te" +
                    "xt/css\">\r\n    .alignment {\r\n        height: 40px;\r\n        width: 100px;\r\n      " +
                    "  text-align: center;\r\n    }\r\n\r\n    .header {\r\n        height: 24px;\r\n        wi" +
                    "dth: 100px;\r\n        text-align: center;\r\n        font-weight: bold;\r\n        ba" +
                    "ckground-color: #c3de9f;\r\n    }\r\n</style>\r\n\r\n<script type=\"text/javascript\">\r\n  " +
                    "  $(document).ready(function () {\r\n        var clonefirst = $(\'#first\').clone();" +
                    "\r\n        $(\'#copybtn\').click(function () {\r\n\r\n            clonefirst.clone(fals" +
                    "e).insertAfter(\"#first\");\r\n\r\n\r\n        });\r\n    });\r\n</script>\r\n\r\n<div class=\"Co" +
                    "ntainer\">\r\n    <table>\r\n        <tr>\r\n            <td class=\"header\">\r\n         " +
                    "       <label>\r\n                    Resource</label>\r\n            </td>\r\n       " +
                    "     <td class=\"header\">\r\n                <label>\r\n                    Client</l" +
                    "abel>\r\n            </td>\r\n            <td class=\"header\">\r\n                <labe" +
                    "l>\r\n                    Project</label>\r\n            </td>\r\n            <td clas" +
                    "s=\"header\">\r\n                <label>\r\n                    Task Title</label>\r\n  " +
                    "          </td>\r\n            <td class=\"header\">\r\n                <label>\r\n     " +
                    "               Work Type</label>\r\n            </td>\r\n            <td class=\"head" +
                    "er\">\r\n                <label>\r\n                    Time</label>\r\n            </t" +
                    "d>\r\n            <td class=\"header\">\r\n                <label>\r\n                  " +
                    "  Date</label>\r\n            </td>\r\n            <td class=\"header\"></td>\r\n       " +
                    " </tr>\r\n        <tr id=\"first\">\r\n            \r\n            <td class=\"alignment\"" +
                    ">\r\n                ");
            parameterContainer.Controls[0].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n\r\n            <td class=\"alignment\">\r\n                ");
            parameterContainer.Controls[1].RenderControl(@__w);
            @__w.Write("\r\n            </td>\r\n\r\n\r\n            <td class=\"alignment\">\r\n                <sel" +
                    "ect id=\"ddlProjectName\" name=\"ddlProjectName\">\r\n                    ");
                       foreach (string value in (ArrayList)ViewState["ProjectValues"])
                       { 
            @__w.Write("\r\n                    <option>");
                    @__w.Write( value );

            @__w.Write("</option>\r\n                    ");
                       } 
            @__w.Write("\r\n                </select>\r\n            </td>\r\n\r\n            <td class=\"alignmen" +
                    "t\">\r\n                ");
            parameterContainer.Controls[2].RenderControl(@__w);
            @__w.Write("</td>\r\n\r\n            <td class=\"alignment\">\r\n                ");
            parameterContainer.Controls[3].RenderControl(@__w);
            @__w.Write(@"
            </td>

            <td class=""alignment"">
                <input type=""text"" id=""txttime"" name=""txttime"" />
            </td>

            <td class=""alignment"">

                
            </td>
            <td colspan=""2"" style=""width: 200px"">&nbsp;&nbsp;
                <img id=""copybtn"" src=""../_layouts/15/TimeSheet/copy.gif"" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=""../_layouts/15/TimeSheet/delete.gif"" alt=""copy"" />
            </td>
        </tr>

    </table>
    <div>

        ");
            parameterContainer.Controls[4].RenderControl(@__w);
            @__w.Write("\r\n    </div>\r\n    ");
            parameterContainer.Controls[5].RenderControl(@__w);
            @__w.Write("\r\n    ");
            parameterContainer.Controls[6].RenderControl(@__w);
            @__w.Write("\r\n</div>\r\n");
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