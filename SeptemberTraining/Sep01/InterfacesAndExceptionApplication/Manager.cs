using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndExceptionApplication
{
    class Manager : IEmployeeManager, ICustomerManager
    {
        public Manager()
        {
            Console.WriteLine("Just created manager interface");
        }
        public void ApproveLoan()
        {
            Console.WriteLine("The Loan has been Approved!");
        }

        public void CheckWork()
        {
            Console.WriteLine("I just checking works...");
        }

        public void CounductMeeting()
        {
            Console.WriteLine("The meeting is started!!");
        }

        public void SolveIssues()
        {
            Console.WriteLine("the issues has been solved");
        }
    }
}
