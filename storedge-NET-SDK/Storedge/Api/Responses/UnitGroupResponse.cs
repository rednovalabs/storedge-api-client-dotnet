﻿using System.Collections.Generic;
using storedge_NET_SDK.Storedge.Api.Helpers;
using storedge_NET_SDK.Storedge.Api.Types;

namespace storedge_NET_SDK.Storedge.Api.Responses
{
    public class UnitGroupResponse
    {
        public List<UnitGroup> unit_groups { get; set; }
        public Meta meta { get; set; }
    }
}