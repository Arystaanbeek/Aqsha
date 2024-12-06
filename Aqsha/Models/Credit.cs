namespace Aqsha.Models
{
    public class Credit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; } = 0;
        public DateTime DueDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
