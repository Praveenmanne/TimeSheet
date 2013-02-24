using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;

namespace TimeSheet.TimeEntrie
{
    [ToolboxItemAttribute(false)]
    public partial class TimeEntrie : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public TimeEntrie()
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
                    using (var site = new SPSite(SPContext.Current.Web.Url))
                    {
                        using (var web = site.OpenWeb())
                        {
                            SPUser user = web.CurrentUser;
                            hdnCurrentUsername.Value = user.Name;

                            //Based on login user login name load
                            //peoplepickeremp.Entities.Add(new PickerEntity() {EntityType = "User",DisplayText = user.Name});

                            lblusername.Text = hdnCurrentUsername.Value;

                            var tasklist = SPContext.Current.Web.Lists.TryGetList("Tasks");

                            var currentuserprojects = GetListItemCollection(tasklist, "Assigned To",
                                                                            hdnCurrentUsername.Value);
                            if (currentuserprojects != null)
                            {
                                DDLtitle.Items.Clear();
                                DDLtitle.Items.Add("--Select--");
                                DDLtitle.Items.Add("General Task");

                                foreach (SPListItem projects in currentuserprojects)
                                {

                                    DDLtitle.Items.Add(projects["Title"].ToString());

                                }
                            }

                            var worktype = SPContext.Current.Web.Lists.TryGetList("Worktype").GetItems();
                            ddlworktype.Items.Clear();
                            ddlworktype.Items.Add("choose a worktype");
                            foreach (SPListItem collection in worktype)
                            {
                                ddlworktype.Items.Add(collection["Title"].ToString());
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

        protected void DdLtitleSelectedIndexChanged(object sender, EventArgs e)
        {

            using (var site = new SPSite(SPContext.Current.Web.Url))
            {
                var web = site.OpenWeb();
                web.AllowUnsafeUpdates = true;
                var tasklist = web.Lists.TryGetList("Tasks");
                var collection = GetListItemCollection(tasklist, "Task Name", DDLtitle.SelectedItem.Text);
                if (collection.Count > 0)
                {
                    foreach (SPListItem item in collection)
                    {
                        txtclient.Text = item["Client Name"].ToString();
                        txtproject.Text = item["Project Name"].ToString();

                    }
                }
                else
                {
                    txtclient.Text = "Tillid Software";
                    txtproject.Text = "General Project";
                }

            }


        }

        protected void BtnsubmitClick(object sender, EventArgs e)
        {
            try
            {
                if (ddlworktype.SelectedIndex < 1)
                {
                    lblerror.Text = "Please select type of work.";
                    lblerror.Text += "<br/>";
                    return;
                }
                if (txtDescription.Text == null)
                {
                    lblerror.Text = "Please enter work descrption.";
                    lblerror.Text += "<br/>";
                    return;
                }
                if (txttime.Text == null)
                {
                    lblerror.Text = "Please enter time";
                    lblerror.Text += "<br/>";
                    return;
                }

                using (var site = new SPSite(SPContext.Current.Web.Url))
                {
                    using (var web = site.OpenWeb())
                    {
                        var list = web.Lists.TryGetList("Time Sheet");
                        web.AllowUnsafeUpdates = true;

                        var newItem = list.Items.Add();
                        newItem["Resource"] = lblusername.Text;
                        newItem["Task Title"] = DDLtitle.SelectedValue;
                        newItem["Date"] = Date.SelectedDate;
                        newItem["Time"] = txttime.Text;
                        newItem["Client"] = txtclient.Text;
                        newItem["Project"] = txtproject.Text;
                        newItem["Worktype"] = ddlworktype.SelectedValue;
                        newItem["Descriptionof Work"] = txtDescription.Text;
                       // newItem["Today"] = DateTime.Now;
                        newItem.Update();
                        web.AllowUnsafeUpdates = false;
                        txttime.Text = "";
                        txtclient.Text = "";
                        txtDescription.Text = "";

                    }
                }
            }
            catch (Exception ex)
            {

                lblerror.Text = ex.Message;
            }
        }
    }
}
