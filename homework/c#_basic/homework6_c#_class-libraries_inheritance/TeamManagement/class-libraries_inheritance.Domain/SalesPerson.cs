using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManagement.class_libraries_inheritance.Domain.Enums;

namespace TeamManagement.class_libraries_inheritance.Domain
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue; // _ as naming convention for private fields

        public SalesPerson(string firstName, string lastName)
            : base(firstName, lastName, Role.Sales, 500)
        {
            _successSaleRevenue = 0;
        }

        public void AddSuccessRevenue(double revenue)
        {
            if (revenue <= 0)
            {
                Console.WriteLine("Sales revenue must be a positive value.");
            }
            else
            {
                _successSaleRevenue += revenue; // Accumulate, don't overwrite
            }
        }

        public override double GetSalary()
        {
            if (_successSaleRevenue <= 300)
            {
                Console.WriteLine("Is this your sales revenue total, or the number of steps you took today?");
            }

            double bonus = 0;

            switch (_successSaleRevenue) // 9.0 has a shorter syntax, kept for readability purposes
            {
                case < 2000:
                    bonus = 500;
                    break;
                case >= 2000 and <= 5000:
                    bonus = 1000;
                    break;
                default:
                    bonus = 1500;
                    break;
            }

            //bonus = _successSaleRevenue switch
            //{
            //    < 2000 => 500,
            //    >= 2000 and <= 5000 => 1000,
            //    _ => 1500
            //};

            return Salary + bonus;
        }
    }
}