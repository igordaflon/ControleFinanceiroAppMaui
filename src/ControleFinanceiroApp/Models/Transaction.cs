using LiteDB;

namespace ControleFinanceiroApp.Models
{
    public class Transaction
    {
        [BsonId]
        public int Id { get; set; }
        public TransactionEnum TransactionType {  get; set; }
        public string Name {  get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal Value { get; set; }
    }

    public enum TransactionEnum
    {
        Income,
        Expenses
    }
}
