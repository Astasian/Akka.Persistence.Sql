﻿// -----------------------------------------------------------------------
//  <copyright file="SqliteSpecSettings.cs" company="Akka.NET Project">
//      Copyright (C) 2013-2022 .NET Foundation <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

namespace Akka.Persistence.Linq2Db.Data.Compatibility.Tests.Sqlite
{
    public sealed class SqliteSpecSettings: TestSettings
    {
        public static readonly SqliteSpecSettings Instance = new SqliteSpecSettings();

        private SqliteSpecSettings()
        {
        }
        
        public override string ProviderName => LinqToDB.ProviderName.SQLite;

        public override string TableMapping => "sqlite";

    }
}