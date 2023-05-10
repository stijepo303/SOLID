using System;
namespace SOLID.FilterComputerMonitors
{
    public class MonitorTypeSpecification: ISpecification<ComputerMonitor>
    {
        private readonly MonitorSpecs.MonitorType monitorType;

        public MonitorTypeSpecification(MonitorSpecs.MonitorType type)
        {
            monitorType = type;
        }

        public bool isSatisfied(ComputerMonitor item) => item.Type == monitorType;
    }
}

