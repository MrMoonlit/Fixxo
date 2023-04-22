using Api.Models.DTOs;

namespace Api.Models.Entities
{
    public class ShowcaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Offer { get; set; } = null!;
        public string Message { get; set;} = null!;
        public string ImgURL { get; set; } = null!;
        public DateTime Date { get; set; }

        public static implicit operator ShowcaseDTO(ShowcaseEntity entity)
        {
            return new ShowcaseDTO
            {
                Title = entity.Title,
                Offer = entity.Offer,
                Message = entity.Message,
                ImgURL = entity.ImgURL,
            };
        }
    }
}
