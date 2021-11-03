// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace crypto_checker_api.Models.MessariApiModels.MessariAllAssetsMarketData
{

    public class Status
    {
        [JsonPropertyName("elapsed")]
        public int Elapsed { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }

    public class OhlcvLast1Hour
    {
        [JsonPropertyName("open")]
        public double Open { get; set; }

        [JsonPropertyName("high")]
        public double High { get; set; }

        [JsonPropertyName("low")]
        public double Low { get; set; }

        [JsonPropertyName("close")]
        public double Close { get; set; }

        [JsonPropertyName("volume")]
        public double Volume { get; set; }
    }

    public class OhlcvLast24Hour
    {
        [JsonPropertyName("open")]
        public double Open { get; set; }

        [JsonPropertyName("high")]
        public double High { get; set; }

        [JsonPropertyName("low")]
        public double Low { get; set; }

        [JsonPropertyName("close")]
        public double Close { get; set; }

        [JsonPropertyName("volume")]
        public double Volume { get; set; }
    }

    public class MarketData
    {
        [JsonPropertyName("price_usd")]
        public double PriceUsd { get; set; }

        [JsonPropertyName("price_btc")]
        public double PriceBtc { get; set; }

        [JsonPropertyName("price_eth")]
        public double PriceEth { get; set; }

        [JsonPropertyName("volume_last_24_hours")]
        public double VolumeLast24Hours { get; set; }

        [JsonPropertyName("real_volume_last_24_hours")]
        public double RealVolumeLast24Hours { get; set; }

        [JsonPropertyName("volume_last_24_hours_overstatement_multiple")]
        public double VolumeLast24HoursOverstatementMultiple { get; set; }

        [JsonPropertyName("percent_change_usd_last_1_hour")]
        public double PercentChangeUsdLast1Hour { get; set; }

        [JsonPropertyName("percent_change_btc_last_1_hour")]
        public double PercentChangeBtcLast1Hour { get; set; }

        [JsonPropertyName("percent_change_eth_last_1_hour")]
        public double PercentChangeEthLast1Hour { get; set; }

        [JsonPropertyName("percent_change_usd_last_24_hours")]
        public double PercentChangeUsdLast24Hours { get; set; }

        [JsonPropertyName("percent_change_btc_last_24_hours")]
        public double PercentChangeBtcLast24Hours { get; set; }

        [JsonPropertyName("percent_change_eth_last_24_hours")]
        public double PercentChangeEthLast24Hours { get; set; }

        [JsonPropertyName("ohlcv_last_1_hour")]
        public OhlcvLast1Hour OhlcvLast1Hour { get; set; }

        [JsonPropertyName("ohlcv_last_24_hour")]
        public OhlcvLast24Hour OhlcvLast24Hour { get; set; }

        [JsonPropertyName("last_trade_at")]
        public DateTime LastTradeAt { get; set; }
    }

    public class Metrics
    {
        [JsonPropertyName("market_data")]
        public MarketData MarketData { get; set; }
    }

    public class Datum
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("metrics")]
        public Metrics Metrics { get; set; }
    }

    public class MessariAllAssetsMarketData
    {
        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; set; }
    }


}
