using System.Web;
using Facebook;
using Facebook.Web;

namespace FacebookAbstractions.Web.Abstractions
{
    public interface IFacebookWebContextFacade
    {
        void DeleteAuthCookie();
        bool HasPermission(string permission);
        string[] HasPermission(params string[] permissions);
        bool IsAuthenticated();
        bool IsAuthorized(params string[] permissions);
        bool IsAuthorized();
        string AccessToken { get; }
        FacebookWebContext Current { get; }
        HttpContextBase HttpContext { get; }
        bool IsSecureConnection { get; }
        FacebookSession Session { get; }
        IFacebookApplication Settings { get; }
        FacebookSignedRequest SignedRequest { get; }
        long UserId { get; }
    }
}