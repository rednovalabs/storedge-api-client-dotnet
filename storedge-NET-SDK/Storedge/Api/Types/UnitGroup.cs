namespace storedge_NET_SDK.Storedge.Api.Types
{
    public class UnitGroup
    {
        public string id { get; set; }
        public string group_id { get; set; }
        public string name { get; set; }
        public int? available_units_count { get; set; }
        public int? total_units_count { get; set; }
        public string size { get; set; }
        public double? price { get; set; }
        public double? standard_rate { get; set; }
        public int? floor { get; set; }
        public double? reduced_price { get; set; }
        public double? occupancy_percent { get; set; }
        public double? area { get; set; }
        public double? length { get; set; }
        public double? width { get; set; }
        public double? height { get; set; }
        public double? due_at_move_in { get; set; }
        public double? due_monthly { get; set; }
        public string attribute_description { get; set; }
        public string description { get; set; }
        public double? average_rent { get; set; }
        public UnitAmenity[] unit_amenities { get; set; }
        public UnitType unit_type { get; set; }
        public double[] invoiceable_fees { get; set; }
        public DiscountPlan[] discount_plans { get; set; }
    }
}