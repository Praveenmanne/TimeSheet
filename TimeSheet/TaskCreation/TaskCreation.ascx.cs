using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;

namespace TimeSheet.TaskCreation
{
    [ToolboxItemAttribute(false)]
    public partial class TaskCreation : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public TaskCreation()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    using (var site = new SPSite(SPContext.Current.Site.Url))
                    {
                        using (var web = site.OpenWeb())
                        {
                            SPUser user = web.CurrentUser;
                            hdnCurrentUsername.Value = user.Name;

                            var tasklist = SPContext.Current.Web.Lists.TryGetList("Projects Assigning");

                            var currentuserprojects = GetListItemCollection(tasklist, "Project Leader",
                                                                            hdnCurrentUsername.Value);
                            if (currentuserprojects != null)
                            {
                                DdlProjectname.Items.Clear();
                                DDlClientname.Items.Clear();
                                DdlProjectname.Items.Add("--Select--");
                                DDlClientname.Items.Add("--Select--");

                                foreach (SPListItem projects in currentuserprojects)
                                {
                                    var spv = new SPFieldLookupValue(projects["Project Name"].ToString());
                                    DdlProjectname.Items.Add(spv.LookupValue);
                                    var clientspv = new SPFieldLookupValue(projects["Client"].ToString());
                                    DDlClientname.Items.Add(clientspv.LookupValue);
                                }
                            }

                        }
                    }


                }

                catch (Exception ex)
                {
                    lblerror.Text = ex.Message;
                }
            }
        }

        protected void BtnsubmitClick(object sender, EventArgs e)
        {
            try
            {
                if (txttitle.Text == null)
                {
                    lblerror.Text = "Please enter Title.";
                    lblerror.Text += "<br/>";
                    return;
                }
                if (DDlClientname.SelectedIndex < 1)
                {
                    lblerror.Text = "Please select Client Name.";
                    lblerror.Text += "<br/>";
                    return;
                }
                if (DdlProjectname.SelectedIndex < 1)
                {
                    lblerror.Text = "Please select Project Name.";
                    lblerror.Text += "<br/>";
                    return;
                }
                if (ddlstatus.SelectedIndex < 1)
                {
                    lblerror.Text = "Please select Status.";
                    lblerror.Text += "<br/>";
                    return;
                }

                if (DDlPriority.SelectedIndex < 1)
                {
                    lblerror.Text = "Please select Priority.";
                    lblerror.Text += "<br/>";
                    return;
                }
                if (txtDescription.Text == null)
                {
                    lblerror.Text = "Please Enter Description of Task .";
                    lblerror.Text += "<br/>";
                    return;
                }

                using (var site = new SPSite(SPContext.Current.Web.Url))
                {
                    using (var web = site.OpenWeb())
                    {
                        var list = web.Lists.TryGetList("Tasks");
                        web.AllowUnsafeUpdates = true;

                        var newItem = list.Items.Add();
                        newItem["Title"] = txttitle.Text;
                        newItem["Client Name"] = DDlClientname.SelectedValue;
                        newItem["Project Name"] = DdlProjectname.SelectedValue;
                        newItem["Priority"] = DDlPriority.SelectedValue;
                        newItem["Status"] = ddlstatus.SelectedValue;
                        newItem["Assigned To"] = web.AllUsers[peoplepickeremp.Accounts[0].ToString()];
                        newItem["Description"] = txtDescription.Text;
                        newItem.Update();
                        web.AllowUnsafeUpdates = false;
                        txttitle.Text = "";
                        DDlClientname.SelectedItem.Text = "";
                        DdlProjectname.SelectedItem.Text = "";
                        DDlPriority.SelectedItem.Text = "";
                        ddlstatus.SelectedItem.Text = "";
                        txtDescription.Text = "";

                    }
                }
            }
            catch (Exception ex)
            {

                lblerror.Text = ex.Message;
            }
        }
        internal SPListItemCollection GetListItemCollection(SPList spList, string keyOne, string valueOne, string keyTwo, string valueTwo)
        {
            // Return list item collection based on the lookup field

            SPField spFieldOne = spList.Fields[keyOne];
            SPField spFieldTwo = spList.Fields[keyTwo];
            var query = new SPQuery
            {
                Query = @"<Where>
                          <And>
                                <Eq>
                                    <FieldRef Name=" + spFieldOne.InternalName + @" />
                                    <Value Type=" + spFieldOne.Type.ToString() + ">" + valueOne + @"</Value>
                                </Eq>
                                <Eq>
                                    <FieldRef Name=" + spFieldTwo.InternalName + @" />
                                    <Value Type=" + spFieldTwo.Type.ToString() + ">" + valueTwo + @"</Value>
                                </Eq>
                          </And>
                        </Where>"
            };

            return spList.GetItems(query);
        }
        internal SPListItemCollection GetListItemCollection(SPList spList, string key, string value)
        {
            // Return list item collection based on the lookup field

            SPField spField = spList.Fields[key];
            var query = new SPQuery
            {
                Query = @"<Where>
                        <Eq>
                            <FieldRef Name='" + spField.InternalName + @"'/><Value Type='" + spField.Type.ToString() + @"'>" + value + @"</Value>
                        </Eq>
                        </Where>"
            };

            return spList.GetItems(query);
        }
    }
}
