using System;
using static SOLID.FilterComputerMonitors.MonitorSpecs;

namespace SOLID.FilterComputerMonitors
{
    public class ComputerMonitor
    {
        public string Name { get; set; }
        public MonitorType Type { get; set; }
        public Screen Screen { get; set; }
    }
}

