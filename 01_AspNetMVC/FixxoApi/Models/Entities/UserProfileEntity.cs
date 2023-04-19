using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FixxoApi.Models.Entities;

public class UserProfileEntity
{
    [Key, ForeignKey(nameof(User))]
    public string UserID { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public IdentityUser User { get; set; } = null!;
}
