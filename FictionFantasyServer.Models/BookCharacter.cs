using System;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Models
{
    public class BookCharacter
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public string FullName { get; set; }
        public string Nickname { get; set; }
        public string Background { get; set; }
        public Gender Gender { get; set; }
        public Orientation Orientation { get; set; }
        public string Occupation { get; set; }

    }
}
