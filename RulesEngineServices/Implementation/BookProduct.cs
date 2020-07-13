using RulesEngineServices.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngineServices.Implementation
{
    public class BookProduct: IProductAgent
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

            // Write logic to generate duplicate packing slip for royalty department
            status = true;

            return status;
        }
    }
}
