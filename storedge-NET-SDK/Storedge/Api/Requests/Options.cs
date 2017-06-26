using System.Collections.Generic;

namespace storedge_NET_SDK.Storedge.Api.Requests
{
    public class Options
    {
        protected Dictionary<string, string> options;

        public Options()
        {
            options = new Dictionary<string, string>();
        }

        public void SetOption(string key, string value)
        {
            options.Add(key, value);
        }

        public Dictionary<string, string> GetOptions()
        {
            return options;
        }

        public void Clear()
        {
            options.Clear();
        }

        public bool IsEmpty()
        {
            if (options == null) return true;
            return options.Count == 0;
        }

        public void SuppressResponseCodes()
        {
            SetOption("suppress_response_codes", "true");
        }

        // Collections
        public void SetPerPage(int perPage)
        {
            SetOption("per_page", perPage.ToString());
        }

        // Collections
        public void SetPageNum(int pageNum)
        {
            SetOption("page", pageNum.ToString());
        }

        // Collections
        public void SetSort(char order, string criteria)
        {
            SetOption(order + "sort", criteria);
        }

        public void SetSparseFields(string field, string criteria)
        {
            SetOption(field, criteria);
        }

        // Collections
        public void SetCreatedAfter(string dateTime)
        {
            SetOption("created_after", dateTime);
        }

        // Collections
        public void SetCreatedBefore(string dateTime)
        {
            SetOption("created_before", dateTime);
        }

        // Collections
        public void SetUpdatedSince(string dateTime)
        {
            SetOption("updated_since", dateTime);
        }

        // Collections
        public void SetIdFiltering(string[] ids)
        {
            var idList = string.Join(",", ids);
            SetOption("only_ids", idList);
        }

        public void SetIncludeObjects(string[] associations)
        {
            var associationList = string.Join(",", associations);
            SetOption("include_as_object", associationList);
        }

        public void SetIncludeIds(string[] associations)
        {
            var associationList = string.Join(",", associations);
            SetOption("include_as_ids", associationList);
        }
    }
}