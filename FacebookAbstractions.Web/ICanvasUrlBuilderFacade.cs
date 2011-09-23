using System;
using System.Collections.Generic;

namespace FacebookAbstractions.Web
{
    /// <summary>
    /// This interface represents a class that can be used
    /// as a facade for the native CanvasUrlBuilder class.
    /// </summary>
    public interface ICanvasUrlBuilderFacade
    {
        Uri CanvasPage { get; }
        string CanvasPageApplicationPath { get; }
        Uri CanvasUrl { get; }
        Uri CurrentCanvasPage { get; }
        string CurrentCanvasPathAndQuery { get; }
        Uri CurrentCanvasUrl { get; }
        bool IsSecureConnection { get; set; }
        Uri SecureCanvasUrl { get; }
        bool UseFacebookBeta { get; set; }

        Uri BuildCanvasPageUrl(string pathAndQuery);
        Uri BuildCanvasUrl(string pathAndQuery);
        string GetCanvasRedirectHtml(Uri url);
        Uri GetLoginUrl(string returnUrlPath, string cancelUrlPath, string state, IDictionary<string, object> loginParameters);
    }
}
