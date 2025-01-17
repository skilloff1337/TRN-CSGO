﻿using Newtonsoft.Json;

namespace TRN_CSGO.Model.ProfileStats
{
    public class ProfileStatInfo
    {
        [JsonProperty("rank")] public object Rank { get; set; }
        [JsonProperty("percentile")] public object Percentile { get; set; }
        [JsonProperty("displayName")] public string DisplayName { get; set; }
        [JsonProperty("displayCategory")] public string DisplayCategory { get; set; }
        [JsonProperty("category")] public string Category { get; set; }
        [JsonProperty("metadata")] public ProfileMetadata ProfileMetadata { get; set; }
        [JsonProperty("value")] public double Value { get; set; }
        [JsonProperty("displayValue")] public string DisplayValue { get; set; }
        [JsonProperty("displayType")] public string DisplayType { get; set; }
    }
}