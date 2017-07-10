using System.Collections.Generic;
using storedge_NET_SDK.Storedge.Api.Helpers;
using storedge_NET_SDK.Storedge.Api.Types;

namespace storedge_NET_SDK.Storedge.Api.Responses
{
    public class LeadResponse
    {
        public List<Lead> leads { get; set; }
        public Meta meta { get; set; }
    }
}