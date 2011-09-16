using System;
using Facebook;

namespace FacebookAbstractions
{
    class FacebookClientFacade : FacadeBase<FacebookClient>
    {
        /// <summary>
        /// Create an instance of the facade class.
        /// </summary>
        /// <param name="baseInstance">The base instance to facade.</param>
        public FacebookClientFacade(FacebookClient baseInstance) : base(baseInstance)
        {
        }


        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        public string AccessToken
        {
            get { return BaseInstance.AccessToken; }
        }

        /// <summary>
        /// Executes a batch request.
        /// </summary>
        /// <param name="batchParameters">The batch parameters.</param>
        /// <returns>Batch request result.</returns>
        public object Batch(params FacebookBatchParameter[] batchParameters)
        {
            return BaseInstance.Batch(batchParameters);
        }

        /// <summary>
        /// Executes a batch request asynchronously.
        /// </summary>
        /// <param name="batchParameters">The batch parameters.</param>
        public void BatchAsync(FacebookBatchParameter[] batchParameters)
        {
            BaseInstance.BatchAsync(batchParameters);
        }

        /// <summary>
        /// Executes a batch request asynchronously.
        /// </summary>
        /// <param name="batchParameters">The batch parameters.</param>
        /// <param name="userToken">The user token.</param>
        public void BatchAsync(FacebookBatchParameter[] batchParameters, object userToken)
        {
            BaseInstance.BatchAsync(batchParameters, userToken);
        }

        /// <summary>
        /// Cancels the asynchronous request.
        /// </summary>
        public void CancelAsync()
        {
            BaseInstance.CancelAsync();
        }

    }
}
