using System;
using System.Collections.Generic;

namespace QuoteMaster.API.Dtos
{
    public class UserForListDto
    {
        
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}