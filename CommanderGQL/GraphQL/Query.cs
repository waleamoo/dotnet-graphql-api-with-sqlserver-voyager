﻿using CommanderGQL.Data;
using CommanderGQL.Models;

namespace CommanderGQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        //[UseProjection] // having resolver helps with projections 
        [UseFiltering]
        [UseSorting]
        public IQueryable<Platform> GetPlatforms([ScopedService] AppDbContext context)
        {
            return context.Platforms;
        }
        
        [UseDbContext(typeof(AppDbContext))]
        //[UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Command> GetCommands([ScopedService] AppDbContext context)
        {
            return context.Commands;
        }
    }
}
