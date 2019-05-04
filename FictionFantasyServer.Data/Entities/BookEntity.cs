using System;
using System.Collections.Generic;
using FictionFantasyServer.Data.Entities.Base;
using FictionFantasyServer.Data.Enums;

namespace FictionFantasyServer.Data.Entities
{
    public class BookEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string MainIdea { get; set; }
        public Genre PrimaryGenre { get; set; }
        public Viewpoint Viewpoint { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public UserEntity Author { get; set; }
        public Guid AuthorId { get; set; }
        public BookIntroductionEntity BookIntroduction { get; set; }
        public Guid BookIntroductionId { get; set;}
        public ICollection<BookCharacterEntity> BookCharacters { get; set; }

    }
}