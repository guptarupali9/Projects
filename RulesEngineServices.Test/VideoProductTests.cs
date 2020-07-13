using System;
using Xunit;
using Moq;
using RulesEngineServices.Interface;
using RulesEngineServices.Implementation;

namespace RulesEngineServices.Test
{
    public class VideoProductTests
    {
        private Mock<IFreeVideo> _mockFreeVideo;
        private IProduct _videoProduct;

        public VideoProductTests()
        {
            _mockFreeVideo = new Mock<IFreeVideo>();
            _videoProduct = new VideoProduct(_mockFreeVideo.Object);
        }

        [Fact]
        public void WhenAddFreeVideo_ThenAddFreeVideoCalledOnce()
        {
            _videoProduct.GeneratePackingSlip();

            _mockFreeVideo.Verify(x=>x.AddFreeVideo(), Times.Once);
        }

        [Fact]
        public void WhenAddFreeVideoReturnsTrue_ThenGeneratePackingSlipReturnsTrue()
        {
            _mockFreeVideo.Setup(x => x.AddFreeVideo()).Returns(true);

            bool status = _videoProduct.GeneratePackingSlip();

            Assert.True(status);

        }

        [Fact]
        public void WhenAddFreeVideoReturnsFalse_ThenGeneratePackingSlipReturnsFalse()
        {
            _mockFreeVideo.Setup(x => x.AddFreeVideo()).Returns(false);

            bool status = _videoProduct.GeneratePackingSlip();

            Assert.False(status);

        }
    }
}
