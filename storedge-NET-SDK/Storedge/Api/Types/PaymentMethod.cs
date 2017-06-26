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
    }
}