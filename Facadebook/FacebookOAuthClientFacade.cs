using System;
using System.Collections.Generic;
using System.Threading;
using Facebook;

namespace Facadebook
{
    /// <summary>
    /// This class can be used as a facade for the FacebookOAuthClient
    /// class. Besides all public methods, it also provides non-static
    /// versions of the static FacebookOAuthClient methods.
    /// </summary>
    public class FacebookOAuthClientFacade : FacadeBase<FacebookOAuthClient>
    {
        public FacebookOAuthClientFacade(FacebookOAuthClient baseInstance) : base(baseInstance)
        {
        }


        public string AppId
        {
            get { return BaseInstance.AppId; }
            set { BaseInstance.AppId = value; }
        }

        public string AppSecret
        {
            get { return BaseInstance.AppSecret; }
            set { BaseInstance.AppSecret = value; }
        }


        public object ExchangeCodeForAccessToken(string code)
        {
            return BaseInstance.ExchangeCodeForAccessToken(code);
        }

        public object ExchangeCodeForAccessToken(string code, IDictionary<string, object> parameters)
        {
            return BaseInstance.ExchangeCodeForAccessToken(code, parameters);
        }

        public void ExchangeCodeForAccessTokenAsync(string code)
        {
            BaseInstance.ExchangeCodeForAccessTokenAsync(code);
        }

        public void ExchangeCodeForAccessTokenAsync(string code, IDictionary<string, object> parameters)
        {
            BaseInstance.ExchangeCodeForAccessTokenAsync(code, parameters);
        }

        public void ExchangeCodeForAccessTokenAsync(string code, IDictionary<string, object> parameters, object userToken)
        {
            BaseInstance.ExchangeCodeForAccessTokenAsync(code, parameters, userToken);
        }

        public void ExchangeCodeForAccessTokenTaskAsync(string code)
        {
            BaseInstance.ExchangeCodeForAccessTokenTaskAsync(code);
        }

        public void ExchangeCodeForAccessTokenTaskAsync(string code, IDictionary<string, object> parameters)
        {
            BaseInstance.ExchangeCodeForAccessTokenTaskAsync(code, parameters);
        }

        public void ExchangeCodeForAccessTokenTaskAsync(string code, IDictionary<string, object> parameters, CancellationToken cancellationToken)
        {
            BaseInstance.ExchangeCodeForAccessTokenTaskAsync(code, parameters, cancellationToken);
        }

        public object GetApplicationAccessToken()
        {
            return BaseInstance.GetApplicationAccessToken();
        }

        public object GetApplicationAccessToken(IDictionary<string, object> parameters)
        {
            return BaseInstance.GetApplicationAccessToken(parameters);
        }

        public void GetApplicationAccessTokenAsync()
        {
            BaseInstance.GetApplicationAccessTokenAsync();
        }

        public void GetApplicationAccessTokenAsync(object userToken)
        {
            BaseInstance.GetApplicationAccessTokenAsync(userToken);
        }

        public void GetApplicationAccessTokenAsync(IDictionary<string, object> parameters, object userToken)
        {
            BaseInstance.GetApplicationAccessTokenAsync(parameters, userToken);
        }

        public void GetApplicationAccessTokenTaskAsync()
        {
            BaseInstance.GetApplicationAccessTokenTaskAsync();
        }

        public void GetApplicationAccessTokenTaskAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken)
        {
            BaseInstance.GetApplicationAccessTokenTaskAsync(parameters, cancellationToken);
        }

        public Uri GetLoginUrl()
        {
            return BaseInstance.GetLoginUrl();
        }

        public Uri GetLoginUrl(IDictionary<string, object> parameters)
        {
            return BaseInstance.GetLoginUrl();
        }

        public Uri GetLoginUrl(string appId, Uri redirectUri)
        {
            return FacebookOAuthClient.GetLoginUrl(appId, redirectUri);
        }

        public Uri GetLoginUrl(string appId, Uri redirectUri, string[] extendedPermissions)
        {
            return FacebookOAuthClient.GetLoginUrl(appId, redirectUri, extendedPermissions);
        }

        public Uri GetLoginUrl(string appId, Uri redirectUri, string[] extendedPermissions, IDictionary<string, object> loginParameters)
        {
            return FacebookOAuthClient.GetLoginUrl(appId, redirectUri, extendedPermissions, loginParameters);
        }

        public virtual FacebookOAuthResult ParseResult(Uri uri)
        {
            return BaseInstance.ParseResult(uri);
        }

        public virtual FacebookOAuthResult ParseResult(string uriString)
        {
            return BaseInstance.ParseResult(uriString);
        }

        public virtual bool TryParseResult(Uri uri, out FacebookOAuthResult result)
        {
            return BaseInstance.TryParseResult(uri, out result);
        }

        public virtual bool TryParseResult(string uriString, out FacebookOAuthResult result)
        {
            return BaseInstance.TryParseResult(uriString, out result);
        }
    }
}
