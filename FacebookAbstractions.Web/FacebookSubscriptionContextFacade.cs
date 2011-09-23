using System.Web;
using Facebook;
using Facebook.Web;

namespace FacebookAbstractions.Web
{
    /// <summary>
    /// This class can be used as a facade for
    /// the native FacebookSubscription class.
    /// </summary>
    public class FacebookSubscriptionContextFacade : FacadeBase<FacebookSubscriptionContext>, IFacebookSubscriptionContextFacade
    {
        public FacebookSubscriptionContextFacade(FacebookSubscriptionContext baseInstance)
            : base(baseInstance)
        {
        }


        public IFacebookApplication FacebookApplication
        {
            get { return BaseInstance.FacebookApplication; }
            set { BaseInstance.FacebookApplication = value; }
        }

        public HttpContextBase HttpContext
        {
            get { return BaseInstance.HttpContext; }
            set { BaseInstance.HttpContext = value; }
        }

        public string VerificationToken
        {
            get { return BaseInstance.VerificationToken; }
            set { BaseInstance.VerificationToken = value; }
        }
    }
}
