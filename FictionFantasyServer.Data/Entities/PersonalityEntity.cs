using System;
using FictionFantasyServer.Data.Entities.Base;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Data.Entities
{
    public class PersonalityEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Trait { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}