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
        public string FullName { get; set; }
        public string Nickname { get; set; }
        public string Background { get; set; }
        public Gender Gender { get; set; }
        public Orientation Orientation { get; set; }
        public string Occupation { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}