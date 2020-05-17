using System;
using System.Collections.Generic;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Models
{
    public class BookIntroduction
    {
        public Guid Id { get; set; }
        public string Summary { get; set; }
        public List<Character> Characters { get; set; }
        public List<Setting> Settings { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
