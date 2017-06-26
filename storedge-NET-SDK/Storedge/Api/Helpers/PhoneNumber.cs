namespace storedge_NET_SDK.Storedge.Api.Helpers
{
    public class PhoneNumber
    {
        public string id { get; set; }
        public bool? primary { get; set; }
        public string source { get; set; }
        public string number { get; set; }
        public string formatted_number { get; set; }
        public string extension { get; set; }
        public string label { get; set; }
        public string unformatted_number { get; set; }
    }
}