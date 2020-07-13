using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngineServices.Interface
{
    public interface IProductAgent : IProduct
    {
        public bool GenerateCommissionPayment();
    }
}
