using storedge_NET_SDK.Storedge.Api.Helpers;

namespace storedge_NET_SDK.Storedge.Api.Types
{
    public class Lead
    {
        public string id { get; set; }
        public string facility_id { get; set; }
        public string caller_first_name { get; set; }
        public string caller_last_name { get; set; }
        public string confirmation_number { get; set; }
        public string kind { get; set; }
        public string size { get; set; }
        public int? floor { get; set; }
        public double? quoted_rate { get; set; }
        public string desired_move_in_date { get; set; }
        public string desired_unit_size_and_price { get; set; }
        public bool? urgent { get; set; }
        public ExtraDetails extra_details { get; set; }
        public bool? reservation_fee_required { get; set; }
        public string next_action_at { get; set; }
        public bool? closed { get; set; }
        public string status { get; set; }
        public string started_at { get; set; }
        public string created_at { get; set; }
        public string moved_in_at { get; set; }
        public string reserved_at { get; set; }
        public string cancelled_at { get; set; }
        public string next_lead_action { get; set; }
        public int? next_lead_action_index { get; set; }
        public string source_name { get; set; }
        public string tenant_id { get; set; }
        public string source_id { get; set; }
        public double? reduced_price { get; set; }
        public double? due_at_move_in { get; set; }
        public double? due_monthly { get; set; }
        public string length_of_stay_id { get; set; }
        public int? reservation_window { get; set; }
        public bool? within_reservation_window { get; set; }
        public bool? wait_list { get; set; }
        public bool? wait_list_available { get; set; }
        public bool? moving_labor { get; set; }
        public bool? moving_labor_contacted_already { get; set; }
        public bool? free_truck { get; set; }
        public bool? plant_a_tree { get; set; }
        public bool? bilingual_agent { get; set; }
        public string facility_time_zone { get; set; }
        public bool? has_paid_reservation_fee { get; set; }
        public Tenant tenant { get; set; }
        public Unit unit { get; set; }
        public int? length_of_stay { get; set; }
        public SuccessfulPaymentEvent[] successful_payment_events { get; set; }
        public string caller_phone_number { get; set; }
        public UnitAmenity[] unit_amenities { get; set; }
        public CurrentUser current_user { get; set; }
        public UnitType unit_type { get; set; }
        public string close_reason { get; set; }
        public InvoiceableItem[] invoiceable_fees { get; set; }
        public DiscountPlan[] discount_plans { get; set; }
        public LeadContents[] lead_contents { get; set; }
        public UnitGroup unit_group { get; set; }
        public CreatedBy created_by { get; set; }
        public string channel_id { get; set; }
        public string confirmation_email { get; set; }
    }
}