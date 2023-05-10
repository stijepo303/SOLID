using System;
namespace SOLID.OpenClosed
{
    public class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperModel developerReport)
            : base(developerReport)
        {
        }

        public override double CalculateSalary() => DeveloperModel.HourlyRate * DeveloperModel.WorkingHours;
    }
}

