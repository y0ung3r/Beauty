﻿using Beauty.Data.ContextsInitializers;
using Beauty.Data.Contexts;
using System.Data.Entity.Infrastructure;

namespace Beauty.Data.ContextsFactories
{
    public class StandartContextFactory : IDbContextFactory<StandartContext>
    {
        public StandartContext Create()
        {
            var contextInitializer = new ContextInitializer();
            var connectionString = "BeautyDatabase";

            return new StandartContext(contextInitializer, connectionString);
        }
    }
}
