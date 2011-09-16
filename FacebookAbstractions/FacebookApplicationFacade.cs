using System;
using Facebook;
using FacebookAbstractions.Abstractions;

namespace FacebookAbstractions
{
    /// <summary>
    /// This class can be used as a facade for the FacebookApplication class.
    /// </summary>
    public class FacebookApplicationFacade : FacadeBase<FacebookApplication>, IFacebookApplicationFacade
    {
        /// <summary>
        /// Create an instance of the facade class.
        /// </summary>
        /// <param name="baseInstance">The base instance to facade.</param>
        public FacebookApplicationFacade(FacebookApplication baseInstance) : base(baseInstance)
        {
        }


        /// <summary>
        /// Get the current Facebook application.
        /// </summary>
        public IFacebookApplication Current
        {
            get { return FacebookApplication.Current; }
        }

        /// <summary>
        /// Gets InnerCurrent.
        /// </summary>
        public IFacebookApplication InnerCurrent
        {
            get { return BaseInstance.InnerCurrent; }
        }


        /// <summary>
        /// Set the inner application.
        /// </summary>
        /// <param name="getFacebookApplication">The get Facebook application.</param>
        public void InnerSetApplication(Func<IFacebookApplication> getFacebookApplication)
        {
            BaseInstance.InnerSetApplication(getFacebookApplication);
        }

        /// <summary>
        /// Set the inner application.
        /// </summary>
        /// <param name="facebookApplication">The Facebook application.</param>
        public void InnerSetApplication(IFacebookApplication facebookApplication)
        {
            BaseInstance.InnerSetApplication(facebookApplication);
        }
    }
}
