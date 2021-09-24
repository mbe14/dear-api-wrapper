using System;

namespace DearInventoryLib.Model.FixedAssetType
{
    public class FixedAssetType
    {
        public Guid FixedAssetTypeID { get; set; }
        public string Name { get; set; }
        public DepreciationMethod DepreciationMethod {  get; set; }
        public AveragingMethod AveragingMethod {  get; set; }
        public decimal Rate { get; set; }
        public decimal EffectiveLife { get; set; }
        public decimal AssetAccountCode {  get; set; }
        public string AccumulatedDepreciationAccountCode { get; set; }
        public string AssetAccountName {  get; set; }
        public string AccumulatedDepreciationAccountName {  get; set; }
        public string DepreciationExpenseAccountName {  get; set; }
    }
}
