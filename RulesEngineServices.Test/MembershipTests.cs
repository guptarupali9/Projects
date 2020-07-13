using Moq;
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
        private Mock<IMail> _mockMail;
        private IMembership _membership;

        public MembershipTests()
        {
            _mockMail = new Mock<IMail>();
            _membership = new Membership(_mockMail.Object);
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

        [Fact]
        public void WhenCallingMembershipUpdate_ThenSendMailCalledOnce()
        {
            string type = "Upgrade";
            bool status = _membership.MembershipUpdate(type);

            _mockMail.Verify(x => x.SendMail(), Times.Once);
        }
    }
}
