using RulesEngineServices.Implementation;
using RulesEngineServices.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RulesEngineServices.Test
{
    public class MembershipTests
    {
        private IMembership _membership;

        public MembershipTests()
        {
            _membership = new Membership();
        }

        [Fact]
        public void GivenTypeIsActivate_WhenCallingMembershipUpdate_ThenReturnTrue()
        {
            string type = "Active";
            bool status = _membership.MembershipUpdate(type);

            Assert.True(status);
        }

        [Fact]
        public void GivenTypeIsUpgrade_WhenCallingMembershipUpdate_ThenReturnTrue()
        {
            string type = "Upgrade";
            bool status = _membership.MembershipUpdate(type);

            Assert.True(status);
        }
    }
}
