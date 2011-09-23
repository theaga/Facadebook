using Facebook.Web;
using FacebookAbstractions.Web.Abstractions;

namespace FacebookAbstractions.Web
{
    public class FacebookWebClientFacade : FacadeBase<FacebookWebClient>, IFacebookWebClientFacade
    {
        public FacebookWebClientFacade(FacebookWebClient baseInstance) 
            : base(baseInstance)
        {
        }

        public bool IsSecureConnection
        {
            get { return BaseInstance.IsSecureConnection;  }
            set { value = BaseInstance.IsSecureConnection; }
        }
    }
}
