using System.Web;
using Facebook;
using Facebook.Web;

namespace Facadebook.Web
{
    /// <summary>
    /// This interface represents a class that can be used
    /// as a facade for the native FacebookWebContext class.
    /// </summary>
    public interface IFacebookWebContextFacade
    {
        string AccessToken { get; }
        FacebookWebContext Current { get; }
        HttpContextBase HttpContext { get; }
        bool IsSecureConnection { get; }
        FacebookSession Session { get; }
        IFacebookApplication Settings { get; }
        FacebookSignedRequest SignedRequest { get; }

        long UserId { get; }
        void DeleteAuthCookie();
        bool HasPermission(string permission);
        string[] HasPermission(params string[] permissions);
        bool IsAuthenticated();
        bool IsAuthorized();
        bool IsAuthorized(params string[] permissions);
    }
}