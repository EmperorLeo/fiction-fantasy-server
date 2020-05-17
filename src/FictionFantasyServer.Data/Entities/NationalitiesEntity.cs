using System;
using FictionFantasyServer.Data.Entities.Base;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Data.Entities
{
    public class NationalitiesEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Persecuted { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}