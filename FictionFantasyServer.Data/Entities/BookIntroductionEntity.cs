using System;
using System.Collections.Generic;
using FictionFantasyServer.Data.Entities.Base;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Data.Entities
{
    public class BookIntroductionEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Summary { get; set; }
        public List<CharacterEntity> Characters { get; set; }
        public List<String> Settings { get; set; }
        public List<String> Relationships { get; set; }
        public List<String> PersonalityTraits { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}