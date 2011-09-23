using System;
using System.Collections.Generic;

namespace FacebookAbstractions.Web
{
    /// <summary>
    /// This interface represents a class that can be used
    /// as a facade for the native CanvasAuthorizer class.
    /// </summary>
    public interface ICanvasAuthorizerFacade
    {
        Uri GetLoginUrl(IDictionary<string, object> parameters);
        void HandleUnauthorizedRequest();
    }
}
