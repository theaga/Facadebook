using System.Collections.Generic;
using Facebook;

namespace Facadebook
{
    /// <summary>
    /// This class can be used as a facade for the FacebookClient class.
    /// </summary>
    public class FacebookClientFacade : FacadeBase<FacebookClient>, IFacebookClientFacade
    {
        public FacebookClientFacade(FacebookClient baseInstance) : base(baseInstance)
        {
        }


        public string AccessToken
        {
            get { return BaseInstance.AccessToken; }
            set { BaseInstance.AccessToken = value; }
        }

        public bool UseFacebookBeta
        {
            get { return BaseInstance.UseFacebookBeta; }
            set { BaseInstance.UseFacebookBeta = value; }
        }

        
        public object Batch(params FacebookBatchParameter[] batchParameters)
        {
            return BaseInstance.Batch(batchParameters);
        }

        public void BatchAsync(FacebookBatchParameter[] batchParameters)
        {
            BaseInstance.BatchAsync(batchParameters);
        }

        public void BatchAsync(FacebookBatchParameter[] batchParameters, object userToken)
        {
            BaseInstance.BatchAsync(batchParameters, userToken);
        }

        public void CancelAsync()
        {
            BaseInstance.CancelAsync();
        }

        public object Delete(string path)
        {
            return BaseInstance.Delete(path);
        }

        public object Delete(string path, IDictionary<string, object> parameters)
        {
            return BaseInstance.Delete(path, parameters);
        }

        public void DeleteAsync(string path)
        {
            BaseInstance.DeleteAsync(path);
        }

        public void DeleteAsync(string path, IDictionary<string, object> parameters)
        {
            BaseInstance.DeleteAsync(path, parameters);
        }

        public void DeleteAsync(string path, IDictionary<string, object> parameters, string userToken)
        {
            BaseInstance.DeleteAsync(path, parameters, userToken);
        }

        public object Get(string path)
        {
            return BaseInstance.Get(path);
        }

        public object Get(IDictionary<string, object> parameters)
        {
            return BaseInstance.Get(parameters);
        }

        public object Get(string path, IDictionary<string, object> parameters)
        {
            return BaseInstance.Get(path, parameters);
        }

        public T Get<T>(string path)
        {
            return BaseInstance.Get<T>(path);
        }

        public T Get<T>(IDictionary<string, object> parameters)
        {
            return BaseInstance.Get<T>(parameters);
        }

        public T Get<T>(string path, IDictionary<string, object> parameters)
        {
            return BaseInstance.Get<T>(path, parameters);
        }

        public void GetAsync(string path)
        {
            BaseInstance.GetAsync(path);
        }

        public void GetAsync(IDictionary<string, object> parameters)
        {
            BaseInstance.GetAsync(parameters);
        }

        public void GetAsync(string path, IDictionary<string, object> parameters)
        {
            BaseInstance.GetAsync(path, parameters);
        }

        public void GetAsync(string path, IDictionary<string, object> parameters, string userToken)
        {
            BaseInstance.GetAsync(path, parameters, userToken);
        }

        public object Post(string path)
        {
            return BaseInstance.Post(path);
        }

        public object Post(IDictionary<string, object> parameters)
        {
            return BaseInstance.Post(parameters);
        }

        public object Post(string path, IDictionary<string, object> parameters)
        {
            return BaseInstance.Post(path, parameters);
        }

        public void PostAsync(object parameters)
        {
            BaseInstance.PostAsync(parameters);
        }

        public void PostAsync(IDictionary<string, object> parameters)
        {
            BaseInstance.PostAsync(parameters);
        }

        public void PostAsync(string path, IDictionary<string, object> parameters)
        {
            BaseInstance.PostAsync(path, parameters);
        }

        public void PostAsync(string path, IDictionary<string, object> parameters, object userToken)
        {
            BaseInstance.PostAsync(path, parameters, userToken);
        }

        public void PostAsync(string path, object parameters)
        {
            BaseInstance.PostAsync(path, parameters);
        }

        public void PostAsync(string path, object parameters, object userToken)
        {
            BaseInstance.PostAsync(path, parameters, userToken);
        }

        public object Query(string fql)
        {
            return BaseInstance.Query(fql);
        }

        public object Query(params string[] fql)
        {
            return BaseInstance.Query(fql);
        }

        public void QueryAsync(string fql)
        {
            BaseInstance.QueryAsync(fql);
        }

        public void QueryAsync(string[] fql)
        {
            BaseInstance.QueryAsync(fql);
        }

        public void QueryAsync(string fql, object userToken)
        {
            BaseInstance.QueryAsync(fql, userToken);
        }

        public void QueryAsync(string[] fql, object userToken)
        {
            BaseInstance.QueryAsync(fql, userToken);
        }
    }
}
