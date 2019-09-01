using System;
using System.Collections.Generic;
using FictionFantasyServer.Data.Entities.Base;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Data.Entities
{
    public class BookCharacterEntity : IEntity
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public BookEntity Book { get; set; }
        public Guid CharacterId { get; set; }
        public CharacterEntity Character { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}