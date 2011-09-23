using System.Web;
using Facebook;

namespace FacebookAbstractions.Web
{
    /// <summary>
    /// This interface represents a class that can be used as a
    /// facade for the native FacebookSubscriptionContext class.
    /// </summary>
    public interface IFacebookSubscriptionContextFacade
    {
        IFacebookApplication FacebookApplication { get; set; }
        HttpContextBase HttpContext { get; set; }
        string VerificationToken { get; set; }
    }
}
