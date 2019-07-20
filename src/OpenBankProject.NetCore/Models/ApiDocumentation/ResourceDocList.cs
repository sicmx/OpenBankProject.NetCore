﻿using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore.Models.ApiDocumentation
{
    public class ResourceDocList : IEnumerableSource<ResourceDoc>
    {
        [JsonProperty("resource_docs")]
        public List<ResourceDoc> ResourceDocs { get; set; }
        public IEnumerable<ResourceDoc> Items => ResourceDocs;
    }
}
