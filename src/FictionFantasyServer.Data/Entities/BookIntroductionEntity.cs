using System;
using System.Collections.Generic;
using FictionFantasyServer.Data.Entities.Base;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Data.Entities
{
    public class BookIntroductionEntity : IEntity
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public BookEntity Book { get; set; }
        public string Summary { get; set; }
        public List<SettingsEntity> Settings { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}