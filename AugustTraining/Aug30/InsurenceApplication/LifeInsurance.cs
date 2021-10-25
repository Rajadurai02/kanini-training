using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurenceApplication
{
    class LifeInsurance:Insurance
    {
        public LifeInsurance()
        {
            Type = "Life";
        }

        public LifeInsurance(string name, string type, double insuranceAmount, string phone) : base(name, "Life", insuranceAmount, phone)
        {

        }
        public override bool CalculatePremium(string transType, double amount)
        {
            bool result = false;
            if (transType == "Life")
            {

            }
            return result;
        }
    }
}
