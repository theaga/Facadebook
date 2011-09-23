using System.Web;
using Facebook;

namespace FacebookAbstractions.Web.Abstractions
{
    public interface IFacebookSubscriptionContextFacade
    {
        IFacebookApplication FacebookApplication { get; set; }
        HttpContextBase HttpContext { get; set; }
        string VerificationToken { get; set; }
    }
}
