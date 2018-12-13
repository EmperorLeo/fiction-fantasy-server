using System;
using FictionFantasyServer.Data.Entities.Base;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Data.Entities
{
    public class SettingEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Place { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}