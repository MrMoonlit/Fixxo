using _01_AspNetMVC.models.DTO;
using _01_AspNetMVC.Models;

namespace _01_AspNetMVC.ViewModels
{
    public class HomeViewViewModel
    {
        public ShowcaseDTO ShowcaseDTO { get; set; } = null!;
        public IEnumerable<CollectionItemModel> Featured { get; set; } = new List<CollectionItemModel>();
        public IEnumerable<CollectionItemModel> New { get; set; } = new List<CollectionItemModel>();
        public IEnumerable<CollectionItemModel> Popular { get; set; } = new List<CollectionItemModel>();
    }
}
