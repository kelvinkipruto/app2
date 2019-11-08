using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace app2
{
	public partial class Default : System.Web.UI.Page
	{
		static Guid ApplicationId = new Guid("1ab32645-a759-4e84-8e92-c1f828db0a82");
		static Guid ApplicationSecret = new Guid("7e735eb4-8fca-44a9-83c1-ba1784252941");

		protected void Page_Load(object sender, EventArgs e)
		{
			if(Request.QueryString["TOKEN"] == null && Session["mySession"] != null)
			{
				SetError("token is not provided");
				return;
			}
			if (Session["mySession"] == null)
			{
	
				var baseSession = LinnworksAPI.AuthorizeByApplicationRequest(ApplicationId, ApplicationSecret, new Guid(Request.QueryString["TOKEN"]));
			
			Models.MySession storeSession = new Models.MySession()
			{
				AuthToken = baseSession.Token,
				Server = baseSession.Server,
				Email = baseSession.Email,
				LinnworksId = baseSession.Id,
			};
			Session["mySession"] = storeSession;
			}

			txtEmail.Text = ((Models.MySession)Session["mySession"]).Email;
			txtLinnworksId.Text = ((Models.MySession)Session["mySession"]).LinnworksId.ToString();

		}

		void SetError(string error)
		{
			errorPanel.Visible = true;
			lblError.Text = error;
		}
	}
}