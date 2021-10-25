using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_application
{
    public class life : insure
    {
        public life()
        {
            Type = "life";
        }

        public life(string policynumber, string name, string phone, string type) : base(policynumber, name, phone, type)
        {

        }
        public override bool policy(string type)
        {

            bool result = false;
            if(type == "life" )
            {
                result= true;
            }
            return result;

        }
    }
}
