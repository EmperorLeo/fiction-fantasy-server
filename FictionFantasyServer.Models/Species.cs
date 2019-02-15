using System;
using System.Collections.Generic;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Models
{
    public class Species
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Persecuted { get; set; }
        public enum Stature { small, large, aggressive, passive, predator, prey, domestic, wild }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}