using RulesEngineServices.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngineServices.Implementation
{
    public class Membership: IMembership
    {
        public bool MembershipUpdate(string type)
        {
            bool status = false;

            // Write logic to activate or upgrade membership based on type
            status = true;

            return status;
        }
    }
}
