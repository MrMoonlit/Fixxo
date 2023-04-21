using Api.Models.Entities;

namespace Api.Models.DTOs
{
    public class CustomerCommentDTO
    {
        public string Name { get; set; } = null!;
        public string Email { get; set;} = null!;
        public string Comment { get; set; } = null!;

        public static implicit operator CustomerCommentEntity(CustomerCommentDTO entity)
        {
            return new CustomerCommentEntity
            {
                CustomerName = entity.Name,
                CustomerEmail = entity.Email,
                Comment = entity.Comment,
            };
        }
    }
}
