
namespace Aqsha.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // 'income' или 'expense'

        public ICollection<Transaction> Transactions { get; set; }
    }
}
