namespace storedge_NET_SDK.Storedge.Api.Types
{
    public class DiscountPlanControls
    {
        public string id { get; set; }
        public string kind { get; set; }
        public double? min_value { get; set; }
        public double? max_value { get; set; }
        public bool? deleted { get; set; }
        public string deleted_on { get; set; }
        public string requirements_text { get; set; }
        public int? applicable_discount_plans_count { get; set; }
        public string[] unit_amenity_ids { get; set; }
        public string[] discount_plan_ids { get; set; }
        public UnitType unit_type { get; set; }
    }
}