using System;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string MainIdea { get; set; }
        public Genre PrimaryGenre { get; set; }
        public Viewpoint Viewpoint { get; set; }
        public Guid AuthorId { get; set; }
    }
}
