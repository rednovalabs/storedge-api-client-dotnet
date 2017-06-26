
namespace storedge_NET_SDK.Storedge.Api.Types
{
    public class Unit
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double? width { get; set; }
        public double? length { get; set; }
        public double? height { get; set; }
        public double? door_height { get; set; }
        public double? door_width { get; set; }
        public string door_type { get; set; }
        public string access_type { get; set; }
        public int? floor { get; set; }
        public string size { get; set; }
        public double? area { get; set; }
        public double? standard_rate { get; set; }
        public double? managed_rate { get; set; }
        public bool? available_for_move_in { get; set; }
        public bool? rentable { get; set; }
        public string status { get; set; }
        public string payment_status { get; set; }
        public string current_ledger_id { get; set; }
        public string current_tenant_id { get; set; }
        public string attribute_description { get; set; }
        public bool? deleted;
        public UnitAmenity[] unit_amenities { get; set; }
        public UnitType unit_type { get; set; }
        public string unit_group_id { get; set; }
    }
}