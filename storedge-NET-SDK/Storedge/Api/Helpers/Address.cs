namespace storedge_NET_SDK.Storedge.Api.Helpers
{
    public class Address
    {
        public string id { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal { get; set; }
        public string country { get; set; }
        public string full_address { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public string time_zone_id { get; set; }
        public string time_zone_offset { get; set; }
        public bool? invalid_data { get; set; }
        public string label { get; set; }
    }
}