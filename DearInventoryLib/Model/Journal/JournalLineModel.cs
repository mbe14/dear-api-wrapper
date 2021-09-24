namespace DearInventoryLib.Model.Journal
{
    public class JournalLineModel
    {
        public string Debit { get; set; }
        public string Credit {  get; set; }
        public string Reference {  get; set; }
        public decimal Amount { get; set; }
        public decimal BaseAmount { get; set; }
    }
}