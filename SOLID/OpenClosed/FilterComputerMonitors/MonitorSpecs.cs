using System;
namespace SOLID.FilterComputerMonitors
{
    public class MonitorSpecs
    {
        public MonitorSpecs()
        {
        }
        public enum MonitorType
        {
            OLED,
            LCD,
            LED
        }
        public enum Screen
        {
            WideScreen,
            CurvedScreen
        }
    }
}

