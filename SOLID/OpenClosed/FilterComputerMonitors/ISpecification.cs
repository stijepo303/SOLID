using System;
namespace SOLID.FilterComputerMonitors
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T item);
    }
}

