﻿using SuperHeroGraphQL.Models;

namespace SuperHeroGraphQL.Data
{
    public class Query
    {
        public IQueryable<Superhero> GetSuperheroes =>
            new List<Superhero>().AsQueryable();
    }
}