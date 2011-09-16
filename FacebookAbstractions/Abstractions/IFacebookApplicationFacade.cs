using System;
using Facebook;

namespace FacebookAbstractions.Abstractions
{
    /// <summary>
    /// This interface can be implemented by all classes that should be
    /// be able to be used as a facade for the FacebookApplication class.
    /// </summary>
    public interface IFacebookApplicationFacade
    {
        /// <summary>
        /// Get the current Facebook application.
        /// </summary>
        IFacebookApplication Current { get; }

        /// <summary>
        /// Gets InnerCurrent.
        /// </summary>
        IFacebookApplication InnerCurrent { get; }


        /// <summary>
        /// Set the inner application.
        /// </summary>
        /// <param name="getFacebookApplication">The get Facebook application.</param>
        void InnerSetApplication(Func<IFacebookApplication> getFacebookApplication);

        /// <summary>
        /// Set the inner application.
        /// </summary>
        /// <param name="facebookApplication">The Facebook application.</param>
        void InnerSetApplication(IFacebookApplication facebookApplication);
    }
}