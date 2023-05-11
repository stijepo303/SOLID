using SOLID.DIP;
using SOLID.FilterComputerMonitors;
using SOLID.LSP;
using SOLID.OpenClosed;
using SOLID.OpenClosed.FilterComputerMonitors;
using SOLID.InterfaceSegregation;
using static SOLID.FilterComputerMonitors.MonitorSpecs;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 1 for salary calculator (OCP)");
        Console.WriteLine("Enter 2 for monitor filter (OCP)");
        Console.WriteLine("Enter 3 for sum calculator (LSP)");
        Console.WriteLine("Enter 4 for sum DI example (DIP)");
        Console.WriteLine("Enter 5 for sum ISP example (DIP)");
        int example = Convert.ToInt32(Console.ReadLine());

        //Open Closed principle
        if (example == 1)
        {
            var devCalculations = new List<BaseSalaryCalculator>
            {
                new SeniorDevSalaryCalculator(new DeveloperModel {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
                new JuniorDevSalaryCalculator(new DeveloperModel {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
                new SeniorDevSalaryCalculator(new DeveloperModel {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
            };
            var calculator = new SalaryCalculator(devCalculations);

            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
        }

        else if (example == 2)
        {
            var monitors = new List<ComputerMonitor>
            {
                new ComputerMonitor { Name = "Samsung S345", Screen = Screen.CurvedScreen, Type = MonitorType.OLED },
                new ComputerMonitor { Name = "Philips P532", Screen = Screen.WideScreen, Type = MonitorType.LCD },
                new ComputerMonitor { Name = "LG L888", Screen = Screen.WideScreen, Type = MonitorType.LED },
                new ComputerMonitor { Name = "Samsung S999", Screen = Screen.WideScreen, Type = MonitorType.OLED },
                new ComputerMonitor { Name = "Dell D2J47", Screen = Screen.CurvedScreen, Type = MonitorType.LCD }
            };

            var filter = new MonitorFilter();
            var lcdMonitors = filter.Filter(monitors, new MonitorTypeSpecification(MonitorSpecs.MonitorType.LCD));
            Console.WriteLine("All LCD monitors");
            foreach (var monitor in lcdMonitors)
            {
                Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }

            Console.WriteLine("All WideScreen Monitors");
            var wideScreenMonitors = filter.Filter(monitors, new ScreenSpecification(Screen.WideScreen));
            foreach (var monitor in wideScreenMonitors)
            {
                Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }
        }
        // Liskov substitution
        else if (example == 3)
        {
            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            CalculateArea calculateRectangle = new CalculateArea(rectangle);
            CalculateArea calculateSquare = new CalculateArea(square);
        }
        //Dependency Injection
        else if (example == 4)
        {
            // Create the service instance
            IService service = new Service();

            // Create the client instance and inject the service
            ClientThatUsesService client = new ClientThatUsesService(service);

            // Use the client
            client.UseService();
        }
        else if (example == 5)
        {
            Car car = new Car();
            Airplane airplane= new Airplane();
            MultiFunctionalCar multiFunctionalCar = new MultiFunctionalCar();

            car.Drive();
            airplane.Fly();
            multiFunctionalCar.Fly();
        }
    }
}