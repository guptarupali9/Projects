using RulesEngineServices.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngineServices.Implementation
{
    public class Membership: IMembership
    {
        private IMail _mail;

        public Membership(IMail mail)
        {
            _mail = mail;
        }

        public bool MembershipUpdate(string type)
        {
            bool status = false;

            _mail.SendMail();

            // Write logic to activate or upgrade membership based on type
            status = true;

            return status;
        }
    }
}
