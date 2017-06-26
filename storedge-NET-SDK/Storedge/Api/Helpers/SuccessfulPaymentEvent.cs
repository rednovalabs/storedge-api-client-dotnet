using storedge_NET_SDK.Storedge.Api.Types;

namespace storedge_NET_SDK.Storedge.Api.Helpers
{
    public class SuccessfulPaymentEvent
    {
        public string id { get; set; }
        public double? amount { get; set; }
        public bool? success { get; set; }
        public string date { get; set; }
        public PaymentMethod payment_method { get; set; }
    }
}