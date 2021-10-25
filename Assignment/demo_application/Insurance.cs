using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_application
{
    class Insurance
    {
        insure[] insureaccounts;
        public Insurance()
        {
            insureaccounts = new insure[3];
        }
        public void CreateUserAccounts()
        {
            for (int i = 0; i < insureaccounts.Length; i++)
            {
                insureaccounts[i] = null;
                Console.WriteLine("Do you want a Life or a Health insure?");
                string type = Console.ReadLine();
                if (type == "life")
                {
                    insureaccounts[i] = new life();
                }
                else if (type == "Health")
                {
                    insureaccounts[i] = new Health();
                }
                else
                {
                    Console.WriteLine("Invalid Entry. Please try again");
                    i = i - 1;
                    break;
                }
                insureaccounts[i].TakePolicyDetailsFromUser();
            }
        }


        
    }
}
