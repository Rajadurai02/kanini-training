using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurenceApplication
{
    class Insure
    {
        Insurance[] insureaccounts;
        public Insure()
        {
            insureaccounts = new Insurance[2];
        }
        public void CreatePolicy()
        {
            for (int i = 0; i < insureaccounts.Length; i++)
            {
                insureaccounts[i] = null;
                Console.WriteLine("Which type of Insurance you want? Life or Health");
                string type = Console.ReadLine();
                if (type == "Life")
                {
                    insureaccounts[i] = new LifeInsurance();
                }
                else if (type == "Health")
                {
                    insureaccounts[i] = new HealthInsurance();
                }
                else
                {
                    Console.WriteLine("Invalid Entry. Please try again");
                    i = i - 1;
                    break;
                }
                insureaccounts[i].GetPloicyHolderDetailsFromUser();
            }
        }

    }
}
