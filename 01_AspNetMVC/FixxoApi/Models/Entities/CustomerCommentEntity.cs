using Microsoft.EntityFrameworkCore;

namespace Api.Models.Entities
{
    public class CustomerCommentEntity
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerEmail { get; set; } = null!;
        public string Comment { get; set; } = null!;
    }
}
