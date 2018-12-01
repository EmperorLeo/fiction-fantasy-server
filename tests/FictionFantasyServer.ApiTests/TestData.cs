using System;
using FictionFantasyServer.Data.Entities;

namespace FictionFantasyServer.ApiTests
{
    public static class TestData
    {
        public static UserEntity James = new UserEntity
        {
            Id = Guid.NewGuid(),
            FamilyName = "Bruening",
            GivenName = "James",
            Username = "bigdaddy",
            Email = "jwbruening@gmail.com",
            ProfileDescription = "My good friend James"
        };
    }
}