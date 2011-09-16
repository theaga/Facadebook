using System;
using Facebook;
using FacebookAbstractions.Abstractions;

namespace FacebookAbstractions
{
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
