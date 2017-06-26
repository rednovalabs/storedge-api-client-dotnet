namespace storedge_NET_SDK.Storedge.Api.Helpers
{
    public class Pagination {
        public int? current_page { get; set; }
        public int? total_pages { get; set; }
        public int? total_entries { get; set; }
        public int? per_page { get; set; }
        public int? previous_page { get; set; }
        public int? next_page { get; set; }
    }
}