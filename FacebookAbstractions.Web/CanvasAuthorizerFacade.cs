using System;
using System.Collections.Generic;
using Facebook.Web;

namespace FacebookAbstractions.Web
{
    /// <summary>
    /// This class can be used as a facade for the native CanvasAuthorizer
    /// class. Besides all the public methods, it also provides non-static
    /// versions of the static CanvasAuthorizer methods.
    /// </summary>
    public class CanvasAuthorizerFacade : FacebookWebAuthorizerFacade, ICanvasAuthorizerFacade
    {
        private readonly CanvasAuthorizer baseInstance;


        public CanvasAuthorizerFacade(CanvasAuthorizer baseInstance) : base(baseInstance)
        {
            this.baseInstance = baseInstance;
        }


        public Uri GetLoginUrl(IDictionary<string, object> parameters)
        {
            return baseInstance.GetLoginUrl(parameters);
        }

        new public void HandleUnauthorizedRequest()
        {
            baseInstance.HandleUnauthorizedRequest();
        }
    }
}
