using System;
using Facebook;
using Facebook.Web;

namespace Facadebook.Web
{
    /// <summary>
    /// This class can be used as a facade for the
    /// native FacebookWebAuthorizer class.
    /// </summary>
    public class FacebookWebAuthorizerFacade : FacadeBase<FacebookWebAuthorizer>, IFacebookWebAuthorizerFacade
    {
        public FacebookWebAuthorizerFacade(FacebookWebAuthorizer baseInstance) 
            : base(baseInstance)
        {
        }


        public string CancelUrlPath
        {
            get { return BaseInstance.CancelUrlPath; }
            set { BaseInstance.CancelUrlPath = value; }
        }

        public FacebookWebContext FacebookWebRequest
        {
            get { return BaseInstance.FacebookWebRequest; }
        }

        public string LoginDisplayMode
        {
            get { return BaseInstance.LoginDisplayMode; }
            set { BaseInstance.LoginDisplayMode = value; }
        }

        public string[] Permissions
        {
            get { return BaseInstance.Permissions; }
            set { BaseInstance.Permissions = value; }
        }

        public string ReturnUrlPath
        {
            get { return BaseInstance.ReturnUrlPath; }
            set { BaseInstance.ReturnUrlPath = value; }
        }

        [Obsolete("Use FacebookWebRequest.Session instead.")]
        public FacebookSession Session
        {
            get { return BaseInstance.Session; }
        }

        public string State
        {
            get { return BaseInstance.State; }
            set { BaseInstance.State = value; }
        }


        public bool Authorize()
        {
            return BaseInstance.Authorize();
        }

        public void HandleUnauthorizedRequest()
        {
            BaseInstance.HandleUnauthorizedRequest();
        }
    }
}
