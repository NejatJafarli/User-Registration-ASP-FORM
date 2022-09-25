using System.Collections.Generic;
using User_Registration.Entities;

namespace User_Registration.Services
{
    public class UserService
    {
        static public List<User> Users { get; set; } = new List<User>
        {
                new User
                {
                    Name="Nejat",
                    Surname="Jafarli",
                    ImagePath="1.jpeg",
                    Age=19
                },
                new User
                {
                    Name="Abdul",
                    Surname="Hajiyev",
                    ImagePath="2.jpeg",
                    Age=21
                },
                new User
                {
                    Name="Huseyn",
                    Surname="Rustemli",
                    ImagePath="3.jpeg",
                    Age=21
                }
        };

    }
}
