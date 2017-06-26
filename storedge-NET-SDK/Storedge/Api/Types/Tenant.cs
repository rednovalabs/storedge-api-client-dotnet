using storedge_NET_SDK.Storedge.Api.Helpers;

namespace storedge_NET_SDK.Storedge.Api.Types
{
    public class Tenant
    {
        public string id { get; set; }
        public dynamic account_number { get; set; } //long
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string middle_initial { get; set; }
        public string email { get; set; }
        public bool? tax_exempt { get; set; }
        public bool? is_military { get; set; }
        public bool? is_business { get; set; }
        public string business_name { get; set; }
        public string last_sign_in_at { get; set; }
        public string title { get; set; }
        public bool? delinquent { get; set; }
        public string[] current_ledger_ids { get; set; }
        public TenantPreferences preferences { get; set; }
        public string username { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string reset_token { get; set; }
        public string current_password { get; set; }
        public string new_password { get; set; }
        public string drivers_license_number { get; set; }
        public string drivers_license_state { get; set; }
        public string vehicle_license_plate_number { get; set; }
        public string vehilce_license_state { get; set; }
        public string vehicle_description { get; set; }
        public bool? has_tenant_portal_account { get; set; }
        public string created_at { get; set; }
        public bool? gate_24_hour_access { get; set; }
        public bool? active { get; set; }
        public string tenant_account_kind_name { get; set; }
        public PhoneNumber[] phone_numbers { get; set; }
        public PhoneNumber[] phone_numbers_attributes { get; set; }
        public MailingAddress mailing_address { get; set; }
        public MailingAddress mailing_address_attributes { get; set; }
        public Address[] addresses { get; set; }
        public string facility_id { get; set; }
        public string[] previous_ledger_ids { get; set; }
        public string[] lead_ids { get; set; }
        public string[] closed_lead_ids { get; set; }
        public string[] contact_ids { get; set; }
        public string[] support_case_ids { get; set; }
        public string[] event_ids { get; set; }
        public dynamic password_recovery_question_ids { get; set; } //string[]
    }
}