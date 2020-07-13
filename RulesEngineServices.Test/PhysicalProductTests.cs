using RulesEngineServices.Implementation;
using RulesEngineServices.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RulesEngineServices.Test
{
    public class PhysicalProductTests
    {
        private IProductAgent _product;

        public PhysicalProductTests()
        {
            _product = new PhysicalProduct();
        }

        [Fact]
        public void WhenCallingGenerateCommissionPayment_ThenReturnTrue()
        {
            bool status = _product.GenerateCommissionPayment();

            Assert.True(status);
        }

        [Fact]
        public void WhenCallingGeneratePackingSlip_ThenReturnTrue()
        {
            bool status = _product.GeneratePackingSlip();

            Assert.True(status);
        }
    }
}
