using System.Threading.Tasks;
using react-dot-net.Models.TokenAuth;
using react-dot-net.Web.Controllers;
using Shouldly;
using Xunit;

namespace react-dot-net.Web.Tests.Controllers
{
    public class HomeController_Tests: react-dot-netWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}