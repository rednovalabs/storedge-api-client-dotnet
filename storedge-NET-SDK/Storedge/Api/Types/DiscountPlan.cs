using storedge_NET_SDK.Storedge.Api.Helpers;

namespace storedge_NET_SDK.Storedge.Api.Types
{
    public class DiscountPlan
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string availability_text { get; set; }
        public string kind { get; set; }
        public bool? min_occupancy_required { get; set; }
        public int? min_occupancy_months;
        public bool? prepay_required;
        public int? prepay_months { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public bool? auto_apply { get; set; }
        public string promotion_type { get; set; }
        public bool? deleted { get; set; }
        public bool? turned_on { get; set; }
        public bool? available_for_all_facilities { get; set; }
        public string round_to_nearest { get; set; }
        public bool? hide_from_website { get; set; }
        public bool? move_in_only { get; set; }
        public string tenant_account_kind_id { get; set; }
        public bool? existing_tenant_only { get; set; }
        public string priority { get; set; }
        public DiscountPlanDiscounts[] discount_plan_discounts { get; set; }
        public DiscountPlanControls[] discount_plan_controls { get; set; }
        public string always_discount_plan_discount_id { get; set; }
        public string[] facility_ids { get; set; }
    }
}