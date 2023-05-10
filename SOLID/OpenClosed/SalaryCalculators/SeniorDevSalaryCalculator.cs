using System;
namespace SOLID.OpenClosed
{
    public class SeniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperModel report)
            : base(report)
        {
        }

        public override double CalculateSalary() => DeveloperModel.HourlyRate * DeveloperModel.WorkingHours * 1.2;
    }
}

