using Microsoft.AspNetCore.Identity;

namespace GeekShoppingIdentityServer.Model.Context
{
    public class ApplicationUser : IdentityUser
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
    }
}
