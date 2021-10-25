using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_application
{
    class Health:insure
    {
        public Health()
        {
            Type = "Health";
        }

        public Health(string number, string name, string phone, string type) : base(number, name, phone, type)
        {

        }

        public override bool policy(string type)
        {

            bool result = false;
            if (type == "Health")
            {
                result = true;
            }
            return result;

        }
    }
}
