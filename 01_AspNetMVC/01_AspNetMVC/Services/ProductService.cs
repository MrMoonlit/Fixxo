using _01_AspNetMVC.models.DTO;
using _01_AspNetMVC.Models;

namespace _01_AspNetMVC.Services
{
    public class ProductService
    {
        private readonly IConfiguration _configuration;

        public ProductService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<CollectionItemModel>> GetAllAsync()
        {
            using var http = new HttpClient();
            var result = await http.GetFromJsonAsync<IEnumerable<CollectionItemModel>>($"https://localhost:7039/api/Products/All?key={_configuration.GetValue<string>("ApiKey")}");
            return result!;
        }
        public async Task<IEnumerable<CollectionItemModel>> GetByTagAsync(string tag)
        {
            using var http = new HttpClient();
            var result = await http.GetFromJsonAsync<IEnumerable<CollectionItemModel>>($"https://localhost:7039/api/Products/Tag?tag={tag}&key={_configuration.GetValue<string>("ApiKey")}");
            return result!;
        }

        public async Task<CollectionItemModel> GetByIdAsync(int id)
        {
            using var http = new HttpClient();
            var result = await http.GetFromJsonAsync<CollectionItemModel>($"https://localhost:7039/api/Products/Id?tag={id}&key={_configuration.GetValue<string>("ApiKey")}");
            return result!;
        }
    }
}
