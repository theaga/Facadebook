using System;
using Facebook;

namespace FacebookAbstractions
{
    /// <summary>
    /// This interface can be implemented by all classes that should be
    /// be able to be used as a facade for the FacebookApplication class.
    /// </summary>
    public interface IFacebookApplicationFacade
    {
        IFacebookApplication Current { get; }

        IFacebookApplication InnerCurrent { get; }


        void InnerSetApplication(Func<IFacebookApplication> getFacebookApplication);

        void InnerSetApplication(IFacebookApplication facebookApplication);

        void SetApplication(Func<IFacebookApplication> getFacebookApplication);

        void SetApplication(IFacebookApplication facebookApplication);
    }
}