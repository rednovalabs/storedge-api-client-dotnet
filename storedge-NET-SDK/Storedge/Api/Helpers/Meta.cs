namespace storedge_NET_SDK.Storedge.Api.Helpers
{
    public class Meta
    {
        public Pagination pagination { get; set; }
        public int? status_code { get; set; }
        public string status_cat { get; set; }
        public string status_message { get; set; }
        public string request_method { get; set; }
        public string message { get; set; }
        public int? error_code { get; set; }
        public string request_id { get; set; }
    }
}