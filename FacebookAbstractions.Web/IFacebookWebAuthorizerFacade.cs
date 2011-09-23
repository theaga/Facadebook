using Facebook;
using Facebook.Web;

namespace FacebookAbstractions.Web
{
    /// <summary>
    /// This interface represents a class that can be used
    /// as a facade for the native FacebookWebAuthorizer class.
    /// </summary>
    public interface IFacebookWebAuthorizerFacade
    {
        string CancelUrlPath { get; set; }
        FacebookWebContext FacebookWebRequest { get; }
        string LoginDisplayMode { get; set; }
        string[] Permissions { get; set; }
        string ReturnUrlPath { get; set; }
        FacebookSession Session { get; }
        string State { get; set; }

        bool Authorize();
        void HandleUnauthorizedRequest();
    }
}