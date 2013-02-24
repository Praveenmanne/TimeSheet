using System;
using System.ComponentModel;
using System.Data;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using System.Collections;

namespace TimeSheet.MultipleTimeEntrie
{
    [ToolboxItemAttribute(false)]
    public partial class MultipleTimeEntrie : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public MultipleTimeEntrie()
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
                    SPUser user = SPContext.Current.Web.CurrentUser;
                    hdncurrentuser.Value = user.Name;
                    var client = SPContext.Current.Web.Lists.TryGetList("Tasks");
                    var currentuserclient = GetListItemCollection(client, "Assigned To", hdncurrentuser.Value);
                    ddlClientname.Items.Clear();
                    ddlClientname.Items.Add("choose a Client");

                    foreach (SPListItem collection in currentuserclient)
                    {
                        ddlClientname.Items.Add(collection["Client Name"].ToString());
                    }


                    var worktype = SPContext.Current.Web.Lists.TryGetList("Worktype").GetItems();
                    ddlWorktype.Items.Clear();
                    ddlWorktype.Items.Add("choose a worktype");
                    foreach (SPListItem collection in worktype)
                    {
                        ddlWorktype.Items.Add(collection["Title"].ToString());
                    }
                    var projectname = SPContext.Current.Web.Lists.TryGetList("Tasks").GetItems();


                    var projectnames = new ArrayList();
                    foreach (SPListItem collection in projectname)
                    {
                        //ddlProjectName.Items.Add(collection["Project Name"].ToString());
                        projectnames.Add(collection["Project Name"].ToString());
                    }
                    ViewState["ProjectValues"] = projectnames;

                    var taskname = SPContext.Current.Web.Lists.TryGetList("Tasks").GetItems();
                    ddlTasktitle.Items.Clear();
                    ddlTasktitle.Items.Add("choose a Task Title");
                    foreach (SPListItem collection in taskname)
                    {
                        ddlTasktitle.Items.Add(collection["Task Name"].ToString());
                    }
                    Loaddetails();


                }
                catch (Exception ex)
                {

                    lblError.Text = ex.Message;
                }
            }

        }

        private void Loaddetails()
        {
            try
            {
                using (var site = new SPSite(SPContext.Current.Site.Url))
                {
                    using (var web = site.OpenWeb())
                    {
                        SPUser user = web.CurrentUser;
                        hdncurrentuser.Value = user.Name;

                        lblResource.Text = hdncurrentuser.Value;
                    }
                }
            }
            catch (Exception ex)
            {

                lblError.Text = ex.Message;
            }

        }

        public bool IsMemberInGroup(string groupName)
        {
            bool memberInGroup;
            using (var site = new SPSite(SPContext.Current.Site.Url))
            {
                using (var web = site.OpenWeb())
                {
                    memberInGroup = web.IsCurrentUserMemberOfGroup(web.Groups[groupName].ID);
                }
            }

            return memberInGroup;
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

        internal SPListItemCollection GetListItemCollection(SPList spList, string keyOne, string valueOne, string keyTwo, string valueTwo, string keyThree, string valueThree)
        {
            // Return list item collection based on the lookup field

            SPField spFieldOne = spList.Fields[keyOne];
            SPField spFieldTwo = spList.Fields[keyTwo];
            SPField spFieldThree = spList.Fields[keyThree];
            var query = new SPQuery
            {
                Query = @"<Where>
                          <And>
                             <And>
                                <Eq>
                                   <FieldRef Name=" + spFieldOne.InternalName + @" />
                                   <Value Type=" + spFieldOne.Type.ToString() + @">" + valueOne + @"</Value>
                                </Eq>
                                <Eq>
                                   <FieldRef Name=" + spFieldTwo.InternalName + @" />
                                   <Value Type=" + spFieldTwo.Type.ToString() + @">" + valueTwo + @"</Value>
                                </Eq>
                             </And>
                             <Eq>
                                <FieldRef Name=" + spFieldThree.InternalName + @" />
                                <Value Type=" + spFieldThree.Type.ToString() + @">" + valueThree + @"</Value>
                             </Eq>
                          </And>
                       </Where>"
            };

            return spList.GetItems(query);
        }

        internal SPListItemCollection GetListItemCollection(SPList spList, string keyOne, string valueOne, string keyTwo, string valueTwo, string keyThree, string valueThree, string keyFour, string valueFour)
        {
            // Return list item collection based on the lookup field

            SPField spFieldOne = spList.Fields[keyOne];
            SPField spFieldTwo = spList.Fields[keyTwo];
            SPField spFieldThree = spList.Fields[keyThree];
            SPField spFieldFour = spList.Fields[keyFour];
            var query = new SPQuery
            {
                Query = @"<Where>
                          <And>
                             <And>
                                <And>
                                <Eq>
                                   <FieldRef Name=" + spFieldOne.InternalName + @" />
                                   <Value Type=" + spFieldOne.Type.ToString() + @">" + valueOne + @"</Value>
                                </Eq>
                                <Eq>
                                   <FieldRef Name=" + spFieldTwo.InternalName + @" />
                                   <Value Type=" + spFieldTwo.Type.ToString() + @">" + valueTwo + @"</Value>
                                </Eq>
                             </And>
                             <Eq>
                                <FieldRef Name=" + spFieldThree.InternalName + @" />
                                <Value Type=" + spFieldThree.Type.ToString() + @">" + valueThree + @"</Value>
                             </Eq>
                          </And>
                             <Eq>
                                <FieldRef Name=" + spFieldFour.InternalName + @" />
                                <Value Type=" + spFieldFour.Type.ToString() + @">" + valueFour + @"</Value>
                             </Eq>
                          </And>
                       </Where>"
            };

            return spList.GetItems(query);
        }

        protected void Ddlclientname(object sender, EventArgs e)
        {
            using (var site = new SPSite(SPContext.Current.Web.Url))
            {
                var web = site.OpenWeb();
                web.AllowUnsafeUpdates = true;
                var tasklist = web.Lists.TryGetList("Tasks");
                var test = ddlClientname.SelectedItem.Text;
                var collection = GetListItemCollection(tasklist, "Client Name", ddlClientname.SelectedItem.Text);
                if (collection.Count > 0)
                {
                    foreach (SPListItem item in collection)
                    {
                        //ddlProjectName.Items.Add( item["Project Name"].ToString());

                    }
                    //ddlProjectName.SelectedIndex = 0;
                }
                else
                {
                    //ddlProjectName.SelectedValue = "";
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

        protected void BtnSaveClick(object sender, EventArgs e)
        {

           

            string[] projectname = System.Web.HttpContext.Current.Request.Form["ddlProjectName"].Split(',');
            var testsave = SPContext.Current.Web.Lists.TryGetList("test");
            foreach (var h in projectname)
            {
                
                var newItem = testsave.Items.Add();
                newItem["Title"] = h;
                newItem.Update();
            }

        }
    }
}
