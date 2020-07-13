using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using RulesEngineServices.Implementation;
using RulesEngineServices.Interface;
using Xunit;

namespace RulesEngineServices.Test
{
    public class BookProductTests
    {
        private IProductAgent _bookProduct;

        public BookProductTests()
        {
            _bookProduct = new BookProduct();
        }

        [Fact]
        public void WhenCallingGenerateCommissionPayment_ThenReturnTrue()
        {
            bool status = _bookProduct.GenerateCommissionPayment();

            Assert.True(status);
        }

        [Fact]
        public void WhenCallingGeneratePackingSlip_ThenReturnTrue()
        {
            bool status = _bookProduct.GeneratePackingSlip();

            Assert.True(status);
        }
    }
}
