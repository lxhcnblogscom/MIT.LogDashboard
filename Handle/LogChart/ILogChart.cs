using LogDashboard.Models;
using LogDashboard.Repository;
using System.Threading.Tasks;

namespace LogDashboard.Handle.LogChart
{
    public interface ILogChart
    {
        Task<GetLogChartsOutput> GetCharts<T>(IRepository<T> repository) where T : class, ILogModel;
    }
}
