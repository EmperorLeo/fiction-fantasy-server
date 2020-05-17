using System;

namespace FictionFantasyServer.Data.Entities.Base
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime Created { get; set; }
        DateTime? Modified { get; set; }
    }
}