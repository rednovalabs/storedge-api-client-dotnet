using storedge_NET_SDK.Storedge.Api.Helpers;

namespace storedge_NET_SDK.Storedge.Api.Types
{
    public class InvoiceableItem
    {
        public string id { get; set; }
        public string product_code { get; set; }
        public string kind { get; set; }
        public string description { get; set; }
        public bool? required_at_move_in { get; set; }
        public bool? required_at_transfer { get; set; }
        public double? amount { get; set; }
        public string short_description { get; set; }
        public bool? show_in_sales_center { get; set; }
        public double? tax_total { get; set; }
        public double? total { get; set; }
        public InvoiceableAmounts[] invoiceable_amounts { get; set; }
    }
}