using Microsoft.AspNetCore.Http;
using User_Registration.Entities;

namespace User_Registration.Models
{
    public class UserAddViewModel
    {
        public User User { get; set; }
        public IFormFile File { get; set; }

    }
}
