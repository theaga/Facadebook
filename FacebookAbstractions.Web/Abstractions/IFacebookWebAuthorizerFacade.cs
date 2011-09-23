using Facebook;
using Facebook.Web;

namespace FacebookAbstractions.Web.Abstractions
{
    public interface IFacebookWebAuthorizerFacade
    {
        bool Authorize();
        void HandleUnauthorizedRequest();
        string CancelUrlPath { get; set; }
        FacebookWebContext FacebookWebRequest { get; }
        string LoginDisplayMode { get; set; }
        string[] Permissions { get; set; }
        string ReturnUrlPath { get; set; }
        FacebookSession Session { get; }
        string State { get; set; }
    }
}