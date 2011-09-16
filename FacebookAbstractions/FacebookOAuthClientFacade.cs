using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;

namespace FacebookAbstractions
{
    public class FacebookOAuthClientFacade : FacadeBase<FacebookOAuthClient>
    {
        public FacebookOAuthClientFacade(FacebookOAuthClient baseInstance) : base(baseInstance)
        {
        }


    }
}
