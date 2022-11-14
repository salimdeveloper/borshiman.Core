using Borshiman.Core.Tests.Acceptance.Brokers;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Borshiman.Core.Tests.Acceptance.Apis.Homes
{
    [Collection(nameof(ApiTestCollection))]
    public class HomeApiTests
    {
        private readonly ApiBroker apiBroker;
        public HomeApiTests(ApiBroker apiBroker) =>
                this.apiBroker = apiBroker;
        [Fact]
        public async Task ShouldReturnHomeMessageAsync()
        {
            //given
            string expectedMessage =
                "Yup its working !!!";
            //when
            string actualMessage =
                await this.apiBroker.GetHomeMessage();
            //then
            actualMessage.Should().Be(expectedMessage);
        }
    }
}
