using System;
using System.Collections.Generic;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Models
{
    public class Nationality
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Persecuted { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
