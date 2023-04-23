using _01_AspNetMVC.models.DTO;

namespace _01_AspNetMVC.Services
{
    public class ShowcaseService
    {
        private readonly IConfiguration _configuration;

        public ShowcaseService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ShowcaseDTO> GetLatestShowcaseAsync()
        {
            using var http = new HttpClient();
            var result = await http.GetFromJsonAsync<ShowcaseDTO>($"https://localhost:7039/api/Showcase/Get?key={_configuration.GetValue<string>("ApiKey")}");
            return result!;
        }
    }
}
