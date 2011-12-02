using System;
using System.Collections.Generic;
using Facebook.Web;

namespace Facadebook.Web
{
    /// <summary>
    /// This class can be used as a facade for the native CanvasUrlBuilder
    /// class. Besides all the public methods, it also provides non-static
    /// versions of the static CanvasUrlBuilder methods.
    /// </summary>
    public class CanvasUrlBuilderFacade : FacadeBase<CanvasUrlBuilder>, ICanvasUrlBuilderFacade
    {
        public CanvasUrlBuilderFacade(CanvasUrlBuilder baseInstance) : base(baseInstance)
        {
        }


        public Uri CanvasPage
        {
            get { return BaseInstance.CanvasPage; }
        }

        public string CanvasPageApplicationPath
        {
            get { return BaseInstance.CanvasPageApplicationPath; }
        }

        public Uri CanvasUrl
        {
            get { return BaseInstance.CanvasUrl; }
        }

        public Uri CurrentCanvasPage
        {
            get { return BaseInstance.CurrentCanvasPage; }
        }

        public string CurrentCanvasPathAndQuery
        {
            get { return BaseInstance.CurrentCanvasPathAndQuery; }
        }

        public Uri CurrentCanvasUrl
        {
            get { return BaseInstance.CurrentCanvasUrl; }
        }

        public bool IsSecureConnection
        {
            get { return BaseInstance.IsSecureConnection; }
            set { BaseInstance.IsSecureConnection = value; }
        }

        public Uri SecureCanvasUrl
        {
            get { return BaseInstance.SecureCanvasUrl; }
        }

        public bool UseFacebookBeta
        {
            get { return BaseInstance.UseFacebookBeta; }
            set { BaseInstance.UseFacebookBeta = value; }
        }


        public Uri BuildCanvasPageUrl(string pathAndQuery)
        {
            return BaseInstance.BuildCanvasPageUrl(pathAndQuery);
        }

        public Uri BuildCanvasUrl(string pathAndQuery)
        {
            return BaseInstance.BuildCanvasUrl(pathAndQuery);
        }

        public string GetCanvasRedirectHtml(Uri url)
        {
            return CanvasUrlBuilder.GetCanvasRedirectHtml(url);
        }

        public Uri GetLoginUrl(string returnUrlPath, string cancelUrlPath, string state, IDictionary<string, object> loginParameters)
        {
            return BaseInstance.GetLoginUrl(returnUrlPath, cancelUrlPath, state, loginParameters);
        }
    }
}
