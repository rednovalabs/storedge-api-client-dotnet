using storedge_NET_SDK.Storedge.Api.Requests;

namespace storedge_NET_SDK.Storedge.Api.Helpers
{
    public class TenantAttributes
    {
        public string title { get; set; }
        public string first_name { get; set; }
        public string middle_initial { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public bool? is_military { get; set; }
        public bool? is_business { get; set; }
        public PhoneNumber[] phone_numbers_attributes { get; set; }
        public MailingAddress mailing_address_attributes { get; set; }

    }
}