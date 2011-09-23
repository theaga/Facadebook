using System;
using Facebook;

namespace Facadebook
{
    /// <summary>
    /// This class can be used as a facade for the FacebookApplication
    /// class. Besides all public methods, it also provides non-static
    /// versions of the static FacebookApplication methods.
    /// </summary>
    public class FacebookApplicationFacade : FacadeBase<FacebookApplication>, IFacebookApplicationFacade
    {
        public FacebookApplicationFacade(FacebookApplication baseInstance) : base(baseInstance)
        {
        }


        public IFacebookApplication Current
        {
            get { return FacebookApplication.Current; }
        }

        public IFacebookApplication InnerCurrent
        {
            get { return BaseInstance.InnerCurrent; }
        }


        public void InnerSetApplication(Func<IFacebookApplication> getFacebookApplication)
        {
            BaseInstance.InnerSetApplication(getFacebookApplication);
        }

        public void InnerSetApplication(IFacebookApplication facebookApplication)
        {
            BaseInstance.InnerSetApplication(facebookApplication);
        }

        public void SetApplication(Func<IFacebookApplication> getFacebookApplication)
        {
            FacebookApplication.SetApplication(getFacebookApplication);
        }

        public void SetApplication(IFacebookApplication facebookApplication)
        {
            FacebookApplication.SetApplication(facebookApplication);
        }
    }
}
