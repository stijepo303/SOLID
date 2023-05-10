using System;
namespace SOLID.FilterComputerMonitors
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}

