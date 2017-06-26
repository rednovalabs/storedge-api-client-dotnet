using System.Collections.Generic;

namespace storedge_NET_SDK.Storedge.Api.Requests
{
    public class Parameters
    {
        protected Dictionary<string, List<string>> param;

        public Parameters()
        {
            param = new Dictionary<string, List<string>>();
        }

        public void Clear()
        {
            param.Clear();
        }

        public void SetParameter(string key, List<string> values)
        {
            param.Add(key, values);
        }

        public Dictionary<string, List<string>> GetParameter()
        {
            return param;
        }

        public List<string> Get(string key)
        {
            return param[key];
        }

        public string GetSpecific(string key, int index)
        {
            return param[key][index];
        }

        public bool HasKey(string key)
        {
            return param.ContainsKey(key);
        }
    }
}