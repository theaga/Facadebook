using System.Collections.Generic;
using Facebook;

namespace FacebookAbstractions.Abstractions
{
    public interface IFacebookClientFacade
    {
        string AccessToken { get; set; }
        bool UseFacebookBeta { get; set; }
        object Batch(params FacebookBatchParameter[] batchParameters);
        void BatchAsync(FacebookBatchParameter[] batchParameters);
        void BatchAsync(FacebookBatchParameter[] batchParameters, object userToken);
        void CancelAsync();
        object Delete(string path);
        object Delete(string path, IDictionary<string, object> parameters);
        void DeleteAsync(string path);
        void DeleteAsync(string path, IDictionary<string, object> parameters);
        void DeleteAsync(string path, IDictionary<string, object> parameters, string userToken);
        object Get(string path);
        object Get(IDictionary<string, object> parameters);
        object Get(string path, IDictionary<string, object> parameters);
        T Get<T>(string path);
        T Get<T>(IDictionary<string, object> parameters);
        T Get<T>(string path, IDictionary<string, object> parameters);
        void GetAsync(string path);
        void GetAsync(IDictionary<string, object> parameters);
        void GetAsync(string path, IDictionary<string, object> parameters);
        void GetAsync(string path, IDictionary<string, object> parameters, string userToken);
        object Post(string path);
        object Post(IDictionary<string, object> parameters);
        object Post(string path, IDictionary<string, object> parameters);
        void PostAsync(object parameters);
        void PostAsync(IDictionary<string, object> parameters);
        void PostAsync(string path, IDictionary<string, object> parameters);
        void PostAsync(string path, IDictionary<string, object> parameters, object userToken);
        void PostAsync(string path, object parameters);
        void PostAsync(string path, object parameters, object userToken);
        object Query(string fql);
        object Query(params string[] fql);
        void QueryAsync(string fql);
        void QueryAsync(string[] fql);
        void QueryAsync(string fql, object userToken);
        void QueryAsync(string[] fql, object userToken);
    }
}