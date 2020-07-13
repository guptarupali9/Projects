using RulesEngineServices.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngineServices.Implementation
{
    public class VideoProduct : IProduct
    {
        private IFreeVideo _freeVideo;

        public VideoProduct(IFreeVideo freeVideo)
        {
            _freeVideo = freeVideo;
        }
        public bool GeneratePackingSlip()
        {
            bool status = false;

            // Generate Packing slip

            // Add free video for Learning to Ski
            status = _freeVideo.AddFreeVideo();

            return status;
        }
    }
}
