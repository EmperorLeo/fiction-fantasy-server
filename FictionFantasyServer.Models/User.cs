using System;

namespace FictionFantasyServer.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }
        public string ProfileDescription { get; set; }
    }
}