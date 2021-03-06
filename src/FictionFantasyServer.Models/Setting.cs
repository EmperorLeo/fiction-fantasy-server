using System;
using System.Collections.Generic;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Models
{
    public class Setting
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Vibe { get; set; }
        public Historical Historical { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
