using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using reqresApiTests.Clients;
using FluentAssertions;

namespace reqresApiTests.Tests
{
    public class UserTests
    {
        [Fact]
        public async Task GetUser_ShouldReturnValidUser()
        {
            var client = new ReqResClient();

            var result = await client.GetUser(2);

            result.Should().NotBeNull();
            result.Data.Should().NotBeNull();
            result.Data.Id.Should().Be(2);
            result.Data.Email.Should().NotBeNullOrEmpty();
            result.Data.FirstName.Should().NotBeNullOrEmpty();
        }
    }
}