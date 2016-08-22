using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hammer
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvbind();
            }

        }
        protected void gvbind()
        {
            AllHammer ah = new AllHammer();
            GridViewHammer.DataSource = ah.gethammers();
            GridViewHammer.DataBind();

        }

        protected void GridViewHammer_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewHammer.EditIndex = -1;
            gvbind();
        }

        protected void GridViewHammer_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewHammer.EditIndex = e.NewEditIndex;
            gvbind();
        }

        protected void GridViewHammer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewHammer.PageIndex = e.NewPageIndex;
            gvbind();
        }

        protected void GridViewHammer_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridViewHammer.Rows[e.RowIndex];
           // Label lbldeleteid = (Label)row.FindControl("lblID");
            AllHammer ah = new AllHammer();
            ah.deletehammer(GridViewHammer.DataKeys[e.RowIndex].Value.ToString());
            gvbind();
        }

        protected void GridViewHammer_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            AllHammer ah = new AllHammer();
            int userid = Convert.ToInt32(GridViewHammer.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridViewHammer.Rows[e.RowIndex];
            TextBox textName = (TextBox)row.Cells[0].Controls[0];
            TextBox texttype = (TextBox)row.Cells[1].Controls[0];
            GridViewHammer.EditIndex = -1;
            ah.updatehammer(textName.Text.ToString(), texttype.Text.ToString(), userid.ToString());
            gvbind();
        }
    }
}