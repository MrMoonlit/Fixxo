using Api.Models.DTOs;
using Api.Repositories;

namespace Api.Services
{
    public class ShowcaseService
    {
        private readonly ShowcaseRepository _showcaseRepo;

        public ShowcaseService(ShowcaseRepository showcaseRepo)
        {
            _showcaseRepo = showcaseRepo;
        }

        public async Task<ShowcaseDTO?> GetAsync()
        {
            var result = await _showcaseRepo.GetAllAsync();
            var latestShowcase = result.OrderByDescending(x => x.Date).FirstOrDefault();
            try
            {
                ShowcaseDTO dto = latestShowcase!;
                return dto;
            }
            catch { return null; }
        }
    }
}
