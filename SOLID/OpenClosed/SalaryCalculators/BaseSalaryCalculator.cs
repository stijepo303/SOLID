using System;
namespace SOLID.OpenClosed
{
    public abstract class BaseSalaryCalculator
    {
        protected DeveloperModel DeveloperModel { get; private set; }

        public BaseSalaryCalculator(DeveloperModel developerModel)
        {
            DeveloperModel = developerModel;
        }

        public abstract double CalculateSalary();
    }
}

