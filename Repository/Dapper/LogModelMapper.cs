using DapperExtensions.Mapper;
using System;

namespace LogDashboard.Repository.Dapper
{
    [Serializable]
    public sealed class LogModelMapper<T> : ClassMapper<T> where T : class
    {

        public LogModelMapper()
        {
            Table(LogDashboardContext.StaticOptions.LogTableName);
            AutoMap();
        }

    }
}
