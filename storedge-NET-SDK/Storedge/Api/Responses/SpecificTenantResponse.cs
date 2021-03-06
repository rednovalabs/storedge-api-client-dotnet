﻿using storedge_NET_SDK.Storedge.Api.Helpers;
using storedge_NET_SDK.Storedge.Api.Types;

namespace storedge_NET_SDK.Storedge.Api.Responses
{    
    public class SpecificTenantResponse
    {
        public Tenant tenant { get; set; }
        public Meta meta { get; set; }
    }
}