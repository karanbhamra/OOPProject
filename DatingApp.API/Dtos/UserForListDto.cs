using System;

namespace DatingApp.API.Dtos
{
    public class UserForListDto
    {
        // what to return when a request for list of users is made
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Alias { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string ArrestedFor { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
    }
}
