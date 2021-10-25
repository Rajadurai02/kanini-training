using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurenceApplication
{
    class HealthInsurance:Insurance
    {
        public HealthInsurance()
        {
            Type = "Health";
        }

        public HealthInsurance(string name, string type, double insuranceAmount, string phone) : base(name, type, insuranceAmount, phone)
        {
        }
        public override bool CalculatePremium(string transType, double amount)
        {
            bool result = false;
            if (transType == "Health")
            {

            }
            return result;
        }
    }
    }
