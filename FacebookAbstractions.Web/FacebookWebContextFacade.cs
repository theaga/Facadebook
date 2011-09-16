﻿using System.Web;
using Facebook.Web;
using FacebookAbstractions.Web.Abstractions;
using Facebook;

namespace FacebookAbstractions.Web
{
    public class FacebookWebContextFacade : FacadeBase<FacebookWebContext>, IFacebookWebContextFacade
    {
        public FacebookWebContextFacade(FacebookWebContext baseInstance) 
            : base(baseInstance)
        {
        }

        public void DeleteAuthCookie()
        {
            BaseInstance.DeleteAuthCookie();
        }

        public bool HasPermission(string permission)
        {
            return BaseInstance.HasPermission(permission);
        }

        public string[] HasPermission(params string[] permissions)
        {
            return BaseInstance.HasPermissions(permissions);
        }

        public bool IsAuthenticated()
        {
            return BaseInstance.IsAuthenticated();
        }

        public bool IsAuthorized(params string[] permissions)
        {
            return BaseInstance.IsAuthorized(permissions);
        }

        public bool IsAuthorized()
        {
            return BaseInstance.IsAuthorized();
        }

        public string AccessToken {
            get { return BaseInstance.AccessToken; }
        }

        public FacebookWebContext Current { 
            get { return FacebookWebContext.Current; }
        }  

        public HttpContextBase HttpContext
        {
            get { return BaseInstance.HttpContext; }
        }

        public bool IsSecureConnection
        {
            get { return BaseInstance.IsSecureConnection; }
        }

        public FacebookSession Session
        {
            get { return BaseInstance.Session; }
        }

        public IFacebookApplication Settings
        {
            get { return BaseInstance.Settings; }
        }

        public FacebookSignedRequest SignedRequest
        {
            get { return BaseInstance.SignedRequest;  }
        }

        public long UserId
        {
            get { return BaseInstance.UserId; }
        }
    }
}
