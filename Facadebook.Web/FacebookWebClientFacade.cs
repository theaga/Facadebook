using Facebook.Web;

namespace Facadebook.Web
{
    /// <summary>
    /// This class can be used as a facade for the
    /// native FacebookWebClient class.
    /// </summary>
    public class FacebookWebClientFacade : FacebookClientFacade, IFacebookWebClientFacade
    {
        private readonly FacebookWebClient baseInstance;


        public FacebookWebClientFacade(FacebookWebClient baseInstance) 
            : base(baseInstance)
        {
            this.baseInstance = baseInstance;
        }


        public bool IsSecureConnection
        {
            get { return baseInstance.IsSecureConnection; }
            set { baseInstance.IsSecureConnection = value; }
        }
    }
}
