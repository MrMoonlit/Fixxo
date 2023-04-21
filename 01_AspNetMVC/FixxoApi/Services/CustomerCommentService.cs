using Api.Models.DTOs;
using Api.Models.Entities;
using Api.Repositories;

namespace Api.Services
{
    public class CustomerCommentService
    {
        private readonly CustomerCommentRepository _commentRepo;

        public CustomerCommentService(CustomerCommentRepository commentRepo)
        {
            _commentRepo = commentRepo;
        }
    }
}
