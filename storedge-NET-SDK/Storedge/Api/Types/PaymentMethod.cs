using storedge_NET_SDK.Storedge.Api.Helpers;

namespace storedge_NET_SDK.Storedge.Api.Types
{
    public class PaymentMethod
    {
        public string id { get; set; }
        public string kind { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool? reuseable { get; set; }
        public string card_number { get; set; }
        public string card_type { get; set; }
        public string expiration_date { get; set; }
        public BillingAddress billing_address { get; set; }
        
        public string security_code { get; set; }
        public string magnetic_track { get; set; }
        public string account_number { get; set; }
        public string account_number_confirmation { get; set; }
        public string account_type { get; set; }
        public string bank_name { get; set; }
        public string routing_number { get; set; }
        public string check_number { get; set; }
        public string name_on_check { get; set; }
        public string check_amount { get; set; }
        public string reference_number { get; set; }
        public string money_order_amount { get; set; }
        public string amount_tendered { get; set; }
        public BillingAddress billing_address_attributes { get; set; }

    }
}