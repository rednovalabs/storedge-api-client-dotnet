namespace storedge_NET_SDK.Storedge.Api.Helpers
{
    public class LeadContents
    {
        public string id { get; set; }
        public string name { get; set; }
        public string company_id { get; set; }
        public bool? deleted { get; set; }
        public string deleted_on { get; set; }
        public string deleted_by_id { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}