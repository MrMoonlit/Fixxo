using _01_AspNetMVC.models.DTO;

namespace _01_AspNetMVC.Services;

public class CustomerSupportServices
{
    public async Task<HttpResponseMessage> SaveCommentAsync(CustomerCommentDTO model)
    {
        using var http = new HttpClient();
        var walla = await http.PostAsJsonAsync("https://localhost:7039/api/AddComment", model);
        
        return walla;
    }
}
