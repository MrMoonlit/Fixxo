using _01_AspNetMVC.models.DTO;

namespace _01_AspNetMVC.Services;

public class CustomerSupportServices
{
    private readonly IConfiguration _configuration;

    public CustomerSupportServices(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<HttpResponseMessage> SaveCommentAsync(CustomerCommentDTO model)
    {
        using var http = new HttpClient();
        var result = await http.PostAsJsonAsync($"https://localhost:7039/api/CustomerComment/AddComment", model);
        
        return result;
    }
    
}
