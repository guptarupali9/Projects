using RulesEngineServices.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngineServices.Implementation
{
    public class PhysicalProduct: IProductAgent
    {
        public bool GenerateCommissionPayment()
        {
            bool status = false;

            // Write logic to generate commission payment
            status = true;

            return status;
        }

        public bool GeneratePackingSlip()
        {
            bool status = false;

            // Write logic to generate packing slip for shipping
            status = true;

            return status;
        }
    }
}
