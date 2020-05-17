using System;
using FictionFantasyServer.Data.Entities.Base;

namespace FictionFantasyServer.Data.Entities
{
    public class UserEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }
        public string ProfileDescription { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}