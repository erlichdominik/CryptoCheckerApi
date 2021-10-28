using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace crypto_checker_api.Models.MessariApiModels.MessariAllAssets
{

    public class Status
    {
        [JsonPropertyName("elapsed")]
        public int Elapsed { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }

    public class ContractAddress
    {
        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        [JsonPropertyName("contract_address")]
        public string ContractAddressData { get; set; }
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
        public double? PercentChangeUsdLast1Hour { get; set; }

        [JsonPropertyName("percent_change_btc_last_1_hour")]
        public double? PercentChangeBtcLast1Hour { get; set; }

        [JsonPropertyName("percent_change_eth_last_1_hour")]
        public double? PercentChangeEthLast1Hour { get; set; }

        [JsonPropertyName("percent_change_usd_last_24_hours")]
        public double? PercentChangeUsdLast24Hours { get; set; }

        [JsonPropertyName("percent_change_btc_last_24_hours")]
        public double? PercentChangeBtcLast24Hours { get; set; }

        [JsonPropertyName("percent_change_eth_last_24_hours")]
        public double? PercentChangeEthLast24Hours { get; set; }

        [JsonPropertyName("ohlcv_last_1_hour")]
        public OhlcvLast1Hour OhlcvLast1Hour { get; set; }

        [JsonPropertyName("ohlcv_last_24_hour")]
        public OhlcvLast24Hour OhlcvLast24Hour { get; set; }

        [JsonPropertyName("last_trade_at")]
        public DateTime LastTradeAt { get; set; }
    }

    public class Marketcap
    {
        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("marketcap_dominance_percent")]
        public double MarketcapDominancePercent { get; set; }

        [JsonPropertyName("current_marketcap_usd")]
        public double CurrentMarketcapUsd { get; set; }

        [JsonPropertyName("y_2050_marketcap_usd")]
        public double? Y2050MarketcapUsd { get; set; }

        [JsonPropertyName("y_plus10_marketcap_usd")]
        public double? YPlus10MarketcapUsd { get; set; }

        [JsonPropertyName("liquid_marketcap_usd")]
        public double? LiquidMarketcapUsd { get; set; }

        [JsonPropertyName("volume_turnover_last_24_hours_percent")]
        public double? VolumeTurnoverLast24HoursPercent { get; set; }

        [JsonPropertyName("realized_marketcap_usd")]
        public double? RealizedMarketcapUsd { get; set; }

        [JsonPropertyName("outstanding_marketcap_usd")]
        public double? OutstandingMarketcapUsd { get; set; }
    }

    public class Supply
    {
        [JsonPropertyName("y_2050")]
        public double? Y2050 { get; set; }

        [JsonPropertyName("y_plus10")]
        public double? YPlus10 { get; set; }

        [JsonPropertyName("liquid")]
        public double? Liquid { get; set; }

        [JsonPropertyName("circulating")]
        public double Circulating { get; set; }

        [JsonPropertyName("y_2050_issued_percent")]
        public double? Y2050IssuedPercent { get; set; }

        [JsonPropertyName("annual_inflation_percent")]
        public double? AnnualInflationPercent { get; set; }

        [JsonPropertyName("stock_to_flow")]
        public double? StockToFlow { get; set; }

        [JsonPropertyName("y_plus10_issued_percent")]
        public double? YPlus10IssuedPercent { get; set; }

        [JsonPropertyName("supply_revived_90d")]
        public double? SupplyRevived90d { get; set; }

        [JsonPropertyName("supply_curve_details")]
        public string SupplyCurveDetails { get; set; }

        [JsonPropertyName("general_emission_type")]
        public string GeneralEmissionType { get; set; }

        [JsonPropertyName("precise_emission_type")]
        public string PreciseEmissionType { get; set; }

        [JsonPropertyName("is_capped_supply")]
        public bool? IsCappedSupply { get; set; }

        [JsonPropertyName("max_supply")]
        public double? MaxSupply { get; set; }
    }

    public class BlockchainStats24Hours
    {
        [JsonPropertyName("count_of_active_addresses")]
        public int? CountOfActiveAddresses { get; set; }

        [JsonPropertyName("transaction_volume")]
        public double? TransactionVolume { get; set; }

        [JsonPropertyName("adjusted_transaction_volume")]
        public double? AdjustedTransactionVolume { get; set; }

        [JsonPropertyName("adjusted_nvt")]
        public double? AdjustedNvt { get; set; }

        [JsonPropertyName("median_tx_value")]
        public double? MedianTxValue { get; set; }

        [JsonPropertyName("median_tx_fee")]
        public double? MedianTxFee { get; set; }

        [JsonPropertyName("count_of_tx")]
        public int? CountOfTx { get; set; }

        [JsonPropertyName("count_of_payments")]
        public int? CountOfPayments { get; set; }

        [JsonPropertyName("new_issuance")]
        public double? NewIssuance { get; set; }

        [JsonPropertyName("average_difficulty")]
        public double? AverageDifficulty { get; set; }

        [JsonPropertyName("kilobytes_added")]
        public object KilobytesAdded { get; set; }

        [JsonPropertyName("count_of_blocks_added")]
        public int? CountOfBlocksAdded { get; set; }
    }

    public class MarketDataLiquidity
    {
        [JsonPropertyName("clearing_prices_to_sell")]
        public object ClearingPricesToSell { get; set; }

        [JsonPropertyName("marketcap")]
        public object Marketcap { get; set; }

        [JsonPropertyName("asset_bid_depth")]
        public object AssetBidDepth { get; set; }

        [JsonPropertyName("usd_bid_depth")]
        public object UsdBidDepth { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    public class AllTimeHigh
    {
        [JsonPropertyName("price")]
        public double? Price { get; set; }

        [JsonPropertyName("at")]
        public DateTime? At { get; set; }

        [JsonPropertyName("days_since")]
        public int? DaysSince { get; set; }

        [JsonPropertyName("percent_down")]
        public double? PercentDown { get; set; }

        [JsonPropertyName("breakeven_multiple")]
        public double? BreakevenMultiple { get; set; }
    }

    public class CycleLow
    {
        [JsonPropertyName("price")]
        public double? Price { get; set; }

        [JsonPropertyName("at")]
        public DateTime? At { get; set; }

        [JsonPropertyName("percent_up")]
        public double? PercentUp { get; set; }

        [JsonPropertyName("days_since")]
        public int? DaysSince { get; set; }
    }

    public class TokenSaleStats
    {
        [JsonPropertyName("sale_proceeds_usd")]
        public object SaleProceedsUsd { get; set; }

        [JsonPropertyName("sale_start_date")]
        public object SaleStartDate { get; set; }

        [JsonPropertyName("sale_end_date")]
        public object SaleEndDate { get; set; }

        [JsonPropertyName("roi_since_sale_usd_percent")]
        public object RoiSinceSaleUsdPercent { get; set; }

        [JsonPropertyName("roi_since_sale_btc_percent")]
        public object RoiSinceSaleBtcPercent { get; set; }

        [JsonPropertyName("roi_since_sale_eth_percent")]
        public object RoiSinceSaleEthPercent { get; set; }
    }

    public class StakingOption
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("reward")]
        public double Reward { get; set; }

        [JsonPropertyName("adjusted_reward")]
        public double AdjustedReward { get; set; }
    }

    public class StakingStats
    {
        [JsonPropertyName("staking_type")]
        public string StakingType { get; set; }

        [JsonPropertyName("staking_yield_percent")]
        public double? StakingYieldPercent { get; set; }

        [JsonPropertyName("real_staking_yield_percent")]
        public double? RealStakingYieldPercent { get; set; }

        [JsonPropertyName("staking_minimum")]
        public object StakingMinimum { get; set; }

        [JsonPropertyName("tokens_staked")]
        public double? TokensStaked { get; set; }

        [JsonPropertyName("tokens_staked_percent")]
        public double? TokensStakedPercent { get; set; }

        [JsonPropertyName("staking_engaged_balance")]
        public double? StakingEngagedBalance { get; set; }

        [JsonPropertyName("staked_total_percent")]
        public double? StakedTotalPercent { get; set; }

        [JsonPropertyName("staking_options")]
        public List<StakingOption> StakingOptions { get; set; }
    }

    public class MiningStats
    {
        [JsonPropertyName("mining_algo")]
        public string MiningAlgo { get; set; }

        [JsonPropertyName("network_hash_rate")]
        public string NetworkHashRate { get; set; }

        [JsonPropertyName("available_on_nicehash_percent")]
        public double? AvailableOnNicehashPercent { get; set; }

        [JsonPropertyName("1_hour_attack_cost")]
        public object _1HourAttackCost { get; set; }

        [JsonPropertyName("24_hours_attack_cost")]
        public object _24HoursAttackCost { get; set; }

        [JsonPropertyName("attack_appeal")]
        public object AttackAppeal { get; set; }

        [JsonPropertyName("hash_rate")]
        public double? HashRate { get; set; }

        [JsonPropertyName("hash_rate_30d_average")]
        public double? HashRate30dAverage { get; set; }

        [JsonPropertyName("mining_revenue_per_hash_usd")]
        public double? MiningRevenuePerHashUsd { get; set; }

        [JsonPropertyName("mining_revenue_per_hash_native_units")]
        public double? MiningRevenuePerHashNativeUnits { get; set; }

        [JsonPropertyName("mining_revenue_per_hash_per_second_usd")]
        public double? MiningRevenuePerHashPerSecondUsd { get; set; }

        [JsonPropertyName("mining_revenue_per_hash_per_second_native_units")]
        public double? MiningRevenuePerHashPerSecondNativeUnits { get; set; }

        [JsonPropertyName("mining_revenue_from_fees_percent_last_24_hours")]
        public double? MiningRevenueFromFeesPercentLast24Hours { get; set; }

        [JsonPropertyName("mining_revenue_native")]
        public double? MiningRevenueNative { get; set; }

        [JsonPropertyName("mining_revenue_usd")]
        public object MiningRevenueUsd { get; set; }

        [JsonPropertyName("mining_revenue_total")]
        public double? MiningRevenueTotal { get; set; }

        [JsonPropertyName("average_difficulty")]
        public double? AverageDifficulty { get; set; }
    }

    public class DeveloperActivity
    {
        [JsonPropertyName("stars")]
        public int? Stars { get; set; }

        [JsonPropertyName("watchers")]
        public int? Watchers { get; set; }

        [JsonPropertyName("commits_last_3_months")]
        public object CommitsLast3Months { get; set; }

        [JsonPropertyName("commits_last_1_year")]
        public object CommitsLast1Year { get; set; }

        [JsonPropertyName("lines_added_last_3_months")]
        public object LinesAddedLast3Months { get; set; }

        [JsonPropertyName("lines_added_last_1_year")]
        public object LinesAddedLast1Year { get; set; }

        [JsonPropertyName("lines_deleted_last_3_months")]
        public object LinesDeletedLast3Months { get; set; }

        [JsonPropertyName("lines_deleted_last_1_year")]
        public object LinesDeletedLast1Year { get; set; }
    }

    public class RoiData
    {
        [JsonPropertyName("percent_change_last_1_week")]
        public double PercentChangeLast1Week { get; set; }

        [JsonPropertyName("percent_change_last_1_month")]
        public double PercentChangeLast1Month { get; set; }

        [JsonPropertyName("percent_change_last_3_months")]
        public double PercentChangeLast3Months { get; set; }

        [JsonPropertyName("percent_change_last_1_year")]
        public double? PercentChangeLast1Year { get; set; }

        [JsonPropertyName("percent_change_btc_last_1_week")]
        public double PercentChangeBtcLast1Week { get; set; }

        [JsonPropertyName("percent_change_btc_last_1_month")]
        public double PercentChangeBtcLast1Month { get; set; }

        [JsonPropertyName("percent_change_btc_last_3_months")]
        public double PercentChangeBtcLast3Months { get; set; }

        [JsonPropertyName("percent_change_btc_last_1_year")]
        public double? PercentChangeBtcLast1Year { get; set; }

        [JsonPropertyName("percent_change_eth_last_1_week")]
        public double PercentChangeEthLast1Week { get; set; }

        [JsonPropertyName("percent_change_eth_last_1_month")]
        public double PercentChangeEthLast1Month { get; set; }

        [JsonPropertyName("percent_change_eth_last_3_months")]
        public double PercentChangeEthLast3Months { get; set; }

        [JsonPropertyName("percent_change_eth_last_1_year")]
        public double? PercentChangeEthLast1Year { get; set; }

        [JsonPropertyName("percent_change_month_to_date")]
        public double PercentChangeMonthToDate { get; set; }

        [JsonPropertyName("percent_change_quarter_to_date")]
        public double PercentChangeQuarterToDate { get; set; }

        [JsonPropertyName("percent_change_year_to_date")]
        public double PercentChangeYearToDate { get; set; }
    }

    public class RoiByYear
    {
        [JsonPropertyName("2020_usd_percent")]
        public double? _2020UsdPercent { get; set; }

        [JsonPropertyName("2019_usd_percent")]
        public double? _2019UsdPercent { get; set; }

        [JsonPropertyName("2018_usd_percent")]
        public double? _2018UsdPercent { get; set; }

        [JsonPropertyName("2017_usd_percent")]
        public double? _2017UsdPercent { get; set; }

        [JsonPropertyName("2016_usd_percent")]
        public double? _2016UsdPercent { get; set; }

        [JsonPropertyName("2015_usd_percent")]
        public double? _2015UsdPercent { get; set; }

        [JsonPropertyName("2014_usd_percent")]
        public double? _2014UsdPercent { get; set; }

        [JsonPropertyName("2013_usd_percent")]
        public double? _2013UsdPercent { get; set; }

        [JsonPropertyName("2012_usd_percent")]
        public double? _2012UsdPercent { get; set; }

        [JsonPropertyName("2011_usd_percent")]
        public double? _2011UsdPercent { get; set; }
    }

    public class SharpeRatios
    {
        [JsonPropertyName("last_30_days")]
        public double? Last30Days { get; set; }

        [JsonPropertyName("last_90_days")]
        public double Last90Days { get; set; }

        [JsonPropertyName("last_1_year")]
        public double Last1Year { get; set; }

        [JsonPropertyName("last_3_years")]
        public double? Last3Years { get; set; }
    }

    public class VolatilityStats
    {
        [JsonPropertyName("volatility_last_30_days")]
        public double? VolatilityLast30Days { get; set; }

        [JsonPropertyName("volatility_last_90_days")]
        public double VolatilityLast90Days { get; set; }

        [JsonPropertyName("volatility_last_1_year")]
        public double VolatilityLast1Year { get; set; }

        [JsonPropertyName("volatility_last_3_years")]
        public double? VolatilityLast3Years { get; set; }
    }

    public class RiskMetrics
    {
        [JsonPropertyName("sharpe_ratios")]
        public SharpeRatios SharpeRatios { get; set; }

        [JsonPropertyName("volatility_stats")]
        public VolatilityStats VolatilityStats { get; set; }
    }

    public class MiscData
    {
        [JsonPropertyName("private_market_price_usd")]
        public double? PrivateMarketPriceUsd { get; set; }

        [JsonPropertyName("vladimir_club_cost")]
        public object VladimirClubCost { get; set; }

        [JsonPropertyName("btc_current_normalized_supply_price_usd")]
        public object BtcCurrentNormalizedSupplyPriceUsd { get; set; }

        [JsonPropertyName("btc_y2050_normalized_supply_price_usd")]
        public object BtcY2050NormalizedSupplyPriceUsd { get; set; }

        [JsonPropertyName("asset_created_at")]
        public object AssetCreatedAt { get; set; }

        [JsonPropertyName("asset_age_days")]
        public object AssetAgeDays { get; set; }

        [JsonPropertyName("categories")]
        public List<string> Categories { get; set; }

        [JsonPropertyName("sectors")]
        public List<string> Sectors { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
    }

    public class Reddit
    {
        [JsonPropertyName("active_user_count")]
        public int? ActiveUserCount { get; set; }

        [JsonPropertyName("subscribers")]
        public int? Subscribers { get; set; }
    }

    public class OnChainData
    {
        [JsonPropertyName("addresses_count")]
        public int? AddressesCount { get; set; }

        [JsonPropertyName("active_addresses")]
        public int? ActiveAddresses { get; set; }

        [JsonPropertyName("active_addresses_received_count")]
        public int? ActiveAddressesReceivedCount { get; set; }

        [JsonPropertyName("active_addresses_sent_count")]
        public int? ActiveAddressesSentCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_0_001_native_units_count")]
        public int? AddressesBalanceGreater0001NativeUnitsCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_0_01_native_units_count")]
        public int? AddressesBalanceGreater001NativeUnitsCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_0_1_native_units_count")]
        public int? AddressesBalanceGreater01NativeUnitsCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_1_usd_count")]
        public int? AddressesBalanceGreater1UsdCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_1_native_units_count")]
        public int? AddressesBalanceGreater1NativeUnitsCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_10_usd_count")]
        public int? AddressesBalanceGreater10UsdCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_10_native_units_count")]
        public int? AddressesBalanceGreater10NativeUnitsCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_100_usd_count")]
        public int? AddressesBalanceGreater100UsdCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_100_native_units_count")]
        public int? AddressesBalanceGreater100NativeUnitsCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_100k_usd_count")]
        public int? AddressesBalanceGreater100kUsdCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_100k_native_units_count")]
        public int? AddressesBalanceGreater100kNativeUnitsCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_10k_usd_count")]
        public int? AddressesBalanceGreater10kUsdCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_10k_native_units_count")]
        public int? AddressesBalanceGreater10kNativeUnitsCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_10m_usd_count")]
        public int? AddressesBalanceGreater10mUsdCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_1k_usd_count")]
        public int? AddressesBalanceGreater1kUsdCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_1k_native_units_count")]
        public int? AddressesBalanceGreater1kNativeUnitsCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_1m_usd_count")]
        public int? AddressesBalanceGreater1mUsdCount { get; set; }

        [JsonPropertyName("addresses_balance_greater_1m_native_units_count")]
        public int? AddressesBalanceGreater1mNativeUnitsCount { get; set; }

        [JsonPropertyName("average_block_gas_limit")]
        public double? AverageBlockGasLimit { get; set; }

        [JsonPropertyName("block_height")]
        public int? BlockHeight { get; set; }

        [JsonPropertyName("average_block_interval")]
        public double? AverageBlockInterval { get; set; }

        [JsonPropertyName("blocks_added_last_24_hours")]
        public int? BlocksAddedLast24Hours { get; set; }

        [JsonPropertyName("block_size_bytes_total")]
        public int? BlockSizeBytesTotal { get; set; }

        [JsonPropertyName("block_size_bytes_average")]
        public double? BlockSizeBytesAverage { get; set; }

        [JsonPropertyName("uncle_blocks_count_last_24_hours")]
        public int? UncleBlocksCountLast24Hours { get; set; }

        [JsonPropertyName("uncle_rewards_last_24_hours_usd")]
        public double? UncleRewardsLast24HoursUsd { get; set; }

        [JsonPropertyName("uncle_rewards_last_24_hours_native_units")]
        public double? UncleRewardsLast24HoursNativeUnits { get; set; }

        [JsonPropertyName("mining_revenue_from_uncle_blocks_percent_last_24_hours")]
        public double? MiningRevenueFromUncleBlocksPercentLast24Hours { get; set; }

        [JsonPropertyName("block_weight")]
        public int? BlockWeight { get; set; }

        [JsonPropertyName("average_block_weight")]
        public double? AverageBlockWeight { get; set; }

        [JsonPropertyName("total_fees_last_24_hours")]
        public double? TotalFeesLast24Hours { get; set; }

        [JsonPropertyName("total_fees_last_24_hours_usd")]
        public double? TotalFeesLast24HoursUsd { get; set; }

        [JsonPropertyName("hash_rate")]
        public double? HashRate { get; set; }

        [JsonPropertyName("issuance_last_24_hours_native_units")]
        public double? IssuanceLast24HoursNativeUnits { get; set; }

        [JsonPropertyName("issuance_rate_daily")]
        public double? IssuanceRateDaily { get; set; }

        [JsonPropertyName("issuance_total_usd")]
        public double? IssuanceTotalUsd { get; set; }

        [JsonPropertyName("issuance_total_native_units")]
        public double? IssuanceTotalNativeUnits { get; set; }

        [JsonPropertyName("new_issuance")]
        public double? NewIssuance { get; set; }

        [JsonPropertyName("issuance_rate")]
        public double? IssuanceRate { get; set; }

        [JsonPropertyName("realized_marketcap_usd")]
        public double? RealizedMarketcapUsd { get; set; }

        [JsonPropertyName("adjusted_nvt")]
        public double? AdjustedNvt { get; set; }

        [JsonPropertyName("adjusted_nvt_90d_moving_average")]
        public double? AdjustedNvt90dMovingAverage { get; set; }

        [JsonPropertyName("adjusted_rvt")]
        public double? AdjustedRvt { get; set; }

        [JsonPropertyName("adjusted_rvt_90d_moving_average")]
        public double? AdjustedRvt90dMovingAverage { get; set; }

        [JsonPropertyName("txn_count_last_24_hours")]
        public int? TxnCountLast24Hours { get; set; }

        [JsonPropertyName("txn_contracts_calls_count_last_24_hours")]
        public int? TxnContractsCallsCountLast24Hours { get; set; }

        [JsonPropertyName("txn_contracts_calls_success_count_last_24_hours")]
        public int? TxnContractsCallsSuccessCountLast24Hours { get; set; }

        [JsonPropertyName("txn_contracts_creation_count_last_24_hours")]
        public int? TxnContractsCreationCountLast24Hours { get; set; }

        [JsonPropertyName("txn_contracts_destruction_count_last_24_hours")]
        public int? TxnContractsDestructionCountLast24Hours { get; set; }

        [JsonPropertyName("txn_contracts_count_last_24_hours")]
        public int? TxnContractsCountLast24Hours { get; set; }

        [JsonPropertyName("txn_erc20_count_last_24_hours")]
        public int? TxnErc20CountLast24Hours { get; set; }

        [JsonPropertyName("txn_erc721_count_last_24_hours")]
        public int? TxnErc721CountLast24Hours { get; set; }

        [JsonPropertyName("txn_per_second_count")]
        public double? TxnPerSecondCount { get; set; }

        [JsonPropertyName("txn_token_count_last_24_hours")]
        public int? TxnTokenCountLast24Hours { get; set; }

        [JsonPropertyName("average_fee_usd")]
        public double? AverageFeeUsd { get; set; }

        [JsonPropertyName("average_fee_native_units")]
        public double? AverageFeeNativeUnits { get; set; }

        [JsonPropertyName("median_fee_usd")]
        public double? MedianFeeUsd { get; set; }

        [JsonPropertyName("median_fee_native_units")]
        public double? MedianFeeNativeUnits { get; set; }

        [JsonPropertyName("average_txn_gas_used")]
        public double? AverageTxnGasUsed { get; set; }

        [JsonPropertyName("txn_gas_limit_last_24_hours")]
        public long? TxnGasLimitLast24Hours { get; set; }

        [JsonPropertyName("average_txn_gas_limit")]
        public double? AverageTxnGasLimit { get; set; }

        [JsonPropertyName("txn_gas_used_last_24_hours")]
        public long? TxnGasUsedLast24Hours { get; set; }

        [JsonPropertyName("transfer_count_last_24_hours")]
        public int? TransferCountLast24Hours { get; set; }

        [JsonPropertyName("transfer_erc_20_count_last_24_hours")]
        public int? TransferErc20CountLast24Hours { get; set; }

        [JsonPropertyName("transfer_erc721_count_last_24_hours")]
        public int? TransferErc721CountLast24Hours { get; set; }

        [JsonPropertyName("txn_volume_last_24_hours_usd")]
        public double? TxnVolumeLast24HoursUsd { get; set; }

        [JsonPropertyName("adjusted_txn_volume_last_24_hours_usd")]
        public double? AdjustedTxnVolumeLast24HoursUsd { get; set; }

        [JsonPropertyName("adjusted_txn_volume_last_24_hours_native_units")]
        public double? AdjustedTxnVolumeLast24HoursNativeUnits { get; set; }

        [JsonPropertyName("txn_volume_last_24_hours_native_units")]
        public double? TxnVolumeLast24HoursNativeUnits { get; set; }

        [JsonPropertyName("average_transfer_value_usd")]
        public double? AverageTransferValueUsd { get; set; }

        [JsonPropertyName("average_transfer_value_native_units")]
        public double? AverageTransferValueNativeUnits { get; set; }

        [JsonPropertyName("median_transfer_value_usd")]
        public double? MedianTransferValueUsd { get; set; }

        [JsonPropertyName("median_transfer_value_native_units")]
        public double? MedianTransferValueNativeUnits { get; set; }

        [JsonPropertyName("average_utxo_age")]
        public double? AverageUtxoAge { get; set; }

        [JsonPropertyName("value_weighted_average_utxo_age")]
        public double? ValueWeightedAverageUtxoAge { get; set; }

        [JsonPropertyName("median_utxo_age")]
        public int? MedianUtxoAge { get; set; }

        [JsonPropertyName("utxo_count_last_24_hours")]
        public int? UtxoCountLast24Hours { get; set; }

        [JsonPropertyName("utxo_in_loss_count")]
        public int? UtxoInLossCount { get; set; }

        [JsonPropertyName("utxo_in_profit_count")]
        public int? UtxoInProfitCount { get; set; }
    }

    public class ExchangeFlows
    {
        [JsonPropertyName("flow_in_exchange_native_units")]
        public double? FlowInExchangeNativeUnits { get; set; }

        [JsonPropertyName("flow_in_exchange_usd")]
        public double? FlowInExchangeUsd { get; set; }

        [JsonPropertyName("flow_in_exchange_native_units_inclusive")]
        public double? FlowInExchangeNativeUnitsInclusive { get; set; }

        [JsonPropertyName("flow_in_exchange_usd_inclusive")]
        public double? FlowInExchangeUsdInclusive { get; set; }

        [JsonPropertyName("flow_out_exchange_native_units")]
        public double? FlowOutExchangeNativeUnits { get; set; }

        [JsonPropertyName("flow_out_exchange_usd")]
        public double? FlowOutExchangeUsd { get; set; }

        [JsonPropertyName("flow_out_exchange_native_units_inclusive")]
        public double? FlowOutExchangeNativeUnitsInclusive { get; set; }

        [JsonPropertyName("flow_out_exchange_usd_inclusive")]
        public double? FlowOutExchangeUsdInclusive { get; set; }

        [JsonPropertyName("flow_in_binance_usd")]
        public double? FlowInBinanceUsd { get; set; }

        [JsonPropertyName("flow_in_binance_native_units")]
        public double? FlowInBinanceNativeUnits { get; set; }

        [JsonPropertyName("flow_in_bitfinex_usd")]
        public double? FlowInBitfinexUsd { get; set; }

        [JsonPropertyName("flow_in_bitfinex_native_units")]
        public double? FlowInBitfinexNativeUnits { get; set; }

        [JsonPropertyName("flow_in_bitmex_usd")]
        public double? FlowInBitmexUsd { get; set; }

        [JsonPropertyName("flow_in_bitmex_native_units")]
        public double? FlowInBitmexNativeUnits { get; set; }

        [JsonPropertyName("flow_in_bitstamp_usd")]
        public double? FlowInBitstampUsd { get; set; }

        [JsonPropertyName("flow_in_bitstamp_native_units")]
        public double? FlowInBitstampNativeUnits { get; set; }

        [JsonPropertyName("flow_in_bittrex_usd")]
        public double? FlowInBittrexUsd { get; set; }

        [JsonPropertyName("flow_in_bittrex_native_units")]
        public double? FlowInBittrexNativeUnits { get; set; }

        [JsonPropertyName("flow_in_gemini_usd")]
        public double? FlowInGeminiUsd { get; set; }

        [JsonPropertyName("flow_in_gemini_native_units")]
        public double? FlowInGeminiNativeUnits { get; set; }

        [JsonPropertyName("flow_in_huobi_usd")]
        public double? FlowInHuobiUsd { get; set; }

        [JsonPropertyName("flow_in_huobi_native_units")]
        public double? FlowInHuobiNativeUnits { get; set; }

        [JsonPropertyName("flow_in_kraken_usd")]
        public double? FlowInKrakenUsd { get; set; }

        [JsonPropertyName("flow_in_kraken_native_units")]
        public double? FlowInKrakenNativeUnits { get; set; }

        [JsonPropertyName("flow_in_poloniex_usd")]
        public double? FlowInPoloniexUsd { get; set; }

        [JsonPropertyName("flow_in_poloniex_native_units")]
        public double? FlowInPoloniexNativeUnits { get; set; }

        [JsonPropertyName("flow_net_binance_usd")]
        public double? FlowNetBinanceUsd { get; set; }

        [JsonPropertyName("flow_net_binance_native_units")]
        public double? FlowNetBinanceNativeUnits { get; set; }

        [JsonPropertyName("flow_net_bitfinex_usd")]
        public double? FlowNetBitfinexUsd { get; set; }

        [JsonPropertyName("flow_net_bitfinex_native_units")]
        public double? FlowNetBitfinexNativeUnits { get; set; }

        [JsonPropertyName("flow_net_bitmex_usd")]
        public double? FlowNetBitmexUsd { get; set; }

        [JsonPropertyName("flow_net_bitmex_native_units")]
        public double? FlowNetBitmexNativeUnits { get; set; }

        [JsonPropertyName("flow_net_bitstamp_usd")]
        public double? FlowNetBitstampUsd { get; set; }

        [JsonPropertyName("flow_net_bitstamp_native_units")]
        public double? FlowNetBitstampNativeUnits { get; set; }

        [JsonPropertyName("flow_net_bittrex_usd")]
        public double? FlowNetBittrexUsd { get; set; }

        [JsonPropertyName("flow_net_bittrex_native_units")]
        public double? FlowNetBittrexNativeUnits { get; set; }

        [JsonPropertyName("flow_net_gemini_usd")]
        public double? FlowNetGeminiUsd { get; set; }

        [JsonPropertyName("flow_net_gemini_native_units")]
        public double? FlowNetGeminiNativeUnits { get; set; }

        [JsonPropertyName("flow_net_huobi_usd")]
        public double? FlowNetHuobiUsd { get; set; }

        [JsonPropertyName("flow_net_huobi_native_units")]
        public double? FlowNetHuobiNativeUnits { get; set; }

        [JsonPropertyName("flow_net_kraken_usd")]
        public double? FlowNetKrakenUsd { get; set; }

        [JsonPropertyName("flow_net_kraken_native_units")]
        public double? FlowNetKrakenNativeUnits { get; set; }

        [JsonPropertyName("flow_net_poloniex_usd")]
        public double? FlowNetPoloniexUsd { get; set; }

        [JsonPropertyName("flow_net_poloniex_native_units")]
        public double? FlowNetPoloniexNativeUnits { get; set; }

        [JsonPropertyName("flow_out_binance_usd")]
        public double? FlowOutBinanceUsd { get; set; }

        [JsonPropertyName("flow_out_binance_native_units")]
        public double? FlowOutBinanceNativeUnits { get; set; }

        [JsonPropertyName("flow_out_bitfinex_usd")]
        public double? FlowOutBitfinexUsd { get; set; }

        [JsonPropertyName("flow_out_bitfinex_native_units")]
        public double? FlowOutBitfinexNativeUnits { get; set; }

        [JsonPropertyName("flow_out_bitmex_usd")]
        public double? FlowOutBitmexUsd { get; set; }

        [JsonPropertyName("flow_out_bitmex_native_units")]
        public double? FlowOutBitmexNativeUnits { get; set; }

        [JsonPropertyName("flow_out_bitstamp_usd")]
        public double? FlowOutBitstampUsd { get; set; }

        [JsonPropertyName("flow_out_bitstamp_native_units")]
        public double? FlowOutBitstampNativeUnits { get; set; }

        [JsonPropertyName("flow_out_bittrex_usd")]
        public double? FlowOutBittrexUsd { get; set; }

        [JsonPropertyName("flow_out_bittrex_native_units")]
        public double? FlowOutBittrexNativeUnits { get; set; }

        [JsonPropertyName("flow_out_gemini_usd")]
        public double? FlowOutGeminiUsd { get; set; }

        [JsonPropertyName("flow_out_gemini_native_units")]
        public double? FlowOutGeminiNativeUnits { get; set; }

        [JsonPropertyName("flow_out_huobi_usd")]
        public double? FlowOutHuobiUsd { get; set; }

        [JsonPropertyName("flow_out_huobi_native_units")]
        public double? FlowOutHuobiNativeUnits { get; set; }

        [JsonPropertyName("flow_out_kraken_usd")]
        public double? FlowOutKrakenUsd { get; set; }

        [JsonPropertyName("flow_out_kraken_native_units")]
        public double? FlowOutKrakenNativeUnits { get; set; }

        [JsonPropertyName("flow_out_poloniex_usd")]
        public double? FlowOutPoloniexUsd { get; set; }

        [JsonPropertyName("flow_out_poloniex_native_units")]
        public double? FlowOutPoloniexNativeUnits { get; set; }

        [JsonPropertyName("supply_exchange_native_units")]
        public double? SupplyExchangeNativeUnits { get; set; }

        [JsonPropertyName("supply_exchange_usd")]
        public double? SupplyExchangeUsd { get; set; }

        [JsonPropertyName("supply_binance_usd")]
        public double? SupplyBinanceUsd { get; set; }

        [JsonPropertyName("supply_binance_native_units")]
        public double? SupplyBinanceNativeUnits { get; set; }

        [JsonPropertyName("supply_bitfinex_usd")]
        public double? SupplyBitfinexUsd { get; set; }

        [JsonPropertyName("supply_bitfinex_native_units")]
        public double? SupplyBitfinexNativeUnits { get; set; }

        [JsonPropertyName("supply_bitmex_usd")]
        public double? SupplyBitmexUsd { get; set; }

        [JsonPropertyName("supply_bitmex_native_units")]
        public double? SupplyBitmexNativeUnits { get; set; }

        [JsonPropertyName("supply_bitstamp_usd")]
        public double? SupplyBitstampUsd { get; set; }

        [JsonPropertyName("supply_bitstamp_native_units")]
        public double? SupplyBitstampNativeUnits { get; set; }

        [JsonPropertyName("supply_bittrex_usd")]
        public double? SupplyBittrexUsd { get; set; }

        [JsonPropertyName("supply_bittrex_native_units")]
        public double? SupplyBittrexNativeUnits { get; set; }

        [JsonPropertyName("supply_gemini_usd")]
        public double? SupplyGeminiUsd { get; set; }

        [JsonPropertyName("supply_gemini_native_units")]
        public double? SupplyGeminiNativeUnits { get; set; }

        [JsonPropertyName("supply_huobi_usd")]
        public double? SupplyHuobiUsd { get; set; }

        [JsonPropertyName("supply_huobi_native_units")]
        public double? SupplyHuobiNativeUnits { get; set; }

        [JsonPropertyName("supply_kraken_usd")]
        public double? SupplyKrakenUsd { get; set; }

        [JsonPropertyName("supply_kraken_native_units")]
        public double? SupplyKrakenNativeUnits { get; set; }

        [JsonPropertyName("supply_poloniex_usd")]
        public double? SupplyPoloniexUsd { get; set; }

        [JsonPropertyName("supply_poloniex_native_units")]
        public double? SupplyPoloniexNativeUnits { get; set; }
    }

    public class MinerFlows
    {
        [JsonPropertyName("supply_1hop_miners_usd")]
        public double? Supply1hopMinersUsd { get; set; }

        [JsonPropertyName("supply_1hop_miners_native_units")]
        public double? Supply1hopMinersNativeUnits { get; set; }

        [JsonPropertyName("supply_miners_usd")]
        public double? SupplyMinersUsd { get; set; }

        [JsonPropertyName("supply_miners_native_units")]
        public double? SupplyMinersNativeUnits { get; set; }
    }

    public class SupplyActivity
    {
        [JsonPropertyName("supply_active_10y")]
        public double? SupplyActive10y { get; set; }

        [JsonPropertyName("supply_active_180d")]
        public double? SupplyActive180d { get; set; }

        [JsonPropertyName("supply_active_1d")]
        public double? SupplyActive1d { get; set; }

        [JsonPropertyName("supply_active_1y")]
        public double? SupplyActive1y { get; set; }

        [JsonPropertyName("supply_active_1y_percent")]
        public double? SupplyActive1yPercent { get; set; }

        [JsonPropertyName("supply_active_2y")]
        public double? SupplyActive2y { get; set; }

        [JsonPropertyName("supply_active_30d")]
        public double? SupplyActive30d { get; set; }

        [JsonPropertyName("supply_active_3y")]
        public double? SupplyActive3y { get; set; }

        [JsonPropertyName("supply_active_4y")]
        public double? SupplyActive4y { get; set; }

        [JsonPropertyName("supply_active_5y")]
        public double? SupplyActive5y { get; set; }

        [JsonPropertyName("supply_active_7d")]
        public double? SupplyActive7d { get; set; }

        [JsonPropertyName("supply_active_90d")]
        public double? SupplyActive90d { get; set; }

        [JsonPropertyName("supply_active_ever")]
        public double? SupplyActiveEver { get; set; }

        [JsonPropertyName("outstanding")]
        public double? Outstanding { get; set; }

        [JsonPropertyName("supply_revived_1y")]
        public double? SupplyRevived1y { get; set; }

        [JsonPropertyName("supply_revived_2y")]
        public double? SupplyRevived2y { get; set; }

        [JsonPropertyName("supply_revived_30d")]
        public double? SupplyRevived30d { get; set; }

        [JsonPropertyName("supply_revived_3y")]
        public double? SupplyRevived3y { get; set; }

        [JsonPropertyName("supply_revived_4y")]
        public double? SupplyRevived4y { get; set; }

        [JsonPropertyName("supply_revived_5y")]
        public double? SupplyRevived5y { get; set; }

        [JsonPropertyName("supply_revived_7d")]
        public double? SupplyRevived7d { get; set; }

        [JsonPropertyName("supply_revived_90d")]
        public double? SupplyRevived90d { get; set; }
    }

    public class SupplyDistribution
    {
        [JsonPropertyName("supply_in_addresses_balance_greater_0_001_native_units")]
        public double? SupplyInAddressesBalanceGreater0001NativeUnits { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_0_01_native_units")]
        public double? SupplyInAddressesBalanceGreater001NativeUnits { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_0_1_native_units")]
        public double? SupplyInAddressesBalanceGreater01NativeUnits { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_1_usd")]
        public double? SupplyInAddressesBalanceGreater1Usd { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_10_usd")]
        public double? SupplyInAddressesBalanceGreater10Usd { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_100_usd")]
        public double? SupplyInAddressesBalanceGreater100Usd { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_100k_usd")]
        public double? SupplyInAddressesBalanceGreater100kUsd { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_100k_native_units")]
        public double? SupplyInAddressesBalanceGreater100kNativeUnits { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_100_native_units")]
        public double? SupplyInAddressesBalanceGreater100NativeUnits { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_10k_usd")]
        public double? SupplyInAddressesBalanceGreater10kUsd { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_10k_native_units")]
        public double? SupplyInAddressesBalanceGreater10kNativeUnits { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_10m_usd")]
        public double? SupplyInAddressesBalanceGreater10mUsd { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_10_native_units")]
        public double? SupplyInAddressesBalanceGreater10NativeUnits { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_1k_usd")]
        public double? SupplyInAddressesBalanceGreater1kUsd { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_1k_native_units")]
        public double? SupplyInAddressesBalanceGreater1kNativeUnits { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_1m_usd")]
        public double? SupplyInAddressesBalanceGreater1mUsd { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_1m_native_units")]
        public double? SupplyInAddressesBalanceGreater1mNativeUnits { get; set; }

        [JsonPropertyName("supply_in_addresses_balance_greater_1_native_units")]
        public double? SupplyInAddressesBalanceGreater1NativeUnits { get; set; }

        [JsonPropertyName("supply_in_contracts_usd")]
        public double? SupplyInContractsUsd { get; set; }

        [JsonPropertyName("supply_in_contracts_native_units")]
        public double? SupplyInContractsNativeUnits { get; set; }

        [JsonPropertyName("supply_shielded")]
        public object SupplyShielded { get; set; }

        [JsonPropertyName("supply_in_top_100_addresses")]
        public double? SupplyInTop100Addresses { get; set; }

        [JsonPropertyName("supply_in_top_10_percent_addresses")]
        public double? SupplyInTop10PercentAddresses { get; set; }

        [JsonPropertyName("supply_in_top_1_percent_addresses")]
        public double? SupplyInTop1PercentAddresses { get; set; }

        [JsonPropertyName("supply_in_utxo_in_loss")]
        public double? SupplyInUtxoInLoss { get; set; }

        [JsonPropertyName("supply_in_utxo_in_profit")]
        public double? SupplyInUtxoInProfit { get; set; }
    }

    public class Metrics
    {
        [JsonPropertyName("market_data")]
        public MarketData MarketData { get; set; }

        [JsonPropertyName("marketcap")]
        public Marketcap Marketcap { get; set; }

        [JsonPropertyName("supply")]
        public Supply Supply { get; set; }

        [JsonPropertyName("blockchain_stats_24_hours")]
        public BlockchainStats24Hours BlockchainStats24Hours { get; set; }

        [JsonPropertyName("market_data_liquidity")]
        public MarketDataLiquidity MarketDataLiquidity { get; set; }

        [JsonPropertyName("all_time_high")]
        public AllTimeHigh AllTimeHigh { get; set; }

        [JsonPropertyName("cycle_low")]
        public CycleLow CycleLow { get; set; }

        [JsonPropertyName("token_sale_stats")]
        public TokenSaleStats TokenSaleStats { get; set; }

        [JsonPropertyName("staking_stats")]
        public StakingStats StakingStats { get; set; }

        [JsonPropertyName("mining_stats")]
        public MiningStats MiningStats { get; set; }

        [JsonPropertyName("developer_activity")]
        public DeveloperActivity DeveloperActivity { get; set; }

        [JsonPropertyName("roi_data")]
        public RoiData RoiData { get; set; }

        [JsonPropertyName("roi_by_year")]
        public RoiByYear RoiByYear { get; set; }

        [JsonPropertyName("risk_metrics")]
        public RiskMetrics RiskMetrics { get; set; }

        [JsonPropertyName("misc_data")]
        public MiscData MiscData { get; set; }

        [JsonPropertyName("reddit")]
        public Reddit Reddit { get; set; }

        [JsonPropertyName("on_chain_data")]
        public OnChainData OnChainData { get; set; }

        [JsonPropertyName("exchange_flows")]
        public ExchangeFlows ExchangeFlows { get; set; }

        [JsonPropertyName("miner_flows")]
        public MinerFlows MinerFlows { get; set; }

        [JsonPropertyName("supply_activity")]
        public SupplyActivity SupplyActivity { get; set; }

        [JsonPropertyName("supply_distribution")]
        public SupplyDistribution SupplyDistribution { get; set; }

        [JsonPropertyName("alert_messages")]
        public object AlertMessages { get; set; }
    }

    public class OfficialLink
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }
    }

    public class Overview
    {
        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }

        [JsonPropertyName("tagline")]
        public string Tagline { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("sector")]
        public string Sector { get; set; }

        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        [JsonPropertyName("project_details")]
        public string ProjectDetails { get; set; }

        [JsonPropertyName("official_links")]
        public List<OfficialLink> OfficialLinks { get; set; }

        [JsonPropertyName("technology_details")]
        public string TechnologyDetails { get; set; }

        [JsonPropertyName("client_repositories")]
        public List<ClientRepository> ClientRepositories { get; set; }
    }

    public class IssuingOrganization
    {
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class Background
    {
        [JsonPropertyName("background_details")]
        public string BackgroundDetails { get; set; }

        [JsonPropertyName("issuing_organizations")]
        public List<IssuingOrganization> IssuingOrganizations { get; set; }
    }

    public class Roadmap
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("date")]
        public DateTime? Date { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("details")]
        public string Details { get; set; }
    }

    public class Regulation
    {
        [JsonPropertyName("regulatory_details")]
        public string RegulatoryDetails { get; set; }

        [JsonPropertyName("sfar_score")]
        public int? SfarScore { get; set; }

        [JsonPropertyName("sfar_summary")]
        public string SfarSummary { get; set; }
    }

    public class General
    {
        [JsonPropertyName("overview")]
        public Overview Overview { get; set; }

        [JsonPropertyName("background")]
        public Background Background { get; set; }

        [JsonPropertyName("roadmap")]
        public List<Roadmap> Roadmap { get; set; }

        [JsonPropertyName("regulation")]
        public Regulation Regulation { get; set; }

        [JsonPropertyName("launch_style")]
        public string LaunchStyle { get; set; }

        [JsonPropertyName("launch_details")]
        public string LaunchDetails { get; set; }
    }

    public class Individual
    {
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }
    }

    public class Organization
    {
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class Contributors
    {
        [JsonPropertyName("individuals")]
        public List<Individual> Individuals { get; set; }

        [JsonPropertyName("organizations")]
        public List<Organization> Organizations { get; set; }
    }

    public class Advisors
    {
        [JsonPropertyName("individuals")]
        public List<Individual> Individuals { get; set; }

        [JsonPropertyName("organizations")]
        public List<Organization> Organizations { get; set; }
    }

    public class Investors
    {
        [JsonPropertyName("individuals")]
        public List<Individual> Individuals { get; set; }

        [JsonPropertyName("organizations")]
        public List<Organization> Organizations { get; set; }
    }

    public class Asset
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Ecosystem
    {
        [JsonPropertyName("assets")]
        public List<Asset> Assets { get; set; }

        [JsonPropertyName("organizations")]
        public List<Organization> Organizations { get; set; }
    }

    public class BlockExplorer
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }
    }

    public class Token
    {
        [JsonPropertyName("token_name")]
        public string TokenName { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("token_address")]
        public string TokenAddress { get; set; }

        [JsonPropertyName("block_explorers")]
        public List<BlockExplorer> BlockExplorers { get; set; }

        [JsonPropertyName("multitoken")]
        public List<object> Multitoken { get; set; }

        [JsonPropertyName("token_usage")]
        public string TokenUsage { get; set; }

        [JsonPropertyName("token_usage_details")]
        public string TokenUsageDetails { get; set; }
    }

    public class SalesRound
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("start_date")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("details")]
        public string Details { get; set; }

        [JsonPropertyName("end_date")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("native_tokens_allocated")]
        public int? NativeTokensAllocated { get; set; }

        [JsonPropertyName("asset_collected")]
        public string AssetCollected { get; set; }

        [JsonPropertyName("price_per_token_in_asset")]
        public double? PricePerTokenInAsset { get; set; }

        [JsonPropertyName("equivalent_price_per_token_in_usd")]
        public double? EquivalentPricePerTokenInUsd { get; set; }

        [JsonPropertyName("amount_collected_in_asset")]
        public double? AmountCollectedInAsset { get; set; }

        [JsonPropertyName("amount_collected_in_usd")]
        public double? AmountCollectedInUsd { get; set; }

        [JsonPropertyName("is_kyc_required")]
        public bool? IsKycRequired { get; set; }

        [JsonPropertyName("restricted_jurisdictions")]
        public List<string> RestrictedJurisdictions { get; set; }
    }

    public class SalesDocument
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }
    }

    public class AssetHeld
    {
        [JsonPropertyName("id")]
        public object Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Address
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }
    }

    public class SalesTreasuryAccount
    {
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        [JsonPropertyName("asset_held")]
        public AssetHeld AssetHeld { get; set; }

        [JsonPropertyName("addresses")]
        public List<Address> Addresses { get; set; }

        [JsonPropertyName("security")]
        public object Security { get; set; }
    }

    public class ProjectedUseOfSalesProceed
    {
        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("amount_in_percentage")]
        public int? AmountInPercentage { get; set; }
    }

    public class Fundraising
    {
        [JsonPropertyName("sales_rounds")]
        public List<SalesRound> SalesRounds { get; set; }

        [JsonPropertyName("sales_documents")]
        public List<SalesDocument> SalesDocuments { get; set; }

        [JsonPropertyName("sales_treasury_accounts")]
        public List<SalesTreasuryAccount> SalesTreasuryAccounts { get; set; }

        [JsonPropertyName("treasury_policies")]
        public List<object> TreasuryPolicies { get; set; }

        [JsonPropertyName("projected_use_of_sales_proceeds")]
        public List<ProjectedUseOfSalesProceed> ProjectedUseOfSalesProceeds { get; set; }
    }

    public class InitialSupplyRepartition
    {
        [JsonPropertyName("allocated_to_investors_percentage")]
        public double? AllocatedToInvestorsPercentage { get; set; }

        [JsonPropertyName("allocated_to_organization_or_founders_percentage")]
        public double? AllocatedToOrganizationOrFoundersPercentage { get; set; }

        [JsonPropertyName("allocated_to_premined_rewards_or_airdrops_percentage")]
        public double? AllocatedToPreminedRewardsOrAirdropsPercentage { get; set; }
    }

    public class InitialDistribution
    {
        [JsonPropertyName("initial_supply")]
        public double? InitialSupply { get; set; }

        [JsonPropertyName("initial_supply_repartition")]
        public InitialSupplyRepartition InitialSupplyRepartition { get; set; }

        [JsonPropertyName("token_distribution_date")]
        public DateTime? TokenDistributionDate { get; set; }

        [JsonPropertyName("genesis_block_date")]
        public DateTime? GenesisBlockDate { get; set; }
    }

    public class Launch
    {
        [JsonPropertyName("general")]
        public General General { get; set; }

        [JsonPropertyName("fundraising")]
        public Fundraising Fundraising { get; set; }

        [JsonPropertyName("initial_distribution")]
        public InitialDistribution InitialDistribution { get; set; }
    }

    public class Consensus
    {
        [JsonPropertyName("consensus_details")]
        public string ConsensusDetails { get; set; }

        [JsonPropertyName("general_consensus_mechanism")]
        public string GeneralConsensusMechanism { get; set; }

        [JsonPropertyName("precise_consensus_mechanism")]
        public string PreciseConsensusMechanism { get; set; }

        [JsonPropertyName("targeted_block_time")]
        public double? TargetedBlockTime { get; set; }

        [JsonPropertyName("block_reward")]
        public double? BlockReward { get; set; }

        [JsonPropertyName("mining_algorithm")]
        public string MiningAlgorithm { get; set; }

        [JsonPropertyName("next_halving_date")]
        public DateTime? NextHalvingDate { get; set; }

        [JsonPropertyName("is_victim_of_51_percent_attack")]
        public bool? IsVictimOf51PercentAttack { get; set; }
    }

    public class ConsensusAndEmission
    {
        [JsonPropertyName("supply")]
        public Supply Supply { get; set; }

        [JsonPropertyName("consensus")]
        public Consensus Consensus { get; set; }
    }

    public class NativeTreasury
    {
        [JsonPropertyName("accounts")]
        public List<object> Accounts { get; set; }

        [JsonPropertyName("treasury_usage_details")]
        public object TreasuryUsageDetails { get; set; }
    }

    public class Economics
    {
        [JsonPropertyName("token")]
        public Token Token { get; set; }

        [JsonPropertyName("launch")]
        public Launch Launch { get; set; }

        [JsonPropertyName("consensus_and_emission")]
        public ConsensusAndEmission ConsensusAndEmission { get; set; }

        [JsonPropertyName("native_treasury")]
        public NativeTreasury NativeTreasury { get; set; }
    }

    public class ClientRepository
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("license_type")]
        public string LicenseType { get; set; }
    }

    public class Audit
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("date")]
        public DateTime? Date { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("details")]
        public string Details { get; set; }
    }

    public class KnownExploitsAndVulnerability
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("details")]
        public string Details { get; set; }
    }

    public class Security
    {
        [JsonPropertyName("audits")]
        public List<Audit> Audits { get; set; }

        [JsonPropertyName("known_exploits_and_vulnerabilities")]
        public List<KnownExploitsAndVulnerability> KnownExploitsAndVulnerabilities { get; set; }
    }

    public class Technology
    {
        [JsonPropertyName("overview")]
        public Overview Overview { get; set; }

        [JsonPropertyName("security")]
        public Security Security { get; set; }
    }

    public class OnchainGovernance
    {
        [JsonPropertyName("onchain_governance_type")]
        public string OnchainGovernanceType { get; set; }

        [JsonPropertyName("onchain_governance_details")]
        public string OnchainGovernanceDetails { get; set; }

        [JsonPropertyName("is_treasury_decentralized")]
        public bool? IsTreasuryDecentralized { get; set; }
    }

    public class Grant
    {
        [JsonPropertyName("funding_organizations")]
        public object FundingOrganizations { get; set; }

        [JsonPropertyName("grant_program_details")]
        public string GrantProgramDetails { get; set; }
    }

    public class Governance
    {
        [JsonPropertyName("governance_details")]
        public string GovernanceDetails { get; set; }

        [JsonPropertyName("onchain_governance")]
        public OnchainGovernance OnchainGovernance { get; set; }

        [JsonPropertyName("grants")]
        public List<Grant> Grants { get; set; }
    }

    public class Metadata
    {
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    public class Profile
    {
        [JsonPropertyName("general")]
        public General General { get; set; }

        [JsonPropertyName("contributors")]
        public Contributors Contributors { get; set; }

        [JsonPropertyName("advisors")]
        public Advisors Advisors { get; set; }

        [JsonPropertyName("investors")]
        public Investors Investors { get; set; }

        [JsonPropertyName("ecosystem")]
        public Ecosystem Ecosystem { get; set; }

        [JsonPropertyName("economics")]
        public Economics Economics { get; set; }

        [JsonPropertyName("technology")]
        public Technology Technology { get; set; }

        [JsonPropertyName("governance")]
        public Governance Governance { get; set; }

        [JsonPropertyName("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class Datum
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
        public List<ContractAddress> ContractAddresses { get; set; }

        [JsonPropertyName("_internal_temp_agora_id")]
        public string InternalTempAgoraId { get; set; }

        [JsonPropertyName("metrics")]
        public Metrics Metrics { get; set; }

        [JsonPropertyName("profile")]
        public Profile Profile { get; set; }
    }

    public class MessariAllAssets
    {
        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; set; }
    }

}
