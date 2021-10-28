using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace crypto_checker_api.Models.MessariApiModels.MessariAssetTimeSeries
{
    public class Status
    {
        [JsonPropertyName("elapsed")]
        public int Elapsed { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }

    public class Parameters
    {
        [JsonPropertyName("asset_key")]
        public string AssetKey { get; set; }

        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        [JsonPropertyName("start")]
        public DateTime Start { get; set; }

        [JsonPropertyName("end")]
        public DateTime End { get; set; }

        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        [JsonPropertyName("order")]
        public string Order { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("timestamp_format")]
        public string TimestampFormat { get; set; }

        [JsonPropertyName("columns")]
        public List<string> Columns { get; set; }
    }

    public class ValuesSchema
    {
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("open")]
        public string Open { get; set; }

        [JsonPropertyName("high")]
        public string High { get; set; }

        [JsonPropertyName("low")]
        public string Low { get; set; }

        [JsonPropertyName("close")]
        public string Close { get; set; }

        [JsonPropertyName("volume")]
        public string Volume { get; set; }
    }

    public class SourceAttribution
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Schema
    {
        [JsonPropertyName("metric_id")]
        public string MetricId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("values_schema")]
        public ValuesSchema ValuesSchema { get; set; }

        [JsonPropertyName("minimum_interval")]
        public string MinimumInterval { get; set; }

        [JsonPropertyName("source_attribution")]
        public List<SourceAttribution> SourceAttribution { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("contract_addresses")]
        public List<object> ContractAddresses { get; set; }

        [JsonPropertyName("_internal_temp_agora_id")]
        public string InternalTempAgoraId { get; set; }

        [JsonPropertyName("parameters")]
        public Parameters Parameters { get; set; }

        [JsonPropertyName("schema")]
        public Schema Schema { get; set; }

        [JsonPropertyName("values")]
        public List<List<double>> Values { get; set; }
    }

    public class MessariAssetTimeSeries
    {
        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

}
